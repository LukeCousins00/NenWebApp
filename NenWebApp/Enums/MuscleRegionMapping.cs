using System;
using System.Collections.Generic;

namespace NenWebApp.Enums;

public static class MuscleRegionMapping
{
    private static readonly Dictionary<Muscle, MuscleRegion> muscleRegionMap = new Dictionary<Muscle, MuscleRegion>()
    {
        { Muscle.Forearm, MuscleRegion.Upper },
        { Muscle.Bicep, MuscleRegion.Upper },
        { Muscle.Tricep, MuscleRegion.Upper },
        { Muscle.Chest, MuscleRegion.Upper },
        { Muscle.Lat, MuscleRegion.Upper },
        { Muscle.UpperBack, MuscleRegion.Upper },
        { Muscle.LowerBack, MuscleRegion.Lower },
        { Muscle.Wrist, MuscleRegion.Upper },
        { Muscle.Ab, MuscleRegion.Upper },
        { Muscle.Calves, MuscleRegion.Lower },
        { Muscle.Ankle, MuscleRegion.Lower },
        { Muscle.Tibialis, MuscleRegion.Lower },
        { Muscle.Glutes, MuscleRegion.Lower },
        { Muscle.Hamstring, MuscleRegion.Lower },
        { Muscle.Hip, MuscleRegion.Lower },
        { Muscle.Quad, MuscleRegion.Lower },
        { Muscle.Shoulder, MuscleRegion.Upper },

    };

    public static List<string> GetMusclesForRegion(string region)
    {
        List<string> matchingMuscles = muscleRegionMap
        .Where(kv => kv.Value == (MuscleRegion)Enum.Parse(typeof(MuscleRegion), region))
            .Select(kv => kv.Key.ToString())
        .ToList();

        return matchingMuscles;
    }
}