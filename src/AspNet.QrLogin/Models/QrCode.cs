namespace AspNet.QrLogin.Models;

public class QrCode
{
    public required Byte[] Image { get; init; }
    public DateTime GeneratedAt { get; init; }
    public DateTime ExpiresAt { get; init; }
    public string Token { get; init; } = default!;
    public string Data { get; init; } = default!;
}