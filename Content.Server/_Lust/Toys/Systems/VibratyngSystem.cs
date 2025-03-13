using Content.Server.Chat.Systems;
using Content.Server.Jittering;
using Content.Server.Lust.Toys.Components;
using Content.Shared.Mobs.Systems;
using Robust.Shared.Random;
using Robust.Shared.Timing;

namespace Content.Server.Lust.Toys.Systems;

public sealed class VibratingSystem : EntitySystem
{
    [Dependency] private readonly MobStateSystem _mobStateSystem = default!;
    [Dependency] private readonly IGameTiming _timing = default!;
    [Dependency] private readonly ChatSystem _chatSystem = default!;
    [Dependency] private readonly IRobustRandom _random = default!;
    [Dependency] private readonly JitteringSystem _jittering = default!;
}