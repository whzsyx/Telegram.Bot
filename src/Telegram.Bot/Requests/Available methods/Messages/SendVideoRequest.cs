// GENERATED FILE - DO NOT MODIFY MANUALLY
namespace Telegram.Bot.Requests;

/// <summary>Use this method to send video files, Telegram clients support MPEG4 videos (other formats may be sent as <see cref="Document"/>).<para>Returns: The sent <see cref="Message"/> is returned.</para></summary>
/// <remarks>Bots can currently send video files of up to 50 MB in size, this limit may be changed in the future.</remarks>
[EditorBrowsable(EditorBrowsableState.Never)]
public partial class SendVideoRequest() : FileRequestBase<Message>("sendVideo"), IChatTargetable, IBusinessConnectable
{
    /// <summary>Unique identifier for the target chat or username of the target channel (in the format <c>@channelusername</c>)</summary>
    [JsonPropertyName("chat_id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public required ChatId ChatId { get; set; }

    /// <summary>Video to send. Pass a FileId as String to send a video that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a video from the Internet, or upload a new video using <see cref="InputFileStream"/>. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public required InputFile Video { get; set; }

    /// <summary>Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</summary>
    [JsonPropertyName("message_thread_id")]
    public int? MessageThreadId { get; set; }

    /// <summary>Duration of sent video in seconds</summary>
    public int? Duration { get; set; }

    /// <summary>Video width</summary>
    public int? Width { get; set; }

    /// <summary>Video height</summary>
    public int? Height { get; set; }

    /// <summary>Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using <see cref="InputFileStream"/>. Thumbnails can't be reused and can be only uploaded as a new file, so you can use <see cref="InputFileStream(Stream, string?)"/> with a specific filename. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></summary>
    public InputFile? Thumbnail { get; set; }

    /// <summary>Cover for the video in the message. Pass a FileId to send a file that exists on the Telegram servers (recommended), pass an HTTP URL for Telegram to get a file from the Internet, or use <see cref="InputFileStream(Stream, string?)"/> with a specific filename. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></summary>
    public InputFile? Cover { get; set; }

    /// <summary>Start timestamp for the video in the message</summary>
    [JsonPropertyName("start_timestamp")]
    public int? StartTimestamp { get; set; }

    /// <summary>Video caption (may also be used when resending videos by <em>FileId</em>), 0-1024 characters after entities parsing</summary>
    public string? Caption { get; set; }

    /// <summary>Mode for parsing entities in the video caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</summary>
    [JsonPropertyName("parse_mode")]
    public ParseMode ParseMode { get; set; }

    /// <summary>A list of special entities that appear in the caption, which can be specified instead of <see cref="ParseMode">ParseMode</see></summary>
    [JsonPropertyName("caption_entities")]
    public IEnumerable<MessageEntity>? CaptionEntities { get; set; }

    /// <summary>Pass <see langword="true"/>, if the caption must be shown above the message media</summary>
    [JsonPropertyName("show_caption_above_media")]
    public bool ShowCaptionAboveMedia { get; set; }

    /// <summary>Pass <see langword="true"/> if the video needs to be covered with a spoiler animation</summary>
    [JsonPropertyName("has_spoiler")]
    public bool HasSpoiler { get; set; }

    /// <summary>Pass <see langword="true"/> if the uploaded video is suitable for streaming</summary>
    [JsonPropertyName("supports_streaming")]
    public bool SupportsStreaming { get; set; }

    /// <summary>Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</summary>
    [JsonPropertyName("disable_notification")]
    public bool DisableNotification { get; set; }

    /// <summary>Protects the contents of the sent message from forwarding and saving</summary>
    [JsonPropertyName("protect_content")]
    public bool ProtectContent { get; set; }

    /// <summary>Pass <see langword="true"/> to allow up to 1000 messages per second, ignoring <a href="https://core.telegram.org/bots/faq#how-can-i-message-all-of-my-bot-39s-subscribers-at-once">broadcasting limits</a> for a fee of 0.1 Telegram Stars per message. The relevant Stars will be withdrawn from the bot's balance</summary>
    [JsonPropertyName("allow_paid_broadcast")]
    public bool AllowPaidBroadcast { get; set; }

    /// <summary>Unique identifier of the message effect to be added to the message; for private chats only</summary>
    [JsonPropertyName("message_effect_id")]
    public string? MessageEffectId { get; set; }

    /// <summary>Description of the message to reply to</summary>
    [JsonPropertyName("reply_parameters")]
    public ReplyParameters? ReplyParameters { get; set; }

    /// <summary>Additional interface options. An object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>, <a href="https://core.telegram.org/bots/features#keyboards">custom reply keyboard</a>, instructions to remove a reply keyboard or to force a reply from the user</summary>
    [JsonPropertyName("reply_markup")]
    public ReplyMarkup? ReplyMarkup { get; set; }

    /// <summary>Unique identifier of the business connection on behalf of which the message will be sent</summary>
    [JsonPropertyName("business_connection_id")]
    public string? BusinessConnectionId { get; set; }
}
