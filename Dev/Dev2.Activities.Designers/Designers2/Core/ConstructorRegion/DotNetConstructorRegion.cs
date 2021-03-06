﻿using System;
using System.Activities.Presentation.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Dev2.Common;
using Dev2.Common.Interfaces;
using Dev2.Common.Interfaces.ToolBase;
using Dev2.Common.Interfaces.ToolBase.DotNet;
using Dev2.Studio.Core.Activities.Utils;







namespace Dev2.Activities.Designers2.Core.ConstructorRegion
{
    public class DotNetConstructorRegion : IConstructorRegion<IPluginConstructor>
    {
        readonly ModelItem _modelItem;
        readonly ISourceToolRegion<IPluginSource> _source;
        readonly INamespaceToolRegion<INamespaceItem> _namespace;
        bool _isEnabled;

        readonly Dictionary<string, IList<IToolRegion>> _previousRegions = new Dictionary<string, IList<IToolRegion>>();
        Action _sourceChangedAction;
        IPluginConstructor _selectedConstructor;
        readonly IPluginServiceModel _model;
        ICollection<IPluginConstructor> _constructors;
        bool _isRefreshing;
        double _labelWidth;
        IList<string> _errors;
        bool _isConstructorExpanded;

        public DotNetConstructorRegion()
        {
            ToolRegionName = "DotNetConstructorRegion";
        }

        public DotNetConstructorRegion(IPluginServiceModel model, ModelItem modelItem,
            ISourceToolRegion<IPluginSource> source, INamespaceToolRegion<INamespaceItem> namespaceItem)
        {
            try
            {
                Errors = new List<string>();

                LabelWidth = 70;
                ToolRegionName = "DotNetConstructorRegion";
                _modelItem = modelItem;
                _model = model;
                _source = source;
                _namespace = namespaceItem;
                _namespace.SomethingChanged += SourceOnSomethingChanged;
                Dependants = new List<IToolRegion>();
                IsRefreshing = false;
                if (_source.SelectedSource != null)
                {
                    Constructors = model.GetConstructors(_source.SelectedSource, _namespace.SelectedNamespace);
                }
                if (Method != null && Constructors != null)
                {
                    SelectedConstructor = Constructors.FirstOrDefault(constructor => constructor.ConstructorName == Method.ConstructorName);
                }
                RefreshConstructorsCommand = new Microsoft.Practices.Prism.Commands.DelegateCommand(() =>
                {
                    IsRefreshing = true;
                    if (_source.SelectedSource != null)
                    {
                        Constructors = model.GetConstructors(_source.SelectedSource, _namespace.SelectedNamespace);
                    }
                    IsRefreshing = false;
                }, CanRefresh);

                IsConstructorExpanded = false;
                IsEnabled = true;
                _modelItem = modelItem;
            }
            catch (Exception e)
            {
                Errors.Add(e.Message);
            }
        }
       


        IPluginConstructor Method
        {
            get
            {
                return _modelItem.GetProperty<IPluginConstructor>("Constructor");
            }
            set
            {
                _modelItem.SetProperty("Constructor", value);
            }
        }

        public double LabelWidth
        {
            get
            {
                return _labelWidth;
            }
            set
            {
                _labelWidth = value;
                OnPropertyChanged();
            }
        }

        void SourceOnSomethingChanged(object sender, IToolRegion args)
        {
            try
            {
                Errors.Clear();
                IsRefreshing = true;

                UpdateBasedOnNamespace();
                IsRefreshing = false;

                OnPropertyChanged(@"IsEnabled");
            }
            catch (Exception e)
            {
                IsRefreshing = false;
                Errors.Add(e.Message);
            }
            finally
            {
                OnSomethingChanged(this);
                CallErrorsEventHandler();
            }
        }

        void CallErrorsEventHandler()
        {
            ErrorsHandler?.Invoke(this, new List<string>(Errors));
        }

        void UpdateBasedOnNamespace()
        {
            if (_source?.SelectedSource != null)
            {
                Constructors = _model.GetConstructors(_source.SelectedSource, _namespace.SelectedNamespace);
                SelectedConstructor = null;
                if (Constructors.Count > 0)
                {
                    SelectedConstructor = Constructors.FirstOrDefault();
                }
                IsEnabled = true;
            }
        }

        public bool CanRefresh() => IsConstructorEnabled;

