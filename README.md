# system-generated-message-template-.net-maui.chat
This repository contains a sample demonstrating how to load templates for system-generated messages in .NET MAUI Chat (SfChat).

## Sample

```xaml  

MessageTemplateSelector:

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

CustomMessageTemplate:

    <Border  Stroke="LightGray">
        <Grid  BackgroundColor="#fef4c5" Padding="15,0,0,0" RowDefinitions="20">
            <Label Grid.Row="0"
                        Text="{Binding Text}"
                        LineBreakMode="NoWrap"
                        TextColor="#212121"
                        FontSize="8" 
                        VerticalOptions="Center"/>
        </Grid>
    </Border>
```

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)

## Troubleshooting:
### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion® has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion® liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion®'s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion®'s samples.