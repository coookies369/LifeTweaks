using BepInEx.Configuration;

public class Config
{
    public static ConfigEntry<int> lifeCap;

    public Config(ConfigFile cfg)
    {
        lifeCap = cfg.Bind(
            "General",
            "LifeCap",
            999,
            "Maximum allowed lives"
        );
    }
}