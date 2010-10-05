using System;
using System.Collections.Generic;
using NzbDrone.Core.Repository;
using NzbDrone.Core.Repository.Episode;

namespace NzbDrone.Core.Providers
{
    public interface IEpisodeProvider
    {
        Episode GetEpisode(long id);
        Episode UpdateEpisode(Episode episode);
        IList<Episode> GetEpisodesBySeason(long seasonId);
        IList<Episode> GetEpisodeBySeries(long seriesId);
        String GetSabTitle(Episode episode);

        /// <summary>
        /// Comprehensive check on whether or not this episode is needed.
        /// </summary>
        /// <param name="episode">Episode that needs to be checked</param>
        /// <returns></returns>
        bool IsNeeded(Episode episode);

        void RefreshSeries(int seriesId);
    }
}