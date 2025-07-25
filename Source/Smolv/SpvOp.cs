namespace Smolv;

public enum SpvOp
{
	Nop = 0,
	Undef = 1,
	SourceContinued = 2,
	Source = 3,
	SourceExtension = 4,
	Name = 5,
	MemberName = 6,
	String = 7,
	Line = 8,
	Extension = 10,
	ExtInstImport = 11,
	ExtInst = 12,
	/// <summary>
	/// Not in SPIR-V, added for SMOL-V!
	/// </summary>
	VectorShuffleCompact = 13,
	MemoryModel = 14,
	EntryPoint = 15,
	ExecutionMode = 16,
	Capability = 17,
	TypeVoid = 19,
	TypeBool = 20,
	TypeInt = 21,
	TypeFloat = 22,
	TypeVector = 23,
	TypeMatrix = 24,
	TypeImage = 25,
	TypeSampler = 26,
	TypeSampledImage = 27,
	TypeArray = 28,
	TypeRuntimeArray = 29,
	TypeStruct = 30,
	TypeOpaque = 31,
	TypePointer = 32,
	TypeFunction = 33,
	TypeEvent = 34,
	TypeDeviceEvent = 35,
	TypeReserveId = 36,
	TypeQueue = 37,
	TypePipe = 38,
	TypeForwardPointer = 39,
	ConstantTrue = 41,
	ConstantFalse = 42,
	Constant = 43,
	ConstantComposite = 44,
	ConstantSampler = 45,
	ConstantNull = 46,
	SpecConstantTrue = 48,
	SpecConstantFalse = 49,
	SpecConstant = 50,
	SpecConstantComposite = 51,
	SpecConstantOp = 52,
	Function = 54,
	FunctionParameter = 55,
	FunctionEnd = 56,
	FunctionCall = 57,
	Variable = 59,
	ImageTexelPointer = 60,
	Load = 61,
	Store = 62,
	CopyMemory = 63,
	CopyMemorySized = 64,
	AccessChain = 65,
	InBoundsAccessChain = 66,
	PtrAccessChain = 67,
	ArrayLength = 68,
	GenericPtrMemSemantics = 69,
	InBoundsPtrAccessChain = 70,
	Decorate = 71,
	MemberDecorate = 72,
	DecorationGroup = 73,
	GroupDecorate = 74,
	GroupMemberDecorate = 75,
	VectorExtractDynamic = 77,
	VectorInsertDynamic = 78,
	VectorShuffle = 79,
	CompositeConstruct = 80,
	CompositeExtract = 81,
	CompositeInsert = 82,
	CopyObject = 83,
	Transpose = 84,
	SampledImage = 86,
	ImageSampleImplicitLod = 87,
	ImageSampleExplicitLod = 88,
	ImageSampleDrefImplicitLod = 89,
	ImageSampleDrefExplicitLod = 90,
	ImageSampleProjImplicitLod = 91,
	ImageSampleProjExplicitLod = 92,
	ImageSampleProjDrefImplicitLod = 93,
	ImageSampleProjDrefExplicitLod = 94,
	ImageFetch = 95,
	ImageGather = 96,
	ImageDrefGather = 97,
	ImageRead = 98,
	ImageWrite = 99,
	Image = 100,
	ImageQueryFormat = 101,
	ImageQueryOrder = 102,
	ImageQuerySizeLod = 103,
	ImageQuerySize = 104,
	ImageQueryLod = 105,
	ImageQueryLevels = 106,
	ImageQuerySamples = 107,
	ConvertFToU = 109,
	ConvertFToS = 110,
	ConvertSToF = 111,
	ConvertUToF = 112,
	UConvert = 113,
	SConvert = 114,
	FConvert = 115,
	QuantizeToF16 = 116,
	ConvertPtrToU = 117,
	SatConvertSToU = 118,
	SatConvertUToS = 119,
	ConvertUToPtr = 120,
	PtrCastToGeneric = 121,
	GenericCastToPtr = 122,
	GenericCastToPtrExplicit = 123,
	Bitcast = 124,
	SNegate = 126,
	FNegate = 127,
	IAdd = 128,
	FAdd = 129,
	ISub = 130,
	FSub = 131,
	IMul = 132,
	FMul = 133,
	UDiv = 134,
	SDiv = 135,
	FDiv = 136,
	UMod = 137,
	SRem = 138,
	SMod = 139,
	FRem = 140,
	FMod = 141,
	VectorTimesScalar = 142,
	MatrixTimesScalar = 143,
	VectorTimesMatrix = 144,
	MatrixTimesVector = 145,
	MatrixTimesMatrix = 146,
	OuterProduct = 147,
	Dot = 148,
	IAddCarry = 149,
	ISubBorrow = 150,
	UMulExtended = 151,
	SMulExtended = 152,
	Any = 154,
	All = 155,
	IsNan = 156,
	IsInf = 157,
	IsFinite = 158,
	IsNormal = 159,
	SignBitSet = 160,
	LessOrGreater = 161,
	Ordered = 162,
	Unordered = 163,
	LogicalEqual = 164,
	LogicalNotEqual = 165,
	LogicalOr = 166,
	LogicalAnd = 167,
	LogicalNot = 168,
	Select = 169,
	IEqual = 170,
	INotEqual = 171,
	UGreaterThan = 172,
	SGreaterThan = 173,
	UGreaterThanEqual = 174,
	SGreaterThanEqual = 175,
	ULessThan = 176,
	SLessThan = 177,
	ULessThanEqual = 178,
	SLessThanEqual = 179,
	FOrdEqual = 180,
	FUnordEqual = 181,
	FOrdNotEqual = 182,
	FUnordNotEqual = 183,
	FOrdLessThan = 184,
	FUnordLessThan = 185,
	FOrdGreaterThan = 186,
	FUnordGreaterThan = 187,
	FOrdLessThanEqual = 188,
	FUnordLessThanEqual = 189,
	FOrdGreaterThanEqual = 190,
	FUnordGreaterThanEqual = 191,
	ShiftRightLogical = 194,
	ShiftRightArithmetic = 195,
	ShiftLeftLogical = 196,
	BitwiseOr = 197,
	BitwiseXor = 198,
	BitwiseAnd = 199,
	Not = 200,
	BitFieldInsert = 201,
	BitFieldSExtract = 202,
	BitFieldUExtract = 203,
	BitReverse = 204,
	BitCount = 205,
	DPdx = 207,
	DPdy = 208,
	Fwidth = 209,
	DPdxFine = 210,
	DPdyFine = 211,
	FwidthFine = 212,
	DPdxCoarse = 213,
	DPdyCoarse = 214,
	FwidthCoarse = 215,
	EmitVertex = 218,
	EndPrimitive = 219,
	EmitStreamVertex = 220,
	EndStreamPrimitive = 221,
	ControlBarrier = 224,
	MemoryBarrier = 225,
	AtomicLoad = 227,
	AtomicStore = 228,
	AtomicExchange = 229,
	AtomicCompareExchange = 230,
	AtomicCompareExchangeWeak = 231,
	AtomicIIncrement = 232,
	AtomicIDecrement = 233,
	AtomicIAdd = 234,
	AtomicISub = 235,
	AtomicSMin = 236,
	AtomicUMin = 237,
	AtomicSMax = 238,
	AtomicUMax = 239,
	AtomicAnd = 240,
	AtomicOr = 241,
	AtomicXor = 242,
	Phi = 245,
	LoopMerge = 246,
	SelectionMerge = 247,
	Label = 248,
	Branch = 249,
	BranchConditional = 250,
	Switch = 251,
	Kill = 252,
	Return = 253,
	ReturnValue = 254,
	Unreachable = 255,
	LifetimeStart = 256,
	LifetimeStop = 257,
	GroupAsyncCopy = 259,
	GroupWaitEvents = 260,
	GroupAll = 261,
	GroupAny = 262,
	GroupBroadcast = 263,
	GroupIAdd = 264,
	GroupFAdd = 265,
	GroupFMin = 266,
	GroupUMin = 267,
	GroupSMin = 268,
	GroupFMax = 269,
	GroupUMax = 270,
	GroupSMax = 271,
	ReadPipe = 274,
	WritePipe = 275,
	ReservedReadPipe = 276,
	ReservedWritePipe = 277,
	ReserveReadPipePackets = 278,
	ReserveWritePipePackets = 279,
	CommitReadPipe = 280,
	CommitWritePipe = 281,
	IsValidReserveId = 282,
	GetNumPipePackets = 283,
	GetMaxPipePackets = 284,
	GroupReserveReadPipePackets = 285,
	GroupReserveWritePipePackets = 286,
	GroupCommitReadPipe = 287,
	GroupCommitWritePipe = 288,
	EnqueueMarker = 291,
	EnqueueKernel = 292,
	GetKernelNDrangeSubGroupCount = 293,
	GetKernelNDrangeMaxSubGroupSize = 294,
	GetKernelWorkGroupSize = 295,
	GetKernelPreferredWorkGroupSizeMultiple = 296,
	RetainEvent = 297,
	ReleaseEvent = 298,
	CreateUserEvent = 299,
	IsValidEvent = 300,
	SetUserEventStatus = 301,
	CaptureEventProfilingInfo = 302,
	GetDefaultQueue = 303,
	BuildNDRange = 304,
	ImageSparseSampleImplicitLod = 305,
	ImageSparseSampleExplicitLod = 306,
	ImageSparseSampleDrefImplicitLod = 307,
	ImageSparseSampleDrefExplicitLod = 308,
	ImageSparseSampleProjImplicitLod = 309,
	ImageSparseSampleProjExplicitLod = 310,
	ImageSparseSampleProjDrefImplicitLod = 311,
	ImageSparseSampleProjDrefExplicitLod = 312,
	ImageSparseFetch = 313,
	ImageSparseGather = 314,
	ImageSparseDrefGather = 315,
	ImageSparseTexelsResident = 316,
	NoLine = 317,
	AtomicFlagTestAndSet = 318,
	AtomicFlagClear = 319,
	ImageSparseRead = 320,
	SizeOf = 321,
	TypePipeStorage = 322,
	ConstantPipeStorage = 323,
	CreatePipeFromPipeStorage = 324,
	GetKernelLocalSizeForSubgroupCount = 325,
	GetKernelMaxNumSubgroups = 326,
	TypeNamedBarrier = 327,
	NamedBarrierInitialize = 328,
	MemoryNamedBarrier = 329,
	ModuleProcessed = 330,
	ExecutionModeId = 331,
	DecorateId = 332,
	GroupNonUniformElect = 333,
	GroupNonUniformAll = 334,
	GroupNonUniformAny = 335,
	GroupNonUniformAllEqual = 336,
	GroupNonUniformBroadcast = 337,
	GroupNonUniformBroadcastFirst = 338,
	GroupNonUniformBallot = 339,
	GroupNonUniformInverseBallot = 340,
	GroupNonUniformBallotBitExtract = 341,
	GroupNonUniformBallotBitCount = 342,
	GroupNonUniformBallotFindLSB = 343,
	GroupNonUniformBallotFindMSB = 344,
	GroupNonUniformShuffle = 345,
	GroupNonUniformShuffleXor = 346,
	GroupNonUniformShuffleUp = 347,
	GroupNonUniformShuffleDown = 348,
	GroupNonUniformIAdd = 349,
	GroupNonUniformFAdd = 350,
	GroupNonUniformIMul = 351,
	GroupNonUniformFMul = 352,
	GroupNonUniformSMin = 353,
	GroupNonUniformUMin = 354,
	GroupNonUniformFMin = 355,
	GroupNonUniformSMax = 356,
	GroupNonUniformUMax = 357,
	GroupNonUniformFMax = 358,
	GroupNonUniformBitwiseAnd = 359,
	GroupNonUniformBitwiseOr = 360,
	GroupNonUniformBitwiseXor = 361,
	GroupNonUniformLogicalAnd = 362,
	GroupNonUniformLogicalOr = 363,
	GroupNonUniformLogicalXor = 364,
	GroupNonUniformQuadBroadcast = 365,
	GroupNonUniformQuadSwap = 366,
}

