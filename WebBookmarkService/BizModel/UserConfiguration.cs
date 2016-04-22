﻿//============================================================
//http://codelover.link author:李国宝
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using WebBookmarkService.Model;

namespace WebBookmarkService.BizModel
{	
	[Serializable()]
    
    /// <summary>
    /// 
    /// </summary>
	public class BizUserConfiguration
	{
        /// <summary>
        /// 
        /// </summary>
		public long UserConfigurationID{get;set;}
            
        /// <summary>
        /// 用户ID
        /// </summary>
		public long UserInfoID{get;set;}
            
        /// <summary>
        /// key
        /// </summary>
		public string UserConfigurationKey{get;set;}
            
        /// <summary>
        /// value
        /// </summary>
		public string UserConfigurationValue{get;set;}
            
        /// <summary>
        /// 描叙
        /// </summary>
		public string Description{get;set;}
            
        /// <summary>
        /// 序号
        /// </summary>
		public int UserConfigurationNo{get;set;}
            
        
        /// <summary>
        /// Biz Convert To DB Model
        /// </summary>
        public UserConfiguration ToModel()
        {
            return new UserConfiguration()
            {
                UserConfigurationID =  UserConfigurationID,
                UserInfoID =  UserInfoID,
                UserConfigurationKey =  UserConfigurationKey,
                UserConfigurationValue =  UserConfigurationValue,
                Description =  Description,
                UserConfigurationNo =  UserConfigurationNo,
            };
        }
        
        
        public BizUserConfiguration (UserConfiguration dataInfo)
        {
             UserConfigurationID =  dataInfo.UserConfigurationID;
             UserInfoID =  dataInfo.UserInfoID;
             UserConfigurationKey =  dataInfo.UserConfigurationKey;
             UserConfigurationValue =  dataInfo.UserConfigurationValue;
             Description =  dataInfo.Description;
             UserConfigurationNo =  dataInfo.UserConfigurationNo;
        }
        
        public  BizUserConfiguration ()
        {
        
        } 
        
	}
}