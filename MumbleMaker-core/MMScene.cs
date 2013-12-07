using System;
using System.Windows;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml.Linq;

using FM = MumbleMaker.FrontendManager;

namespace MumbleMaker {
    /// <summary>
    /// Class which stores all data about the scene.
    /// </summary>
    public class MmScene
    {
        private ObservableCollection<MmCharacter> _characters; 
        private ObservableCollection<MmSceneNode> _sceneNodes; 
        private Dictionary<string, string> _sceneProperties;

        public Dictionary<string, string> Properties {
            get { return _sceneProperties; }
        }
        public ObservableCollection<MmCharacter> Characters {
            get { return _characters; }
        }

        public ObservableCollection<MmSceneNode> Nodes {
            get { return _sceneNodes; }
        }

        public string Name { get; set; }

        /// <summary>
        /// Creates a new instance of MmScene class.
        /// </summary>
        public MmScene() {
            _characters = new ObservableCollection<MmCharacter>();
            _sceneNodes = new ObservableCollection<MmSceneNode>();
            _sceneProperties = new Dictionary<string, string>();
        }

        /// <summary>
        /// Get the value of a custom scene property.
        /// </summary>
        /// <param name="key">Name of a property.</param>
        /// <returns>Property's value.</returns>
        public string GetProperty(string key) {
            // if dictionary contains this key, we return a value by it
            if (_sceneProperties.ContainsKey(key)) {
                return _sceneProperties[key];
            }
            else {  // return empty string then
                return "";
            }
        }

        /// <summary>
        /// Set the value of a custom scene property.
        /// </summary>
        /// <param name="key">Name of a property</param>
        /// <param name="value">Property's value</param>
        public void SetProperty(string key, string value) {
            _sceneProperties[key] = value;
        }

        /// <summary>
        /// Save scene to the specified file.
        /// </summary>
        /// <param name="fileName">File to save to.</param>
        public void SaveToFile(string fileName) {

        }

        /// <summary>
        /// Load a scene from the specified file.
        /// </summary>
        /// <param name="fileName">File to load from.</param>
        /// <returns>An instance of MmScene class.</returns>
        public static MmScene LoadFromFile(string fileName) {
            var scene = new MmScene();
            try {
                var doc = new XDocument(fileName);
                XElement sceneElement = doc.Element("scene");
                if (sceneElement != null) {
                    scene.Name = sceneElement.Attribute("name").Value;
                    // characters
                    if (sceneElement.Element("characters") != null) {
                        foreach (XElement chr in sceneElement.Element("characters").Elements("character")) {
                            scene._characters.Add(new MmCharacter() {
                                Name = chr.Attribute("name").Value
                            }); 
                        }
                    }
                    // scene nodes
                } 
                else {
                    throw new Exception("File is wrong or corrupt!");
                }
            }
            catch (Exception ex) {
                FM.Frontend.ShowErrorMessage(title: "Error!", text: ex.Message);
            }
            return null;
        }
    }
}
