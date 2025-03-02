// GENERATED FILE - DO NOT MODIFY MANUALLY
namespace Telegram.Bot.Requests;

/// <summary>Use this method to delete a forum topic along with all its messages in a forum supergroup chat. The bot must be an administrator in the chat for this to work and must have the <em>CanDeleteMessages</em> administrator rights.<para>Returns: </para></summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public partial class DeleteForumTopicRequest() : RequestBase<bool>("deleteForumTopic"), IChatTargetable
{
    /// <summary>Unique identifier for the target chat or username of the target supergroup (in the format <c>@supergroupusername</c>)</summary>
    [JsonPropertyName("chat_id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public required ChatId ChatId { get; set; }

    /// <summary>Unique identifier for the target message thread of the forum topic</summary>
    [JsonPropertyName("message_thread_id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public required int MessageThreadId { get; set; }
}
