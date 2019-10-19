namespace BlueRayStoreModel.Interface
{
    public interface IRender
    {
        string RenderHeader(string storeName);

        string RenderBody(Page page);

        string Renderfooter();
    }
}
