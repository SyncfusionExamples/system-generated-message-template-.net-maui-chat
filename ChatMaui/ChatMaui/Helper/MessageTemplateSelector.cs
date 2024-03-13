using Syncfusion.Maui.Chat;

namespace ChatMaui
{
    public class MessageTemplateSelector : ChatMessageTemplateSelector
    {
        #region Fields
        private readonly DataTemplate customMessageTemplate;

        #endregion

        #region Constructor
        public MessageTemplateSelector(SfChat sfChat) : base(sfChat)
        {
            this.customMessageTemplate = new DataTemplate(typeof(CustomMessageTemplate));
        }

        #endregion

        #region Override Methods

        protected override DataTemplate? OnSelectTemplate(object item, BindableObject container)
        {
            var message = item! as IMessage;
            if (message == null)
            {
                return null;
            }

            if (item as ITextMessage != null)
            {
                if ((item as ITextMessage)!.Author == null)
                {
                    return customMessageTemplate;
                }
                else
                {
                    return base.OnSelectTemplate(item, container);
                }
            }
            else
            {
                return null;

            }
        }
        #endregion
    }
}
