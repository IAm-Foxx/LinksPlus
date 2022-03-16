using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedPlus.Commands
{
    public class InfoCommand : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "info";

        public string Help => "";

        public string Syntax => "";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string>();

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedPlayer player = (UnturnedPlayer)caller;

            if (player.HasPermission("info"))
            {
                UnturnedChat.Say(caller, LinksPlus.Instance.Translate("Info1"), LinksPlus.Instance.MessageColour);
                UnturnedChat.Say(caller, LinksPlus.Instance.Translate("Info2"), LinksPlus.Instance.MessageColour);
                UnturnedChat.Say(caller, LinksPlus.Instance.Translate("Info3"), LinksPlus.Instance.MessageColour);
                UnturnedChat.Say(caller, LinksPlus.Instance.Translate("Info4"), LinksPlus.Instance.MessageColour);
                UnturnedChat.Say(caller, LinksPlus.Instance.Translate("Info5"), LinksPlus.Instance.MessageColour);
                UnturnedChat.Say(caller, LinksPlus.Instance.Translate("Info6"), LinksPlus.Instance.MessageColour);
                UnturnedChat.Say(caller, LinksPlus.Instance.Translate("Info7"), LinksPlus.Instance.MessageColour);
                UnturnedChat.Say(caller, LinksPlus.Instance.Translate("Info8"), LinksPlus.Instance.MessageColour);
                UnturnedChat.Say(caller, LinksPlus.Instance.Translate("Info9"), LinksPlus.Instance.MessageColour);
            }
        }
    }
}