public static class SpvOpExtensions
{
	/// <summary>
	/// Instruction encoding depends on the table that describes the various SPIR-V opcodes.<br/>
	/// Whenever we change or expand the table, we need to bump up the SMOL-V version,<br/>
	/// and make sure that we can still decode files encoded by an older version.
	/// </summary>
	static int GetKnownOpsCount(int version)
	{
		if (version == 0)
		{
			return (int)(SpvOp.ModuleProcessed + 1);
		}

		if (version == 1) // 2020 February, version 1 added ExecutionModeId..GroupNonUniformQuadSwap
		{
			return (int)(SpvOp.GroupNonUniformQuadSwap + 1);
		}

		return 0;
	}

	public static bool OpHasResult(this SpvOp _this) => OpHasResult(_this, GetKnownOpsCount(0));
	public static bool OpHasResult(this SpvOp _this, int opsCount)
	{
		if (_this < 0 || (int)_this >= opsCount)
		{
			return false;
		}
		return OpData.Get(_this).HasResult != 0;
	}

	public static bool OpHasType(this SpvOp _this) => OpHasType(_this, GetKnownOpsCount(0));
	public static bool OpHasType(this SpvOp _this, int opsCount)
	{
		if (_this < 0 || (int)_this >= opsCount)
		{
			return false;
		}
		return OpData.Get(_this).HasType != 0;
	}

	public static int OpDeltaFromResult(this SpvOp _this) => OpDeltaFromResult(_this, GetKnownOpsCount(0));
	public static int OpDeltaFromResult(this SpvOp _this, int opsCount)
	{
		if (_this < 0 || (int)_this >= opsCount)
		{
			return 0;
		}
		return OpData.Get(_this).DeltaFromResult;
	}

	public static bool OpVarRest(this SpvOp _this) => OpVarRest(_this, GetKnownOpsCount(0));
	public static bool OpVarRest(this SpvOp _this, int opsCount)
	{
		if (_this < 0 || (int)_this >= opsCount)
		{
			return false;
		}
		return OpData.Get(_this).VarRest != 0;
	}

	public static bool OpDebugInfo(this SpvOp _this) => OpDebugInfo(_this, GetKnownOpsCount(0));
	public static bool OpDebugInfo(this SpvOp _this, int opsCount)
	{
		return _this is
			SpvOp.SourceContinued or
			SpvOp.Source or
			SpvOp.SourceExtension or
			SpvOp.Name or
			SpvOp.MemberName or
			SpvOp.String or
			SpvOp.Line or
			SpvOp.NoLine or
			SpvOp.ModuleProcessed;
	}
}
