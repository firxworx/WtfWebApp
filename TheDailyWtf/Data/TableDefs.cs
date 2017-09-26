//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using global::System;
using global::System.ComponentModel;
using global::System.Data;
using global::System.Data.SqlClient;
using global::System.Collections.Generic;
using global::System.Linq;
using global::System.Xml.Linq;
using global::Inedo.Data;

#pragma warning disable 1591
namespace TheDailyWtf.Data
{
	public static class TableDefs
	{
		public static class AdImpressions
		{
			public const string Banner_Name = "Banner_Name";
			public const string Impression_Date = "Impression_Date";
			public const string Impression_Count = "Impression_Count";
		}
		public static class AdRedirectUrls
		{
			public const string Ad_Guid = "Ad_Guid";
			public const string Redirect_Url = "Redirect_Url";
			public const string Click_Count = "Click_Count";
		}
		public static class Ads
		{
			public const string Ad_Id = "Ad_Id";
			public const string Ad_Html = "Ad_Html";
		}
		public static class ArticlePostMappings
		{
			public const string Post_Id = "Post_Id";
			public const string Article_Id = "Article_Id";
		}
		[Obsolete("Articles is obsolete. Use Articles_Extended instead.", true)]
		public static class Articles
		{
			public const string Article_Id = "Article_Id";
			public const string Article_Slug = "Article_Slug";
			public const string Published_Date = "Published_Date";
			public const string PublishedStatus_Name = "PublishedStatus_Name";
			public const string Author_Slug = "Author_Slug";
			public const string Title_Text = "Title_Text";
			public const string Series_Slug = "Series_Slug";
			public const string Body_Html = "Body_Html";
			public const string Discourse_Topic_Id = "Discourse_Topic_Id";
			public const string Discourse_Topic_Opened = "Discourse_Topic_Opened";
			public const string Ad_Id = "Ad_Id";
		}
		public static class Articles_Extended
		{
			public const string Article_Id = "Article_Id";
			public const string Article_Slug = "Article_Slug";
			public const string Published_Date = "Published_Date";
			public const string PublishedStatus_Name = "PublishedStatus_Name";
			public const string Author_Slug = "Author_Slug";
			public const string Title_Text = "Title_Text";
			public const string Series_Slug = "Series_Slug";
			public const string Body_Html = "Body_Html";
			public const string BodyAndAd_Html = "BodyAndAd_Html";
			public const string Discourse_Topic_Id = "Discourse_Topic_Id";
			public const string Discourse_Topic_Opened = "Discourse_Topic_Opened";
			public const string Previous_Article_Id = "Previous_Article_Id";
			public const string Previous_Article_Slug = "Previous_Article_Slug";
			public const string Previous_Title_Text = "Previous_Title_Text";
			public const string Next_Article_Id = "Next_Article_Id";
			public const string Next_Article_Slug = "Next_Article_Slug";
			public const string Next_Title_Text = "Next_Title_Text";
			public const string Author_Display_Name = "Author_Display_Name";
			public const string Author_Admin_Indicator = "Author_Admin_Indicator";
			public const string Author_Bio_Html = "Author_Bio_Html";
			public const string Author_ShortBio_Text = "Author_ShortBio_Text";
			public const string Author_Image_Url = "Author_Image_Url";
			public const string Author_Active_Indicator = "Author_Active_Indicator";
			public const string Series_Title_Text = "Series_Title_Text";
			public const string Series_Description_Text = "Series_Description_Text";
			public const string Cached_Comment_Count = "Cached_Comment_Count";
			public const string Last_Comment_Date = "Last_Comment_Date";
			public const string Ad_Html = "Ad_Html";
		}
		public static class Authors
		{
			public const string Author_Slug = "Author_Slug";
			public const string Display_Name = "Display_Name";
			public const string Password_Bytes = "Password_Bytes";
			public const string Salt_Bytes = "Salt_Bytes";
			public const string Admin_Indicator = "Admin_Indicator";
			public const string Bio_Html = "Bio_Html";
			public const string ShortBio_Text = "ShortBio_Text";
			public const string Image_Url = "Image_Url";
			public const string Active_Indicator = "Active_Indicator";
		}
		[Obsolete("Comments is obsolete. Use Comments_Extended instead.", true)]
		public static class Comments
		{
			public const string Comment_Id = "Comment_Id";
			public const string Article_Id = "Article_Id";
			public const string Body_Html = "Body_Html";
			public const string User_Name = "User_Name";
			public const string Posted_Date = "Posted_Date";
			public const string Discourse_Post_Id = "Discourse_Post_Id";
			public const string Featured_Indicator = "Featured_Indicator";
			public const string User_IP = "User_IP";
			public const string User_Token = "User_Token";
			public const string Parent_Comment_Id = "Parent_Comment_Id";
			public const string Hidden_Indicator = "Hidden_Indicator";
		}
		public static class Comments_Extended
		{
			public const string Comment_Id = "Comment_Id";
			public const string Comment_Index = "Comment_Index";
			public const string Article_Id = "Article_Id";
			public const string Article_Title = "Article_Title";
			public const string Body_Html = "Body_Html";
			public const string User_Name = "User_Name";
			public const string Posted_Date = "Posted_Date";
			public const string Discourse_Post_Id = "Discourse_Post_Id";
			public const string Featured_Indicator = "Featured_Indicator";
			public const string Hidden_Indicator = "Hidden_Indicator";
			public const string User_IP = "User_IP";
			public const string User_Token = "User_Token";
			public const string Parent_Comment_Id = "Parent_Comment_Id";
			public const string Parent_Comment_Index = "Parent_Comment_Index";
			public const string Parent_Comment_User_Name = "Parent_Comment_User_Name";
		}
		public static class FeaturedComments
		{
			public const string Article_Id = "Article_Id";
			public const string Discourse_Post_Id = "Discourse_Post_Id";
		}
		public static class Series
		{
			public const string Series_Slug = "Series_Slug";
			public const string Title_Text = "Title_Text";
			public const string Description_Text = "Description_Text";
		}
	}
}
#pragma warning restore 1591
