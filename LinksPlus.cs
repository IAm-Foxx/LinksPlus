using Rocket.Unturned.Chat;
using Rocket.Core.Plugins;
using Rocket.Core.Logging;
using Rocket.API.Collections;

namespace RedPlus
{

    public class LinksPlus : RocketPlugin<LinksPlusConfiguration> {

        public static LinksPlus Instance { get; private set; }
        public UnityEngine.Color MessageColour { get; private set; }
        

        protected override void Load() {

            Instance = this;
            MessageColour = UnturnedChat.GetColorFromName(Configuration.Instance.MessageColour, UnityEngine.Color.magenta);

            Logger.Log(Configuration.Instance.LoadMessage);
            Logger.Log($"{Name} v{Assembly.GetName().Version} has successfully loaded!");
            
        }

        protected override void Unload() {

            Logger.Log($"{Name} v{Assembly.GetName().Version} has been unloaded!");

        }

        public override TranslationList DefaultTranslations => new TranslationList()
        {
            { "Info1", "Info" },
            { "Info2", "This server" },
            { "Info3", "hasn't added" },
            { "Info4", "any info" },
            { "Info5", "yet!" },
            { "Info6", "Please check" },
            { "Info7", "again at" },
            { "Info8", "a later" },
            { "Info9", "date :)" },
            { "Placeholder", "Do not edit!" },
            { "StoreLink", "This server hasn't setup a store!" },
            { "WebsiteLink", "This server hasn't setup a website!" },
            { "StaffList", "This server hasn't setup a staff list yet!" }
        };

    }

}
