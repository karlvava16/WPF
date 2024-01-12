using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.Xml;
using Newtonsoft.Json;
using System.IO;
using Formatting = Newtonsoft.Json.Formatting;

namespace Notebook
{
    public class WindowViewModel : DependencyObject
    {
        private static readonly DependencyProperty ContactsProperty;
        private static readonly DependencyProperty SelectedContactProperty;
        private static readonly DependencyProperty InformationFullNameProperty;
        private static readonly DependencyProperty InformationAddressProperty;
        private static readonly DependencyProperty InformationPhoneProperty;

        static WindowViewModel()
        {
            ContactsProperty = DependencyProperty.Register("Contacts", typeof(ObservableCollection<Model>), typeof(WindowViewModel));
            SelectedContactProperty = DependencyProperty.Register("SelectedContact", typeof(Model), typeof(WindowViewModel));
            InformationFullNameProperty = DependencyProperty.Register("InformationFullName", typeof(string), typeof(WindowViewModel));
            InformationAddressProperty = DependencyProperty.Register("InformationAddress", typeof(string), typeof(WindowViewModel));
            InformationPhoneProperty = DependencyProperty.Register("InformationPhone", typeof(string), typeof(WindowViewModel));
        }

        public ObservableCollection<Model> Contacts
        {
            get { return (ObservableCollection<Model>)GetValue(ContactsProperty); }
            set { SetValue(ContactsProperty, value); }
        }

        public Model SelectedContact
        {
            get { return (Model)GetValue(SelectedContactProperty); }
            set { SetValue(SelectedContactProperty, value); }
        }

        public string InformationFullName
        {
            get { return (string)GetValue(InformationFullNameProperty); }
            set { SetValue(InformationFullNameProperty, value); }
        }

        public string InformationAddress
        {
            get { return (string)GetValue(InformationAddressProperty); }
            set { SetValue(InformationAddressProperty, value); }
        }

        public string InformationPhone
        {
            get { return (string)GetValue(InformationPhoneProperty); }
            set { SetValue(InformationPhoneProperty, value); }
        }

        public ICommand AddCommand { get; private set; }
        public ICommand EditCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }
        public ICommand SaveJsonCommand { get; private set; }
        public ICommand LoadJsonCommand { get; private set; }

        public WindowViewModel()
        {
            Contacts = new ObservableCollection<Model>();
            AddCommand = new DelegateCommand(param => Add(), param => CanAdd());
            EditCommand = new DelegateCommand(param => Edit(), param => CanEdit());
            DeleteCommand = new DelegateCommand(param => Delete(), param => CanDelete());
            SaveJsonCommand = new DelegateCommand(param => SaveJson(), param => CanSaveJson());
            LoadJsonCommand = new DelegateCommand(param => LoadJson(), null);
        }

        private void Add()
        {
            Contacts.Add(new Model { FullName = InformationFullName, Address = InformationAddress, Phone = InformationPhone });
            InformationFullName = string.Empty;
            InformationAddress = string.Empty;
            InformationPhone = string.Empty;
        }

        private bool CanAdd()
        {
            return !string.IsNullOrEmpty(InformationFullName) && !string.IsNullOrEmpty(InformationAddress) && !string.IsNullOrEmpty(InformationPhone);
        }

        private void Edit()
        {
            if (SelectedContact != null)
            {
                SelectedContact.FullName = InformationFullName;
                SelectedContact.Address = InformationAddress;
                SelectedContact.Phone = InformationPhone;
                InformationFullName = string.Empty;
                InformationAddress = string.Empty;
                InformationPhone = string.Empty;
            }
        }

        private bool CanEdit()
        {
            return SelectedContact != null && CanAdd();
        }

        private void Delete()
        {
            if (SelectedContact != null)
            {
                Contacts.Remove(SelectedContact);
                SelectedContact = null;
            }
        }

        private bool CanDelete()
        {
            return SelectedContact != null;
        }

        private void SaveJson()
        {
            try
            {
                string json = JsonConvert.SerializeObject(Contacts, Formatting.Indented);
                File.WriteAllText("ContactInformation.json", json);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool CanSaveJson()
        {
            return Contacts.Count > 0;
        }

        private void LoadJson()
        {
            try
            {
                if (File.Exists("ContactInformation.json"))
                {
                    string json = File.ReadAllText("ContactInformation.json");
                    ObservableCollection<Model> load = JsonConvert.DeserializeObject<ObservableCollection<Model>>(json);
                    Contacts.Clear();
                    foreach (var i in load)
                    {
                        Contacts.Add(i);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
