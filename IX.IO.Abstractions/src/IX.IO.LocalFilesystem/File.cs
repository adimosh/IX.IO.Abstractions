using System;
using FSFile = System.IO.File;
using IX.IO.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IX.IO.LocalFilesystem
{
    public class File : IFile
    {
        public void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding = null)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));
            if (contents == null)
                throw new ArgumentNullException(nameof(contents));

            if (encoding == null)
                FSFile.AppendAllLines(path, contents);
            else
                FSFile.AppendAllLines(path, contents, encoding);
        }

        public void AppendAllText(string path, string contents, Encoding encoding = null)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));
            if (string.IsNullOrWhiteSpace(contents))
                throw new ArgumentNullException(nameof(contents));

            if (encoding == null)
                FSFile.AppendAllText(path, contents);
            else
                FSFile.AppendAllText(path, contents, encoding);
        }

        public StreamWriter AppendText(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            return FSFile.AppendText(path);
        }

        public void Copy(string sourceFileName, string destFileName, bool overwrite = false)
        {
            if (string.IsNullOrWhiteSpace(sourceFileName))
                throw new ArgumentNullException(nameof(sourceFileName));
            if (string.IsNullOrWhiteSpace(destFileName))
                throw new ArgumentNullException(nameof(destFileName));

            FSFile.Copy(sourceFileName, destFileName, overwrite);
        }

        public Stream Create(string path, int bufferSize = 4096)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));
            if (bufferSize <= 0)
                throw new ArgumentOutOfRangeException(nameof(bufferSize));

            return FSFile.Create(path, bufferSize);
        }

        public StreamWriter CreateText(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            return FSFile.CreateText(path);
        }

        public void Delete(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            FSFile.Delete(path);
        }

        public bool Exists(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            return FSFile.Exists(path);
        }

        public DateTime GetCreationTime(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            return FSFile.GetCreationTimeUtc(path);
        }

        public DateTime GetLastAccessTime(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            return FSFile.GetLastAccessTimeUtc(path);
        }

        public DateTime GetLastWriteTime(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            return FSFile.GetLastWriteTimeUtc(path);
        }

        public void Move(string sourceFileName, string destFileName)
        {
            if (string.IsNullOrWhiteSpace(sourceFileName))
                throw new ArgumentNullException(nameof(sourceFileName));
            if (string.IsNullOrWhiteSpace(destFileName))
                throw new ArgumentNullException(nameof(destFileName));

            FSFile.Move(sourceFileName, destFileName);
        }

        public Stream OpenRead(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            return FSFile.OpenRead(path);
        }

        public StreamReader OpenText(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            return FSFile.OpenText(path);
        }

        public Stream OpenWrite(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            return FSFile.OpenWrite(path);
        }

        public byte[] ReadAllBytes(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            return FSFile.ReadAllBytes(path);
        }

        public string[] ReadAllLines(string path, Encoding encoding = null)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            if (encoding == null)
                return FSFile.ReadAllLines(path);
            else
                return FSFile.ReadAllLines(path, encoding);
        }

        public string ReadAllText(string path, Encoding encoding = null)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            if (encoding == null)
                return FSFile.ReadAllText(path);
            else
                return FSFile.ReadAllText(path, encoding);
        }

        public IEnumerable<string> ReadLines(string path, Encoding encoding = null)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            if (encoding == null)
                return FSFile.ReadLines(path);
            else
                return FSFile.ReadLines(path, encoding);
        }

        public void SetCreationTime(string path, DateTime creationTime)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            FSFile.SetCreationTimeUtc(path, creationTime);
        }

        public void SetLastAccessTime(string path, DateTime lastAccessTime)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            FSFile.SetLastAccessTimeUtc(path, lastAccessTime);
        }

        public void SetLastWriteTime(string path, DateTime lastWriteTime)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            FSFile.SetLastWriteTimeUtc(path, lastWriteTime);
        }

        public void WriteAllBytes(string path, byte[] bytes)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));
            if (bytes == null)
                throw new ArgumentNullException(nameof(bytes));

            FSFile.WriteAllBytes(path, bytes);
        }

        public void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding = null)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));
            if (contents == null)
                throw new ArgumentNullException(nameof(contents));

            if (encoding == null)
                FSFile.WriteAllLines(path, contents);
            else
                FSFile.WriteAllLines(path, contents, encoding);
        }

        public void WriteAllText(string path, string contents, Encoding encoding = null)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));
            if (string.IsNullOrWhiteSpace(contents))
                throw new ArgumentNullException(nameof(contents));

            if (encoding == null)
                FSFile.WriteAllText(path, contents);
            else
                FSFile.WriteAllText(path, contents, encoding);
        }
    }
}