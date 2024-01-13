using PluginPile.Common;
using PluginPile.Sorting;
using PluginPile.RaidImporter;
using PluginPile.SVivillon;
using PluginPile.FashionEditor;
using PluginPile.SVProfilePictureViewer;
using PluginPile.RoamerTool;
using PluginPile.RentalViewer;

namespace PluginPile; 
public class PluginLoader : PluginBase {
  public override string Name => "Plugin Pile";

  private readonly SortingPlugin SortingPluginInstance;
  private readonly RaidImportPlugin RaidImportPluginInstance;
  private readonly SVivillonPlugin SVivillonPluginInstance;
  private readonly FashionEditorPlugin FashionEditorPluginInstance;
  private readonly SVProfilePictureViewerPlugin SVProfilePictureViewerPluginInstance;
  private readonly RoamerPlugin RoamerPluginInstance;
  private readonly RentalViewerPlugin RentalViewerPluginInstance;

  public PluginLoader() {
    SortingPluginInstance = new SortingPlugin();
    RaidImportPluginInstance = new RaidImportPlugin();
    SVivillonPluginInstance = new SVivillonPlugin();
    FashionEditorPluginInstance = new FashionEditorPlugin();
    SVProfilePictureViewerPluginInstance = new SVProfilePictureViewerPlugin();
    RoamerPluginInstance = new RoamerPlugin();
    RentalViewerPluginInstance = new RentalViewerPlugin();
  }

  public override void Initialize(params object[] args) {
    SortingPluginInstance.Initialize(args);
    RaidImportPluginInstance.Initialize(args);
    SVivillonPluginInstance.Initialize(args);
    FashionEditorPluginInstance.Initialize(args);
    SVProfilePictureViewerPluginInstance.Initialize(args);
    RoamerPluginInstance.Initialize(args);
    RentalViewerPluginInstance.Initialize(args);
  }

  public override void NotifySaveLoaded() {
    SortingPluginInstance.NotifySaveLoaded();
    RaidImportPluginInstance.NotifySaveLoaded();
    SVivillonPluginInstance.NotifySaveLoaded();
    FashionEditorPluginInstance.NotifySaveLoaded();
    SVProfilePictureViewerPluginInstance.NotifySaveLoaded();
    RoamerPluginInstance.NotifySaveLoaded();
    RentalViewerPluginInstance.NotifySaveLoaded();
  }

  public override void NotifyDisplayLanguageChanged(string language) {
    SortingPluginInstance.NotifyDisplayLanguageChanged(language);
    RaidImportPluginInstance.NotifyDisplayLanguageChanged(language);
    SVivillonPluginInstance.NotifyDisplayLanguageChanged(language);
    FashionEditorPluginInstance.NotifyDisplayLanguageChanged(language);
    SVProfilePictureViewerPluginInstance.NotifyDisplayLanguageChanged(language);
    RoamerPluginInstance.NotifyDisplayLanguageChanged(language);
    RentalViewerPluginInstance.NotifyDisplayLanguageChanged(language);
  }

}
