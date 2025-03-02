// GENERATED FILE - DO NOT MODIFY MANUALLY
namespace Telegram.Bot.Requests;

/// <summary>Use this method to send point on the map.<para>Returns: The sent <see cref="Message"/> is returned.</para></summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public partial class SendLocationRequest() : RequestBase<Message>("sendLocation"), IChatTargetable, IBusinessConnectable
{
    /// <summary>Unique identifier for the target chat or username of the target channel (in the format <c>@channelusername</c>)</summary>
    [JsonPropertyName("chat_id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public required ChatId ChatId { get; set; }

    /// <summary>Latitude of the location</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public required double Latitude { get; set; }

    /// <summary>Longitude of the location</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public required double Longitude { get; set; }

    /// <summary>Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</summary>
    [JsonPropertyName("message_thread_id")]
    public int? MessageThreadId { get; set; }

    /// <summary>The radius of uncertainty for the location, measured in meters; 0-1500</summary>
    [JsonPropertyName("horizontal_accuracy")]
    public double? HorizontalAccuracy { get; set; }

    /// <summary>Period in seconds during which the location will be updated (see <a href="https://telegram.org/blog/live-locations">Live Locations</a>, should be between 60 and 86400, or 0x7FFFFFFF for live locations that can be edited indefinitely.</summary>
    [JsonPropertyName("live_period")]
    public int? LivePeriod { get; set; }

    /// <summary>For live locations, a direction in which the user is moving, in degrees. Must be between 1 and 360 if specified.</summary>
    public int? Heading { get; set; }

    /// <summary>For live locations, a maximum distance for proximity alerts about approaching another chat member, in meters. Must be between 1 and 100000 if specified.</summary>
    [JsonPropertyName("proximity_alert_radius")]
    public int? ProximityAlertRadius { get; set; }

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
