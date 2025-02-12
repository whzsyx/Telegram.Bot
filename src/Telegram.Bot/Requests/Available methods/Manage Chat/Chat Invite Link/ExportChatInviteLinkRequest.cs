// GENERATED FILE - DO NOT MODIFY MANUALLY
namespace Telegram.Bot.Requests;

/// <summary>Use this method to generate a new primary invite link for a chat; any previously generated primary link is revoked. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights.<para>Returns: The new invite link as <em>String</em> on success.</para></summary>
/// <remarks>Note: Each administrator in a chat generates their own invite links. Bots can't use invite links generated by other administrators. If you want your bot to work with invite links, it will need to generate its own link using <see cref="TelegramBotClientExtensions.ExportChatInviteLink">ExportChatInviteLink</see> or by calling the <see cref="TelegramBotClientExtensions.GetChat">GetChat</see> method. If your bot needs to generate a new primary invite link replacing its previous one, use <see cref="TelegramBotClientExtensions.ExportChatInviteLink">ExportChatInviteLink</see> again.</remarks>
[EditorBrowsable(EditorBrowsableState.Never)]
public partial class ExportChatInviteLinkRequest() : RequestBase<string>("exportChatInviteLink"), IChatTargetable
{
    /// <summary>Unique identifier for the target chat or username of the target channel (in the format <c>@channelusername</c>)</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public required ChatId ChatId { get; set; }
}
