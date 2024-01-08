using System.Collections.Generic;

namespace Patterns.Composite
{
    public class Directory : FileSystemItem
    {
        private List<FileSystemItem> _fileSystemItems { get; set; } = new List<FileSystemItem>();

        private long _size;

        public Directory(string name, long size) : base(name)
        {
            _size = size;
        }

        public void Add(FileSystemItem item)
        {
            _fileSystemItems.Add(item);
        }

        public void Remove(FileSystemItem item)
        {
            _fileSystemItems.Remove(item);
        }

        public override long GetSize()
        {
            var treeSize = _size;
            foreach (var fileSystemItem in _fileSystemItems)
            {
                treeSize += fileSystemItem.GetSize();
            }
            return treeSize;
        }
    }
}