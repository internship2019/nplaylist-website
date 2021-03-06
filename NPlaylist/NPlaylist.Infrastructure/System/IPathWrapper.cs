﻿namespace NPlaylist.Infrastructure.System
{
    public interface IPathWrapper
    {
        string GetDirectoryName(string filePath);

        string GetExtension(string fileName);

        string Combine(params string[] pathParts);
    }
}