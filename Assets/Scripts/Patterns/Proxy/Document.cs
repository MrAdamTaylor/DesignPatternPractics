using System;
using System.Threading;
using JetBrains.Annotations;
using UnityEngine;

namespace Patterns.Proxy
{
    public class Document : IDocument
    {
        [CanBeNull] public string Title { get; private set; }
        [CanBeNull] public string Content { get; private set; }
        public int AuthorId { get; private set; }
        public DateTimeOffset LastAccesed { get; private set; }
        private string _fileName;

        public Document(string fileName)
        {
            _fileName = fileName;
            LoadDocument(fileName);
        }

        private void LoadDocument(string fileName)
        {
            Debug.Log("Выполенине дорогого действия: загрузка файла с диска");
            // fake loading
            Thread.Sleep(1000);

            Title = "Большой документ";
            Content = "Много содержимого";
            AuthorId = 1;
            LastAccesed = DateTimeOffset.UtcNow;
        }

        public void DisplayDocument()
        {
            Debug.Log($"Title: {Title}, Content: {Content}");
        }
    }
}