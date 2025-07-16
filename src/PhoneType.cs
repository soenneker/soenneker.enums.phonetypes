using Intellenum;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Enums.PhoneTypes;

/// <summary>
/// Represents the classification of a phone number for compliance, routing, or message deliverability purposes.
/// </summary>
[PublicOpenApiObject]
[Intellenum<string>]
public partial class PhoneType
{
    /// <summary>
    /// A mobile phone number (typically cellular). Usually supports both SMS and voice.
    /// </summary>
    public static readonly PhoneType Mobile = new(nameof(Mobile));

    /// <summary>
    /// A landline phone number (non-mobile, fixed line). Usually supports voice only.
    /// </summary>
    public static readonly PhoneType Landline = new(nameof(Landline));

    /// <summary>
    /// A VoIP (Voice over IP) number, such as those from services like Google Voice, Twilio, or other SIP providers.
    /// </summary>
    public static readonly PhoneType Voip = new(nameof(Voip));

    /// <summary>
    /// A toll-free number (e.g., 800, 888) often used for business inbound voice and limited SMS support.
    /// </summary>
    public static readonly PhoneType TollFree = new(nameof(TollFree));

    /// <summary>
    /// A short code (typically 5–6 digits) used for high-volume A2P (application-to-person) SMS or MMS.
    /// </summary>
    public static readonly PhoneType ShortCode = new(nameof(ShortCode));

    /// <summary>
    /// A premium rate number that charges the caller or sender a higher rate, often used for services like voting or contests.
    /// </summary>
    public static readonly PhoneType PremiumRate = new(nameof(PremiumRate));

    /// <summary>
    /// A masked, disposable, or temporary number used for one-time or anonymized communication, such as in marketplaces or ride-sharing.
    /// </summary>
    public static readonly PhoneType Masked = new(nameof(Masked));

    /// <summary>
    /// A shared-cost number where the cost of the call is split between the caller and the recipient.
    /// </summary>
    public static readonly PhoneType SharedCost = new(nameof(SharedCost));

    /// <summary>
    /// A fax number. Rarely used today but still present in some telecom data sources.
    /// </summary>
    public static readonly PhoneType Fax = new(nameof(Fax));

    /// <summary>
    /// A pager number. Legacy type, sometimes returned by carrier lookups.
    /// </summary>
    public static readonly PhoneType Pager = new(nameof(Pager));

    /// <summary>
    /// A phone number that does not fit any recognized or supported category.
    /// </summary>
    public static readonly PhoneType Other = new(nameof(Other));
}