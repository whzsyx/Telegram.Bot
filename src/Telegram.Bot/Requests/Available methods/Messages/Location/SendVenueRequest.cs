// GENERATED FILE - DO NOT MODIFY MANUALLY
namespace Telegram.Bot.Requests;

/// <summary>Use this method to send information about a venue.<para>Returns: The sent <see cref="Message"/> is returned.</para></summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public partial class SendVenueRequest() : RequestBase<Message>("sendVenue"), IChatTargetable, IBusinessConnectable
{
    /// <summary>Unique identifier for the target chat or username of the target channel (in the format <c>@channelusername</c>)</summary>
    [JsonPropertyName("chat_id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public required ChatId ChatId { get; set; }

    /// <summary>Latitude of the venue</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public required double Latitude { get; set; }

    /// <summary>Longitude of the venue</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public required double Longitude { get; set; }

    /// <summary>Name of the venue</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public required string Title { get; set; }

    /// <summary>Address of the venue</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public required string Address { get; set; }

    /// <summary>Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</summary>
    [JsonPropertyName("message_thread_id")]
    public int? MessageThreadId { get; set; }

    /// <summary>Foursquare identifier of the venue</summary>
    [JsonPropertyName("foursquare_id")]
    public string? FoursquareId { get; set; }

    /// <summary>Foursquare type of the venue, if known. (For example, “arts_entertainment/default”, “arts_entertainment/aquarium” or “food/icecream”.)</summary>
    [JsonPropertyName("foursquare_type")]
    public string? FoursquareType { get; set; }

    /// <summary>Google Places identifier of the venue</summary>
    [JsonPropertyName("google_place_id")]
    public string? GooglePlaceId { get; set; }

    /// <summary>Google Places type of the venue. (See <a href="https://developers.google.com/places/web-service/supported_types">supported types</a>.)</summary>
    [JsonPropertyName("google_place_type")]
    public string? GooglePlaceType { get; set; }

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
