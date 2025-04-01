public record Password
{
    public string Hash { get; }

    public Password(string plainText)
    {
        if (string.IsNullOrWhiteSpace(plainText) || plainText.Length < 8)
        {
            throw new ArgumentException("Password must be at least 8 characters");
        }
        // In real implementation, you would hash the password here
        Hash = plainText; // This is just for illustration
    }
}