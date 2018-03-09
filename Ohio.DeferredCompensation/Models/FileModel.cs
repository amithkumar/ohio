/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System;

namespace Ohio.DeferredCompensation.Models
{
    public class FileModel
    {
        public long Id { get; set; }

        public string FileName { get; set; }

        public DateTime UploadDate { get; set; }

        public string FileSize { get; set; }

        public string DocumentType { get; set; }

        public string Comment { get; set; }
    }
}