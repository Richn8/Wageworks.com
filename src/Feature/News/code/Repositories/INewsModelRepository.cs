﻿using System.Collections.Generic;
using Vista.Feature.News.Models;

namespace Vista.Feature.News.Repositories
{
    public interface INewsModelRepository
    {
        NewsListViewModel GetNewsList(string parentId, int page = 1, int pageSize = 6, List<string> filters = null, bool onlyVideos = false, string queryFilter = "");
        NewsPromoSectionViewModel GetNewsPromos();
        NewsPromoSectionViewModel GetRelatedNews();
    }
}