        public IPluginConstructor SelectedConstructor
        {
            get
            {
                _selectedConstructor = _modelItem.GetProperty<IPluginConstructor>("Constructor");
                return _selectedConstructor;
            }
            set
            {
                if(value?.ID == Guid.Empty)
                {
                    value.ID = Guid.NewGuid();
                }
                _modelItem.SetProperty("Constructor", value);
                RestoreIfPrevious(value);
                OnPropertyChanged();
                OnPropertyChanged("IsConstructorEnabled");
            }
        }
        void RestoreIfPrevious(IPluginConstructor value)
        {
            if (IsAPreviousValue(value) && _selectedConstructor != null)
            {
                RestorePreviousValues(value);
                SetSelectedConstructor(value);
            }
            else
            {
                SetSelectedConstructor(value);
                SourceChangedAction?.Invoke();

                OnSomethingChanged(this);
            }
            var delegateCommand = RefreshConstructorsCommand as Microsoft.Practices.Prism.Commands.DelegateCommand;
            delegateCommand?.RaiseCanExecuteChanged();

            _selectedConstructor = value;
        }

        public ICollection<IPluginConstructor> Constructors
        {
            get
            {
                return _constructors;
            }
            set
            {
                _constructors = value;
                OnPropertyChanged();
            }
        }
        public ICommand RefreshConstructorsCommand { get; set; }

        public bool IsConstructorEnabled => _source.SelectedSource != null && _namespace.SelectedNamespace != null;

        public bool IsConstructorExpanded
        {
            get
            {
                return _isConstructorExpanded;
            }
            set
            {
                _isConstructorExpanded = value;
                OnPropertyChanged();
            }
        }
        public bool IsRefreshing
        {
            get
            {
                return _isRefreshing;
            }
            set
            {
                _isRefreshing = value;
                OnPropertyChanged();
            }
        }

        public Action SourceChangedAction
        {
            get
            {
                return _sourceChangedAction ?? (() => { });
            }
            set
            {
                _sourceChangedAction = value;
            }
        }
        public event SomethingChanged SomethingChanged;

        #region Implementation of IToolRegion

        public string ToolRegionName { get; set; }
        public bool IsEnabled
        {
            get
            {
                return _isEnabled;
            }
            set
            {
                _isEnabled = value;
                OnPropertyChanged();
            }
        }
        public IList<IToolRegion> Dependants { get; set; }

        public IToolRegion CloneRegion() => new DotNetConstructorRegion
        {
            IsEnabled = IsEnabled,
            SelectedConstructor = SelectedConstructor == null ? null : new PluginConstructor
            {
                Inputs = SelectedConstructor.Inputs,
                ConstructorName = SelectedConstructor.ConstructorName,
                ReturnObject = SelectedConstructor.ReturnObject
            }
        };

        public void RestoreRegion(IToolRegion toRestore)
        {
            if (toRestore is DotNetConstructorRegion region)
            {
                SelectedConstructor = region.SelectedConstructor;
                RestoreIfPrevious(region.SelectedConstructor);
                IsEnabled = region.IsEnabled;
                OnPropertyChanged("SelectedConstructor");
            }
        }

        public EventHandler<List<string>> ErrorsHandler
        {
            get;
            set;
        }

        #endregion

        #region Implementation of IConstructorRegion<IPluginConstructor>

        void SetSelectedConstructor(IPluginConstructor value)
        {
            _selectedConstructor = value;
            SavedConstructor = value;
            if (value != null)
            {
                Method = value;
            }

            OnPropertyChanged("SelectedConstructor");
        }

        void RestorePreviousValues(IPluginConstructor value)
        {
            var toRestore = _previousRegions[value.GetIdentifier()];
            foreach (var toolRegion in Dependants.Zip(toRestore, (a, b) => new Tuple<IToolRegion, IToolRegion>(a, b)))
            {
                toolRegion.Item1.RestoreRegion(toolRegion.Item2);
            }
        }

        bool IsAPreviousValue(IPluginConstructor value) => value != null && _previousRegions.Keys.Any(a => a == value.GetIdentifier());

        public IList<string> Errors
        {
            get
            {
                return _errors;
            }
            set
            {
                _errors = value;
                OnPropertyChanged();
            }
        }

        public IPluginConstructor SavedConstructor
        {
            get
            {
                return _modelItem.GetProperty<IPluginConstructor>("SavedConstructor");
            }
            set
            {
                _modelItem.SetProperty("SavedConstructor", value);
            }
        }

        #endregion


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnSomethingChanged(IToolRegion args)
        {
            var handler = SomethingChanged;
            handler?.Invoke(this, args);
        }
    }
}
