using UnityEditor;
using UnityEditor.Compilation;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Serialization;

namespace Fantasy
{
    [ScriptableObjectPath("ProjectSettings/FantasySettings.asset")]
    public class FantasySettingsScriptableObject : ScriptableObjectSingleton<FantasySettingsScriptableObject>, ISerializationCallbackReceiver
    {
        [FormerlySerializedAs("AutoCopyAssembly")] [Header("自动拷贝程序集到HotUpdatePath目录中")]
        public bool autoCopyAssembly = false;
        [FormerlySerializedAs("HotUpdatePath")] [Header("HotUpdate目录(Unity编译后会把所有HotUpdate程序集Copy一份到这个目录下)")]
        public string hotUpdatePath;
        [FormerlySerializedAs("HotUpdateAssemblyDefinitions")] [Header("HotUpdate程序集")]
        public AssemblyDefinitionAsset[] hotUpdateAssemblyDefinitions;
        [FormerlySerializedAs("LinkAssemblyDefinitions")] [Header("指定要生成Link.xml的程序集")]
        public AssemblyDefinitionAsset[] linkAssemblyDefinitions;
        [FormerlySerializedAs("IncludeAssembly")] [Header("生成Link.xml时候默认包含的程序集")]
        public string[] includeAssembly = new[] { "Assembly-CSharp", "Fantasy.Unity" };
        public void OnBeforeSerialize() { }
        public void OnAfterDeserialize() { }
    }
}