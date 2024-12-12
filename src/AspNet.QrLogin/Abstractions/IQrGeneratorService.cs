using AspNet.QrLogin.Components;

namespace AspNet.QrLogin.Abstractions;

public interface IQrGeneratorService
{
    public Task<QrCode> GenerateQrCode();
}