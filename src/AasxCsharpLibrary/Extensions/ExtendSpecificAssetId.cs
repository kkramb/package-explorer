﻿using Extensions;
using System.Collections.Generic;
using System.Linq;

namespace AdminShellNS.Extensions
{
    public static class ExtendSpecificAssetId
    {
        public static bool Matches(this ISpecificAssetId specificAssetId, ISpecificAssetId other)
        {
            if (specificAssetId == null) return false;
            if (other == null) return false;

            //check mandatory parameters first
            if (specificAssetId.Name != other.Name) return false;
            if (specificAssetId.Value != other.Value) return false;
            if (!specificAssetId.ExternalSubjectId.Matches(other.ExternalSubjectId)) return false;

            //TODO: jtikekar Check optional parameter i.e., Semantic Id and supplementatry semantic id

            return true;
        }

        #region ListOfSpecificAssetIds

        public static bool ContainsSpecificAssetId(this List<ISpecificAssetId> specificAssetIds, ISpecificAssetId other)
        {
            if (specificAssetIds == null) return false;
            if (other == null) return false;

            var foundIds = specificAssetIds.Where(assetId => assetId.Matches(other));
            if (foundIds.Any()) return true;

            return false;
        }

        #endregion

    }
}
