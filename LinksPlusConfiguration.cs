using Rocket.API;

namespace RedPlus
{
    public class LinksPlusConfiguration : IRocketPluginConfiguration {

        public string MessageColour { get; set; }
        public string LoadMessage { get; set; }

        public void LoadDefaults() {

            MessageColour = "magenta";
            LoadMessage = "LinksPlus is made by: MrRed";

        }

    }

}
