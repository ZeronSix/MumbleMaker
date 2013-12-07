using System.Collections.ObjectModel;

namespace MumbleMaker {
    /// <summary>
    /// Struct representing a dialogue node.
    /// </summary>
    public struct MmSceneNode {
        /// <summary>
        /// Name of a node. Can be used as node's ID.
        /// </summary>
        public string Name;

        /// <summary>
        /// Answers of this node.
        /// </summary>
        public ObservableCollection<MmNodeAnswer> Answers;
    }
}
