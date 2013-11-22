using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Xpf.Grid;

namespace DXGridSample
{
    /// <summary>
    /// The main window view model.
    /// </summary>
    public class MainWindowViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindowViewModel"/> class.
        /// </summary>
        public MainWindowViewModel()
        {
            Persons = new ObservableCollection<Person>();
            FillData();
        }

        private void FillData()
        {
            if (PersonDataProvider.Instance.IsDataReady)
            {
                OnPrepareDataFinished(null, null);
            }
            else
            {
                PersonDataProvider.Instance.PrepareDataFinished += OnPrepareDataFinished;
            }
        }

        /// <summary>
        /// Gets the persons.
        /// </summary>
        public ObservableCollection<Person> Persons { get; private set; }

        private void OnPrepareDataFinished(object sender, EventArgs eventArgs)
        {
            foreach (Person originalPerson in PersonDataProvider.Instance.People)
            {
                Persons.Add(originalPerson);
            }
        }
    }
}