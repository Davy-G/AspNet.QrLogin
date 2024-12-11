using AspNet.QrLogin.Components;

namespace AspNet.QrLogin.Services;

public interface IQrGeneratorService
{
    public Task<QrCode> GenerateQrCode();
}