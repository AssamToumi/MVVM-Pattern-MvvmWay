namespace Mvvm.Session01.ViewModel
{
    using System.Windows;
    using System.Windows.Input;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Mvvm.Session01.Command;
    using Mvvm.Session01.Model;

    public class PeopleViewModel
    {
        public ObservableCollection<PersonViewModel> People { get; set; }

        public PersonViewModel SelectedPerson { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand NewCommand { get; set; }
        public PeopleViewModel()
        {
            People = new ObservableCollection<PersonViewModel>()
            {
                new PersonViewModel(new Person(){
                    Id = 1,
                    FirstName="Tareq", LastName="Jehad"}),

                new PersonViewModel(new Person(){
                    Id = 2,
                    FirstName="Ahmad", LastName="Mohammad"}),

                new PersonViewModel(new Person(){
                    Id = 3,
                    FirstName="Visual", LastName="Studio"}),

                new PersonViewModel(new Person(){
                    Id = 4,
                    FirstName="MVVM", LastName="Way"})
            };

            DeleteCommand = new MVVMCommand(Delete, CanDelete);
            NewCommand = new MVVMCommand(New);

        }
        private bool CanDelete()
        {
            return (SelectedPerson != null);
        }
        public void Delete()
        {
            if (CanDelete())
                People.Remove(SelectedPerson);
        }
        private int id = 5;
        private void New()
        {
            Person person = new Person
            {
                Id = id++,
                FirstName= "first Name",
                LastName = "last Name"
            };

            People.Add(new PersonViewModel(person));
        }
    }

  /*  public class DeleteCommand : ICommand
    {
        private PeopleViewModel _viewModel;
        public DeleteCommand(PeopleViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        public bool CanExecute(object parameter)
        {
            return _viewModel.SelectedPerson != null;
        }
        public void Execute(object parameter)
        {
            _viewModel.People.Remove(_viewModel.SelectedPerson);
        }

        public event System.EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
   * */
}
