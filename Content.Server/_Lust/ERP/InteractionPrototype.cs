using Content.Shared.FixedPoint;
using Robust.Shared.Prototypes;
using Robust.Shared.Utility;
using Robust.Shared.Audio;
using Content.Shared.Humanoid;
namespace Content.Shared.Lust.ERP;

using Content.Shared.Damage;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

[Prototype("interaction")]
public sealed partial class InteractionPrototype : IPrototype
{
    [IdDataField]
    public string ID { get; private set; } = default!;

    [DataField(required: true)]
    public string Name = default!; //Обнять, Дать пять, что-либо ещё..


    [DataField] public SpriteSpecifier Icon = new SpriteSpecifier.Texture(new("/Textures/_Lust/Interface/ERP/blankIcon.png")); //Иконка рядом с текстом
    [DataField] public List<SoundSpecifier> Sounds = new(); // Звуки
    [DataField] public HashSet<string> Emotes = new(); // Эмоуты, которые проигрывает юзер
    [DataField] public bool Erp = false; // Это ЕРП-действие?
    [DataField] public HashSet<string> InhandObject = new(); // Требуемый в руке объект у юзера
    [DataField] public bool UseSelf = false; // Можно ли использовать на себе?
    [DataField] public string Category = "standart"; // Категория действия
    [DataField] public int SortOrder = 0; // Порядок действия в категории



    [DataField] public List<Sex> UserSex = [];
    [DataField] public bool UserWithoutCloth = false; //Нужно ли, чтобы на энтити не было комбенизона / скафандра
    [DataField] public HashSet<string> UserTagWhitelist = new(); // Вайтлист тегов
    [DataField] public HashSet<string> UserTagBlacklist = new(); // Блеклист тегов
    [DataField] public float UserMoanChance = 0;


    // Тоже самое, но таргет
    [DataField] public List<Sex> TargetSex = [];
    [DataField] public bool TargetWithoutCloth = false;
    [DataField] public HashSet<string> TargetTagWhitelist = new();
    [DataField] public HashSet<string> TargetTagBlacklist = new();
    [DataField] public float TargetMoanChance = 0;
}