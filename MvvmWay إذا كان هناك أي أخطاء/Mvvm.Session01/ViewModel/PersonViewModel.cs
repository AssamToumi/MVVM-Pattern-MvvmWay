namespace Mvvm.Session01.ViewModel
{
    using Mvvm.Session01.Model;
    using System.ComponentModel;
    public class PersonViewModel : INotifyPropertyChanged
    {
        private Person model;

        public int Id
        {
            get { return model.Id; }
            set
            {
                model.Id = value;
            }
        }

        public string FirstName
        {
            get { return model.FirstName; }
            set
            {
                model.FirstName = value;
                RaisePropertyChanged("FullName");
            }
        }

        public string LastName
        {
            get { return model.LastName; }
            set
            {
                model.LastName = value;
                RaisePropertyChanged("FullName");
            }
        }
        public string FullName
        {
            get { return model.FullName; }
        }
        public PersonViewModel(Person person)
        {
            model = person;
        }

        public PersonViewModel()
            :this(new Person())
        { }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
