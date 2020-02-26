﻿using Soccer.web.Data.Entities;
using Soccer.web.Models;
using Soccer.Web.Data.Entities;


namespace Soccer.Web.Helpers
{
    public interface IConverterHelper
    {
        TeamEntity ToTeamEntity(TeamViewModel model, string path, bool isNew);

        TeamViewModel ToTeamViewModel(TeamEntity teamEntity);
    }
}
