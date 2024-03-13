using Syncfusion.Maui.Chat;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ChatMaui
{
    public class ViewModel : INotifyPropertyChanged
    {
        #region Fields
        /// <summary>
        /// Collection of messages or conversation.
        /// </summary>
        private ObservableCollection<object> messages;

        /// <summary>
        /// current user of chat.
        /// </summary>
        private Author currentUser;
        #endregion

        #region Constructor
        public ViewModel()
        {
            this.messages = new ObservableCollection<object>();
            this.currentUser = new Author() { Name = "Stevan", Avatar = "peoplecircle23.png" };
            this.GenerateMessages();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the group message conversation.
        /// </summary>
        public ObservableCollection<object> Messages
        {
            get
            {
                return this.messages;
            }

            set
            {
                this.messages = value;
            }
        }

        /// <summary>
        /// Gets or sets the current author.
        /// </summary>
        public Author CurrentUser
        {
            get
            {
                return this.currentUser;
            }
            set
            {
                this.currentUser = value;
                RaisePropertyChanged("CurrentUser");
            }
        }

        #endregion

        #region INotifypropertychanged
        /// <summary>
        /// Property changed handler.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Occurs when property is changed.
        /// </summary>
        /// <param name="propName">changed property name</param>
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
        #endregion

        #region Message Generation
        private void GenerateMessages()
        {

            this.Messages.Add(new TextMessage()
            {
                Text = "Security Code Changed. Click for more info."
            });

            this.Messages.Add(new TextMessage()
            {
                Author = CurrentUser,
                Text = "Hi",
            });

            this.Messages.Add(new TextMessage()
            {
                Author = new Author() { Name = "Nancy", Avatar = "peoplecircle16.png" },
                Text = "Hi",
            });

            this.Messages.Add(new TextMessage()
            {
                Author = CurrentUser,
                Text = "How are you?",
            });

            this.Messages.Add(new TextMessage()
            {
                Author = new Author() { Name = "Nancy", Avatar = "peoplecircle16.png" },
                Text = "I'm fine.",
            });
        }
        #endregion
    }
}
