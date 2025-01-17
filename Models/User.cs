public class User
{
    // Username of the user
    public string Username { get; set; }

    // User's password (typically hashed before storage)
    public string Password { get; set; }

    // User's email address
    public string Email { get; set; }

    // The currency the user prefers to use (e.g., "USD", "EUR")
    public string Currency { get; set; }

    // The initial amount in the user's selected currency
    public decimal InitialAmount { get; set; }

    // The equivalent amount in USD (for example, for conversions or reporting)
    public decimal UsdEquivalent { get; set; }

    // Unique identifier for the user (can be auto-incremented)
    public int Id { get; internal set; }
}
