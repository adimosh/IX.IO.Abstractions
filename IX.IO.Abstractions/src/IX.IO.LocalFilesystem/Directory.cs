using System;
using System.Collections.Generic;
using FSDir = System.IO.Directory;
using IX.IO.Abstractions;

namespace IX.IO.LocalFilesystem
{
    public class Directory : IDirectory
    {
        public void CreateDirectory(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            FSDir.CreateDirectory(path);
        }

        public void Delete(string path, bool recursive = false)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            if (recursive)
                FSDir.Delete(path, true);
            else
                FSDir.Delete(path);
        }

        public IEnumerable<string> EnumerateDirectories(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            return FSDir.EnumerateDirectories(path);
        }

        public IEnumerable<string> EnumerateDirectories(string path, string searchPattern)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));
            if (string.IsNullOrWhiteSpace(searchPattern))
                throw new ArgumentNullException(nameof(searchPattern));

            return FSDir.EnumerateDirectories(path, searchPattern);
        }

        public IEnumerable<string> EnumerateFiles(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            return FSDir.EnumerateFiles(path);
        }

        public IEnumerable<string> EnumerateFiles(string path, string searchPattern)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));
            if (string.IsNullOrWhiteSpace(searchPattern))
                throw new ArgumentNullException(nameof(searchPattern));

            return FSDir.EnumerateFiles(path, searchPattern);
        }

        public IEnumerable<string> EnumerateFileSystemEntries(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            return FSDir.EnumerateFileSystemEntries(path);
        }

        public IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));
            if (string.IsNullOrWhiteSpace(searchPattern))
                throw new ArgumentNullException(nameof(searchPattern));

            return FSDir.EnumerateFileSystemEntries(path, searchPattern);
        }

        public bool Exists(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            return FSDir.Exists(path);
        }

        public DateTime GetCreationTime(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            return FSDir.GetCreationTimeUtc(path);
        }

        public string[] GetDirectories(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            return FSDir.GetDirectories(path);
        }

        public string[] GetDirectories(string path, string searchPattern)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));
            if (string.IsNullOrWhiteSpace(searchPattern))
                throw new ArgumentNullException(nameof(searchPattern));

            return FSDir.GetDirectories(path, searchPattern);
        }

        public string[] GetFiles(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            return FSDir.GetFiles(path);
        }

        public string[] GetFiles(string path, string searchPattern)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));
            if (string.IsNullOrWhiteSpace(searchPattern))
                throw new ArgumentNullException(nameof(searchPattern));

            return FSDir.GetFiles(path, searchPattern);
        }

        public string[] GetFileSystemEntries(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            return FSDir.GetFileSystemEntries(path);
        }

        public string[] GetFileSystemEntries(string path, string searchPattern)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));
            if (string.IsNullOrWhiteSpace(searchPattern))
                throw new ArgumentNullException(nameof(searchPattern));

            return FSDir.GetFileSystemEntries(path, searchPattern);
        }

        public DateTime GetLastAccessTime(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            return FSDir.GetLastAccessTimeUtc(path);
        }

        public DateTime GetLastWriteTime(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            return FSDir.GetLastWriteTimeUtc(path);
        }

        public void Move(string sourceDirName, string destDirName)
        {
            if (string.IsNullOrWhiteSpace(sourceDirName))
                throw new ArgumentNullException(nameof(sourceDirName));
            if (string.IsNullOrWhiteSpace(destDirName))
                throw new ArgumentNullException(nameof(destDirName));

            FSDir.Move(sourceDirName, destDirName);
        }

        public void SetCreationTime(string path, DateTime creationTime)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            FSDir.SetCreationTime(path, creationTime);
        }

        public void SetLastAccessTime(string path, DateTime lastAccessTime)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            FSDir.SetLastAccessTime(path, lastAccessTime);
        }

        public void SetLastWriteTime(string path, DateTime lastWriteTime)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            FSDir.SetLastWriteTime(path, lastWriteTime);
        }
    }
}