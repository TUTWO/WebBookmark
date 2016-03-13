﻿//============================================================
//http://codelover.link author:李国宝
//============================================================

using System;
using System.Collections.Generic;
using System.Text;

namespace WebfolderService.Model
{	
	[Serializable()]
    
    /// <summary>
    /// 
    /// </summary>
	public class UserWebFolderImportLog
	{
        /// <summary>
        /// 主键
        /// </summary>
		public long UserWebFolderImportLogID{get;set;}
            
        /// <summary>
        /// 用户UID
        /// </summary>
		public long UserInfoID{get;set;}
            
        /// <summary>
        /// 文件所在路径
        /// </summary>
		public string Path{get;set;}
            
        /// <summary>
        /// 文件名称
        /// </summary>
		public string FileName{get;set;}
            
        /// <summary>
        /// 创建时间
        /// </summary>
		public DateTime CreateTime{get;set;}
            
	}
}