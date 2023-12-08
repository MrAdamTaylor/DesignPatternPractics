namespace Singleton
{
    
    
    public class SingletonLauncher : DesignPatternLauncher
    {
        public override void Launch()
        {
            Logger.Instance.Test();
        }
    }
}