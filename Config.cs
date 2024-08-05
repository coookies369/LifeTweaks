using BepInEx.Configuration;

public class Config
{
    public static ConfigEntry<int> lifeCap;
    public static ConfigEntry<int> startLifeCount;

    public Config(ConfigFile cfg)
    {
        lifeCap = cfg.Bind(
            "General",
            "LifeCap",
            999,
            "Maximum allowed lives"
        );
        startLifeCount = cfg.Bind(
            "General",
            "StartLifeCount",
            9,
            "Lives you start the game with"
        );
    }
}