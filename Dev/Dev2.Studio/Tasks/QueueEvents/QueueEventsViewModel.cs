﻿/*
*  Warewolf - Once bitten, there's no going back
*  Copyright 2019 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/

using Dev2.Common;
using Dev2.Common.Interfaces;
using Dev2.Common.Interfaces.Data;
using Dev2.Common.Interfaces.DB;
using Dev2.Common.Interfaces.Resources;
using Dev2.Studio.Interfaces;
using Microsoft.Practices.Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;

namespace Dev2.Tasks.QueueEvents
{
    public class QueueEventsViewModel : TasksItemViewModel, IUpdatesHelp
    {
        ICommand _newCommand;
        ICommand _deleteCommand;
        IResource _selectedQueueSource;
        string _selectedQueueEvent;
        string _queueName;
        string _workflowName;
        int _concurrency;
        private IServer _server;
        private IResourceRepository _resourceRepository;
        private IExternalProcessExecutor _externalProcessExecutor;
        private ObservableCollection<INameValue> _queueNames;
        private ICollection<IServiceInput> _inputs;
        private bool _pasteResponseVisible;
        private string _pasteResponse;
        private ICommand _queueStatsCommand;

        public QueueEventsViewModel(IServer server)
            : this(server, new ExternalProcessExecutor())
        {

        }

        public QueueEventsViewModel(IServer server, IExternalProcessExecutor externalProcessExecutor)
        {
            _server = server;
            _resourceRepository = server.ResourceRepository;
            _externalProcessExecutor = externalProcessExecutor;
            Inputs = new ObservableCollection<IServiceInput>();
        }

        public ObservableCollection<string> QueueEvents { get; set; }

        public string SelectedQueueEvent
        {
            get => _selectedQueueEvent;
            set
            {
                _selectedQueueEvent = value;
                OnPropertyChanged(nameof(SelectedQueueEvent));
            }
        }

        public List<IResource> QueueSources => _resourceRepository.FindResourcesByType<IQueueSource>(_server);

        public IResource SelectedQueueSource
        {
            get => _selectedQueueSource;
            set
            {
                _selectedQueueSource = value;
                if (_selectedQueueSource != null)
                {
                    QueueNames = GetQueueNamesFromSource();
                }
                
                OnPropertyChanged(nameof(SelectedQueueSource));
            }
        }

        private ObservableCollection<INameValue> GetQueueNamesFromSource()
        {
            var queueNames = new ObservableCollection<INameValue>();

            var list = _resourceRepository.FindAutocompleteOptions(_server, SelectedQueueSource);

#pragma warning disable CC0021 // Use nameof
            foreach (var item in list["QueueNames"])
#pragma warning restore CC0021 // Use nameof
            {
                var nameValue = new NameValue(item, item);
                queueNames.Add(nameValue);
            }

            return queueNames;
        }

        public ObservableCollection<INameValue> QueueNames
        {
            get => _queueNames;
            set
            {
                _queueNames = value;
                OnPropertyChanged(nameof(QueueNames));
            }
        }

        public string QueueName
        {
            get => _queueName;
            set
            {
                _queueName = value;
                OnPropertyChanged(nameof(QueueName));
            }
        }

        public string WorkflowName
        {
            get => _workflowName;
            set
            {
                _workflowName = value;
                OnPropertyChanged(nameof(WorkflowName));
            }
        }

        public int Concurrency
        {
            get => _concurrency;
            set
            {
                _concurrency = value;
                OnPropertyChanged(nameof(Concurrency));
            }
        }

        public ICollection<IServiceInput> Inputs
        {
            get => _inputs;
            set
            {
                _inputs = value;
                OnPropertyChanged(nameof(Inputs));
            }
        }

        public bool PasteResponseVisible
        {
            get => _pasteResponseVisible;
            set
            {
                _pasteResponseVisible = value;
                OnPropertyChanged(nameof(PasteResponseVisible));
            }
        }

        public string PasteResponse
        {
            get => _pasteResponse;
            set
            {
                _pasteResponse = value;
                OnPropertyChanged(nameof(PasteResponse));
            }
        }

        public ICommand QueueStatsCommand => _queueStatsCommand ??
            (_queueStatsCommand = new DelegateCommand(ViewQueueStats));

        private void ViewQueueStats()
        {
            _externalProcessExecutor.OpenInBrowser(new Uri("https://www.rabbitmq.com/blog/tag/statistics/"));
        }

        public ICommand NewCommand => _newCommand ??
                       (_newCommand = new DelegateCommand(CreateNewQueueEvent));

        private void CreateNewQueueEvent()
        {
            QueueEvents.Add("");
        }

        public ICommand DeleteCommand => _deleteCommand ??
                       (_deleteCommand = new DelegateCommand(DeleteQueueEvent));

        private void DeleteQueueEvent()
        {
            QueueEvents.Remove("");
        }

        public void UpdateHelpDescriptor(string helpText)
        {
            HelpText = helpText;
        }

        protected override void CloseHelp()
        {
            
        }

        public static bool Save()
        {
            return true;
        }
    }
}