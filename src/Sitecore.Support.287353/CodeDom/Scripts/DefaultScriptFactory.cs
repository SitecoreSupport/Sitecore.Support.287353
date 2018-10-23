namespace Sitecore.Support.CodeDom.Scripts
{
  using Sitecore.Abstractions;

  public class DefaultScriptFactory : Sitecore.CodeDom.Scripts.DefaultScriptFactory
  {
    public DefaultScriptFactory(BaseFactory factory, BaseLog log) : base(factory, log)
    {
      base.Initialize();
    }

    public override void Initialize()
    {
    }

  }
}
