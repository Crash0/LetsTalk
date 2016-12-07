namespace LetsTalk.Core.Common.UI.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using FluentValidation.Results;

    using LetsTalk.Core.Common.Core;

    using Prism;
    using Prism.Commands;
    using Prism.Regions;

    // TODO: Shold Probably use bindable base :game_die:
    public class ViewModelBase : ObjectBase, INavigationAware, IActiveAware
    {
        public ViewModelBase()
        {
            ToggleErrorsCommand = new DelegateCommand<object>(OnToggleErrorsCommandExecute, OnToggleErrorsCommandCanExecute);
        }

        bool _ErrorsVisible = false;

        public object ViewLoaded
        {
            get
            {
                OnViewLoaded();
                return null;
            }
        }

        protected virtual void OnViewLoaded() { }

        protected void WithClient<T>(T proxy, Action<T> codeToExecute)
        {
            codeToExecute.Invoke(proxy);

            IDisposable disposableClient = proxy as IDisposable;
            disposableClient?.Dispose();
        }

        public virtual string ViewTitle { get; private set; }

        private List<ObjectBase> _Models;

        protected virtual void AddModels(List<ObjectBase> models)
        {
        }

        protected void ValidateModel()
        {
            if (_Models == null)
            {
                _Models = new List<ObjectBase>();
                AddModels(_Models);
            }

            _ValidationErrors = new List<ValidationFailure>();

            if (_Models.Count > 0)
            {
                foreach (var modelObject in _Models)
                {
                    modelObject?.Validate();

                    _ValidationErrors = _ValidationErrors.Union(modelObject.ValidationErrors).ToList();
                }

                OnPropertyChanged(() => ValidationErrors, false);
                OnPropertyChanged(() => ValidationHeaderText, false);
                OnPropertyChanged(() => ValidationHeaderVisible, false);
            }
        }

        public DelegateCommand<object> ToggleErrorsCommand { get; protected set; }

        public virtual bool ValidationHeaderVisible => 
            ValidationErrors != null && ValidationErrors.Any();

        public virtual bool ErrorsVisible
        {
            get { return _ErrorsVisible; }
            set
            {
                if (_ErrorsVisible == value)
                    return;

                _ErrorsVisible = value;
                OnPropertyChanged(() => ErrorsVisible, false);
            }
        }

        public virtual string ValidationHeaderText
        {
            get
            {
                string ret = string.Empty;

                if (ValidationErrors != null)
                {
                    var verb = (ValidationErrors.Count() == 1 ? "is" : "are");
                    var suffix = (ValidationErrors.Count() == 1 ? "" : "s");

                    if (!IsValid)
                        ret = $"There {verb} {ValidationErrors.Count()} validation error{suffix}.";
                }

                return ret;
            }
        }

        protected virtual void OnToggleErrorsCommandExecute(object arg)
        {
            ErrorsVisible = !ErrorsVisible;
        }

        protected virtual bool OnToggleErrorsCommandCanExecute(object arg)
        {
            return !IsValid;
        }

        public virtual void OnNavigatedTo(NavigationContext navigationContext)
        {
        }

        public virtual bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public virtual void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        private bool _isActive;

        public bool IsActive
        {
            get
            {
                return _isActive;
            }
            set
            {
                if (value != _isActive)
                {
                    _isActive = value;
                    OnPropertyChanged(()=>IsActive);
                }
                
            }
        }

        public event EventHandler IsActiveChanged;
    }
}
