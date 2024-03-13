using Syncfusion.Maui.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMaui
{
    public class Behavior : Behavior<ContentPage>
    {
        #region Fields
        private SfChat? chat;
        #endregion

        #region Override Methods
        protected override void OnAttachedTo(ContentPage bindable)
        {
            this.chat = bindable!.FindByName<SfChat>("sfChat");
            
            if (this.chat != null)
            {
                this.chat.MessageTemplate = new MessageTemplateSelector(this.chat);
            }
         
            base.OnAttachedTo(bindable);
        }
        protected override void OnDetachingFrom(ContentPage bindable)
        {
            this.chat = null;
            base.OnDetachingFrom(bindable);
        }
        #endregion
    }
}
