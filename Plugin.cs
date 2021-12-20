using IPA;
using IPA.Config;
using IPA.Utilities;
using IPA.Config.Stores;
using UnityEngine.SceneManagement;
using IPA.Logging;
using HarmonyLib;
using System;
using System.Collections;

namespace EnvironmentDump {
  [Plugin(RuntimeOptions.SingleStartInit)]
  public class Plugin {
    public static string PluginName => "EnvironmentDump";

    public static Logger log { get; private set; }

    [Init]
    public void Init(Logger logger, Config cfgProvider) {
      log = logger;
    }

    [OnStart]
    public void OnApplicationStart() {
      log.Info("Environment Variables:");
      foreach(DictionaryEntry entry in Environment.GetEnvironmentVariables()) {
        log.Info($" {entry.Key}:{entry.Value}");
      }
    }

    [OnExit]
    public void OnApplicationQuit() {
    }

    public void OnFixedUpdate() {

    }

    public void OnUpdate() {

    }

    public void OnActiveSceneChanged(Scene prevScene, Scene nextScene) {

    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode sceneMode) {

    }

    public void OnSceneUnloaded(Scene scene) {

    }
  }
}
