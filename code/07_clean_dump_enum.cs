private enum SimpleCollator.ExtenderType
{
	None = 0,
	Simple = 1,
	Voiced = 2,
	Conditional = 3,
	Buggy = 4,
}

internal enum X509ChainStatusFlags
{
	InvalidBasicConstraints = 1024,
	NoError = 0,
	NotSignatureValid = 8,
	NotTimeNested = 2,
	NotTimeValid = 1,
	PartialChain = 65536,
	UntrustedRoot = 32,
}

public enum PKCS8.KeyInfo
{
	PrivateKey = 0,
	EncryptedPrivateKey = 1,
	Unknown = 2,
}

public enum BigInteger.Sign
{
	Zero = 0,
	Positive = 1,
}

internal enum ConfidenceFactor
{
	ExtraLow = 0,
	Low = 1,
	Medium = 2,
	High = 3,
	ExtraHigh = 4,
	Provable = 5,
}

public enum RegistryHive
{
}

public enum RegistryValueKind
{
	Unknown = 0,
	String = 1,
	ExpandString = 2,
	Binary = 3,
	DWord = 4,
	MultiString = 7,
	QWord = 11,
}

public enum RegistryValueOptions
{
	None = 0,
	DoNotExpandEnvironmentNames = 1,
}

public enum AttributeTargets
{
	Assembly = 1,
	Module = 2,
	Class = 4,
	Struct = 8,
	Enum = 16,
	Constructor = 32,
	Method = 64,
	Property = 128,
	Field = 256,
	Event = 512,
	Interface = 1024,
	Parameter = 2048,
	Delegate = 4096,
	ReturnValue = 8192,
	GenericParameter = 16384,
	All = 32767,
}

public enum ConsoleColor
{
	Black = 0,
	DarkBlue = 1,
	DarkGreen = 2,
	DarkCyan = 3,
	DarkRed = 4,
	DarkMagenta = 5,
	DarkYellow = 6,
	Gray = 7,
	DarkGray = 8,
	Blue = 9,
	Green = 10,
	Cyan = 11,
	Red = 12,
	Magenta = 13,
	Yellow = 14,
	White = 15,
}

public enum ConsoleKey
{
	Backspace = 8,
	Tab = 9,
	Clear = 12,
	Enter = 13,
	Pause = 19,
	Escape = 27,
	Spacebar = 32,
	PageUp = 33,
	PageDown = 34,
	End = 35,
	Home = 36,
	LeftArrow = 37,
	UpArrow = 38,
	RightArrow = 39,
	DownArrow = 40,
	Select = 41,
	Print = 42,
	Execute = 43,
	PrintScreen = 44,
	Insert = 45,
	Delete = 46,
	Help = 47,
	D0 = 48,
	D1 = 49,
	D2 = 50,
	D3 = 51,
	D4 = 52,
	D5 = 53,
	D6 = 54,
	D7 = 55,
	D8 = 56,
	D9 = 57,
	A = 65,
	B = 66,
	C = 67,
	D = 68,
	E = 69,
	F = 70,
	G = 71,
	H = 72,
	I = 73,
	J = 74,
	K = 75,
	L = 76,
	M = 77,
	N = 78,
	O = 79,
	P = 80,
	Q = 81,
	R = 82,
	S = 83,
	T = 84,
	U = 85,
	V = 86,
	W = 87,
	X = 88,
	Y = 89,
	Z = 90,
	LeftWindows = 91,
	RightWindows = 92,
	Applications = 93,
	Sleep = 95,
	NumPad0 = 96,
	NumPad1 = 97,
	NumPad2 = 98,
	NumPad3 = 99,
	NumPad4 = 100,
	NumPad5 = 101,
	NumPad6 = 102,
	NumPad7 = 103,
	NumPad8 = 104,
	NumPad9 = 105,
	Multiply = 106,
	Add = 107,
	Separator = 108,
	Subtract = 109,
	Decimal = 110,
	Divide = 111,
	F1 = 112,
	F2 = 113,
	F3 = 114,
	F4 = 115,
	F5 = 116,
	F6 = 117,
	F7 = 118,
	F8 = 119,
	F9 = 120,
	F10 = 121,
	F11 = 122,
	F12 = 123,
	F13 = 124,
	F14 = 125,
	F15 = 126,
	F16 = 127,
	F17 = 128,
	F18 = 129,
	F19 = 130,
	F20 = 131,
	F21 = 132,
	F22 = 133,
	F23 = 134,
	F24 = 135,
	BrowserBack = 166,
	BrowserForward = 167,
	BrowserRefresh = 168,
	BrowserStop = 169,
	BrowserSearch = 170,
	BrowserFavorites = 171,
	BrowserHome = 172,
	VolumeMute = 173,
	VolumeDown = 174,
	VolumeUp = 175,
	MediaNext = 176,
	MediaPrevious = 177,
	MediaStop = 178,
	MediaPlay = 179,
	LaunchMail = 180,
	LaunchMediaSelect = 181,
	LaunchApp1 = 182,
	LaunchApp2 = 183,
	Oem1 = 186,
	OemPlus = 187,
	OemComma = 188,
	OemMinus = 189,
	OemPeriod = 190,
	Oem2 = 191,
	Oem3 = 192,
	Oem4 = 219,
	Oem5 = 220,
	Oem6 = 221,
	Oem7 = 222,
	Oem8 = 223,
	Oem102 = 226,
	Process = 229,
	Packet = 231,
	Attention = 246,
	CrSel = 247,
	ExSel = 248,
	EraseEndOfFile = 249,
	Play = 250,
	Zoom = 251,
	NoName = 252,
	Pa1 = 253,
	OemClear = 254,
}

public enum ConsoleModifiers
{
	Alt = 1,
	Shift = 2,
	Control = 4,
}

public enum ConsoleSpecialKey
{
	ControlC = 0,
	ControlBreak = 1,
}

public enum Base64FormattingOptions
{
	None = 0,
	InsertLineBreaks = 1,
}

public enum DateTimeKind
{
	Unspecified = 0,
	Utc = 1,
	Local = 2,
}

public enum DayOfWeek
{
	Sunday = 0,
	Monday = 1,
	Tuesday = 2,
	Wednesday = 3,
	Thursday = 4,
	Friday = 5,
	Saturday = 6,
}

private enum Enum.ParseFailureKind
{
	None = 0,
	Argument = 1,
	ArgumentNull = 2,
	ArgumentWithParameter = 3,
	UnhandledException = 4,
}

internal enum Exception.ExceptionMessageKind
{
	ThreadAbort = 1,
	ThreadInterrupted = 2,
	OutOfMemory = 3,
}

public enum GCCollectionMode
{
	Default = 0,
	Forced = 1,
	Optimized = 2,
}

internal enum DateTimeParse.DTT
{
	End = 0,
	NumEnd = 1,
	NumAmpm = 2,
	NumSpace = 3,
	NumDatesep = 4,
	NumTimesep = 5,
	MonthEnd = 6,
	MonthSpace = 7,
	MonthDatesep = 8,
	NumDatesuff = 9,
	NumTimesuff = 10,
	DayOfWeek = 11,
	YearSpace = 12,
	YearDateSep = 13,
	YearEnd = 14,
	TimeZone = 15,
	Era = 16,
	NumUTCTimeMark = 17,
	Unk = 18,
	NumLocalTimeMark = 19,
	Max = 20,
}

internal enum DateTimeParse.TM
{
	AM = 0,
	PM = 1,
}

internal enum DateTimeParse.DS
{
	BEGIN = 0,
	N = 1,
	NN = 2,
	D_Nd = 3,
	D_NN = 4,
	D_NNd = 5,
	D_M = 6,
	D_MN = 7,
	D_NM = 8,
	D_MNd = 9,
	D_NDS = 10,
	D_Y = 11,
	D_YN = 12,
	D_YNd = 13,
	D_YM = 14,
	D_YMd = 15,
	D_S = 16,
	T_S = 17,
	T_Nt = 18,
	T_NNt = 19,
	ERROR = 20,
	DX_NN = 21,
	DX_NNN = 22,
	DX_MN = 23,
	DX_NM = 24,
	DX_MNN = 25,
	DX_DS = 26,
	DX_DSN = 27,
	DX_NDS = 28,
	DX_NNDS = 29,
	DX_YNN = 30,
	DX_YMN = 31,
	DX_YN = 32,
	DX_YM = 33,
	TX_N = 34,
	TX_NN = 35,
	TX_NNN = 36,
	TX_TS = 37,
	DX_NNY = 38,
}

internal enum DTSubStringType
{
	Unknown = 0,
	Invalid = 1,
	Number = 2,
	End = 3,
	Other = 4,
}

internal enum ParseFailureKind
{
	None = 0,
	ArgumentNull = 1,
	Format = 2,
	FormatWithParameter = 3,
	FormatBadDateTimeCalendar = 4,
}

internal enum ParseFlags
{
	HaveYear = 1,
	HaveMonth = 2,
	HaveDay = 4,
	HaveHour = 8,
	HaveMinute = 16,
	HaveSecond = 32,
	HaveTime = 64,
	HaveDate = 128,
	TimeZoneUsed = 256,
	TimeZoneUtc = 512,
	ParsedMonthName = 1024,
	CaptureOffset = 2048,
	YearDefault = 4096,
	Rfc1123Pattern = 8192,
	UtcSortPattern = 16384,
}

internal enum TokenType
{
	NumberToken = 1,
	YearNumberToken = 2,
	Am = 3,
	Pm = 4,
	MonthToken = 5,
	EndOfString = 6,
	DayOfWeekToken = 7,
	TimeZoneToken = 8,
	EraToken = 9,
	DateWordToken = 10,
	UnknownToken = 11,
	HebrewNumber = 12,
	JapaneseEraToken = 13,
	TEraToken = 14,
	IgnorableSymbol = 15,
	SEP_Unk = 256,
	SEP_End = 512,
	SEP_Space = 768,
	SEP_Am = 1024,
	SEP_Pm = 1280,
	SEP_Date = 1536,
	SEP_Time = 1792,
	SEP_YearSuff = 2048,
	SEP_MonthSuff = 2304,
	SEP_DaySuff = 2560,
	SEP_HourSuff = 2816,
	SEP_MinuteSuff = 3072,
	SEP_SecondSuff = 3328,
	SEP_LocalTimeMark = 3584,
	SEP_DateOrOffset = 3840,
	RegularTokenMask = 255,
	SeparatorTokenMask = 65280,
}

private enum Guid.GuidStyles
{
	None = 0,
	AllowParenthesis = 1,
	AllowBraces = 2,
	AllowDashes = 4,
	AllowHexPrefix = 8,
	RequireParenthesis = 16,
	RequireBraces = 32,
	RequireDashes = 64,
	RequireHexPrefix = 128,
	HexFormat = 160,
	NumberFormat = 0,
	DigitFormat = 64,
	BraceFormat = 96,
	ParenthesisFormat = 80,
	Any = 15,
}

private enum Guid.GuidParseThrowStyle
{
	None = 0,
	All = 1,
	AllButOverflow = 2,
}

private enum Guid.ParseFailureKind
{
	None = 0,
	ArgumentNull = 1,
	Format = 2,
	FormatWithParameter = 3,
	NativeException = 4,
	FormatWithInnerException = 5,
}

public enum MidpointRounding
{
	ToEven = 0,
	AwayFromZero = 1,
}

internal enum TypeNameFormatFlags
{
	FormatBasic = 0,
	FormatNamespace = 1,
	FormatFullInst = 2,
	FormatAssembly = 4,
	FormatSignature = 8,
	FormatNoVersion = 16,
	FormatAngleBrackets = 64,
	FormatStubInfo = 128,
	FormatGenericParam = 256,
	FormatSerialization = 259,
}

internal enum TypeNameKind
{
	Name = 0,
	ToString = 1,
	SerializationName = 2,
	FullName = 3,
}

internal enum RuntimeType.MemberListType
{
	All = 0,
	CaseSensitive = 1,
	CaseInsensitive = 2,
	HandleToInfo = 3,
}

public enum StringSplitOptions
{
	None = 0,
	RemoveEmptyEntries = 1,
}

internal enum ExceptionArgument
{
	obj = 0,
	dictionary = 1,
	dictionaryCreationThreshold = 2,
	array = 3,
	info = 4,
	key = 5,
	collection = 6,
	list = 7,
	match = 8,
	converter = 9,
	queue = 10,
	stack = 11,
	capacity = 12,
	index = 13,
	startIndex = 14,
	value = 15,
	count = 16,
	arrayIndex = 17,
	name = 18,
	mode = 19,
	item = 20,
	options = 21,
	view = 22,
	sourceBytesToCopy = 23,
	start = 24,
	pointer = 25,
	ownedMemory = 26,
	text = 27,
}

internal enum ExceptionResource
{
	Argument_ImplementIComparable = 0,
	Argument_InvalidType = 1,
	Argument_InvalidArgumentForComparison = 2,
	Argument_InvalidRegistryKeyPermissionCheck = 3,
	ArgumentOutOfRange_NeedNonNegNum = 4,
	Arg_ArrayPlusOffTooSmall = 5,
	Arg_NonZeroLowerBound = 6,
	Arg_RankMultiDimNotSupported = 7,
	Arg_RegKeyDelHive = 8,
	Arg_RegKeyStrLenBug = 9,
	Arg_RegSetStrArrNull = 10,
	Arg_RegSetMismatchedKind = 11,
	Arg_RegSubKeyAbsent = 12,
	Arg_RegSubKeyValueAbsent = 13,
	Argument_AddingDuplicate = 14,
	Serialization_InvalidOnDeser = 15,
	Serialization_MissingKeys = 16,
	Serialization_NullKey = 17,
	Argument_InvalidArrayType = 18,
	NotSupported_KeyCollectionSet = 19,
	NotSupported_ValueCollectionSet = 20,
	ArgumentOutOfRange_SmallCapacity = 21,
	ArgumentOutOfRange_Index = 22,
	Argument_InvalidOffLen = 23,
	Argument_ItemNotExist = 24,
	ArgumentOutOfRange_Count = 25,
	ArgumentOutOfRange_InvalidThreshold = 26,
	ArgumentOutOfRange_ListInsert = 27,
	NotSupported_ReadOnlyCollection = 28,
	InvalidOperation_CannotRemoveFromStackOrQueue = 29,
	InvalidOperation_EmptyQueue = 30,
	InvalidOperation_EnumOpCantHappen = 31,
	InvalidOperation_EnumFailedVersion = 32,
	InvalidOperation_EmptyStack = 33,
	ArgumentOutOfRange_BiggerThanCollection = 34,
	InvalidOperation_EnumNotStarted = 35,
	InvalidOperation_EnumEnded = 36,
	NotSupported_SortedListNestedWrite = 37,
	InvalidOperation_NoValue = 38,
	InvalidOperation_RegRemoveSubKey = 39,
	Security_RegistryPermission = 40,
	UnauthorizedAccess_RegistryNoWrite = 41,
	ObjectDisposed_RegKeyClosed = 42,
	NotSupported_InComparableType = 43,
	Argument_InvalidRegistryOptionsCheck = 44,
	Argument_InvalidRegistryViewCheck = 45,
}

internal enum TimeZoneInfoOptions
{
	None = 1,
	NoThrowOnInvalidTime = 2,
}

internal enum Version.ParseFailureKind
{
	ArgumentNullException = 0,
	ArgumentException = 1,
	ArgumentOutOfRangeException = 2,
	FormatException = 3,
}

public enum Environment.SpecialFolder
{
	MyDocuments = 5,
	Desktop = 0,
	MyComputer = 17,
	Programs = 2,
	Personal = 5,
	Favorites = 6,
	Startup = 7,
	Recent = 8,
	SendTo = 9,
	StartMenu = 11,
	MyMusic = 13,
	DesktopDirectory = 16,
	Templates = 21,
	ApplicationData = 26,
	LocalApplicationData = 28,
	InternetCache = 32,
	Cookies = 33,
	History = 34,
	CommonApplicationData = 35,
	System = 37,
	ProgramFiles = 38,
	MyPictures = 39,
	CommonProgramFiles = 43,
	MyVideos = 14,
	NetworkShortcuts = 19,
	Fonts = 20,
	CommonStartMenu = 22,
	CommonPrograms = 23,
	CommonStartup = 24,
	CommonDesktopDirectory = 25,
	PrinterShortcuts = 27,
	Windows = 36,
	UserProfile = 40,
	SystemX86 = 41,
	ProgramFilesX86 = 42,
	CommonProgramFilesX86 = 44,
	CommonTemplates = 45,
	CommonDocuments = 46,
	CommonAdminTools = 47,
	AdminTools = 48,
	CommonMusic = 53,
	CommonPictures = 54,
	CommonVideos = 55,
	Resources = 56,
	LocalizedResources = 57,
	CommonOemLinks = 58,
	CDBurning = 59,
}

public enum Environment.SpecialFolderOption
{
	None = 0,
	DoNotVerify = 16384,
	Create = 32768,
}

internal enum SByteEnum
{
}

internal enum Int16Enum
{
}

internal enum Int32Enum
{
}

internal enum Int64Enum
{
}

internal enum ByteEnum
{
}

internal enum UInt16Enum
{
}

internal enum UInt32Enum
{
}

internal enum UInt64Enum
{
}

public enum PlatformID
{
	Win32S = 0,
	Win32Windows = 1,
	Win32NT = 2,
	WinCE = 3,
	Unix = 4,
	Xbox = 5,
	MacOSX = 6,
}

public enum StringComparison
{
	CurrentCulture = 0,
	CurrentCultureIgnoreCase = 1,
	InvariantCulture = 2,
	InvariantCultureIgnoreCase = 3,
	Ordinal = 4,
	OrdinalIgnoreCase = 5,
}

internal enum TermInfoNumbers
{
	Columns = 0,
	InitTabs = 1,
	Lines = 2,
	LinesOfMemory = 3,
	MagicCookieGlitch = 4,
	PaddingBaudRate = 5,
	VirtualTerminal = 6,
	WidthStatusLine = 7,
	NumLabels = 8,
	LabelHeight = 9,
	LabelWidth = 10,
	MaxAttributes = 11,
	MaximumWindows = 12,
	MaxColors = 13,
	MaxPairs = 14,
	NoColorVideo = 15,
	BufferCapacity = 16,
	DotVertSpacing = 17,
	DotHorzSpacing = 18,
	MaxMicroAddress = 19,
	MaxMicroJump = 20,
	MicroColSize = 21,
	MicroLineSize = 22,
	NumberOfPins = 23,
	OutputResChar = 24,
	OutputResLine = 25,
	OutputResHorzInch = 26,
	OutputResVertInch = 27,
	PrintRate = 28,
	WideCharSize = 29,
	Buttons = 30,
	BitImageEntwining = 31,
	BitImageType = 32,
	Last = 33,
}

internal enum TermInfoStrings
{
	BackTab = 0,
	Bell = 1,
	CarriageReturn = 2,
	ChangeScrollRegion = 3,
	ClearAllTabs = 4,
	ClearScreen = 5,
	ClrEol = 6,
	ClrEos = 7,
	ColumnAddress = 8,
	CommandCharacter = 9,
	CursorAddress = 10,
	CursorDown = 11,
	CursorHome = 12,
	CursorInvisible = 13,
	CursorLeft = 14,
	CursorMemAddress = 15,
	CursorNormal = 16,
	CursorRight = 17,
	CursorToLl = 18,
	CursorUp = 19,
	CursorVisible = 20,
	DeleteCharacter = 21,
	DeleteLine = 22,
	DisStatusLine = 23,
	DownHalfLine = 24,
	EnterAltCharsetMode = 25,
	EnterBlinkMode = 26,
	EnterBoldMode = 27,
	EnterCaMode = 28,
	EnterDeleteMode = 29,
	EnterDimMode = 30,
	EnterInsertMode = 31,
	EnterSecureMode = 32,
	EnterProtectedMode = 33,
	EnterReverseMode = 34,
	EnterStandoutMode = 35,
	EnterUnderlineMode = 36,
	EraseChars = 37,
	ExitAltCharsetMode = 38,
	ExitAttributeMode = 39,
	ExitCaMode = 40,
	ExitDeleteMode = 41,
	ExitInsertMode = 42,
	ExitStandoutMode = 43,
	ExitUnderlineMode = 44,
	FlashScreen = 45,
	FormFeed = 46,
	FromStatusLine = 47,
	Init1string = 48,
	Init2string = 49,
	Init3string = 50,
	InitFile = 51,
	InsertCharacter = 52,
	InsertLine = 53,
	InsertPadding = 54,
	KeyBackspace = 55,
	KeyCatab = 56,
	KeyClear = 57,
	KeyCtab = 58,
	KeyDc = 59,
	KeyDl = 60,
	KeyDown = 61,
	KeyEic = 62,
	KeyEol = 63,
	KeyEos = 64,
	KeyF0 = 65,
	KeyF1 = 66,
	KeyF10 = 67,
	KeyF2 = 68,
	KeyF3 = 69,
	KeyF4 = 70,
	KeyF5 = 71,
	KeyF6 = 72,
	KeyF7 = 73,
	KeyF8 = 74,
	KeyF9 = 75,
	KeyHome = 76,
	KeyIc = 77,
	KeyIl = 78,
	KeyLeft = 79,
	KeyLl = 80,
	KeyNpage = 81,
	KeyPpage = 82,
	KeyRight = 83,
	KeySf = 84,
	KeySr = 85,
	KeyStab = 86,
	KeyUp = 87,
	KeypadLocal = 88,
	KeypadXmit = 89,
	LabF0 = 90,
	LabF1 = 91,
	LabF10 = 92,
	LabF2 = 93,
	LabF3 = 94,
	LabF4 = 95,
	LabF5 = 96,
	LabF6 = 97,
	LabF7 = 98,
	LabF8 = 99,
	LabF9 = 100,
	MetaOff = 101,
	MetaOn = 102,
	Newline = 103,
	PadChar = 104,
	ParmDch = 105,
	ParmDeleteLine = 106,
	ParmDownCursor = 107,
	ParmIch = 108,
	ParmIndex = 109,
	ParmInsertLine = 110,
	ParmLeftCursor = 111,
	ParmRightCursor = 112,
	ParmRindex = 113,
	ParmUpCursor = 114,
	PkeyKey = 115,
	PkeyLocal = 116,
	PkeyXmit = 117,
	PrintScreen = 118,
	PrtrOff = 119,
	PrtrOn = 120,
	RepeatChar = 121,
	Reset1string = 122,
	Reset2string = 123,
	Reset3string = 124,
	ResetFile = 125,
	RestoreCursor = 126,
	RowAddress = 127,
	SaveCursor = 128,
	ScrollForward = 129,
	ScrollReverse = 130,
	SetAttributes = 131,
	SetTab = 132,
	SetWindow = 133,
	Tab = 134,
	ToStatusLine = 135,
	UnderlineChar = 136,
	UpHalfLine = 137,
	InitProg = 138,
	KeyA1 = 139,
	KeyA3 = 140,
	KeyB2 = 141,
	KeyC1 = 142,
	KeyC3 = 143,
	PrtrNon = 144,
	CharPadding = 145,
	AcsChars = 146,
	PlabNorm = 147,
	KeyBtab = 148,
	EnterXonMode = 149,
	ExitXonMode = 150,
	EnterAmMode = 151,
	ExitAmMode = 152,
	XonCharacter = 153,
	XoffCharacter = 154,
	EnaAcs = 155,
	LabelOn = 156,
	LabelOff = 157,
	KeyBeg = 158,
	KeyCancel = 159,
	KeyClose = 160,
	KeyCommand = 161,
	KeyCopy = 162,
	KeyCreate = 163,
	KeyEnd = 164,
	KeyEnter = 165,
	KeyExit = 166,
	KeyFind = 167,
	KeyHelp = 168,
	KeyMark = 169,
	KeyMessage = 170,
	KeyMove = 171,
	KeyNext = 172,
	KeyOpen = 173,
	KeyOptions = 174,
	KeyPrevious = 175,
	KeyPrint = 176,
	KeyRedo = 177,
	KeyReference = 178,
	KeyRefresh = 179,
	KeyReplace = 180,
	KeyRestart = 181,
	KeyResume = 182,
	KeySave = 183,
	KeySuspend = 184,
	KeyUndo = 185,
	KeySbeg = 186,
	KeyScancel = 187,
	KeyScommand = 188,
	KeyScopy = 189,
	KeyScreate = 190,
	KeySdc = 191,
	KeySdl = 192,
	KeySelect = 193,
	KeySend = 194,
	KeySeol = 195,
	KeySexit = 196,
	KeySfind = 197,
	KeyShelp = 198,
	KeyShome = 199,
	KeySic = 200,
	KeySleft = 201,
	KeySmessage = 202,
	KeySmove = 203,
	KeySnext = 204,
	KeySoptions = 205,
	KeySprevious = 206,
	KeySprint = 207,
	KeySredo = 208,
	KeySreplace = 209,
	KeySright = 210,
	KeySrsume = 211,
	KeySsave = 212,
	KeySsuspend = 213,
	KeySundo = 214,
	ReqForInput = 215,
	KeyF11 = 216,
	KeyF12 = 217,
	KeyF13 = 218,
	KeyF14 = 219,
	KeyF15 = 220,
	KeyF16 = 221,
	KeyF17 = 222,
	KeyF18 = 223,
	KeyF19 = 224,
	KeyF20 = 225,
	KeyF21 = 226,
	KeyF22 = 227,
	KeyF23 = 228,
	KeyF24 = 229,
	KeyF25 = 230,
	KeyF26 = 231,
	KeyF27 = 232,
	KeyF28 = 233,
	KeyF29 = 234,
	KeyF30 = 235,
	KeyF31 = 236,
	KeyF32 = 237,
	KeyF33 = 238,
	KeyF34 = 239,
	KeyF35 = 240,
	KeyF36 = 241,
	KeyF37 = 242,
	KeyF38 = 243,
	KeyF39 = 244,
	KeyF40 = 245,
	KeyF41 = 246,
	KeyF42 = 247,
	KeyF43 = 248,
	KeyF44 = 249,
	KeyF45 = 250,
	KeyF46 = 251,
	KeyF47 = 252,
	KeyF48 = 253,
	KeyF49 = 254,
	KeyF50 = 255,
	KeyF51 = 256,
	KeyF52 = 257,
	KeyF53 = 258,
	KeyF54 = 259,
	KeyF55 = 260,
	KeyF56 = 261,
	KeyF57 = 262,
	KeyF58 = 263,
	KeyF59 = 264,
	KeyF60 = 265,
	KeyF61 = 266,
	KeyF62 = 267,
	KeyF63 = 268,
	ClrBol = 269,
	ClearMargins = 270,
	SetLeftMargin = 271,
	SetRightMargin = 272,
	LabelFormat = 273,
	SetClock = 274,
	DisplayClock = 275,
	RemoveClock = 276,
	CreateWindow = 277,
	GotoWindow = 278,
	Hangup = 279,
	DialPhone = 280,
	QuickDial = 281,
	Tone = 282,
	Pulse = 283,
	FlashHook = 284,
	FixedPause = 285,
	WaitTone = 286,
	User0 = 287,
	User1 = 288,
	User2 = 289,
	User3 = 290,
	User4 = 291,
	User5 = 292,
	User6 = 293,
	User7 = 294,
	User8 = 295,
	User9 = 296,
	OrigPair = 297,
	OrigColors = 298,
	InitializeColor = 299,
	InitializePair = 300,
	SetColorPair = 301,
	SetForeground = 302,
	SetBackground = 303,
	ChangeCharPitch = 304,
	ChangeLinePitch = 305,
	ChangeResHorz = 306,
	ChangeResVert = 307,
	DefineChar = 308,
	EnterDoublewideMode = 309,
	EnterDraftQuality = 310,
	EnterItalicsMode = 311,
	EnterLeftwardMode = 312,
	EnterMicroMode = 313,
	EnterNearLetterQuality = 314,
	EnterNormalQuality = 315,
	EnterShadowMode = 316,
	EnterSubscriptMode = 317,
	EnterSuperscriptMode = 318,
	EnterUpwardMode = 319,
	ExitDoublewideMode = 320,
	ExitItalicsMode = 321,
	ExitLeftwardMode = 322,
	ExitMicroMode = 323,
	ExitShadowMode = 324,
	ExitSubscriptMode = 325,
	ExitSuperscriptMode = 326,
	ExitUpwardMode = 327,
	MicroColumnAddress = 328,
	MicroDown = 329,
	MicroLeft = 330,
	MicroRight = 331,
	MicroRowAddress = 332,
	MicroUp = 333,
	OrderOfPins = 334,
	ParmDownMicro = 335,
	ParmLeftMicro = 336,
	ParmRightMicro = 337,
	ParmUpMicro = 338,
	SelectCharSet = 339,
	SetBottomMargin = 340,
	SetBottomMarginParm = 341,
	SetLeftMarginParm = 342,
	SetRightMarginParm = 343,
	SetTopMargin = 344,
	SetTopMarginParm = 345,
	StartBitImage = 346,
	StartCharSetDef = 347,
	StopBitImage = 348,
	StopCharSetDef = 349,
	SubscriptCharacters = 350,
	SuperscriptCharacters = 351,
	TheseCauseCr = 352,
	ZeroMotion = 353,
	CharSetNames = 354,
	KeyMouse = 355,
	MouseInfo = 356,
	ReqMousePos = 357,
	GetMouse = 358,
	SetAForeground = 359,
	SetABackground = 360,
	PkeyPlab = 361,
	DeviceType = 362,
	CodeSetInit = 363,
	Set0DesSeq = 364,
	Set1DesSeq = 365,
	Set2DesSeq = 366,
	Set3DesSeq = 367,
	SetLrMargin = 368,
	SetTbMargin = 369,
	BitImageRepeat = 370,
	BitImageNewline = 371,
	BitImageCarriageReturn = 372,
	ColorNames = 373,
	DefineBitImageRegion = 374,
	EndBitImageRegion = 375,
	SetColorBand = 376,
	SetPageLength = 377,
	DisplayPcChar = 378,
	EnterPcCharsetMode = 379,
	ExitPcCharsetMode = 380,
	EnterScancodeMode = 381,
	ExitScancodeMode = 382,
	PcTermOptions = 383,
	ScancodeEscape = 384,
	AltScancodeEsc = 385,
	EnterHorizontalHlMode = 386,
	EnterLeftHlMode = 387,
	EnterLowHlMode = 388,
	EnterRightHlMode = 389,
	EnterTopHlMode = 390,
	EnterVerticalHlMode = 391,
	SetAAttributes = 392,
	SetPglenInch = 393,
	Last = 394,
}

public enum TypeCode
{
	Empty = 0,
	Object = 1,
	DBNull = 2,
	Boolean = 3,
	Char = 4,
	SByte = 5,
	Byte = 6,
	Int16 = 7,
	UInt16 = 8,
	Int32 = 9,
	UInt32 = 10,
	Int64 = 11,
	UInt64 = 12,
	Single = 13,
	Double = 14,
	Decimal = 15,
	DateTime = 16,
	String = 18,
}

internal enum TypeSpec.DisplayNameFormat
{
	Default = 0,
	WANT_ASSEMBLY = 1,
	NO_MODIFIERS = 2,
}

internal enum Handles
{
}

public enum AssemblyHashAlgorithm
{
	None = 0,
	MD5 = 32771,
	SHA1 = 32772,
	SHA256 = 32780,
	SHA384 = 32781,
	SHA512 = 32782,
}

public enum AssemblyVersionCompatibility
{
	SameMachine = 1,
	SameProcess = 2,
	SameDomain = 3,
}

internal enum NormalizationCheck
{
	Yes = 0,
	No = 1,
	Maybe = 2,
}

public enum NormalizationForm
{
	FormC = 1,
	FormD = 2,
	FormKC = 5,
	FormKD = 6,
}

internal enum ResourceTypeCode
{
	Null = 0,
	String = 1,
	Boolean = 2,
	Char = 3,
	Byte = 4,
	SByte = 5,
	Int16 = 6,
	UInt16 = 7,
	Int32 = 8,
	UInt32 = 9,
	Int64 = 10,
	UInt64 = 11,
	Single = 12,
	Double = 13,
	Decimal = 14,
	DateTime = 15,
	TimeSpan = 16,
	LastPrimitive = 16,
	ByteArray = 32,
	Stream = 33,
	StartOfUserTypes = 64,
}

public enum UltimateResourceFallbackLocation
{
	MainAssembly = 0,
	Satellite = 1,
}

public enum AssemblyNameFlags
{
	None = 0,
	PublicKey = 1,
	EnableJITcompileOptimizer = 16384,
	EnableJITcompileTracking = 32768,
	Retargetable = 256,
}

public enum AssemblyContentType
{
	Default = 0,
	WindowsRuntime = 1,
}

public enum ProcessorArchitecture
{
	None = 0,
	MSIL = 1,
	X86 = 2,
	IA64 = 3,
	Amd64 = 4,
	Arm = 5,
}

public enum BindingFlags
{
	Default = 0,
	IgnoreCase = 1,
	DeclaredOnly = 2,
	Instance = 4,
	Static = 8,
	Public = 16,
	NonPublic = 32,
	FlattenHierarchy = 64,
	InvokeMethod = 256,
	CreateInstance = 512,
	GetField = 1024,
	SetField = 2048,
	GetProperty = 4096,
	SetProperty = 8192,
	PutDispProperty = 16384,
	PutRefDispProperty = 32768,
	ExactBinding = 65536,
	SuppressChangeType = 131072,
	OptionalParamBinding = 262144,
	IgnoreReturn = 16777216,
}

public enum CallingConventions
{
	Standard = 1,
	VarArgs = 2,
	Any = 3,
	HasThis = 32,
	ExplicitThis = 64,
}

public enum EventAttributes
{
	None = 0,
	SpecialName = 512,
	ReservedMask = 1024,
	RTSpecialName = 1024,
}

public enum FieldAttributes
{
	FieldAccessMask = 7,
	PrivateScope = 0,
	Private = 1,
	FamANDAssem = 2,
	Assembly = 3,
	Family = 4,
	FamORAssem = 5,
	Public = 6,
	Static = 16,
	InitOnly = 32,
	Literal = 64,
	NotSerialized = 128,
	SpecialName = 512,
	PinvokeImpl = 8192,
	ReservedMask = 38144,
	RTSpecialName = 1024,
	HasFieldMarshal = 4096,
	HasDefault = 32768,
	HasFieldRVA = 256,
}

public enum GenericParameterAttributes
{
	None = 0,
	VarianceMask = 3,
	Covariant = 1,
	Contravariant = 2,
	SpecialConstraintMask = 28,
	ReferenceTypeConstraint = 4,
	NotNullableValueTypeConstraint = 8,
	DefaultConstructorConstraint = 16,
}

public enum ResourceLocation
{
	Embedded = 1,
	ContainedInAnotherAssembly = 2,
	ContainedInManifestFile = 4,
}

internal enum PInvokeAttributes
{
	NoMangle = 1,
	CharSetMask = 6,
	CharSetNotSpec = 0,
	CharSetAnsi = 2,
	CharSetUnicode = 4,
	CharSetAuto = 6,
	BestFitUseAssem = 0,
	BestFitEnabled = 16,
	BestFitDisabled = 32,
	BestFitMask = 48,
	ThrowOnUnmappableCharUseAssem = 0,
	ThrowOnUnmappableCharEnabled = 4096,
	ThrowOnUnmappableCharDisabled = 8192,
	ThrowOnUnmappableCharMask = 12288,
	SupportsLastError = 64,
	CallConvMask = 1792,
	CallConvWinapi = 256,
	CallConvCdecl = 512,
	CallConvStdcall = 768,
	CallConvThiscall = 1024,
	CallConvFastcall = 1280,
	MaxValue = 65535,
}

public enum MemberTypes
{
	Constructor = 1,
	Event = 2,
	Field = 4,
	Method = 8,
	Property = 16,
	TypeInfo = 32,
	Custom = 64,
	NestedType = 128,
	All = 191,
}

public enum MethodAttributes
{
	MemberAccessMask = 7,
	PrivateScope = 0,
	Private = 1,
	FamANDAssem = 2,
	Assembly = 3,
	Family = 4,
	FamORAssem = 5,
	Public = 6,
	Static = 16,
	Final = 32,
	Virtual = 64,
	HideBySig = 128,
	CheckAccessOnOverride = 512,
	VtableLayoutMask = 256,
	ReuseSlot = 0,
	NewSlot = 256,
	Abstract = 1024,
	SpecialName = 2048,
	PinvokeImpl = 8192,
	UnmanagedExport = 8,
	RTSpecialName = 4096,
	ReservedMask = 53248,
	HasSecurity = 16384,
	RequireSecObject = 32768,
}

public enum ExceptionHandlingClauseOptions
{
	Clause = 0,
	Filter = 1,
	Finally = 2,
	Fault = 4,
}

public enum MethodImplAttributes
{
	CodeTypeMask = 3,
	IL = 0,
	Native = 1,
	OPTIL = 2,
	Runtime = 3,
	ManagedMask = 4,
	Unmanaged = 4,
	Managed = 0,
	ForwardRef = 16,
	PreserveSig = 128,
	InternalCall = 4096,
	Synchronized = 32,
	NoInlining = 8,
	AggressiveInlining = 256,
	NoOptimization = 64,
	MaxMethodImplVal = 65535,
}

public enum ParameterAttributes
{
	None = 0,
	In = 1,
	Out = 2,
	Lcid = 4,
	Retval = 8,
	Optional = 16,
	ReservedMask = 61440,
	HasDefault = 4096,
	HasFieldMarshal = 8192,
	Reserved3 = 16384,
	Reserved4 = 32768,
}

public enum PropertyAttributes
{
	None = 0,
	SpecialName = 512,
	ReservedMask = 62464,
	RTSpecialName = 1024,
	HasDefault = 4096,
	Reserved2 = 8192,
	Reserved3 = 16384,
	Reserved4 = 32768,
}

public enum TypeAttributes
{
	VisibilityMask = 7,
	NotPublic = 0,
	Public = 1,
	NestedPublic = 2,
	NestedPrivate = 3,
	NestedFamily = 4,
	NestedAssembly = 5,
	NestedFamANDAssem = 6,
	NestedFamORAssem = 7,
	LayoutMask = 24,
	AutoLayout = 0,
	SequentialLayout = 8,
	ExplicitLayout = 16,
	ClassSemanticsMask = 32,
	Class = 0,
	Interface = 32,
	Abstract = 128,
	Sealed = 256,
	SpecialName = 1024,
	Import = 4096,
	Serializable = 8192,
	WindowsRuntime = 16384,
	StringFormatMask = 196608,
	AnsiClass = 0,
	UnicodeClass = 65536,
	AutoClass = 131072,
	CustomFormatClass = 196608,
	CustomFormatMask = 12582912,
	BeforeFieldInit = 1048576,
	ReservedMask = 264192,
	RTSpecialName = 2048,
	HasSecurity = 262144,
}

internal enum PInfo
{
	Attributes = 1,
	GetMethod = 2,
	SetMethod = 4,
	ReflectedType = 8,
	DeclaringType = 16,
	Name = 32,
}

public enum FileAccess
{
	Read = 1,
	Write = 2,
	ReadWrite = 3,
}

public enum FileAttributes
{
	Archive = 32,
	Compressed = 2048,
	Device = 64,
	Directory = 16,
	Encrypted = 16384,
	Hidden = 2,
	Normal = 128,
	NotContentIndexed = 8192,
	Offline = 4096,
	ReadOnly = 1,
	ReparsePoint = 1024,
	SparseFile = 512,
	System = 4,
	Temporary = 256,
	IntegrityStream = 32768,
	NoScrubData = 131072,
}

public enum FileMode
{
	CreateNew = 1,
	Create = 2,
	Open = 3,
	OpenOrCreate = 4,
	Truncate = 5,
	Append = 6,
}

public enum FileOptions
{
	None = 0,
	Encrypted = 16384,
	DeleteOnClose = 67108864,
	SequentialScan = 134217728,
	RandomAccess = 268435456,
	Asynchronous = 1073741824,
}

public enum FileShare
{
	None = 0,
	Read = 1,
	Write = 2,
	ReadWrite = 3,
	Delete = 4,
	Inheritable = 16,
}

internal enum MonoFileType
{
	Unknown = 0,
	Disk = 1,
	Char = 2,
	Pipe = 3,
	Remote = 32768,
}

internal enum MonoIOError
{
	ERROR_SUCCESS = 0,
	ERROR_FILE_NOT_FOUND = 2,
	ERROR_PATH_NOT_FOUND = 3,
	ERROR_TOO_MANY_OPEN_FILES = 4,
	ERROR_ACCESS_DENIED = 5,
	ERROR_INVALID_HANDLE = 6,
	ERROR_INVALID_DRIVE = 15,
	ERROR_NOT_SAME_DEVICE = 17,
	ERROR_NO_MORE_FILES = 18,
	ERROR_NOT_READY = 21,
	ERROR_WRITE_FAULT = 29,
	ERROR_READ_FAULT = 30,
	ERROR_GEN_FAILURE = 31,
	ERROR_SHARING_VIOLATION = 32,
	ERROR_LOCK_VIOLATION = 33,
	ERROR_HANDLE_DISK_FULL = 39,
	ERROR_FILE_EXISTS = 80,
	ERROR_CANNOT_MAKE = 82,
	ERROR_INVALID_PARAMETER = 87,
	ERROR_BROKEN_PIPE = 109,
	ERROR_INVALID_NAME = 123,
	ERROR_DIR_NOT_EMPTY = 145,
	ERROR_ALREADY_EXISTS = 183,
	ERROR_FILENAME_EXCED_RANGE = 206,
	ERROR_DIRECTORY = 267,
	ERROR_ENCRYPTION_FAILED = 6000,
}

public enum SearchOption
{
	TopDirectoryOnly = 0,
	AllDirectories = 1,
}

public enum SeekOrigin
{
	Begin = 0,
	Current = 1,
	End = 2,
}

public enum CompareOptions
{
	None = 0,
	IgnoreCase = 1,
	IgnoreNonSpace = 2,
	IgnoreSymbols = 4,
	IgnoreKanaType = 8,
	IgnoreWidth = 16,
	OrdinalIgnoreCase = 268435456,
	StringSort = 536870912,
	Ordinal = 1073741824,
}

public enum CultureTypes
{
	NeutralCultures = 1,
	SpecificCultures = 2,
	InstalledWin32Cultures = 4,
	AllCultures = 7,
	UserCustomCulture = 8,
	ReplacementCultures = 16,
	WindowsOnlyCultures = 32,
	FrameworkCultures = 64,
}

internal enum MonthNameStyles
{
	Regular = 0,
	Genitive = 1,
	LeapYear = 2,
}

internal enum DateTimeFormatFlags
{
	None = 0,
	UseGenitiveMonth = 1,
	UseLeapYearMonth = 2,
	UseSpacesInMonthNames = 4,
	UseHebrewRule = 8,
	UseSpacesInDayNames = 16,
	UseDigitPrefixInTokens = 32,
}

internal enum FORMATFLAGS
{
	None = 0,
	UseGenitiveMonth = 1,
	UseLeapYearMonth = 2,
	UseSpacesInMonthNames = 4,
	UseHebrewParsing = 8,
	UseSpacesInDayNames = 16,
	UseDigitPrefixInTokens = 32,
}

internal enum CalendarId
{
	GREGORIAN = 1,
	GREGORIAN_US = 2,
	JAPAN = 3,
	TAIWAN = 4,
	KOREA = 5,
	HIJRI = 6,
	THAI = 7,
	HEBREW = 8,
	GREGORIAN_ME_FRENCH = 9,
	GREGORIAN_ARABIC = 10,
	GREGORIAN_XLIT_ENGLISH = 11,
	GREGORIAN_XLIT_FRENCH = 12,
	JULIAN = 13,
	JAPANESELUNISOLAR = 14,
	CHINESELUNISOLAR = 15,
	SAKA = 16,
	LUNAR_ETO_CHN = 17,
	LUNAR_ETO_KOR = 18,
	LUNAR_ETO_ROKUYOU = 19,
	KOREANLUNISOLAR = 20,
	TAIWANLUNISOLAR = 21,
	PERSIAN = 22,
	UMALQURA = 23,
	LAST_CALENDAR = 23,
}

private enum DateTimeFormatInfoScanner.FoundDatePattern
{
	None = 0,
	FoundYearPatternFlag = 1,
	FoundMonthPatternFlag = 2,
	FoundDayPatternFlag = 4,
	FoundYMDPatternFlag = 7,
}

public enum DateTimeStyles
{
	None = 0,
	AllowLeadingWhite = 1,
	AllowTrailingWhite = 2,
	AllowInnerWhite = 4,
	AllowWhiteSpaces = 7,
	NoCurrentDateDefault = 8,
	AdjustToUniversal = 16,
	AssumeLocal = 32,
	AssumeUniversal = 64,
	RoundtripKind = 128,
}

public enum GregorianCalendarTypes
{
	Localized = 1,
	USEnglish = 2,
	MiddleEastFrench = 9,
	Arabic = 10,
	TransliteratedEnglish = 11,
	TransliteratedFrench = 12,
}

internal enum HebrewNumberParsingState
{
	InvalidHebrewNumber = 0,
	NotHebrewDigit = 1,
	FoundEndOfHebrewNumber = 2,
	ContinueParsing = 3,
}

private enum HebrewNumber.HebrewToken
{
	Digit400 = 0,
	Digit200_300 = 1,
	Digit100 = 2,
	Digit10 = 3,
	Digit1 = 4,
	Digit6_7 = 5,
	Digit7 = 6,
	Digit9 = 7,
	SingleQuote = 8,
	DoubleQuote = 9,
}

internal enum HebrewNumber.HS
{
	Start = 0,
	S400 = 1,
	S400_400 = 2,
	S400_X00 = 3,
	S400_X0 = 4,
	X00_DQ = 5,
	S400_X00_X0 = 6,
	X0_DQ = 7,
	X = 8,
	X0 = 9,
	X00 = 10,
	S400_DQ = 11,
	S400_400_DQ = 12,
	S400_400_100 = 13,
	S9 = 14,
	X00_S9 = 15,
	S9_DQ = 16,
	END = 100,
}

public enum NumberStyles
{
	None = 0,
	AllowLeadingWhite = 1,
	AllowTrailingWhite = 2,
	AllowLeadingSign = 4,
	AllowTrailingSign = 8,
	AllowParentheses = 16,
	AllowDecimalPoint = 32,
	AllowThousands = 64,
	AllowExponent = 128,
	AllowCurrencySymbol = 256,
	AllowHexSpecifier = 512,
	Integer = 7,
	HexNumber = 515,
	Number = 111,
	Float = 167,
	Currency = 383,
	Any = 511,
}

internal enum TimeSpanFormat.Pattern
{
	None = 0,
	Minimum = 1,
	Full = 2,
}

private enum TimeSpanParse.TimeSpanThrowStyle
{
	None = 0,
	All = 1,
}

private enum TimeSpanParse.ParseFailureKind
{
	None = 0,
	ArgumentNull = 1,
	Format = 2,
	FormatWithParameter = 3,
	Overflow = 4,
}

private enum TimeSpanParse.TimeSpanStandardStyles
{
	None = 0,
	Invariant = 1,
	Localized = 2,
	RequireFull = 4,
	Any = 3,
}

private enum TimeSpanParse.TTT
{
	None = 0,
	End = 1,
	Num = 2,
	Sep = 3,
	NumOverflow = 4,
}

public enum UnicodeCategory
{
	UppercaseLetter = 0,
	LowercaseLetter = 1,
	TitlecaseLetter = 2,
	ModifierLetter = 3,
	OtherLetter = 4,
	NonSpacingMark = 5,
	SpacingCombiningMark = 6,
	EnclosingMark = 7,
	DecimalDigitNumber = 8,
	LetterNumber = 9,
	OtherNumber = 10,
	SpaceSeparator = 11,
	LineSeparator = 12,
	ParagraphSeparator = 13,
	Control = 14,
	Format = 15,
	Surrogate = 16,
	PrivateUse = 17,
	ConnectorPunctuation = 18,
	DashPunctuation = 19,
	OpenPunctuation = 20,
	ClosePunctuation = 21,
	InitialQuotePunctuation = 22,
	FinalQuotePunctuation = 23,
	OtherPunctuation = 24,
	MathSymbol = 25,
	CurrencySymbol = 26,
	ModifierSymbol = 27,
	OtherSymbol = 28,
	OtherNotAssigned = 29,
}

public enum EventResetMode
{
	AutoReset = 0,
	ManualReset = 1,
}

private enum ExecutionContext.Flags
{
	None = 0,
	IsNewCapture = 1,
	IsFlowSuppressed = 2,
	IsPreAllocatedDefault = 4,
}

internal enum ExecutionContext.CaptureOptions
{
	None = 0,
	IgnoreSyncCtx = 1,
	OptimizeDefaultCase = 2,
}

internal enum SynchronizationContextProperties
{
	None = 0,
	RequireWaitNotification = 1,
}

internal enum StackCrawlMark
{
	LookForMe = 0,
	LookForMyCaller = 1,
	LookForMyCallersCaller = 2,
	LookForThread = 3,
}

public enum ThreadState
{
	Running = 0,
	StopRequested = 1,
	SuspendRequested = 2,
	Background = 4,
	Unstarted = 8,
	Stopped = 16,
	WaitSleepJoin = 32,
	Suspended = 64,
	AbortRequested = 128,
	Aborted = 256,
}

internal enum CausalityTraceLevel
{
	Required = 0,
	Important = 1,
	Verbose = 2,
}

internal enum AsyncCausalityStatus
{
	Started = 0,
	Completed = 1,
	Canceled = 2,
	Error = 3,
}

internal enum CausalityRelation
{
	AssignDelegate = 0,
	Join = 1,
	Choice = 2,
	Cancel = 3,
	Error = 4,
}

internal enum CausalitySynchronousWork
{
	CompletionNotification = 0,
	ProgressNotification = 1,
	Execution = 2,
}

public enum TaskStatus
{
	Created = 0,
	WaitingForActivation = 1,
	WaitingToRun = 2,
	Running = 3,
	WaitingForChildrenToComplete = 4,
	RanToCompletion = 5,
	Canceled = 6,
	Faulted = 7,
}

public enum TaskCreationOptions
{
	None = 0,
	PreferFairness = 1,
	LongRunning = 2,
	AttachedToParent = 4,
	DenyChildAttach = 8,
	HideScheduler = 16,
	RunContinuationsAsynchronously = 64,
}

internal enum InternalTaskOptions
{
	None = 0,
	InternalOptionsMask = 65280,
	ChildReplica = 256,
	ContinuationTask = 512,
	PromiseTask = 1024,
	SelfReplicating = 2048,
	LazyCancellation = 4096,
	QueuedByRuntime = 8192,
	DoNotDispose = 16384,
}

public enum TaskContinuationOptions
{
	None = 0,
	PreferFairness = 1,
	LongRunning = 2,
	AttachedToParent = 4,
	DenyChildAttach = 8,
	HideScheduler = 16,
	LazyCancellation = 32,
	RunContinuationsAsynchronously = 64,
	NotOnRanToCompletion = 65536,
	NotOnFaulted = 131072,
	NotOnCanceled = 262144,
	OnlyOnRanToCompletion = 393216,
	OnlyOnFaulted = 327680,
	OnlyOnCanceled = 196608,
	ExecuteSynchronously = 524288,
}

public enum PartialTrustVisibilityLevel
{
	VisibleToAllHosts = 0,
	NotVisibleByDefault = 1,
}

public enum SecurityCriticalScope
{
	Explicit = 0,
	Everything = 1,
}

public enum SecurityRuleSet
{
	None = 0,
	Level1 = 1,
	Level2 = 2,
}

public enum SecurityContextSource
{
	CurrentAppDomain = 0,
	CurrentAssembly = 1,
}

internal enum SecurityContextDisableFlow
{
	Nothing = 0,
	WI = 1,
	All = 16383,
}

public enum HostSecurityManagerOptions
{
	None = 0,
	HostAppDomainEvidence = 1,
	HostPolicyLevel = 2,
	HostAssemblyEvidence = 4,
	HostDetermineApplicationTrust = 8,
	HostResolvePolicy = 16,
	AllFlags = 31,
}

public enum PolicyLevelType
{
	User = 0,
	Machine = 1,
	Enterprise = 2,
	AppDomain = 3,
}

internal enum SecurityElementType
{
	Regular = 0,
	Format = 1,
	Comment = 2,
}

public enum SecurityZone
{
	MyComputer = 0,
	Intranet = 1,
	Trusted = 2,
	Internet = 3,
	Untrusted = 4,
}

public enum PolicyStatementAttribute
{
	Nothing = 0,
	Exclusive = 1,
	LevelFinal = 2,
	All = 3,
}

public enum HostProtectionResource
{
	None = 0,
	Synchronization = 1,
	SharedState = 2,
	ExternalProcessMgmt = 4,
	SelfAffectingProcessMgmt = 8,
	ExternalThreading = 16,
	SelfAffectingThreading = 32,
	SecurityInfrastructure = 64,
	UI = 128,
	MayLeakOnAbort = 256,
	All = 511,
}

public enum PermissionState
{
	Unrestricted = 1,
	None = 0,
}

public enum ReflectionPermissionFlag
{
	NoFlags = 0,
	TypeInformation = 1,
	MemberAccess = 2,
	ReflectionEmit = 4,
	AllFlags = 7,
	RestrictedMemberAccess = 8,
}

public enum SecurityAction
{
	Demand = 2,
	Assert = 3,
	Deny = 4,
	PermitOnly = 5,
	LinkDemand = 6,
	InheritanceDemand = 7,
	RequestMinimum = 8,
	RequestOptional = 9,
	RequestRefuse = 10,
}

private enum Tokenizer.TokenSource
{
	UnicodeByteArray = 0,
	UTF8ByteArray = 1,
	ASCIIByteArray = 2,
	CharArray = 3,
	String = 4,
	NestedStrings = 5,
	Other = 6,
}

public enum TokenImpersonationLevel
{
	Anonymous = 1,
	Delegation = 4,
	Identification = 2,
	Impersonation = 3,
	None = 0,
}

public enum WindowsAccountType
{
	Normal = 0,
	Guest = 1,
	System = 2,
	Anonymous = 3,
}

public enum RSAEncryptionPaddingMode
{
	Pkcs1 = 0,
	Oaep = 1,
}

public enum RSASignaturePaddingMode
{
	Pkcs1 = 0,
	Pss = 1,
}

public enum FromBase64TransformMode
{
	IgnoreWhiteSpaces = 0,
	DoNotIgnoreWhiteSpaces = 1,
}

public enum CipherMode
{
	CBC = 1,
	ECB = 2,
	OFB = 3,
	CFB = 4,
	CTS = 5,
}

public enum PaddingMode
{
	None = 1,
	PKCS7 = 2,
	Zeros = 3,
	ANSIX923 = 4,
	ISO10126 = 5,
}

public enum CspProviderFlags
{
	NoFlags = 0,
	UseMachineKeyStore = 1,
	UseDefaultKeyContainer = 2,
	UseNonExportableKey = 4,
	UseExistingKey = 8,
	UseArchivableKey = 16,
	UseUserProtectedKey = 32,
	NoPrompt = 64,
	CreateEphemeralKey = 128,
}

public enum CryptoStreamMode
{
	Read = 0,
	Write = 1,
}

internal enum RijndaelManagedTransformMode
{
	Encrypt = 0,
	Decrypt = 1,
}

internal enum CspAlgorithmType
{
	Rsa = 0,
	Dss = 1,
}

public enum KeyNumber
{
	Exchange = 1,
	Signature = 2,
}

public enum X509ContentType
{
	Unknown = 0,
	Cert = 1,
	SerializedCert = 2,
	Pfx = 3,
	Pkcs12 = 3,
	SerializedStore = 4,
	Pkcs7 = 5,
	Authenticode = 6,
}

public enum X509KeyStorageFlags
{
	DefaultKeySet = 0,
	UserKeySet = 1,
	MachineKeySet = 2,
	Exportable = 4,
	UserProtected = 8,
	PersistKeySet = 16,
	EphemeralKeySet = 32,
}

internal enum OidGroup
{
	AllGroups = 0,
	HashAlgorithm = 1,
	EncryptionAlgorithm = 2,
	PublicKeyAlgorithm = 3,
	SignatureAlgorithm = 4,
	Attribute = 5,
	ExtensionOrAttribute = 6,
	EnhancedKeyUsage = 7,
	Policy = 8,
	Template = 9,
	KeyDerivationFunction = 10,
}

internal enum OidKeyType
{
	Oid = 1,
	Name = 2,
	AlgorithmID = 3,
	SignatureID = 4,
	CngAlgorithmID = 5,
	CngSignatureID = 6,
}

public enum StreamingContextStates
{
	CrossProcess = 1,
	CrossMachine = 2,
	File = 4,
	Persistence = 8,
	Remoting = 16,
	Other = 32,
	Clone = 64,
	CrossAppDomain = 128,
	All = 255,
}

public enum FormatterTypeStyle
{
	TypesWhenNeeded = 0,
	TypesAlways = 1,
	XsdString = 2,
}

public enum FormatterAssemblyStyle
{
	Simple = 0,
	Full = 1,
}

public enum TypeFilterLevel
{
	Low = 2,
	Full = 3,
}

internal enum BinaryHeaderEnum
{
	SerializedStreamHeader = 0,
	Object = 1,
	ObjectWithMap = 2,
	ObjectWithMapAssemId = 3,
	ObjectWithMapTyped = 4,
	ObjectWithMapTypedAssemId = 5,
	ObjectString = 6,
	Array = 7,
	MemberPrimitiveTyped = 8,
	MemberReference = 9,
	ObjectNull = 10,
	MessageEnd = 11,
	Assembly = 12,
	ObjectNullMultiple256 = 13,
	ObjectNullMultiple = 14,
	ArraySinglePrimitive = 15,
	ArraySingleObject = 16,
	ArraySingleString = 17,
	CrossAppDomainMap = 18,
	CrossAppDomainString = 19,
	CrossAppDomainAssembly = 20,
	MethodCall = 21,
	MethodReturn = 22,
}

internal enum BinaryTypeEnum
{
	Primitive = 0,
	String = 1,
	Object = 2,
	ObjectUrt = 3,
	ObjectUser = 4,
	ObjectArray = 5,
	StringArray = 6,
	PrimitiveArray = 7,
}

internal enum BinaryArrayTypeEnum
{
	Single = 0,
	Jagged = 1,
	Rectangular = 2,
	SingleOffset = 3,
	JaggedOffset = 4,
	RectangularOffset = 5,
}

internal enum InternalSerializerTypeE
{
	Soap = 1,
	Binary = 2,
}

internal enum InternalParseTypeE
{
	Empty = 0,
	SerializedStreamHeader = 1,
	Object = 2,
	Member = 3,
	ObjectEnd = 4,
	MemberEnd = 5,
	Headers = 6,
	HeadersEnd = 7,
	SerializedStreamHeaderEnd = 8,
	Envelope = 9,
	EnvelopeEnd = 10,
	Body = 11,
	BodyEnd = 12,
}

internal enum InternalObjectTypeE
{
	Empty = 0,
	Object = 1,
	Array = 2,
}

internal enum InternalObjectPositionE
{
	Empty = 0,
	Top = 1,
	Child = 2,
	Headers = 3,
}

internal enum InternalArrayTypeE
{
	Empty = 0,
	Single = 1,
	Jagged = 2,
	Rectangular = 3,
	Base64 = 4,
}

internal enum InternalMemberTypeE
{
	Empty = 0,
	Header = 1,
	Field = 2,
	Item = 3,
}

internal enum InternalMemberValueE
{
	Empty = 0,
	InlineValue = 1,
	Nested = 2,
	Reference = 3,
	Null = 4,
}

internal enum InternalPrimitiveTypeE
{
	Invalid = 0,
	Boolean = 1,
	Byte = 2,
	Char = 3,
	Currency = 4,
	Decimal = 5,
	Double = 6,
	Int16 = 7,
	Int32 = 8,
	Int64 = 9,
	SByte = 10,
	Single = 11,
	TimeSpan = 12,
	DateTime = 13,
	UInt16 = 14,
	UInt32 = 15,
	UInt64 = 16,
	Null = 17,
	String = 18,
}

internal enum MessageEnum
{
	NoArgs = 1,
	ArgsInline = 2,
	ArgsIsArray = 4,
	ArgsInArray = 8,
	NoContext = 16,
	ContextInline = 32,
	ContextInArray = 64,
	MethodSignatureInArray = 128,
	PropertyInArray = 256,
	NoReturnValue = 512,
	ReturnValueVoid = 1024,
	ReturnValueInline = 2048,
	ReturnValueInArray = 4096,
	ExceptionInArray = 8192,
	GenericMethod = 32768,
}

internal enum ValueFixupEnum
{
	Empty = 0,
	Array = 1,
	Header = 2,
	Member = 3,
}

public enum WellKnownObjectMode
{
	Singleton = 1,
	SingleCall = 2,
}

public enum LeaseState
{
	Null = 0,
	Initial = 1,
	Active = 2,
	Renewing = 3,
	Expired = 4,
}

internal enum ArgInfoType
{
	In = 0,
	Out = 1,
}

internal enum CallType
{
	Sync = 0,
	BeginInvoke = 1,
	EndInvoke = 2,
	OneWay = 3,
}

public enum Consistency
{
	MayCorruptProcess = 0,
	MayCorruptAppDomain = 1,
	MayCorruptInstance = 2,
	WillNotCorruptState = 3,
}

public enum Cer
{
	None = 0,
	MayFail = 1,
	Success = 2,
}

public enum LoadHint
{
	Default = 0,
	Always = 1,
	Sometimes = 2,
}

public enum CompilationRelaxations
{
	NoStringInterning = 8,
}

public enum ComInterfaceType
{
	InterfaceIsDual = 0,
	InterfaceIsIUnknown = 1,
	InterfaceIsIDispatch = 2,
	InterfaceIsIInspectable = 3,
}

public enum ClassInterfaceType
{
	None = 0,
	AutoDispatch = 1,
	AutoDual = 2,
}

public enum VarEnum
{
	VT_EMPTY = 0,
	VT_NULL = 1,
	VT_I2 = 2,
	VT_I4 = 3,
	VT_R4 = 4,
	VT_R8 = 5,
	VT_CY = 6,
	VT_DATE = 7,
	VT_BSTR = 8,
	VT_DISPATCH = 9,
	VT_ERROR = 10,
	VT_BOOL = 11,
	VT_VARIANT = 12,
	VT_UNKNOWN = 13,
	VT_DECIMAL = 14,
	VT_I1 = 16,
	VT_UI1 = 17,
	VT_UI2 = 18,
	VT_UI4 = 19,
	VT_I8 = 20,
	VT_UI8 = 21,
	VT_INT = 22,
	VT_UINT = 23,
	VT_VOID = 24,
	VT_HRESULT = 25,
	VT_PTR = 26,
	VT_SAFEARRAY = 27,
	VT_CARRAY = 28,
	VT_USERDEFINED = 29,
	VT_LPSTR = 30,
	VT_LPWSTR = 31,
	VT_RECORD = 36,
	VT_FILETIME = 64,
	VT_BLOB = 65,
	VT_STREAM = 66,
	VT_STORAGE = 67,
	VT_STREAMED_OBJECT = 68,
	VT_STORED_OBJECT = 69,
	VT_BLOB_OBJECT = 70,
	VT_CF = 71,
	VT_CLSID = 72,
	VT_VECTOR = 4096,
	VT_ARRAY = 8192,
	VT_BYREF = 16384,
}

public enum UnmanagedType
{
	Bool = 2,
	I1 = 3,
	U1 = 4,
	I2 = 5,
	U2 = 6,
	I4 = 7,
	U4 = 8,
	I8 = 9,
	U8 = 10,
	R4 = 11,
	R8 = 12,
	Currency = 15,
	BStr = 19,
	LPStr = 20,
	LPWStr = 21,
	LPTStr = 22,
	ByValTStr = 23,
	IUnknown = 25,
	IDispatch = 26,
	Struct = 27,
	Interface = 28,
	SafeArray = 29,
	ByValArray = 30,
	SysInt = 31,
	SysUInt = 32,
	VBByRefStr = 34,
	AnsiBStr = 35,
	TBStr = 36,
	VariantBool = 37,
	FunctionPtr = 38,
	AsAny = 40,
	LPArray = 42,
	LPStruct = 43,
	CustomMarshaler = 44,
	Error = 45,
	IInspectable = 46,
	HString = 47,
	LPUTF8Str = 48,
}

public enum DllImportSearchPath
{
	UseDllDirectoryForDependencies = 256,
	ApplicationDirectory = 512,
	UserDirectories = 1024,
	System32 = 2048,
	SafeDirectories = 4096,
	AssemblyDirectory = 2,
	LegacyBehavior = 0,
}

public enum CallingConvention
{
	Winapi = 1,
	Cdecl = 2,
	StdCall = 3,
	ThisCall = 4,
	FastCall = 5,
}

public enum CharSet
{
	None = 1,
	Ansi = 2,
	Unicode = 3,
	Auto = 4,
}

public enum GCHandleType
{
	Weak = 0,
	WeakTrackResurrection = 1,
	Normal = 2,
	Pinned = 3,
}

internal enum InsertionBehavior
{
	None = 0,
	OverwriteExisting = 1,
	ThrowOnExisting = 2,
}

public enum DebuggableAttribute.DebuggingModes
{
	None = 0,
	Default = 1,
	DisableOptimizations = 256,
	IgnoreSymbolStoreSequencePoints = 2,
	EnableEditAndContinue = 4,
}

public enum DebuggerBrowsableState
{
	Never = 0,
	Collapsed = 2,
	RootHidden = 3,
}

internal enum StackTrace.TraceFormat
{
	Normal = 0,
	TrailingNewLine = 1,
	NoResourceLookup = 2,
}

public enum EventKeywords
{
	None = 0,
	MicrosoftTelemetry = 562949953421312,
	WdiContext = 562949953421312,
	WdiDiagnostic = 1125899906842624,
	Sqm = 2251799813685248,
	AuditFailure = 4503599627370496,
	AuditSuccess = 9007199254740992,
	CorrelationHint = 4503599627370496,
	EventLogClassic = 36028797018963968,
}

public enum ConfigurationElementCollectionType
{
	AddRemoveClearMap = 1,
	AddRemoveClearMapAlternate = 3,
	BasicMap = 0,
	BasicMapAlternate = 2,
}

public enum ConfigurationSaveMode
{
	Full = 2,
	Minimal = 1,
	Modified = 0,
}

public enum PKCS12.DeriveBytes.Purpose
{
	Key = 0,
	IV = 1,
	MAC = 2,
}

public enum X509ChainStatusFlags
{
	InvalidBasicConstraints = 1024,
	NoError = 0,
	NotSignatureValid = 8,
	NotTimeNested = 2,
	NotTimeValid = 1,
	PartialChain = 65536,
	UntrustedRoot = 32,
}

public enum KeyUsages
{
	digitalSignature = 128,
	nonRepudiation = 64,
	keyEncipherment = 32,
	dataEncipherment = 16,
	keyAgreement = 8,
	keyCertSign = 4,
	cRLSign = 2,
	encipherOnly = 1,
	decipherOnly = 2048,
	none = 0,
}

public enum NetscapeCertTypeExtension.CertTypes
{
	SslClient = 128,
	SslServer = 64,
	Smime = 32,
	ObjectSigning = 16,
	SslCA = 4,
	SmimeCA = 2,
	ObjectSigningCA = 1,
}

internal enum AlertLevel
{
	Warning = 1,
	Fatal = 2,
}

internal enum AlertDescription
{
	CloseNotify = 0,
	UnexpectedMessage = 10,
	BadRecordMAC = 20,
	DecryptionFailed = 21,
	RecordOverflow = 22,
	DecompressionFailiure = 30,
	HandshakeFailiure = 40,
	NoCertificate = 41,
	BadCertificate = 42,
	UnsupportedCertificate = 43,
	CertificateRevoked = 44,
	CertificateExpired = 45,
	CertificateUnknown = 46,
	IlegalParameter = 47,
	UnknownCA = 48,
	AccessDenied = 49,
	DecodeError = 50,
	DecryptError = 51,
	ExportRestriction = 60,
	ProtocolVersion = 70,
	InsuficientSecurity = 71,
	InternalError = 80,
	UserCancelled = 90,
	NoRenegotiation = 100,
}

public enum CipherAlgorithmType
{
	Des = 0,
	None = 1,
	Rc2 = 2,
	Rc4 = 3,
	Rijndael = 4,
	SkipJack = 5,
	TripleDes = 6,
}

internal enum ContentType
{
	ChangeCipherSpec = 20,
	Alert = 21,
	Handshake = 22,
	ApplicationData = 23,
}

public enum ExchangeAlgorithmType
{
	DiffieHellman = 0,
	Fortezza = 1,
	None = 2,
	RsaKeyX = 3,
	RsaSign = 4,
}

internal enum HandshakeState
{
	None = 0,
	Started = 1,
	Finished = 2,
}

public enum HashAlgorithmType
{
	Md5 = 0,
	None = 1,
	Sha1 = 2,
}

public enum SecurityCompressionType
{
	None = 0,
	Zlib = 1,
}

public enum SecurityProtocolType
{
	Ssl2 = 12,
	Ssl3 = 48,
	Tls = 192,
	Tls11 = 768,
	Tls12 = 3072,
}

private enum SslClientStream.NegotiateState
{
	SentClientHello = 0,
	ReceiveClientHelloResponse = 1,
	SentCipherSpec = 2,
	ReceiveCipherSpecResponse = 3,
	SentKeyExchange = 4,
	ReceiveFinishResponse = 5,
	SentFinished = 6,
}

internal enum ClientCertificateType
{
	RSA = 1,
	DSS = 2,
	RSAFixed = 3,
	DSSFixed = 4,
	Unknown = 255,
}

internal enum HandshakeType
{
	HelloRequest = 0,
	ClientHello = 1,
	ServerHello = 2,
	Certificate = 11,
	ServerKeyExchange = 12,
	CertificateRequest = 13,
	ServerHelloDone = 14,
	CertificateVerify = 15,
	ClientKeyExchange = 16,
	Finished = 20,
	None = 255,
}

public enum NtlmAuthLevel
{
	LM_and_NTLM = 0,
	LM_and_NTLM_and_try_NTLMv2_Session = 1,
	NTLM_only = 2,
	NTLMv2_only = 3,
}

public enum NtlmFlags
{
	NegotiateUnicode = 1,
	NegotiateOem = 2,
	RequestTarget = 4,
	NegotiateNtlm = 512,
	NegotiateDomainSupplied = 4096,
	NegotiateWorkstationSupplied = 8192,
	NegotiateAlwaysSign = 32768,
	NegotiateNtlm2Key = 524288,
	Negotiate128 = 536870912,
}

public enum AlertLevel
{
	Warning = 1,
	Fatal = 2,
}

public enum AlertDescription
{
	CloseNotify = 0,
	UnexpectedMessage = 10,
	BadRecordMAC = 20,
	DecryptionFailed_RESERVED = 21,
	RecordOverflow = 22,
	DecompressionFailure = 30,
	HandshakeFailure = 40,
	NoCertificate_RESERVED = 41,
	BadCertificate = 42,
	UnsupportedCertificate = 43,
	CertificateRevoked = 44,
	CertificateExpired = 45,
	CertificateUnknown = 46,
	IlegalParameter = 47,
	UnknownCA = 48,
	AccessDenied = 49,
	DecodeError = 50,
	DecryptError = 51,
	ExportRestriction = 60,
	ProtocolVersion = 70,
	InsuficientSecurity = 71,
	InternalError = 80,
	UserCancelled = 90,
	NoRenegotiation = 100,
	UnsupportedExtension = 110,
}

public enum CipherAlgorithmType
{
	None = 0,
	Aes128 = 1,
	Aes256 = 2,
	AesGcm128 = 3,
	AesGcm256 = 4,
}

public enum CipherSuiteCode
{
	TLS_NULL_WITH_NULL_NULL = 0,
	TLS_RSA_WITH_NULL_MD5 = 1,
	TLS_RSA_WITH_NULL_SHA = 2,
	TLS_RSA_EXPORT_WITH_RC4_40_MD5 = 3,
	TLS_RSA_WITH_RC4_128_MD5 = 4,
	TLS_RSA_WITH_RC4_128_SHA = 5,
	TLS_RSA_EXPORT_WITH_RC2_CBC_40_MD5 = 6,
	TLS_RSA_WITH_IDEA_CBC_SHA = 7,
	TLS_RSA_EXPORT_WITH_DES40_CBC_SHA = 8,
	TLS_RSA_WITH_DES_CBC_SHA = 9,
	TLS_RSA_WITH_3DES_EDE_CBC_SHA = 10,
	TLS_DH_DSS_EXPORT_WITH_DES40_CBC_SHA = 11,
	TLS_DH_DSS_WITH_DES_CBC_SHA = 12,
	TLS_DH_DSS_WITH_3DES_EDE_CBC_SHA = 13,
	TLS_DH_RSA_EXPORT_WITH_DES40_CBC_SHA = 14,
	TLS_DH_RSA_WITH_DES_CBC_SHA = 15,
	TLS_DH_RSA_WITH_3DES_EDE_CBC_SHA = 16,
	TLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA = 17,
	TLS_DHE_DSS_WITH_DES_CBC_SHA = 18,
	TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA = 19,
	TLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA = 20,
	TLS_DHE_RSA_WITH_DES_CBC_SHA = 21,
	TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA = 22,
	TLS_DH_anon_EXPORT_WITH_RC4_40_MD5 = 23,
	TLS_DH_anon_WITH_RC4_128_MD5 = 24,
	TLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA = 25,
	TLS_DH_anon_WITH_DES_CBC_SHA = 26,
	TLS_DH_anon_WITH_3DES_EDE_CBC_SHA = 27,
	TLS_RSA_WITH_AES_128_CBC_SHA = 47,
	TLS_DH_DSS_WITH_AES_128_CBC_SHA = 48,
	TLS_DH_RSA_WITH_AES_128_CBC_SHA = 49,
	TLS_DHE_DSS_WITH_AES_128_CBC_SHA = 50,
	TLS_DHE_RSA_WITH_AES_128_CBC_SHA = 51,
	TLS_DH_anon_WITH_AES_128_CBC_SHA = 52,
	TLS_RSA_WITH_AES_256_CBC_SHA = 53,
	TLS_DH_DSS_WITH_AES_256_CBC_SHA = 54,
	TLS_DH_RSA_WITH_AES_256_CBC_SHA = 55,
	TLS_DHE_DSS_WITH_AES_256_CBC_SHA = 56,
	TLS_DHE_RSA_WITH_AES_256_CBC_SHA = 57,
	TLS_DH_anon_WITH_AES_256_CBC_SHA = 58,
	TLS_RSA_WITH_CAMELLIA_128_CBC_SHA = 65,
	TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA = 66,
	TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA = 67,
	TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA = 68,
	TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA = 69,
	TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA = 70,
	TLS_RSA_WITH_CAMELLIA_256_CBC_SHA = 132,
	TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA = 133,
	TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA = 134,
	TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA = 135,
	TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA = 136,
	TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA = 137,
	TLS_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 186,
	TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 187,
	TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 188,
	TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 189,
	TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 190,
	TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA256 = 191,
	TLS_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 192,
	TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 193,
	TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 194,
	TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 195,
	TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 196,
	TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA256 = 197,
	TLS_RSA_WITH_SEED_CBC_SHA = 150,
	TLS_DH_DSS_WITH_SEED_CBC_SHA = 151,
	TLS_DH_RSA_WITH_SEED_CBC_SHA = 152,
	TLS_DHE_DSS_WITH_SEED_CBC_SHA = 153,
	TLS_DHE_RSA_WITH_SEED_CBC_SHA = 154,
	TLS_DH_anon_WITH_SEED_CBC_SHA = 155,
	TLS_PSK_WITH_RC4_128_SHA = 138,
	TLS_PSK_WITH_3DES_EDE_CBC_SHA = 139,
	TLS_PSK_WITH_AES_128_CBC_SHA = 140,
	TLS_PSK_WITH_AES_256_CBC_SHA = 141,
	TLS_DHE_PSK_WITH_RC4_128_SHA = 142,
	TLS_DHE_PSK_WITH_3DES_EDE_CBC_SHA = 143,
	TLS_DHE_PSK_WITH_AES_128_CBC_SHA = 144,
	TLS_DHE_PSK_WITH_AES_256_CBC_SHA = 145,
	TLS_RSA_PSK_WITH_RC4_128_SHA = 146,
	TLS_RSA_PSK_WITH_3DES_EDE_CBC_SHA = 147,
	TLS_RSA_PSK_WITH_AES_128_CBC_SHA = 148,
	TLS_RSA_PSK_WITH_AES_256_CBC_SHA = 149,
	TLS_ECDH_ECDSA_WITH_NULL_SHA = 49153,
	TLS_ECDH_ECDSA_WITH_RC4_128_SHA = 49154,
	TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA = 49155,
	TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA = 49156,
	TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA = 49157,
	TLS_ECDHE_ECDSA_WITH_NULL_SHA = 49158,
	TLS_ECDHE_ECDSA_WITH_RC4_128_SHA = 49159,
	TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA = 49160,
	TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA = 49161,
	TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA = 49162,
	TLS_ECDH_RSA_WITH_NULL_SHA = 49163,
	TLS_ECDH_RSA_WITH_RC4_128_SHA = 49164,
	TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA = 49165,
	TLS_ECDH_RSA_WITH_AES_128_CBC_SHA = 49166,
	TLS_ECDH_RSA_WITH_AES_256_CBC_SHA = 49167,
	TLS_ECDHE_RSA_WITH_NULL_SHA = 49168,
	TLS_ECDHE_RSA_WITH_RC4_128_SHA = 49169,
	TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA = 49170,
	TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA = 49171,
	TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA = 49172,
	TLS_ECDH_anon_WITH_NULL_SHA = 49173,
	TLS_ECDH_anon_WITH_RC4_128_SHA = 49174,
	TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA = 49175,
	TLS_ECDH_anon_WITH_AES_128_CBC_SHA = 49176,
	TLS_ECDH_anon_WITH_AES_256_CBC_SHA = 49177,
	TLS_PSK_WITH_NULL_SHA = 44,
	TLS_DHE_PSK_WITH_NULL_SHA = 45,
	TLS_RSA_PSK_WITH_NULL_SHA = 46,
	TLS_SRP_SHA_WITH_3DES_EDE_CBC_SHA = 49178,
	TLS_SRP_SHA_RSA_WITH_3DES_EDE_CBC_SHA = 49179,
	TLS_SRP_SHA_DSS_WITH_3DES_EDE_CBC_SHA = 49180,
	TLS_SRP_SHA_WITH_AES_128_CBC_SHA = 49181,
	TLS_SRP_SHA_RSA_WITH_AES_128_CBC_SHA = 49182,
	TLS_SRP_SHA_DSS_WITH_AES_128_CBC_SHA = 49183,
	TLS_SRP_SHA_WITH_AES_256_CBC_SHA = 49184,
	TLS_SRP_SHA_RSA_WITH_AES_256_CBC_SHA = 49185,
	TLS_SRP_SHA_DSS_WITH_AES_256_CBC_SHA = 49186,
	TLS_RSA_WITH_NULL_SHA256 = 59,
	TLS_RSA_WITH_AES_128_CBC_SHA256 = 60,
	TLS_RSA_WITH_AES_256_CBC_SHA256 = 61,
	TLS_DH_DSS_WITH_AES_128_CBC_SHA256 = 62,
	TLS_DH_RSA_WITH_AES_128_CBC_SHA256 = 63,
	TLS_DHE_DSS_WITH_AES_128_CBC_SHA256 = 64,
	TLS_DHE_RSA_WITH_AES_128_CBC_SHA256 = 103,
	TLS_DH_DSS_WITH_AES_256_CBC_SHA256 = 104,
	TLS_DH_RSA_WITH_AES_256_CBC_SHA256 = 105,
	TLS_DHE_DSS_WITH_AES_256_CBC_SHA256 = 106,
	TLS_DHE_RSA_WITH_AES_256_CBC_SHA256 = 107,
	TLS_DH_anon_WITH_AES_128_CBC_SHA256 = 108,
	TLS_DH_anon_WITH_AES_256_CBC_SHA256 = 109,
	TLS_RSA_WITH_AES_128_GCM_SHA256 = 156,
	TLS_RSA_WITH_AES_256_GCM_SHA384 = 157,
	TLS_DHE_RSA_WITH_AES_128_GCM_SHA256 = 158,
	TLS_DHE_RSA_WITH_AES_256_GCM_SHA384 = 159,
	TLS_DH_RSA_WITH_AES_128_GCM_SHA256 = 160,
	TLS_DH_RSA_WITH_AES_256_GCM_SHA384 = 161,
	TLS_DHE_DSS_WITH_AES_128_GCM_SHA256 = 162,
	TLS_DHE_DSS_WITH_AES_256_GCM_SHA384 = 163,
	TLS_DH_DSS_WITH_AES_128_GCM_SHA256 = 164,
	TLS_DH_DSS_WITH_AES_256_GCM_SHA384 = 165,
	TLS_DH_anon_WITH_AES_128_GCM_SHA256 = 166,
	TLS_DH_anon_WITH_AES_256_GCM_SHA384 = 167,
	TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256 = 49187,
	TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384 = 49188,
	TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256 = 49189,
	TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384 = 49190,
	TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256 = 49191,
	TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384 = 49192,
	TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256 = 49193,
	TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384 = 49194,
	TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256 = 49195,
	TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384 = 49196,
	TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256 = 49197,
	TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384 = 49198,
	TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256 = 49199,
	TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384 = 49200,
	TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256 = 49201,
	TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384 = 49202,
	TLS_PSK_WITH_AES_128_GCM_SHA256 = 168,
	TLS_PSK_WITH_AES_256_GCM_SHA384 = 169,
	TLS_DHE_PSK_WITH_AES_128_GCM_SHA256 = 170,
	TLS_DHE_PSK_WITH_AES_256_GCM_SHA384 = 171,
	TLS_RSA_PSK_WITH_AES_128_GCM_SHA256 = 172,
	TLS_RSA_PSK_WITH_AES_256_GCM_SHA384 = 173,
	TLS_PSK_WITH_AES_128_CBC_SHA256 = 174,
	TLS_PSK_WITH_AES_256_CBC_SHA384 = 175,
	TLS_PSK_WITH_NULL_SHA256 = 176,
	TLS_PSK_WITH_NULL_SHA384 = 177,
	TLS_DHE_PSK_WITH_AES_128_CBC_SHA256 = 178,
	TLS_DHE_PSK_WITH_AES_256_CBC_SHA384 = 179,
	TLS_DHE_PSK_WITH_NULL_SHA256 = 180,
	TLS_DHE_PSK_WITH_NULL_SHA384 = 181,
	TLS_RSA_PSK_WITH_AES_128_CBC_SHA256 = 182,
	TLS_RSA_PSK_WITH_AES_256_CBC_SHA384 = 183,
	TLS_RSA_PSK_WITH_NULL_SHA256 = 184,
	TLS_RSA_PSK_WITH_NULL_SHA384 = 185,
	TLS_ECDHE_PSK_WITH_RC4_128_SHA = 49203,
	TLS_ECDHE_PSK_WITH_3DES_EDE_CBC_SHA = 49204,
	TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA = 49205,
	TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA = 49206,
	TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA256 = 49207,
	TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA384 = 49208,
	TLS_ECDHE_PSK_WITH_NULL_SHA = 49209,
	TLS_ECDHE_PSK_WITH_NULL_SHA256 = 49210,
	TLS_ECDHE_PSK_WITH_NULL_SHA384 = 49211,
	TLS_EMPTY_RENEGOTIATION_INFO_SCSV = 255,
	TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49266,
	TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49267,
	TLS_ECDH_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49268,
	TLS_ECDH_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49269,
	TLS_ECDHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49270,
	TLS_ECDHE_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49271,
	TLS_ECDH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49272,
	TLS_ECDH_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49273,
	TLS_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49274,
	TLS_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49275,
	TLS_DHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49276,
	TLS_DHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49277,
	TLS_DH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49278,
	TLS_DH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49279,
	TLS_DHE_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49280,
	TLS_DHE_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49281,
	TLS_DH_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49282,
	TLS_DH_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49283,
	TLS_DH_anon_WITH_CAMELLIA_128_GCM_SHA256 = 49284,
	TLS_DH_anon_WITH_CAMELLIA_256_GCM_SHA384 = 49285,
	TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49286,
	TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49287,
	TLS_ECDH_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49288,
	TLS_ECDH_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49289,
	TLS_ECDHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49290,
	TLS_ECDHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49291,
	TLS_ECDH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49292,
	TLS_ECDH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49293,
	TLS_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49294,
	TLS_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49295,
	TLS_DHE_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49296,
	TLS_DHE_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49297,
	TLS_RSA_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49298,
	TLS_RSA_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49299,
	TLS_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49300,
	TLS_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49301,
	TLS_DHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49302,
	TLS_DHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49303,
	TLS_RSA_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49304,
	TLS_RSA_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49305,
	TLS_ECDHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49306,
	TLS_ECDHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49307,
	TLS_RSA_WITH_AES_128_CCM = 49308,
	TLS_RSA_WITH_AES_256_CCM = 49309,
	TLS_DHE_RSA_WITH_AES_128_CCM = 49310,
	TLS_DHE_RSA_WITH_AES_256_CCM = 49311,
	TLS_RSA_WITH_AES_128_CCM_8 = 49312,
	TLS_RSA_WITH_AES_256_CCM_8 = 49313,
	TLS_DHE_RSA_WITH_AES_128_CCM_8 = 49314,
	TLS_DHE_RSA_WITH_AES_256_CCM_8 = 49315,
	TLS_PSK_WITH_AES_128_CCM = 49316,
	TLS_PSK_WITH_AES_256_CCM = 49317,
	TLS_DHE_PSK_WITH_AES_128_CCM = 49318,
	TLS_DHE_PSK_WITH_AES_256_CCM = 49319,
	TLS_PSK_WITH_AES_128_CCM_8 = 49320,
	TLS_PSK_WITH_AES_256_CCM_8 = 49321,
	TLS_PSK_DHE_WITH_AES_128_CCM_8 = 49322,
	TLS_PSK_DHE_WITH_AES_256_CCM_8 = 49323,
	TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52243,
	TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256 = 52244,
	TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52245,
	TLS_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58384,
	TLS_RSA_WITH_SALSA20_SHA1 = 58385,
	TLS_ECDHE_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58386,
	TLS_ECDHE_RSA_WITH_SALSA20_SHA1 = 58387,
	TLS_ECDHE_ECDSA_WITH_ESTREAM_SALSA20_SHA1 = 58388,
	TLS_ECDHE_ECDSA_WITH_SALSA20_SHA1 = 58389,
	TLS_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58390,
	TLS_PSK_WITH_SALSA20_SHA1 = 58391,
	TLS_ECDHE_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58392,
	TLS_ECDHE_PSK_WITH_SALSA20_SHA1 = 58393,
	TLS_RSA_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58394,
	TLS_RSA_PSK_WITH_SALSA20_SHA1 = 58395,
	TLS_DHE_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58396,
	TLS_DHE_PSK_WITH_SALSA20_SHA1 = 58397,
	TLS_DHE_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58398,
	TLS_DHE_RSA_WITH_SALSA20_SHA1 = 58399,
	TLS_FALLBACK_SCSV = 22016,
}

public enum ExchangeAlgorithmType
{
	None = 0,
	Dhe = 1,
	Rsa = 2,
	EcDhe = 3,
}

public enum HashAlgorithmType
{
	None = 0,
	Md5 = 1,
	Sha1 = 2,
	Sha224 = 3,
	Sha256 = 4,
	Sha384 = 5,
	Sha512 = 6,
	Unknown = 255,
	Md5Sha1 = 254,
}

public enum MonoSslPolicyErrors
{
	None = 0,
	RemoteCertificateNotAvailable = 1,
	RemoteCertificateNameMismatch = 2,
	RemoteCertificateChainErrors = 4,
}

public enum TlsProtocols
{
	Zero = 0,
	Tls10Client = 128,
	Tls10Server = 64,
	Tls10 = 192,
	Tls11Client = 512,
	Tls11Server = 256,
	Tls11 = 768,
	Tls12Client = 2048,
	Tls12Server = 1024,
	Tls12 = 3072,
	ClientMask = 2688,
	ServerMask = 1344,
}

public enum BigInteger.Sign
{
	Zero = 0,
	Positive = 1,
}

public enum ConfidenceFactor
{
	ExtraLow = 0,
	Low = 1,
	Medium = 2,
	High = 3,
	ExtraHigh = 4,
	Provable = 5,
}

public enum AstNode.AstType
{
	Axis = 0,
	Operator = 1,
	Filter = 2,
	ConstantOperand = 3,
	Function = 4,
	Group = 5,
	Root = 6,
	Variable = 7,
	Error = 8,
}

public enum Axis.AxisType
{
	Ancestor = 0,
	AncestorOrSelf = 1,
	Attribute = 2,
	Child = 3,
	Descendant = 4,
	DescendantOrSelf = 5,
	Following = 6,
	FollowingSibling = 7,
	Namespace = 8,
	Parent = 9,
	Preceding = 10,
	PrecedingSibling = 11,
	Self = 12,
	None = 13,
}

public enum Function.FunctionType
{
	FuncLast = 0,
	FuncPosition = 1,
	FuncCount = 2,
	FuncID = 3,
	FuncLocalName = 4,
	FuncNameSpaceUri = 5,
	FuncName = 6,
	FuncString = 7,
	FuncBoolean = 8,
	FuncNumber = 9,
	FuncTrue = 10,
	FuncFalse = 11,
	FuncNot = 12,
	FuncConcat = 13,
	FuncStartsWith = 14,
	FuncContains = 15,
	FuncSubstringBefore = 16,
	FuncSubstringAfter = 17,
	FuncSubstring = 18,
	FuncStringLength = 19,
	FuncNormalize = 20,
	FuncTranslate = 21,
	FuncLang = 22,
	FuncSum = 23,
	FuncFloor = 24,
	FuncCeiling = 25,
	FuncRound = 26,
	FuncUserDefined = 27,
}

public enum Operator.Op
{
	INVALID = 0,
	OR = 1,
	AND = 2,
	EQ = 3,
	NE = 4,
	LT = 5,
	LE = 6,
	GT = 7,
	GE = 8,
	PLUS = 9,
	MINUS = 10,
	MUL = 11,
	DIV = 12,
	MOD = 13,
	UNION = 14,
}

public enum XPathScanner.LexKind
{
	Comma = 44,
	Slash = 47,
	At = 64,
	Dot = 46,
	LParens = 40,
	RParens = 41,
	LBracket = 91,
	RBracket = 93,
	Star = 42,
	Plus = 43,
	Minus = 45,
	Eq = 61,
	Lt = 60,
	Gt = 62,
	Bang = 33,
	Dollar = 36,
	Apos = 39,
	Quote = 34,
	Union = 124,
	Ne = 78,
	Le = 76,
	Ge = 71,
	And = 65,
	Or = 79,
	DotDot = 68,
	SlashSlash = 83,
	Name = 110,
	String = 115,
	Number = 100,
	Axe = 97,
	Eof = 69,
}

internal enum BinXmlToken
{
	Error = 0,
	XmlDecl = 254,
	Encoding = 253,
	DocType = 252,
	System = 251,
	Public = 250,
	Subset = 249,
	Element = 248,
	EndElem = 247,
	Attr = 246,
	EndAttrs = 245,
	PI = 244,
	Comment = 243,
	CData = 242,
	EndCData = 241,
	Name = 240,
	QName = 239,
	XmlText = 237,
	Nest = 236,
	EndNest = 235,
	Extn = 234,
	NmFlush = 233,
	SQL_BIT = 6,
	SQL_TINYINT = 7,
	SQL_SMALLINT = 1,
	SQL_INT = 2,
	SQL_BIGINT = 8,
	SQL_REAL = 3,
	SQL_FLOAT = 4,
	SQL_MONEY = 5,
	SQL_SMALLMONEY = 20,
	SQL_DATETIME = 18,
	SQL_SMALLDATETIME = 19,
	SQL_DECIMAL = 10,
	SQL_NUMERIC = 11,
	SQL_UUID = 9,
	SQL_VARBINARY = 15,
	SQL_BINARY = 12,
	SQL_IMAGE = 23,
	SQL_CHAR = 13,
	SQL_VARCHAR = 16,
	SQL_TEXT = 22,
	SQL_NVARCHAR = 17,
	SQL_NCHAR = 14,
	SQL_NTEXT = 24,
	SQL_UDT = 27,
	XSD_KATMAI_DATE = 127,
	XSD_KATMAI_DATETIME = 126,
	XSD_KATMAI_TIME = 125,
	XSD_KATMAI_DATEOFFSET = 124,
	XSD_KATMAI_DATETIMEOFFSET = 123,
	XSD_KATMAI_TIMEOFFSET = 122,
	XSD_BOOLEAN = 134,
	XSD_TIME = 129,
	XSD_DATETIME = 130,
	XSD_DATE = 131,
	XSD_BINHEX = 132,
	XSD_BASE64 = 133,
	XSD_DECIMAL = 135,
	XSD_BYTE = 136,
	XSD_UNSIGNEDSHORT = 137,
	XSD_UNSIGNEDINT = 138,
	XSD_UNSIGNEDLONG = 139,
	XSD_QNAME = 140,
}

private enum XmlSqlBinaryReader.ScanState
{
	Doc = 0,
	XmlText = 1,
	Attr = 2,
	AttrVal = 3,
	AttrValPseudoValue = 4,
	Init = 5,
	Error = 6,
	EOF = 7,
	Closed = 8,
}

public enum ConformanceLevel
{
	Auto = 0,
	Fragment = 1,
	Document = 2,
}

public enum DtdProcessing
{
	Prohibit = 0,
	Ignore = 1,
	Parse = 2,
}

public enum EntityHandling
{
	ExpandEntities = 1,
	ExpandCharEntities = 2,
}

public enum NamespaceHandling
{
	Default = 0,
	OmitDuplicates = 1,
}

public enum NewLineHandling
{
	Replace = 0,
	Entitize = 1,
	None = 2,
}

private enum ReadContentAsBinaryHelper.State
{
	None = 0,
	InReadContent = 1,
	InReadElementContent = 2,
}

internal enum ElementProperties
{
	DEFAULT = 0,
	URI_PARENT = 1,
	BOOL_PARENT = 2,
	NAME_PARENT = 4,
	EMPTY = 8,
	NO_ENTITIES = 16,
	HEAD = 32,
	BLOCK_WS = 64,
	HAS_NS = 128,
}

internal enum AttributeProperties
{
	DEFAULT = 0,
	URI = 1,
	BOOLEAN = 2,
	NAME = 4,
}

public enum ReadState
{
	Initial = 0,
	Interactive = 1,
	Error = 2,
	EndOfFile = 3,
	Closed = 4,
}

public enum ValidationType
{
	None = 0,
	Auto = 1,
	DTD = 2,
	XDR = 3,
	Schema = 4,
}

public enum WhitespaceHandling
{
	All = 0,
	Significant = 1,
	None = 2,
}

private enum XmlEventCache.XmlEventType
{
	Unknown = 0,
	DocType = 1,
	StartElem = 2,
	StartAttr = 3,
	EndAttr = 4,
	CData = 5,
	Comment = 6,
	PI = 7,
	Whitespace = 8,
	String = 9,
	Raw = 10,
	EntRef = 11,
	CharEnt = 12,
	SurrCharEnt = 13,
	Base64 = 14,
	BinHex = 15,
	XmlDecl1 = 16,
	XmlDecl2 = 17,
	StartContent = 18,
	EndElem = 19,
	FullEndElem = 20,
	Nmsp = 21,
	EndBase64 = 22,
	Close = 23,
	Flush = 24,
	Dispose = 25,
}

public enum XmlSpace
{
	None = 0,
	Default = 1,
	Preserve = 2,
}

private enum XmlTextReaderImpl.ParsingFunction
{
	ElementContent = 0,
	NoData = 1,
	OpenUrl = 2,
	SwitchToInteractive = 3,
	SwitchToInteractiveXmlDecl = 4,
	DocumentContent = 5,
	MoveToElementContent = 6,
	PopElementContext = 7,
	PopEmptyElementContext = 8,
	ResetAttributesRootLevel = 9,
	Error = 10,
	Eof = 11,
	ReaderClosed = 12,
	EntityReference = 13,
	InIncrementalRead = 14,
	FragmentAttribute = 15,
	ReportEndEntity = 16,
	AfterResolveEntityInContent = 17,
	AfterResolveEmptyEntityInContent = 18,
	XmlDeclarationFragment = 19,
	GoToEof = 20,
	PartialTextValue = 21,
	InReadAttributeValue = 22,
	InReadValueChunk = 23,
	InReadContentAsBinary = 24,
	InReadElementContentAsBinary = 25,
}

private enum XmlTextReaderImpl.ParsingMode
{
	Full = 0,
	SkipNode = 1,
	SkipContent = 2,
}

private enum XmlTextReaderImpl.EntityType
{
	CharacterDec = 0,
	CharacterHex = 1,
	CharacterNamed = 2,
	Expanded = 3,
	Skipped = 4,
	FakeExpanded = 5,
	Unexpanded = 6,
	ExpandedInAttribute = 7,
}

private enum XmlTextReaderImpl.EntityExpandType
{
	All = 0,
	OnlyGeneral = 1,
	OnlyCharacter = 2,
}

private enum XmlTextReaderImpl.IncrementalReadState
{
	Text = 0,
	StartTag = 1,
	PI = 2,
	CDATA = 3,
	Comment = 4,
	Attributes = 5,
	AttributeValue = 6,
	ReadData = 7,
	EndElement = 8,
	End = 9,
	ReadValueChunk_OnCachedValue = 10,
	ReadValueChunk_OnPartialValue = 11,
	ReadContentAsBinary_OnCachedValue = 12,
	ReadContentAsBinary_OnPartialValue = 13,
	ReadContentAsBinary_End = 14,
}

private enum XmlTextReaderImpl.InitInputType
{
	UriString = 0,
	Stream = 1,
	TextReader = 2,
	Invalid = 3,
}

public enum Formatting
{
	None = 0,
	Indented = 1,
}

private enum XmlTextWriter.NamespaceState
{
	Uninitialized = 0,
	NotDeclaredButInScope = 1,
	DeclaredButNotWrittenOut = 2,
	DeclaredAndWrittenOut = 3,
}

private enum XmlTextWriter.SpecialAttr
{
	None = 0,
	XmlSpace = 1,
	XmlLang = 2,
	XmlNs = 3,
}

private enum XmlTextWriter.State
{
	Start = 0,
	Prolog = 1,
	PostDTD = 2,
	Element = 3,
	Attribute = 4,
	Content = 5,
	AttrOnly = 6,
	Epilog = 7,
	Error = 8,
	Closed = 9,
}

private enum XmlTextWriter.Token
{
	PI = 0,
	Doctype = 1,
	Comment = 2,
	CData = 3,
	StartElement = 4,
	EndElement = 5,
	LongEndElement = 6,
	StartAttribute = 7,
	EndAttribute = 8,
	Content = 9,
	Base64 = 10,
	RawData = 11,
	Whitespace = 12,
	Empty = 13,
}

private enum XmlValidatingReaderImpl.ParsingFunction
{
	Read = 0,
	Init = 1,
	ParseDtdFromContext = 2,
	ResolveEntityInternally = 3,
	InReadBinaryContent = 4,
	ReaderClosed = 5,
	Error = 6,
	None = 7,
}

private enum XmlWellFormedWriter.State
{
	Start = 0,
	TopLevel = 1,
	Document = 2,
	Element = 3,
	Content = 4,
	B64Content = 5,
	B64Attribute = 6,
	AfterRootEle = 7,
	Attribute = 8,
	SpecialAttr = 9,
	EndDocument = 10,
	RootLevelAttr = 11,
	RootLevelSpecAttr = 12,
	RootLevelB64Attr = 13,
	AfterRootLevelAttr = 14,
	Closed = 15,
	Error = 16,
	StartContent = 101,
	StartContentEle = 102,
	StartContentB64 = 103,
	StartDoc = 104,
	StartDocEle = 106,
	EndAttrSEle = 107,
	EndAttrEEle = 108,
	EndAttrSCont = 109,
	EndAttrSAttr = 111,
	PostB64Cont = 112,
	PostB64Attr = 113,
	PostB64RootAttr = 114,
	StartFragEle = 115,
	StartFragCont = 116,
	StartFragB64 = 117,
	StartRootLevelAttr = 118,
}

private enum XmlWellFormedWriter.Token
{
	StartDocument = 0,
	EndDocument = 1,
	PI = 2,
	Comment = 3,
	Dtd = 4,
	StartElement = 5,
	EndElement = 6,
	StartAttribute = 7,
	EndAttribute = 8,
	Text = 9,
	CData = 10,
	AtomicValue = 11,
	Base64 = 12,
	RawData = 13,
	Whitespace = 14,
}

private enum XmlWellFormedWriter.NamespaceKind
{
	Written = 0,
	NeedToWrite = 1,
	Implied = 2,
	Special = 3,
}

private enum XmlWellFormedWriter.SpecialAttribute
{
	No = 0,
	DefaultXmlns = 1,
	PrefixedXmlns = 2,
	XmlSpace = 3,
	XmlLang = 4,
}

private enum XmlWellFormedWriter.AttributeValueCache.ItemType
{
	EntityRef = 0,
	CharEntity = 1,
	SurrogateCharEntity = 2,
	Whitespace = 3,
	String = 4,
	StringChars = 5,
	Raw = 6,
	RawChars = 7,
	ValueString = 8,
}

public enum WriteState
{
	Start = 0,
	Prolog = 1,
	Element = 2,
	Attribute = 3,
	Content = 4,
	Closed = 5,
	Error = 6,
}

public enum XmlOutputMethod
{
	Xml = 0,
	Html = 1,
	Text = 2,
	AutoDetect = 3,
}

internal enum TriState
{
	False = 0,
	True = 1,
}

internal enum XmlStandalone
{
	Omit = 0,
	Yes = 1,
	No = 2,
}

private enum XsdCachingReader.CachingReaderState
{
	None = 0,
	Init = 1,
	Record = 2,
	Replay = 3,
	ReaderClosed = 4,
	Error = 5,
}

private enum XsdValidatingReader.ValidatingReaderState
{
	None = 0,
	Init = 1,
	Read = 2,
	OnAttribute = 3,
	ClearAttributes = 4,
	ParseInlineSchema = 5,
	ReadAhead = 6,
	OnReadBinaryContent = 7,
	ReaderClosed = 8,
	EOF = 9,
	Error = 10,
}

public enum XmlNodeChangedAction
{
	Insert = 0,
	Remove = 1,
	Change = 2,
}

private enum DtdParser.Token
{
	CDATA = 0,
	ID = 1,
	IDREF = 2,
	IDREFS = 3,
	ENTITY = 4,
	ENTITIES = 5,
	NMTOKEN = 6,
	NMTOKENS = 7,
	NOTATION = 8,
	None = 9,
	PERef = 10,
	AttlistDecl = 11,
	ElementDecl = 12,
	EntityDecl = 13,
	NotationDecl = 14,
	Comment = 15,
	PI = 16,
	CondSectionStart = 17,
	CondSectionEnd = 18,
	Eof = 19,
	REQUIRED = 20,
	IMPLIED = 21,
	FIXED = 22,
	QName = 23,
	Name = 24,
	Nmtoken = 25,
	Quote = 26,
	LeftParen = 27,
	RightParen = 28,
	GreaterThan = 29,
	Or = 30,
	LeftBracket = 31,
	RightBracket = 32,
	PUBLIC = 33,
	SYSTEM = 34,
	Literal = 35,
	DOCTYPE = 36,
	NData = 37,
	Percent = 38,
	Star = 39,
	QMark = 40,
	Plus = 41,
	PCDATA = 42,
	Comma = 43,
	ANY = 44,
	EMPTY = 45,
	IGNORE = 46,
	INCLUDE = 47,
}

private enum DtdParser.ScanningFunction
{
	SubsetContent = 0,
	Name = 1,
	QName = 2,
	Nmtoken = 3,
	Doctype1 = 4,
	Doctype2 = 5,
	Element1 = 6,
	Element2 = 7,
	Element3 = 8,
	Element4 = 9,
	Element5 = 10,
	Element6 = 11,
	Element7 = 12,
	Attlist1 = 13,
	Attlist2 = 14,
	Attlist3 = 15,
	Attlist4 = 16,
	Attlist5 = 17,
	Attlist6 = 18,
	Attlist7 = 19,
	Entity1 = 20,
	Entity2 = 21,
	Entity3 = 22,
	Notation1 = 23,
	CondSection1 = 24,
	CondSection2 = 25,
	CondSection3 = 26,
	Literal = 27,
	SystemId = 28,
	PublicId1 = 29,
	PublicId2 = 30,
	ClosingTag = 31,
	ParamEntitySpace = 32,
	None = 33,
}

private enum DtdParser.LiteralType
{
	AttributeValue = 0,
	EntityReplText = 1,
	SystemOrPublicID = 2,
}

public enum XmlTokenizedType
{
	CDATA = 0,
	ID = 1,
	IDREF = 2,
	IDREFS = 3,
	ENTITY = 4,
	ENTITIES = 5,
	NMTOKEN = 6,
	NMTOKENS = 7,
	NOTATION = 8,
	ENUMERATION = 9,
	QName = 10,
	NCName = 11,
	None = 12,
}

internal enum ExceptionType
{
	ArgumentException = 0,
	XmlException = 1,
}

public enum XmlDateTimeSerializationMode
{
	Local = 0,
	Utc = 1,
	Unspecified = 2,
	RoundtripKind = 3,
}

public enum XmlNamespaceScope
{
	All = 0,
	ExcludeXml = 1,
	Local = 2,
}

public enum XmlNodeType
{
	None = 0,
	Element = 1,
	Attribute = 2,
	Text = 3,
	CDATA = 4,
	EntityReference = 5,
	Entity = 6,
	ProcessingInstruction = 7,
	Comment = 8,
	Document = 9,
	DocumentType = 10,
	DocumentFragment = 11,
	Notation = 12,
	Whitespace = 13,
	SignificantWhitespace = 14,
	EndElement = 15,
	EndEntity = 16,
	XmlDeclaration = 17,
}

public enum XPathResultType
{
	Number = 0,
	String = 1,
	Boolean = 2,
	NodeSet = 3,
	Navigator = 1,
	Any = 5,
	Error = 6,
}

public enum XPathNamespaceScope
{
	All = 0,
	ExcludeXml = 1,
	Local = 2,
}

public enum XPathNodeType
{
	Root = 0,
	Element = 1,
	Attribute = 2,
	Namespace = 3,
	Text = 4,
	SignificantWhitespace = 5,
	Whitespace = 6,
	ProcessingInstruction = 7,
	Comment = 8,
	All = 9,
}

internal enum SchemaTypes
{
	NotSet = 0,
	Primitive = 1,
	Enum = 2,
	Array = 3,
	Class = 4,
	XmlSerializable = 5,
	XmlNode = 6,
	Void = 7,
}

internal enum SerializationFormat
{
	Encoded = 0,
	Literal = 1,
}

public enum CompiledIdentityConstraint.ConstraintRole
{
	Unique = 0,
	Key = 1,
	Keyref = 2,
}

public enum XmlSchemaDatatypeVariety
{
	Atomic = 0,
	List = 1,
	Union = 2,
}

internal enum RestrictionFlags
{
	Length = 1,
	MinLength = 2,
	MaxLength = 4,
	Pattern = 8,
	Enumeration = 16,
	WhiteSpace = 32,
	MaxInclusive = 64,
	MaxExclusive = 128,
	MinInclusive = 256,
	MinExclusive = 512,
	TotalDigits = 1024,
	FractionDigits = 2048,
}

internal enum XmlSchemaWhiteSpace
{
	Preserve = 0,
	Replace = 1,
	Collapse = 2,
}

public enum XmlSchemaInference.InferenceOption
{
	Restricted = 0,
	Relaxed = 1,
}

public enum NamespaceList.ListType
{
	Any = 0,
	Other = 1,
	Set = 2,
}

internal enum Compositor
{
	Root = 0,
	Include = 1,
	Import = 2,
	Redefine = 3,
}

internal enum SchemaAttDef.Reserve
{
	None = 0,
	XmlSpace = 1,
	XmlLang = 2,
}

private enum SchemaCollectionPreprocessor.Compositor
{
	Root = 0,
	Include = 1,
	Import = 2,
}

internal enum SchemaDeclBase.Use
{
	Default = 0,
	Required = 1,
	Implied = 2,
	Fixed = 3,
	RequiredFixed = 4,
}

internal enum AttributeMatchState
{
	AttributeFound = 0,
	AnyIdAttributeFound = 1,
	UndeclaredElementAndAttribute = 2,
	UndeclaredAttribute = 3,
	AnyAttributeLax = 4,
	AnyAttributeSkip = 5,
	ProhibitedAnyAttribute = 6,
	ProhibitedAttribute = 7,
	AttributeNameMismatch = 8,
	ValidateAttributeInvalidCall = 9,
}

public enum SchemaNames.Token
{
	Empty = 0,
	SchemaName = 1,
	SchemaType = 2,
	SchemaMaxOccurs = 3,
	SchemaMinOccurs = 4,
	SchemaInfinite = 5,
	SchemaModel = 6,
	SchemaOpen = 7,
	SchemaClosed = 8,
	SchemaContent = 9,
	SchemaMixed = 10,
	SchemaEmpty = 11,
	SchemaElementOnly = 12,
	SchemaTextOnly = 13,
	SchemaOrder = 14,
	SchemaSeq = 15,
	SchemaOne = 16,
	SchemaMany = 17,
	SchemaRequired = 18,
	SchemaYes = 19,
	SchemaNo = 20,
	SchemaString = 21,
	SchemaId = 22,
	SchemaIdref = 23,
	SchemaIdrefs = 24,
	SchemaEntity = 25,
	SchemaEntities = 26,
	SchemaNmtoken = 27,
	SchemaNmtokens = 28,
	SchemaEnumeration = 29,
	SchemaDefault = 30,
	XdrRoot = 31,
	XdrElementType = 32,
	XdrElement = 33,
	XdrGroup = 34,
	XdrAttributeType = 35,
	XdrAttribute = 36,
	XdrDatatype = 37,
	XdrDescription = 38,
	XdrExtends = 39,
	SchemaXdrRootAlias = 40,
	SchemaDtType = 41,
	SchemaDtValues = 42,
	SchemaDtMaxLength = 43,
	SchemaDtMinLength = 44,
	SchemaDtMax = 45,
	SchemaDtMin = 46,
	SchemaDtMinExclusive = 47,
	SchemaDtMaxExclusive = 48,
	SchemaTargetNamespace = 49,
	SchemaVersion = 50,
	SchemaFinalDefault = 51,
	SchemaBlockDefault = 52,
	SchemaFixed = 53,
	SchemaAbstract = 54,
	SchemaBlock = 55,
	SchemaSubstitutionGroup = 56,
	SchemaFinal = 57,
	SchemaNillable = 58,
	SchemaRef = 59,
	SchemaBase = 60,
	SchemaDerivedBy = 61,
	SchemaNamespace = 62,
	SchemaProcessContents = 63,
	SchemaRefer = 64,
	SchemaPublic = 65,
	SchemaSystem = 66,
	SchemaSchemaLocation = 67,
	SchemaValue = 68,
	SchemaSource = 69,
	SchemaAttributeFormDefault = 70,
	SchemaElementFormDefault = 71,
	SchemaUse = 72,
	SchemaForm = 73,
	XsdSchema = 74,
	XsdAnnotation = 75,
	XsdInclude = 76,
	XsdImport = 77,
	XsdElement = 78,
	XsdAttribute = 79,
	xsdAttributeGroup = 80,
	XsdAnyAttribute = 81,
	XsdGroup = 82,
	XsdAll = 83,
	XsdChoice = 84,
	XsdSequence = 85,
	XsdAny = 86,
	XsdNotation = 87,
	XsdSimpleType = 88,
	XsdComplexType = 89,
	XsdUnique = 90,
	XsdKey = 91,
	XsdKeyref = 92,
	XsdSelector = 93,
	XsdField = 94,
	XsdMinExclusive = 95,
	XsdMinInclusive = 96,
	XsdMaxExclusive = 97,
	XsdMaxInclusive = 98,
	XsdTotalDigits = 99,
	XsdFractionDigits = 100,
	XsdLength = 101,
	XsdMinLength = 102,
	XsdMaxLength = 103,
	XsdEnumeration = 104,
	XsdPattern = 105,
	XsdDocumentation = 106,
	XsdAppInfo = 107,
	XsdComplexContent = 108,
	XsdComplexContentExtension = 109,
	XsdComplexContentRestriction = 110,
	XsdSimpleContent = 111,
	XsdSimpleContentExtension = 112,
	XsdSimpleContentRestriction = 113,
	XsdSimpleTypeList = 114,
	XsdSimpleTypeRestriction = 115,
	XsdSimpleTypeUnion = 116,
	XsdWhitespace = 117,
	XsdRedefine = 118,
	SchemaItemType = 119,
	SchemaMemberTypes = 120,
	SchemaXPath = 121,
	XmlLang = 122,
}

internal enum SchemaType
{
	None = 0,
	DTD = 1,
	XDR = 2,
	XSD = 3,
}

public enum XmlSchemaContentProcessing
{
	None = 0,
	Skip = 1,
	Lax = 2,
	Strict = 3,
}

public enum XmlSchemaContentType
{
	TextOnly = 0,
	Empty = 1,
	ElementOnly = 2,
	Mixed = 3,
}

public enum XmlSchemaDerivationMethod
{
	Empty = 0,
	Substitution = 1,
	Extension = 2,
	Restriction = 4,
	List = 8,
	Union = 16,
	All = 255,
	None = 256,
}

internal enum FacetType
{
	None = 0,
	Length = 1,
	MinLength = 2,
	MaxLength = 3,
	Pattern = 4,
	Whitespace = 5,
	Enumeration = 6,
	MinExclusive = 7,
	MinInclusive = 8,
	MaxExclusive = 9,
	MaxInclusive = 10,
	TotalDigits = 11,
	FractionDigits = 12,
}

public enum XmlSchemaForm
{
	None = 0,
	Qualified = 1,
	Unqualified = 2,
}

internal enum XmlSchemaObjectTable.EnumeratorType
{
	Keys = 0,
	Values = 1,
	DictionaryEntry = 2,
}

private enum XmlSchemaParticle.Occurs
{
	None = 0,
	Min = 1,
	Max = 2,
}

public enum XmlSchemaUse
{
	None = 0,
	Optional = 1,
	Prohibited = 2,
	Required = 3,
}

public enum XmlSchemaValidationFlags
{
	None = 0,
	ProcessInlineSchema = 1,
	ProcessSchemaLocation = 2,
	ReportValidationWarnings = 4,
	ProcessIdentityConstraints = 8,
	AllowXmlAttributes = 16,
}

internal enum ValidatorState
{
	None = 0,
	Start = 1,
	TopLevelAttribute = 2,
	TopLevelTextOrWS = 3,
	Element = 4,
	Attribute = 5,
	EndOfAttributes = 6,
	Text = 7,
	Whitespace = 8,
	EndElement = 9,
	SkipToEndElement = 10,
	Finish = 11,
}

public enum XmlSchemaValidity
{
	NotKnown = 0,
	Valid = 1,
	Invalid = 2,
}

public enum XmlSeverityType
{
	Error = 0,
	Warning = 1,
}

public enum XmlTypeCode
{
	None = 0,
	Item = 1,
	Node = 2,
	Document = 3,
	Element = 4,
	Attribute = 5,
	Namespace = 6,
	ProcessingInstruction = 7,
	Comment = 8,
	Text = 9,
	AnyAtomicType = 10,
	UntypedAtomic = 11,
	String = 12,
	Boolean = 13,
	Decimal = 14,
	Float = 15,
	Double = 16,
	Duration = 17,
	DateTime = 18,
	Time = 19,
	Date = 20,
	GYearMonth = 21,
	GYear = 22,
	GMonthDay = 23,
	GDay = 24,
	GMonth = 25,
	HexBinary = 26,
	Base64Binary = 27,
	AnyUri = 28,
	QName = 29,
	Notation = 30,
	NormalizedString = 31,
	Token = 32,
	Language = 33,
	NmToken = 34,
	Name = 35,
	NCName = 36,
	Id = 37,
	Idref = 38,
	Entity = 39,
	Integer = 40,
	NonPositiveInteger = 41,
	NegativeInteger = 42,
	Long = 43,
	Int = 44,
	Short = 45,
	Byte = 46,
	NonNegativeInteger = 47,
	UnsignedLong = 48,
	UnsignedInt = 49,
	UnsignedShort = 50,
	UnsignedByte = 51,
	PositiveInteger = 52,
	YearMonthDuration = 53,
	DayTimeDuration = 54,
}

private enum XsdBuilder.State
{
	Root = 0,
	Schema = 1,
	Annotation = 2,
	Include = 3,
	Import = 4,
	Element = 5,
	Attribute = 6,
	AttributeGroup = 7,
	AttributeGroupRef = 8,
	AnyAttribute = 9,
	Group = 10,
	GroupRef = 11,
	All = 12,
	Choice = 13,
	Sequence = 14,
	Any = 15,
	Notation = 16,
	SimpleType = 17,
	ComplexType = 18,
	ComplexContent = 19,
	ComplexContentRestriction = 20,
	ComplexContentExtension = 21,
	SimpleContent = 22,
	SimpleContentExtension = 23,
	SimpleContentRestriction = 24,
	SimpleTypeUnion = 25,
	SimpleTypeList = 26,
	SimpleTypeRestriction = 27,
	Unique = 28,
	Key = 29,
	KeyRef = 30,
	Selector = 31,
	Field = 32,
	MinExclusive = 33,
	MinInclusive = 34,
	MaxExclusive = 35,
	MaxInclusive = 36,
	TotalDigits = 37,
	FractionDigits = 38,
	Length = 39,
	MinLength = 40,
	MaxLength = 41,
	Enumeration = 42,
	Pattern = 43,
	WhiteSpace = 44,
	AppInfo = 45,
	Documentation = 46,
	Redefine = 47,
}

internal enum XsdDateTimeFlags
{
	DateTime = 1,
	Time = 2,
	Date = 4,
	GYearMonth = 8,
	GYear = 16,
	GMonthDay = 32,
	GDay = 64,
	GMonth = 128,
	XdrDateTimeNoTz = 256,
	XdrDateTime = 512,
	XdrTimeNoTz = 1024,
	AllXsd = 255,
}

private enum XsdDateTime.DateTimeTypeCode
{
	DateTime = 0,
	Time = 1,
	Date = 2,
	GYearMonth = 3,
	GYear = 4,
	GMonthDay = 5,
	GDay = 6,
	GMonth = 7,
	XdrDateTime = 8,
}

private enum XsdDateTime.XsdDateTimeKind
{
	Unspecified = 0,
	Zulu = 1,
	LocalWestOfZulu = 2,
	LocalEastOfZulu = 3,
}

private enum XsdDuration.Parts
{
	HasNone = 0,
	HasYears = 1,
	HasMonths = 2,
	HasDays = 4,
	HasHours = 8,
	HasMinutes = 16,
	HasSeconds = 32,
}

public enum XsdDuration.DurationType
{
	Duration = 0,
	YearMonthDuration = 1,
	DayTimeDuration = 2,
}

public enum UnityTls.unitytls_error_code
{
	UNITYTLS_SUCCESS = 0,
	UNITYTLS_INVALID_ARGUMENT = 1,
	UNITYTLS_INVALID_FORMAT = 2,
	UNITYTLS_INVALID_PASSWORD = 3,
	UNITYTLS_INVALID_STATE = 4,
	UNITYTLS_BUFFER_OVERFLOW = 5,
	UNITYTLS_OUT_OF_MEMORY = 6,
	UNITYTLS_INTERNAL_ERROR = 7,
	UNITYTLS_NOT_SUPPORTED = 8,
	UNITYTLS_ENTROPY_SOURCE_FAILED = 9,
	UNITYTLS_STREAM_CLOSED = 10,
	UNITYTLS_USER_CUSTOM_ERROR_START = 1048576,
	UNITYTLS_USER_WOULD_BLOCK = 1048577,
	UNITYTLS_USER_READ_FAILED = 1048578,
	UNITYTLS_USER_WRITE_FAILED = 1048579,
	UNITYTLS_USER_UNKNOWN_ERROR = 1048580,
	UNITYTLS_USER_CUSTOM_ERROR_END = 2097152,
}

public enum UnityTls.unitytls_x509verify_result
{
	UNITYTLS_X509VERIFY_SUCCESS = 0,
	UNITYTLS_X509VERIFY_NOT_DONE = 2147483648,
	UNITYTLS_X509VERIFY_FATAL_ERROR = 4294967295,
	UNITYTLS_X509VERIFY_FLAG_EXPIRED = 1,
	UNITYTLS_X509VERIFY_FLAG_REVOKED = 2,
	UNITYTLS_X509VERIFY_FLAG_CN_MISMATCH = 4,
	UNITYTLS_X509VERIFY_FLAG_NOT_TRUSTED = 8,
	UNITYTLS_X509VERIFY_FLAG_USER_ERROR1 = 65536,
	UNITYTLS_X509VERIFY_FLAG_USER_ERROR2 = 131072,
	UNITYTLS_X509VERIFY_FLAG_USER_ERROR3 = 262144,
	UNITYTLS_X509VERIFY_FLAG_USER_ERROR4 = 524288,
	UNITYTLS_X509VERIFY_FLAG_USER_ERROR5 = 1048576,
	UNITYTLS_X509VERIFY_FLAG_USER_ERROR6 = 2097152,
	UNITYTLS_X509VERIFY_FLAG_USER_ERROR7 = 4194304,
	UNITYTLS_X509VERIFY_FLAG_USER_ERROR8 = 8388608,
	UNITYTLS_X509VERIFY_FLAG_UNKNOWN_ERROR = 134217728,
}

public enum UnityTls.unitytls_ciphersuite
{
	UNITYTLS_CIPHERSUITE_INVALID = 16777215,
}

public enum UnityTls.unitytls_protocol
{
	UNITYTLS_PROTOCOL_TLS_1_0 = 0,
	UNITYTLS_PROTOCOL_TLS_1_1 = 1,
	UNITYTLS_PROTOCOL_TLS_1_2 = 2,
	UNITYTLS_PROTOCOL_INVALID = 3,
}

internal enum CFProxyType
{
	None = 0,
	AutoConfigurationUrl = 1,
	AutoConfigurationJavaScript = 2,
	FTP = 3,
	HTTP = 4,
	HTTPS = 5,
	SOCKS = 6,
}

internal enum AsyncOperationStatus
{
	Initialize = 0,
	Continue = 1,
	ReadDone = 2,
	Complete = 3,
}

private enum MobileAuthenticatedStream.OperationType
{
	Read = 0,
	Write = 1,
	Shutdown = 2,
}

public enum GenericUriParserOptions
{
	Default = 0,
	GenericAuthority = 1,
	AllowEmptyAuthority = 2,
	NoUserInfo = 4,
	NoPort = 8,
	NoQuery = 16,
	NoFragment = 32,
	DontConvertPathBackslashes = 64,
	DontCompressPath = 128,
	DontUnescapePathDotsAndSlashes = 256,
	Idn = 512,
	IriParsing = 1024,
}

private enum Uri.Flags
{
	Zero = 0,
	SchemeNotCanonical = 1,
	UserNotCanonical = 2,
	HostNotCanonical = 4,
	PortNotCanonical = 8,
	PathNotCanonical = 16,
	QueryNotCanonical = 32,
	FragmentNotCanonical = 64,
	CannotDisplayCanonical = 127,
	E_UserNotCanonical = 128,
	E_HostNotCanonical = 256,
	E_PortNotCanonical = 512,
	E_PathNotCanonical = 1024,
	E_QueryNotCanonical = 2048,
	E_FragmentNotCanonical = 4096,
	E_CannotDisplayCanonical = 8064,
	ShouldBeCompressed = 8192,
	FirstSlashAbsent = 16384,
	BackslashInPath = 32768,
	IndexMask = 65535,
	HostTypeMask = 458752,
	HostNotParsed = 0,
	IPv6HostType = 65536,
	IPv4HostType = 131072,
	DnsHostType = 196608,
	UncHostType = 262144,
	BasicHostType = 327680,
	UnusedHostType = 393216,
	UnknownHostType = 458752,
	UserEscaped = 524288,
	AuthorityFound = 1048576,
	HasUserInfo = 2097152,
	LoopbackHost = 4194304,
	NotDefaultPort = 8388608,
	UserDrivenParsing = 16777216,
	CanonicalDnsHost = 33554432,
	ErrorOrParsingRecursion = 67108864,
	DosPath = 134217728,
	UncPath = 268435456,
	ImplicitFile = 536870912,
	MinimalUriInfoSet = 1073741824,
	AllUriInfoSet = 2147483648,
	IdnHost = 4294967296,
	HasUnicode = 8589934592,
	HostUnicodeNormalized = 17179869184,
	RestUnicodeNormalized = 34359738368,
	UnicodeHost = 68719476736,
	IntranetUri = 137438953472,
	UseOrigUncdStrOffset = 274877906944,
	UserIriCanonical = 549755813888,
	PathIriCanonical = 1099511627776,
	QueryIriCanonical = 2199023255552,
	FragmentIriCanonical = 4398046511104,
	IriCanonical = 8246337208320,
	CompressedSlashes = 17592186044416,
}

private enum Uri.Check
{
	None = 0,
	EscapedCanonical = 1,
	DisplayCanonical = 2,
	DotSlashAttn = 4,
	DotSlashEscaped = 128,
	BackslashInPath = 16,
	ReservedFound = 32,
	NotIriCanonical = 64,
	FoundNonAscii = 8,
}

public enum UriPartial
{
	Scheme = 0,
	Authority = 1,
	Path = 2,
	Query = 3,
}

public enum UriKind
{
	RelativeOrAbsolute = 0,
	Absolute = 1,
	Relative = 2,
}

public enum UriComponents
{
	Scheme = 1,
	UserInfo = 2,
	Host = 4,
	Port = 8,
	Path = 16,
	Query = 32,
	Fragment = 64,
	StrongPort = 128,
	NormalizedHost = 256,
	KeepDelimiter = 1073741824,
	AbsoluteUri = 127,
	HostAndPort = 132,
	StrongAuthority = 134,
	SchemeAndServer = 13,
	HttpRequestUrl = 61,
	PathAndQuery = 48,
}

public enum UriFormat
{
	UriEscaped = 1,
	Unescaped = 2,
	SafeUnescaped = 3,
}

public enum UriIdnScope
{
	None = 0,
	AllExceptIntranet = 1,
	All = 2,
}

internal enum ParsingError
{
	None = 0,
	BadFormat = 1,
	BadScheme = 2,
	BadAuthority = 3,
	EmptyUriString = 4,
	LastRelativeUriOkErrIndex = 4,
	SchemeLimit = 5,
	SizeLimit = 6,
	MustRootedPath = 7,
	BadHostName = 8,
	NonEmptyHost = 9,
	BadPort = 10,
	BadAuthorityTerminator = 11,
	CannotCreateRelative = 12,
}

internal enum UnescapeMode
{
	CopyOnly = 0,
	Escape = 1,
	Unescape = 2,
	EscapeUnescape = 3,
	V1ToStringFlag = 4,
	UnescapeAll = 8,
	UnescapeAllOrThrow = 24,
}

public enum UriHostNameType
{
	Unknown = 0,
	Basic = 1,
	Dns = 2,
	IPv4 = 3,
	IPv6 = 4,
}

private enum UriParser.UriQuirksVersion
{
	V2 = 2,
	V3 = 3,
}

internal enum UriSyntaxFlags
{
	None = 0,
	MustHaveAuthority = 1,
	OptionalAuthority = 2,
	MayHaveUserInfo = 4,
	MayHavePort = 8,
	MayHavePath = 16,
	MayHaveQuery = 32,
	MayHaveFragment = 64,
	AllowEmptyHost = 128,
	AllowUncHost = 256,
	AllowDnsHost = 512,
	AllowIPv4Host = 1024,
	AllowIPv6Host = 2048,
	AllowAnInternetHost = 3584,
	AllowAnyOtherHost = 4096,
	FileLikeUri = 8192,
	MailToLikeUri = 16384,
	V1_UnknownUri = 65536,
	SimpleUserSyntax = 131072,
	BuiltInSyntax = 262144,
	ParserSchemeOnly = 524288,
	AllowDOSPath = 1048576,
	PathIsRooted = 2097152,
	ConvertPathSlashes = 4194304,
	CompressPath = 8388608,
	CanonicalizeAsFilePath = 16777216,
	UnEscapeDotsAndSlashes = 33554432,
	AllowIdn = 67108864,
	AllowIriParsing = 268435456,
}

internal enum IOOperation
{
	Read = 1,
	Write = 2,
}

public enum RegexOptions
{
	None = 0,
	IgnoreCase = 1,
	Multiline = 2,
	ExplicitCapture = 4,
	Compiled = 8,
	Singleline = 16,
	IgnorePatternWhitespace = 32,
	RightToLeft = 64,
	ECMAScript = 256,
	CultureInvariant = 512,
}

public enum TraceLevel
{
	Off = 0,
	Error = 1,
	Warning = 2,
	Info = 3,
	Verbose = 4,
}

private enum Process.StreamReadMode
{
	undefined = 0,
	syncMode = 1,
	asyncMode = 2,
}

private enum Process.State
{
	HaveId = 1,
	IsLocal = 2,
	IsNt = 4,
	HaveProcessInfo = 8,
	Exited = 16,
	Associated = 32,
	IsWin2k = 64,
	HaveNtProcessInfo = 12,
}

public enum ProcessWindowStyle
{
	Hidden = 1,
	Maximized = 3,
	Minimized = 2,
	Normal = 0,
}

public enum BindableSupport
{
	No = 0,
	Yes = 1,
	Default = 2,
}

public enum BindingDirection
{
	OneWay = 0,
	TwoWay = 1,
}

public enum CollectionChangeAction
{
	Add = 1,
	Remove = 2,
	Refresh = 3,
}

public enum DataObjectMethodType
{
	Fill = 0,
	Select = 1,
	Update = 2,
	Insert = 3,
	Delete = 4,
}

public enum DesignerSerializationVisibility
{
	Hidden = 0,
	Visible = 1,
	Content = 2,
}

public enum EditorBrowsableState
{
	Always = 0,
	Never = 1,
	Advanced = 2,
}

public enum LicenseUsageMode
{
	Runtime = 0,
	Designtime = 1,
}

public enum ListChangedType
{
	Reset = 0,
	ItemAdded = 1,
	ItemDeleted = 2,
	ItemMoved = 3,
	ItemChanged = 4,
	PropertyDescriptorAdded = 5,
	PropertyDescriptorDeleted = 6,
	PropertyDescriptorChanged = 7,
}

public enum ListSortDirection
{
	Ascending = 0,
	Descending = 1,
}

private enum MaskedTextProvider.CaseConversion
{
	None = 0,
	ToLower = 1,
	ToUpper = 2,
}

private enum MaskedTextProvider.CharType
{
	EditOptional = 1,
	EditRequired = 2,
	Separator = 4,
	Literal = 8,
	Modifier = 16,
}

public enum MaskedTextResultHint
{
	Unknown = 0,
	CharacterEscaped = 1,
	NoEffect = 2,
	SideEffect = 3,
	Success = 4,
}

public enum ToolboxItemFilterType
{
	Allow = 0,
	Custom = 1,
	Prevent = 2,
	Require = 3,
}

public enum InheritanceLevel
{
	Inherited = 1,
	InheritedReadOnly = 2,
	NotInherited = 3,
}

public enum PropertyTabScope
{
	Static = 0,
	Global = 1,
	Document = 2,
	Component = 3,
}

public enum RefreshProperties
{
	None = 0,
	All = 1,
	Repaint = 2,
}

public enum CipherAlgorithmType
{
	None = 0,
	Null = 24576,
	Aes = 26129,
	Aes128 = 26126,
	Aes192 = 26127,
	Aes256 = 26128,
	Des = 26113,
	Rc2 = 26114,
	Rc4 = 26625,
	TripleDes = 26115,
}

public enum ExchangeAlgorithmType
{
	None = 0,
	DiffieHellman = 43522,
	RsaKeyX = 41984,
	RsaSign = 9216,
}

public enum HashAlgorithmType
{
	None = 0,
	Md5 = 32771,
	Sha1 = 32772,
	Sha256 = 32780,
	Sha384 = 32781,
	Sha512 = 32782,
}

public enum SslProtocols
{
	None = 0,
	Ssl2 = 12,
	Ssl3 = 48,
	Tls = 192,
	Tls11 = 768,
	Tls12 = 3072,
	Default = 240,
}

public enum ChannelBindingKind
{
	Unknown = 0,
	Unique = 25,
	Endpoint = 26,
}

public enum PolicyEnforcement
{
	Never = 0,
	WhenSupported = 1,
	Always = 2,
}

public enum OidGroup
{
	All = 0,
	HashAlgorithm = 1,
	EncryptionAlgorithm = 2,
	PublicKeyAlgorithm = 3,
	SignatureAlgorithm = 4,
	Attribute = 5,
	ExtensionOrAttribute = 6,
	EnhancedKeyUsage = 7,
	Policy = 8,
	Template = 9,
	KeyDerivationFunction = 10,
}

internal enum AsnDecodeStatus
{
	Ok = 0,
	BadAsn = 1,
	BadTag = 2,
	BadLength = 3,
	InformationNotAvailable = 4,
}

public enum OpenFlags
{
	ReadOnly = 0,
	ReadWrite = 1,
	MaxAllowed = 2,
	OpenExistingOnly = 4,
	IncludeArchived = 8,
}

public enum StoreLocation
{
	CurrentUser = 1,
	LocalMachine = 2,
}

public enum StoreName
{
	AddressBook = 1,
	AuthRoot = 2,
	CertificateAuthority = 3,
	Disallowed = 4,
	My = 5,
	Root = 6,
	TrustedPeople = 7,
	TrustedPublisher = 8,
}

public enum X500DistinguishedNameFlags
{
	None = 0,
	Reversed = 1,
	UseSemicolons = 16,
	DoNotUsePlusSign = 32,
	DoNotUseQuotes = 64,
	UseCommas = 128,
	UseNewLines = 256,
	UseUTF8Encoding = 4096,
	UseT61Encoding = 8192,
	ForceUTF8Encoding = 16384,
}

public enum X509ChainStatusFlags
{
	NoError = 0,
	NotTimeValid = 1,
	NotTimeNested = 2,
	Revoked = 4,
	NotSignatureValid = 8,
	NotValidForUsage = 16,
	UntrustedRoot = 32,
	RevocationStatusUnknown = 64,
	Cyclic = 128,
	InvalidExtension = 256,
	InvalidPolicyConstraints = 512,
	InvalidBasicConstraints = 1024,
	InvalidNameConstraints = 2048,
	HasNotSupportedNameConstraint = 4096,
	HasNotDefinedNameConstraint = 8192,
	HasNotPermittedNameConstraint = 16384,
	HasExcludedNameConstraint = 32768,
	PartialChain = 65536,
	CtlNotTimeValid = 131072,
	CtlNotSignatureValid = 262144,
	CtlNotValidForUsage = 524288,
	OfflineRevocation = 16777216,
	NoIssuanceChainPolicy = 33554432,
	ExplicitDistrust = 67108864,
	HasNotSupportedCriticalExtension = 134217728,
	HasWeakSignature = 1048576,
}

public enum X509FindType
{
	FindByThumbprint = 0,
	FindBySubjectName = 1,
	FindBySubjectDistinguishedName = 2,
	FindByIssuerName = 3,
	FindByIssuerDistinguishedName = 4,
	FindBySerialNumber = 5,
	FindByTimeValid = 6,
	FindByTimeNotYetValid = 7,
	FindByTimeExpired = 8,
	FindByTemplateName = 9,
	FindByApplicationPolicy = 10,
	FindByCertificatePolicy = 11,
	FindByExtension = 12,
	FindByKeyUsage = 13,
	FindBySubjectKeyIdentifier = 14,
}

public enum X509IncludeOption
{
	None = 0,
	ExcludeRoot = 1,
	EndCertOnly = 2,
	WholeChain = 3,
}

public enum X509KeyUsageFlags
{
	None = 0,
	EncipherOnly = 1,
	CrlSign = 2,
	KeyCertSign = 4,
	KeyAgreement = 8,
	DataEncipherment = 16,
	KeyEncipherment = 32,
	NonRepudiation = 64,
	DigitalSignature = 128,
	DecipherOnly = 32768,
}

public enum X509NameType
{
	SimpleName = 0,
	EmailName = 1,
	UpnName = 2,
	DnsName = 3,
	DnsFromAlternativeName = 4,
	UrlName = 5,
}

public enum X509RevocationFlag
{
	EndCertificateOnly = 0,
	EntireChain = 1,
	ExcludeRoot = 2,
}

public enum X509RevocationMode
{
	NoCheck = 0,
	Online = 1,
	Offline = 2,
}

public enum X509SubjectKeyIdentifierHashAlgorithm
{
	Sha1 = 0,
	ShortSha1 = 1,
	CapiSha1 = 2,
}

public enum X509VerificationFlags
{
	NoFlag = 0,
	IgnoreNotTimeValid = 1,
	IgnoreCtlNotTimeValid = 2,
	IgnoreNotTimeNested = 4,
	IgnoreInvalidBasicConstraints = 8,
	AllowUnknownCertificateAuthority = 16,
	IgnoreWrongUsage = 32,
	IgnoreInvalidName = 64,
	IgnoreInvalidPolicy = 128,
	IgnoreEndRevocationUnknown = 256,
	IgnoreCtlSignerRevocationUnknown = 512,
	IgnoreCertificateAuthorityRevocationUnknown = 1024,
	IgnoreRootRevocationUnknown = 2048,
	AllFlags = 4095,
}

public enum OSX509Certificates.SecTrustResult
{
	Invalid = 0,
	Proceed = 1,
	Confirm = 2,
	Deny = 3,
	Unspecified = 4,
	RecoverableTrustFailure = 5,
	FatalTrustFailure = 6,
	ResultOtherError = 7,
}

public enum CompressionLevel
{
	Optimal = 0,
	Fastest = 1,
	NoCompression = 2,
}

public enum CompressionMode
{
	Decompress = 0,
	Compress = 1,
}

public enum NotifyCollectionChangedAction
{
	Add = 0,
	Remove = 1,
	Replace = 2,
	Move = 3,
	Reset = 4,
}

internal enum NodeColor
{
	Black = 0,
	Red = 1,
}

internal enum TreeRotation
{
	Left = 0,
	LeftRight = 1,
	Right = 2,
	RightLeft = 3,
}

public enum SecurityProtocolType
{
	SystemDefault = 0,
	Ssl3 = 48,
	Tls = 192,
	Tls11 = 768,
	Tls12 = 3072,
}

public enum AuthenticationSchemes
{
	None = 0,
	Digest = 1,
	Negotiate = 2,
	Ntlm = 4,
	Basic = 8,
	Anonymous = 32768,
	IntegratedWindowsAuthentication = 6,
}

public enum FtpStatusCode
{
	Undefined = 0,
	RestartMarker = 110,
	ServiceTemporarilyNotAvailable = 120,
	DataAlreadyOpen = 125,
	OpeningData = 150,
	CommandOK = 200,
	CommandExtraneous = 202,
	DirectoryStatus = 212,
	FileStatus = 213,
	SystemType = 215,
	SendUserCommand = 220,
	ClosingControl = 221,
	ClosingData = 226,
	EnteringPassive = 227,
	LoggedInProceed = 230,
	ServerWantsSecureSession = 234,
	FileActionOK = 250,
	PathnameCreated = 257,
	SendPasswordCommand = 331,
	NeedLoginAccount = 332,
	FileCommandPending = 350,
	ServiceNotAvailable = 421,
	CantOpenData = 425,
	ConnectionClosed = 426,
	ActionNotTakenFileUnavailableOrBusy = 450,
	ActionAbortedLocalProcessingError = 451,
	ActionNotTakenInsufficientSpace = 452,
	CommandSyntaxError = 500,
	ArgumentSyntaxError = 501,
	CommandNotImplemented = 502,
	BadCommandSequence = 503,
	NotLoggedIn = 530,
	AccountNeeded = 532,
	ActionNotTakenFileUnavailable = 550,
	ActionAbortedUnknownPageType = 551,
	FileActionAborted = 552,
	ActionNotTakenFilenameNotAllowed = 553,
}

private enum HttpListenerRequestUriBuilder.ParsingResult
{
	Success = 0,
	InvalidString = 1,
	EncodingError = 2,
}

private enum HttpListenerRequestUriBuilder.EncodingType
{
	Primary = 0,
	Secondary = 1,
}

public enum HttpRequestHeader
{
	CacheControl = 0,
	Connection = 1,
	Date = 2,
	KeepAlive = 3,
	Pragma = 4,
	Trailer = 5,
	TransferEncoding = 6,
	Upgrade = 7,
	Via = 8,
	Warning = 9,
	Allow = 10,
	ContentLength = 11,
	ContentType = 12,
	ContentEncoding = 13,
	ContentLanguage = 14,
	ContentLocation = 15,
	ContentMd5 = 16,
	ContentRange = 17,
	Expires = 18,
	LastModified = 19,
	Accept = 20,
	AcceptCharset = 21,
	AcceptEncoding = 22,
	AcceptLanguage = 23,
	Authorization = 24,
	Cookie = 25,
	Expect = 26,
	From = 27,
	Host = 28,
	IfMatch = 29,
	IfModifiedSince = 30,
	IfNoneMatch = 31,
	IfRange = 32,
	IfUnmodifiedSince = 33,
	MaxForwards = 34,
	ProxyAuthorization = 35,
	Referer = 36,
	Range = 37,
	Te = 38,
	Translate = 39,
	UserAgent = 40,
}

public enum HttpResponseHeader
{
	CacheControl = 0,
	Connection = 1,
	Date = 2,
	KeepAlive = 3,
	Pragma = 4,
	Trailer = 5,
	TransferEncoding = 6,
	Upgrade = 7,
	Via = 8,
	Warning = 9,
	Allow = 10,
	ContentLength = 11,
	ContentType = 12,
	ContentEncoding = 13,
	ContentLanguage = 14,
	ContentLocation = 15,
	ContentMd5 = 16,
	ContentRange = 17,
	Expires = 18,
	LastModified = 19,
	AcceptRanges = 20,
	Age = 21,
	ETag = 22,
	Location = 23,
	ProxyAuthenticate = 24,
	RetryAfter = 25,
	Server = 26,
	SetCookie = 27,
	Vary = 28,
	WwwAuthenticate = 29,
}

public enum HttpStatusCode
{
	Continue = 100,
	SwitchingProtocols = 101,
	OK = 200,
	Created = 201,
	Accepted = 202,
	NonAuthoritativeInformation = 203,
	NoContent = 204,
	ResetContent = 205,
	PartialContent = 206,
	MultipleChoices = 300,
	Ambiguous = 300,
	MovedPermanently = 301,
	Moved = 301,
	Found = 302,
	Redirect = 302,
	SeeOther = 303,
	RedirectMethod = 303,
	NotModified = 304,
	UseProxy = 305,
	Unused = 306,
	TemporaryRedirect = 307,
	RedirectKeepVerb = 307,
	BadRequest = 400,
	Unauthorized = 401,
	PaymentRequired = 402,
	Forbidden = 403,
	NotFound = 404,
	MethodNotAllowed = 405,
	NotAcceptable = 406,
	ProxyAuthenticationRequired = 407,
	RequestTimeout = 408,
	Conflict = 409,
	Gone = 410,
	LengthRequired = 411,
	PreconditionFailed = 412,
	RequestEntityTooLarge = 413,
	RequestUriTooLong = 414,
	UnsupportedMediaType = 415,
	RequestedRangeNotSatisfiable = 416,
	ExpectationFailed = 417,
	UpgradeRequired = 426,
	InternalServerError = 500,
	NotImplemented = 501,
	BadGateway = 502,
	ServiceUnavailable = 503,
	GatewayTimeout = 504,
	HttpVersionNotSupported = 505,
}

internal enum WindowsInstallationType
{
	Unknown = 0,
	Client = 1,
	Server = 2,
	ServerCore = 3,
	Embedded = 4,
}

internal enum SecurityStatus
{
	OK = 0,
	ContinueNeeded = 590610,
	CompleteNeeded = 590611,
	CompAndContinue = 590612,
	ContextExpired = 590615,
	CredentialsNeeded = 590624,
	Renegotiate = 590625,
}

internal enum ContentTypeValues
{
	ChangeCipherSpec = 20,
	Alert = 21,
	HandShake = 22,
	AppData = 23,
	Unrecognized = 255,
}

internal enum ContextAttribute
{
	Sizes = 0,
	Names = 1,
	Lifespan = 2,
	DceInfo = 3,
	StreamSizes = 4,
	Authority = 6,
	PackageInfo = 10,
	NegotiationInfo = 12,
	UniqueBindings = 25,
	EndpointBindings = 26,
	ClientSpecifiedSpn = 27,
	RemoteCertificate = 83,
	LocalCertificate = 84,
	RootStore = 85,
	IssuerListInfoEx = 89,
	ConnectionInfo = 90,
	UiInfo = 104,
}

internal enum Endianness
{
	Network = 0,
	Native = 16,
}

internal enum CredentialUse
{
	Inbound = 1,
	Outbound = 2,
	Both = 3,
}

internal enum BufferType
{
	Empty = 0,
	Data = 1,
	Token = 2,
	Parameters = 3,
	Missing = 4,
	Extra = 5,
	Trailer = 6,
	Header = 7,
	Padding = 9,
	Stream = 10,
	ChannelBindings = 14,
	TargetHost = 16,
	ReadOnlyWithChecksum = 268435456,
}

internal enum ChainPolicyType
{
	Base = 1,
	Authenticode = 2,
	Authenticode_TS = 3,
	SSL = 4,
	BasicConstraints = 5,
	NtAuth = 6,
}

internal enum IgnoreCertProblem
{
	not_time_valid = 1,
	ctl_not_time_valid = 2,
	not_time_nested = 4,
	invalid_basic_constraints = 8,
	all_not_time_valid = 7,
	allow_unknown_ca = 16,
	wrong_usage = 32,
	invalid_name = 64,
	invalid_policy = 128,
	end_rev_unknown = 256,
	ctl_signer_rev_unknown = 512,
	ca_rev_unknown = 1024,
	root_rev_unknown = 2048,
	all_rev_unknown = 3840,
	none = 4095,
}

internal enum CertUsage
{
	MatchTypeAnd = 0,
	MatchTypeOr = 1,
}

internal enum CertificateEncoding
{
	Zero = 0,
	X509AsnEncoding = 1,
	X509NdrEncoding = 2,
	Pkcs7AsnEncoding = 65536,
	Pkcs7NdrEncoding = 131072,
	AnyAsnEncoding = 65537,
}

internal enum CertificateProblem
{
	OK = 0,
}

internal enum HttpWriteMode
{
	Unknown = 0,
	ContentLength = 1,
	Chunked = 2,
	Buffer = 3,
	None = 4,
}

internal enum HttpBehaviour
{
	Unknown = 0,
	HTTP10 = 1,
	HTTP11PartiallyCompliant = 2,
	HTTP11 = 3,
}

internal enum HttpProcessingResult
{
	Continue = 0,
	ReadWait = 1,
	WriteWait = 2,
}

internal enum TriState
{
	False = 0,
	True = 1,
}

internal enum DefaultPorts
{
	DEFAULT_FTP_PORT = 21,
	DEFAULT_GOPHER_PORT = 70,
	DEFAULT_HTTP_PORT = 80,
	DEFAULT_HTTPS_PORT = 443,
	DEFAULT_NNTP_PORT = 119,
	DEFAULT_SMTP_PORT = 25,
	DEFAULT_TELNET_PORT = 23,
}

public enum NetworkAccess
{
	Accept = 128,
	Connect = 64,
}

public enum TransportType
{
	Udp = 1,
	Connectionless = 1,
	Tcp = 2,
	ConnectionOriented = 2,
	All = 3,
}

internal enum WebExceptionInternalStatus
{
	RequestFatal = 0,
	ServicePointFatal = 1,
	Recoverable = 2,
	Isolated = 3,
}

public enum WebExceptionStatus
{
	Success = 0,
	NameResolutionFailure = 1,
	ConnectFailure = 2,
	ReceiveFailure = 3,
	SendFailure = 4,
	PipelineFailure = 5,
	RequestCanceled = 6,
	ProtocolError = 7,
	ConnectionClosed = 8,
	TrustFailure = 9,
	SecureChannelFailure = 10,
	ServerProtocolViolation = 11,
	KeepAliveFailure = 12,
	Pending = 13,
	Timeout = 14,
	ProxyNameResolutionFailure = 15,
	UnknownError = 16,
	MessageLengthLimitExceeded = 17,
	CacheEntryNotFound = 18,
	RequestProhibitedByCachePolicy = 19,
	RequestProhibitedByProxy = 20,
}

internal enum WebHeaderCollectionType
{
	Unknown = 0,
	WebRequest = 1,
	WebResponse = 2,
	HttpWebRequest = 3,
	HttpWebResponse = 4,
	HttpListenerRequest = 5,
	HttpListenerResponse = 6,
	FtpWebRequest = 7,
	FtpWebResponse = 8,
	FileWebRequest = 9,
	FileWebResponse = 10,
}

private enum WebHeaderCollection.RfcChar
{
	High = 0,
	Reg = 1,
	Ctl = 2,
	CR = 3,
	LF = 4,
	WS = 5,
	Colon = 6,
	Delim = 7,
}

internal enum DataParseStatus
{
	NeedMoreData = 0,
	ContinueParsing = 1,
	Done = 2,
	Invalid = 3,
	DataTooBig = 4,
}

internal enum WriteBufferState
{
	Disabled = 0,
	Headers = 1,
	Buffer = 2,
	Playback = 3,
}

internal enum WebParseErrorSection
{
	Generic = 0,
	ResponseHeader = 1,
	ResponseStatusLine = 2,
	ResponseBody = 3,
}

internal enum WebParseErrorCode
{
	Generic = 0,
	InvalidHeaderName = 1,
	InvalidContentLength = 2,
	IncompleteHeaderLine = 3,
	CrLfError = 4,
	InvalidChunkFormat = 5,
	UnexpectedServerResponse = 6,
}

internal enum CloseExState
{
	Normal = 0,
	Abort = 1,
	Silent = 2,
}

internal enum ThreadKinds
{
	Unknown = 0,
	User = 1,
	System = 2,
	Sync = 4,
	Async = 8,
	Timer = 16,
	CompletionPort = 32,
	Worker = 64,
	Finalization = 128,
	Other = 256,
	OwnerMask = 3,
	SyncMask = 12,
	SourceMask = 496,
	SafeSources = 352,
	ThreadPool = 96,
}

private enum TimerThread.TimerThreadState
{
	Idle = 0,
	Running = 1,
	Stopped = 2,
}

private enum TimerThread.TimerNode.TimerState
{
	Ready = 0,
	Fired = 1,
	Cancelled = 2,
	Sentinel = 3,
}

private enum ConnectionPool.State
{
	Initializing = 0,
	Running = 1,
	ShuttingDown = 2,
}

internal enum CookieVariant
{
	Unknown = 0,
	Plain = 1,
	Rfc2109 = 2,
	Rfc2965 = 3,
	Default = 2,
}

internal enum CookieToken
{
	Nothing = 0,
	NameValuePair = 1,
	Attribute = 2,
	EndToken = 3,
	EndCookie = 4,
	End = 5,
	Equals = 6,
	Comment = 7,
	CommentUrl = 8,
	CookieName = 9,
	Discard = 10,
	Domain = 11,
	Expires = 12,
	MaxAge = 13,
	Path = 14,
	Port = 15,
	Secure = 16,
	HttpOnly = 17,
	Unknown = 18,
	Version = 19,
}

internal enum CookieCollection.Stamp
{
	Check = 0,
	Set = 1,
	SetToUnused = 2,
	SetToMaxUsed = 3,
}

internal enum UnsafeNclNativeMethods.HttpApi.Enum
{
	HttpHeaderCacheControl = 0,
	HttpHeaderConnection = 1,
	HttpHeaderDate = 2,
	HttpHeaderKeepAlive = 3,
	HttpHeaderPragma = 4,
	HttpHeaderTrailer = 5,
	HttpHeaderTransferEncoding = 6,
	HttpHeaderUpgrade = 7,
	HttpHeaderVia = 8,
	HttpHeaderWarning = 9,
	HttpHeaderAllow = 10,
	HttpHeaderContentLength = 11,
	HttpHeaderContentType = 12,
	HttpHeaderContentEncoding = 13,
	HttpHeaderContentLanguage = 14,
	HttpHeaderContentLocation = 15,
	HttpHeaderContentMd5 = 16,
	HttpHeaderContentRange = 17,
	HttpHeaderExpires = 18,
	HttpHeaderLastModified = 19,
	HttpHeaderAcceptRanges = 20,
	HttpHeaderAge = 21,
	HttpHeaderEtag = 22,
	HttpHeaderLocation = 23,
	HttpHeaderProxyAuthenticate = 24,
	HttpHeaderRetryAfter = 25,
	HttpHeaderServer = 26,
	HttpHeaderSetCookie = 27,
	HttpHeaderVary = 28,
	HttpHeaderWwwAuthenticate = 29,
	HttpHeaderResponseMaximum = 30,
	HttpHeaderMaximum = 41,
}

public enum DecompressionMethods
{
	None = 0,
	GZip = 1,
	Deflate = 2,
}

private enum FtpWebRequest.RequestState
{
	Before = 0,
	Scheduled = 1,
	Connecting = 2,
	Authenticating = 3,
	OpeningData = 4,
	TransferInProgress = 5,
	Finished = 6,
	Aborted = 7,
	Error = 8,
}

private enum HttpConnection.InputState
{
	RequestLine = 0,
	Headers = 1,
}

private enum HttpConnection.LineState
{
	None = 0,
	CR = 1,
	LF = 2,
}

private enum HttpWebRequest.NtlmAuthState
{
	None = 0,
	Challenge = 1,
	Response = 2,
}

private enum MonoChunkStream.State
{
	None = 0,
	PartialSize = 1,
	Body = 2,
	BodyFinished = 3,
	Trailer = 4,
}

private enum WebCompletionSource.State
{
	Running = 0,
	Completed = 1,
	Canceled = 2,
	Faulted = 3,
}

internal enum ReadState
{
	None = 0,
	Status = 1,
	Headers = 2,
	Content = 3,
	Aborted = 4,
}

private enum WebConnectionTunnel.NtlmAuthState
{
	None = 0,
	Challenge = 1,
	Response = 2,
}

public enum SmtpDeliveryFormat
{
	SevenBit = 0,
	International = 1,
}

public enum SmtpDeliveryMethod
{
	Network = 0,
	SpecifiedPickupDirectory = 1,
	PickupDirectoryFromIis = 2,
}

public enum AddressFamily
{
	Unspecified = 0,
	Unix = 1,
	InterNetwork = 2,
	ImpLink = 3,
	Pup = 4,
	Chaos = 5,
	NS = 6,
	Ipx = 6,
	Iso = 7,
	Osi = 7,
	Ecma = 8,
	DataKit = 9,
	Ccitt = 10,
	Sna = 11,
	DecNet = 12,
	DataLink = 13,
	Lat = 14,
	HyperChannel = 15,
	AppleTalk = 16,
	NetBios = 17,
	VoiceView = 18,
	FireFox = 19,
	Banyan = 21,
	Atm = 22,
	InterNetworkV6 = 23,
	Cluster = 24,
	Ieee12844 = 25,
	Irda = 26,
	NetworkDesigners = 28,
	Max = 29,
}

public enum IOControlCode
{
	AsyncIO = 2147772029,
	NonBlockingIO = 2147772030,
	DataToRead = 1074030207,
	OobDataRead = 1074033415,
	AssociateHandle = 2281701377,
	EnableCircularQueuing = 671088642,
	Flush = 671088644,
	GetBroadcastAddress = 1207959557,
	GetExtensionFunctionPointer = 3355443206,
	GetQos = 3355443207,
	GetGroupQos = 3355443208,
	MultipointLoopback = 2281701385,
	MulticastScope = 2281701386,
	SetQos = 2281701387,
	SetGroupQos = 2281701388,
	TranslateHandle = 3355443213,
	RoutingInterfaceQuery = 3355443220,
	RoutingInterfaceChange = 2281701397,
	AddressListQuery = 1207959574,
	AddressListChange = 671088663,
	QueryTargetPnpHandle = 1207959576,
	NamespaceChange = 2281701401,
	AddressListSort = 3355443225,
	ReceiveAll = 2550136833,
	ReceiveAllMulticast = 2550136834,
	ReceiveAllIgmpMulticast = 2550136835,
	KeepAliveValues = 2550136836,
	AbsorbRouterAlert = 2550136837,
	UnicastInterface = 2550136838,
	LimitBroadcasts = 2550136839,
	BindToInterface = 2550136840,
	MulticastInterface = 2550136841,
	AddMulticastGroupOnInterface = 2550136842,
	DeleteMulticastGroupFromInterface = 2550136843,
}

public enum IPProtectionLevel
{
	Unrestricted = 10,
	EdgeRestricted = 20,
	Restricted = 30,
}

public enum ProtocolFamily
{
	Unspecified = 0,
	Unix = 1,
	InterNetwork = 2,
	ImpLink = 3,
	Pup = 4,
	Chaos = 5,
	NS = 6,
	Ipx = 6,
	Iso = 7,
	Osi = 7,
	Ecma = 8,
	DataKit = 9,
	Ccitt = 10,
	Sna = 11,
	DecNet = 12,
	DataLink = 13,
	Lat = 14,
	HyperChannel = 15,
	AppleTalk = 16,
	NetBios = 17,
	VoiceView = 18,
	FireFox = 19,
	Banyan = 21,
	Atm = 22,
	InterNetworkV6 = 23,
	Cluster = 24,
	Ieee12844 = 25,
	Irda = 26,
	NetworkDesigners = 28,
	Max = 29,
}

public enum ProtocolType
{
	IP = 0,
	IPv6HopByHopOptions = 0,
	Icmp = 1,
	Igmp = 2,
	Ggp = 3,
	IPv4 = 4,
	Tcp = 6,
	Pup = 12,
	Udp = 17,
	Idp = 22,
	IPv6 = 41,
	IPv6RoutingHeader = 43,
	IPv6FragmentHeader = 44,
	IPSecEncapsulatingSecurityPayload = 50,
	IPSecAuthenticationHeader = 51,
	IcmpV6 = 58,
	IPv6NoNextHeader = 59,
	IPv6DestinationOptions = 60,
	ND = 77,
	Raw = 255,
	Unspecified = 0,
	Ipx = 1000,
	Spx = 1256,
	SpxII = 1257,
}

public enum SelectMode
{
	SelectRead = 0,
	SelectWrite = 1,
	SelectError = 2,
}

public enum SocketAsyncOperation
{
	None = 0,
	Accept = 1,
	Connect = 2,
	Disconnect = 3,
	Receive = 4,
	ReceiveFrom = 5,
	ReceiveMessageFrom = 6,
	Send = 7,
	SendPackets = 8,
	SendTo = 9,
}

public enum SocketClientAccessPolicyProtocol
{
	Tcp = 0,
	Http = 1,
}

public enum SocketError
{
	Success = 0,
	Interrupted = 10004,
	AccessDenied = 10013,
	Fault = 10014,
	InvalidArgument = 10022,
	TooManyOpenSockets = 10024,
	WouldBlock = 10035,
	InProgress = 10036,
	AlreadyInProgress = 10037,
	NotSocket = 10038,
	DestinationAddressRequired = 10039,
	MessageSize = 10040,
	ProtocolType = 10041,
	ProtocolOption = 10042,
	ProtocolNotSupported = 10043,
	SocketNotSupported = 10044,
	OperationNotSupported = 10045,
	ProtocolFamilyNotSupported = 10046,
	AddressFamilyNotSupported = 10047,
	AddressAlreadyInUse = 10048,
	AddressNotAvailable = 10049,
	NetworkDown = 10050,
	NetworkUnreachable = 10051,
	NetworkReset = 10052,
	ConnectionAborted = 10053,
	ConnectionReset = 10054,
	NoBufferSpaceAvailable = 10055,
	IsConnected = 10056,
	NotConnected = 10057,
	Shutdown = 10058,
	TimedOut = 10060,
	ConnectionRefused = 10061,
	HostDown = 10064,
	HostUnreachable = 10065,
	ProcessLimit = 10067,
	SystemNotReady = 10091,
	VersionNotSupported = 10092,
	NotInitialized = 10093,
	Disconnecting = 10101,
	TypeNotFound = 10109,
	HostNotFound = 11001,
	TryAgain = 11002,
	NoRecovery = 11003,
	NoData = 11004,
	IOPending = 997,
	OperationAborted = 995,
}

public enum SocketFlags
{
	None = 0,
	OutOfBand = 1,
	Peek = 2,
	DontRoute = 4,
	MaxIOVectorLength = 16,
	Truncated = 256,
	ControlDataTruncated = 512,
	Broadcast = 1024,
	Multicast = 2048,
	Partial = 32768,
}

public enum SocketInformationOptions
{
	NonBlocking = 1,
	Connected = 2,
	Listening = 4,
	UseOnlyOverlappedIO = 8,
}

public enum SocketOptionLevel
{
	Socket = 65535,
	IP = 0,
	IPv6 = 41,
	Tcp = 6,
	Udp = 17,
}

public enum SocketOptionName
{
	Debug = 1,
	AcceptConnection = 2,
	ReuseAddress = 4,
	KeepAlive = 8,
	DontRoute = 16,
	Broadcast = 32,
	UseLoopback = 64,
	Linger = 128,
	OutOfBandInline = 256,
	SendBuffer = 4097,
	ReceiveBuffer = 4098,
	SendLowWater = 4099,
	ReceiveLowWater = 4100,
	SendTimeout = 4101,
	ReceiveTimeout = 4102,
	Error = 4103,
	Type = 4104,
	ReuseUnicastPort = 12295,
	MaxConnections = 2147483647,
	IPOptions = 1,
	HeaderIncluded = 2,
	TypeOfService = 3,
	IpTimeToLive = 4,
	MulticastInterface = 9,
	MulticastTimeToLive = 10,
	MulticastLoopback = 11,
	AddMembership = 12,
	DropMembership = 13,
	DontFragment = 14,
	AddSourceMembership = 15,
	DropSourceMembership = 16,
	BlockSource = 17,
	UnblockSource = 18,
	PacketInformation = 19,
	HopLimit = 21,
	IPProtectionLevel = 23,
	IPv6Only = 27,
	NoDelay = 1,
	BsdUrgent = 2,
	Expedited = 2,
	NoChecksum = 1,
	ChecksumCoverage = 20,
	UpdateAcceptContext = 28683,
	UpdateConnectContext = 28688,
}

public enum SocketShutdown
{
	Receive = 0,
	Send = 1,
	Both = 2,
}

public enum SocketType
{
	Stream = 1,
	Dgram = 2,
	Raw = 3,
	Rdm = 4,
	Seqpacket = 5,
}

public enum TransmitFileOptions
{
	UseDefaultWorkerThread = 0,
	Disconnect = 1,
	ReuseSocket = 2,
	WriteBehind = 4,
	UseSystemThread = 16,
	UseKernelApc = 32,
}

private enum MultipleConnectAsync.State
{
	NotStarted = 0,
	DnsQuery = 1,
	ConnectAttempt = 2,
	Completed = 3,
	Canceled = 4,
}

internal enum SocketOperation
{
	Accept = 0,
	Connect = 1,
	Receive = 2,
	ReceiveFrom = 3,
	Send = 4,
	SendTo = 5,
	RecvJustCallback = 6,
	SendJustCallback = 7,
	Disconnect = 8,
	AcceptReceive = 9,
	ReceiveGeneric = 10,
	SendGeneric = 11,
}

public enum AuthenticationLevel
{
	None = 0,
	MutualAuthRequested = 1,
	MutualAuthRequired = 2,
}

public enum ProtectionLevel
{
	None = 0,
	Sign = 1,
	EncryptAndSign = 2,
}

public enum EncryptionPolicy
{
	RequireEncryption = 0,
	AllowNoEncryption = 1,
	NoEncryption = 2,
}

public enum SslPolicyErrors
{
	None = 0,
	RemoteCertificateNotAvailable = 1,
	RemoteCertificateNameMismatch = 2,
	RemoteCertificateChainErrors = 4,
}

public enum DuplicateAddressDetectionState
{
	Invalid = 0,
	Tentative = 1,
	Duplicate = 2,
	Deprecated = 3,
	Preferred = 4,
}

internal enum IcmpV4Type
{
	ICMP4_ECHO_REPLY = 0,
	ICMP4_DST_UNREACH = 3,
	ICMP4_SOURCE_QUENCH = 4,
	ICMP4_TIME_EXCEEDED = 11,
	ICMP4_PARAM_PROB = 12,
	ICMP4_REDIRECT = 5,
	ICMP4_ECHO_REQUEST = 8,
	ICMP4_ROUTER_ADVERT = 9,
	ICMP4_ROUTER_SOLICIT = 10,
	ICMP4_TIMESTAMP_REQUEST = 13,
	ICMP4_TIMESTAMP_REPLY = 14,
	ICMP4_MASK_REQUEST = 17,
	ICMP4_MASK_REPLY = 18,
}

internal enum IcmpV4Code
{
	ICMP4_UNREACH_NET = 0,
	ICMP4_UNREACH_HOST = 1,
	ICMP4_UNREACH_PROTOCOL = 2,
	ICMP4_UNREACH_PORT = 3,
	ICMP4_UNREACH_FRAG_NEEDED = 4,
	ICMP4_UNREACH_SOURCEROUTE_FAILED = 5,
	ICMP4_UNREACH_NET_UNKNOWN = 6,
	ICMP4_UNREACH_HOST_UNKNOWN = 7,
	ICMP4_UNREACH_ISOLATED = 8,
	ICMP4_UNREACH_NET_ADMIN = 9,
	ICMP4_UNREACH_HOST_ADMIN = 10,
	ICMP4_UNREACH_NET_TOS = 11,
	ICMP4_UNREACH_HOST_TOS = 12,
	ICMP4_UNREACH_ADMIN = 13,
}

public enum IPStatus
{
	Success = 0,
	DestinationNetworkUnreachable = 11002,
	DestinationHostUnreachable = 11003,
	DestinationProtocolUnreachable = 11004,
	DestinationPortUnreachable = 11005,
	DestinationProhibited = 11004,
	NoResources = 11006,
	BadOption = 11007,
	HardwareError = 11008,
	PacketTooBig = 11009,
	TimedOut = 11010,
	BadRoute = 11012,
	TtlExpired = 11013,
	TtlReassemblyTimeExceeded = 11014,
	ParameterProblem = 11015,
	SourceQuench = 11016,
	BadDestination = 11018,
	DestinationUnreachable = 11040,
	TimeExceeded = 11041,
	BadHeader = 11042,
	UnrecognizedNextHeader = 11043,
	IcmpError = 11044,
	DestinationScopeMismatch = 11045,
}

internal enum StartIPOptions
{
	Both = 3,
	None = 0,
	StartIPv4 = 1,
	StartIPv6 = 2,
}

public enum NetworkInformationAccess
{
	None = 0,
	Read = 1,
	Ping = 4,
}

public enum NetworkInterfaceComponent
{
	IPv4 = 0,
	IPv6 = 1,
}

public enum OperationalStatus
{
	Up = 1,
	Down = 2,
	Testing = 3,
	Unknown = 4,
	Dormant = 5,
	NotPresent = 6,
	LowerLayerDown = 7,
}

public enum PrefixOrigin
{
	Other = 0,
	Manual = 1,
	WellKnown = 2,
	Dhcp = 3,
	RouterAdvertisement = 4,
}

public enum ScopeLevel
{
	None = 0,
	Interface = 1,
	Link = 2,
	Subnet = 3,
	Admin = 4,
	Site = 5,
	Organization = 8,
	Global = 14,
}

public enum SuffixOrigin
{
	Other = 0,
	Manual = 1,
	WellKnown = 2,
	OriginDhcp = 3,
	LinkLayerAddress = 4,
	Random = 5,
}

public enum TcpState
{
	Unknown = 0,
	Closed = 1,
	Listen = 2,
	SynSent = 3,
	SynReceived = 4,
	Established = 5,
	FinWait1 = 6,
	FinWait2 = 7,
	CloseWait = 8,
	Closing = 9,
	LastAck = 10,
	TimeWait = 11,
	DeleteTcb = 12,
}

public enum NetworkInterfaceType
{
	Unknown = 1,
	Ethernet = 6,
	TokenRing = 9,
	Fddi = 15,
	BasicIsdn = 20,
	PrimaryIsdn = 21,
	Ppp = 23,
	Loopback = 24,
	Ethernet3Megabit = 26,
	Slip = 28,
	Atm = 37,
	GenericModem = 48,
	FastEthernetT = 62,
	Isdn = 63,
	FastEthernetFx = 69,
	Wireless80211 = 71,
	AsymmetricDsl = 94,
	RateAdaptDsl = 95,
	SymmetricDsl = 96,
	VeryHighSpeedDsl = 97,
	IPOverAtm = 114,
	GigabitEthernet = 117,
	Tunnel = 131,
	MultiRateSymmetricDsl = 143,
	HighPerformanceSerialBus = 144,
	Wman = 237,
	Wwanpp = 243,
	Wwanpp2 = 244,
}

public enum NetBiosNodeType
{
	Unknown = 0,
	Broadcast = 1,
	Peer2Peer = 2,
	Mixed = 4,
	Hybrid = 8,
}

internal enum LinuxArpHardware
{
	ETHER = 1,
	EETHER = 2,
	PRONET = 4,
	ATM = 19,
	SLIP = 256,
	CSLIP = 257,
	SLIP6 = 258,
	CSLIP6 = 259,
	PPP = 512,
	LOOPBACK = 772,
	FDDI = 774,
	TUNNEL = 768,
	TUNNEL6 = 769,
	SIT = 776,
	IPDDP = 777,
	IPGRE = 778,
	IP6GRE = 823,
}

internal enum MacOsArpHardware
{
	ETHER = 6,
	ATM = 37,
	SLIP = 28,
	PPP = 23,
	LOOPBACK = 24,
	FDDI = 15,
}

internal enum MacOsInterfaceFlags
{
	IFF_UP = 1,
	IFF_BROADCAST = 2,
	IFF_DEBUG = 4,
	IFF_LOOPBACK = 8,
	IFF_POINTOPOINT = 16,
	IFF_NOTRAILERS = 32,
	IFF_RUNNING = 64,
	IFF_NOARP = 128,
	IFF_PROMISC = 256,
	IFF_ALLMULTI = 512,
	IFF_OACTIVE = 1024,
	IFF_SIMPLEX = 2048,
	IFF_LINK0 = 4096,
	IFF_LINK1 = 8192,
	IFF_LINK2 = 16384,
	IFF_MULTICAST = 32768,
}

private enum MacNetworkChange.NetworkReachabilityFlags
{
	None = 0,
	TransientConnection = 1,
	Reachable = 2,
	ConnectionRequired = 4,
	ConnectionOnTraffic = 8,
	InterventionRequired = 16,
	ConnectionOnDemand = 32,
	IsLocalAddress = 65536,
	IsDirect = 131072,
	IsWWAN = 262144,
	ConnectionAutomatic = 8,
}

private enum LinuxNetworkChange.EventType
{
	Availability = 1,
	Address = 2,
}

public enum UnicodeDecodingConformance
{
	Auto = 0,
	Strict = 1,
	Compat = 2,
	Loose = 3,
}

public enum UnicodeEncodingConformance
{
	Auto = 0,
	Strict = 1,
	Compat = 2,
}

public enum RequestCacheLevel
{
	Default = 0,
	BypassCache = 1,
	CacheOnly = 2,
	CacheIfAvailable = 3,
	Revalidate = 4,
	Reload = 5,
	NoCacheNoStore = 6,
}

public enum HttpRequestCacheLevel
{
	Default = 0,
	BypassCache = 1,
	CacheOnly = 2,
	CacheIfAvailable = 3,
	Revalidate = 4,
	Reload = 5,
	NoCacheNoStore = 6,
	CacheOrNextCacheOnly = 7,
	Refresh = 8,
}

public enum SettingsSerializeAs
{
	Binary = 2,
	ProviderSpecific = 3,
	String = 0,
	Xml = 1,
}

public enum ProxyElement.AutoDetectValues
{
	False = 0,
	True = 1,
}

public enum ProxyElement.BypassOnLocalValues
{
	False = 0,
	True = 1,
}

public enum ProxyElement.UseSystemDefaultValues
{
	False = 0,
	True = 1,
}

public enum SettingsManageability
{
	Roaming = 0,
}

public enum SpecialSetting
{
	ConnectionString = 0,
	WebServiceUrl = 1,
}

public enum LockRecursionPolicy
{
	NoRecursion = 0,
	SupportsRecursion = 1,
}

internal enum AsymmetricPaddingMode
{
	None = 1,
	Pkcs1 = 2,
	Oaep = 4,
	Pss = 8,
}

internal enum HASHALGORITHM_ENUM
{
	DSA_HASH_ALGORITHM_SHA1 = 0,
	DSA_HASH_ALGORITHM_SHA256 = 1,
	DSA_HASH_ALGORITHM_SHA512 = 2,
}

internal enum DSAFIPSVERSION_ENUM
{
	DSA_FIPS186_2 = 0,
	DSA_FIPS186_3 = 1,
}

public enum CngKeyHandleOpenOptions
{
	None = 0,
	EphemeralKey = 1,
}

public enum ECKeyXmlFormat
{
	Rfc4050 = 0,
}

public enum CngExportPolicies
{
	None = 0,
	AllowExport = 1,
	AllowPlaintextExport = 2,
	AllowArchiving = 4,
	AllowPlaintextArchiving = 8,
}

public enum CngKeyCreationOptions
{
	None = 0,
	MachineKey = 32,
	OverwriteExistingKey = 128,
}

public enum CngKeyOpenOptions
{
	None = 0,
	UserKey = 0,
	MachineKey = 32,
	Silent = 64,
}

internal enum CngKeyTypes
{
	None = 0,
	MachineKey = 32,
}

public enum CngKeyUsages
{
	None = 0,
	Decryption = 1,
	Signing = 2,
	KeyAgreement = 4,
	AllUsages = 16777215,
}

public enum CngPropertyOptions
{
	None = 0,
	CustomProperty = 1073741824,
}

public enum CngUIProtectionLevels
{
	None = 0,
	ProtectKey = 1,
	ForceHighProtection = 2,
}

public enum ECCurve.ECCurveType
{
	Implicit = 0,
	PrimeShortWeierstrass = 1,
	PrimeTwistedEdwards = 2,
	PrimeMontgomery = 3,
	Characteristic2 = 4,
	Named = 5,
}

internal enum AnalyzeTypeIsResult
{
	KnownFalse = 0,
	KnownTrue = 1,
	KnownAssignable = 2,
	Unknown = 3,
}

public enum ExpressionType
{
	Add = 0,
	AddChecked = 1,
	And = 2,
	AndAlso = 3,
	ArrayLength = 4,
	ArrayIndex = 5,
	Call = 6,
	Coalesce = 7,
	Conditional = 8,
	Constant = 9,
	Convert = 10,
	ConvertChecked = 11,
	Divide = 12,
	Equal = 13,
	ExclusiveOr = 14,
	GreaterThan = 15,
	GreaterThanOrEqual = 16,
	Invoke = 17,
	Lambda = 18,
	LeftShift = 19,
	LessThan = 20,
	LessThanOrEqual = 21,
	ListInit = 22,
	MemberAccess = 23,
	MemberInit = 24,
	Modulo = 25,
	Multiply = 26,
	MultiplyChecked = 27,
	Negate = 28,
	UnaryPlus = 29,
	NegateChecked = 30,
	New = 31,
	NewArrayInit = 32,
	NewArrayBounds = 33,
	Not = 34,
	NotEqual = 35,
	Or = 36,
	OrElse = 37,
	Parameter = 38,
	Power = 39,
	Quote = 40,
	RightShift = 41,
	Subtract = 42,
	SubtractChecked = 43,
	TypeAs = 44,
	TypeIs = 45,
	Assign = 46,
	Block = 47,
	DebugInfo = 48,
	Decrement = 49,
	Dynamic = 50,
	Default = 51,
	Extension = 52,
	Goto = 53,
	Increment = 54,
	Index = 55,
	Label = 56,
	RuntimeVariables = 57,
	Loop = 58,
	Switch = 59,
	Throw = 60,
	Try = 61,
	Unbox = 62,
	AddAssign = 63,
	AndAssign = 64,
	DivideAssign = 65,
	ExclusiveOrAssign = 66,
	LeftShiftAssign = 67,
	ModuloAssign = 68,
	MultiplyAssign = 69,
	OrAssign = 70,
	PowerAssign = 71,
	RightShiftAssign = 72,
	SubtractAssign = 73,
	AddAssignChecked = 74,
	MultiplyAssignChecked = 75,
	SubtractAssignChecked = 76,
	PreIncrementAssign = 77,
	PreDecrementAssign = 78,
	PostIncrementAssign = 79,
	PostDecrementAssign = 80,
	TypeEqual = 81,
	OnesComplement = 82,
	IsTrue = 83,
	IsFalse = 84,
}

public enum GotoExpressionKind
{
	Goto = 0,
	Return = 1,
	Break = 2,
	Continue = 3,
}

public enum MemberBindingType
{
	Assignment = 0,
	MemberBinding = 1,
	ListBinding = 2,
}

internal enum LabelScopeKind
{
	Statement = 0,
	Block = 1,
	Switch = 2,
	Lambda = 3,
	Try = 4,
	Catch = 5,
	Finally = 6,
	Filter = 7,
	Expression = 8,
}

public enum ManifestKinds
{
	Application = 2,
	ApplicationAndDeployment = 3,
	Deployment = 1,
	None = 0,
}

public enum ECDiffieHellmanKeyDerivationFunction
{
	Hash = 0,
	Hmac = 1,
	Tls = 2,
}

public enum SignatureVerificationResult
{
	AssemblyIdentityMismatch = 1,
	ContainingSignatureInvalid = 2,
	PublicKeyTokenMismatch = 3,
	PublisherMismatch = 4,
	Valid = 0,
}

internal enum TargetType
{
	Function = 0,
	Field = 1,
}

internal enum CodegenOptions
{
	Auto = 0,
	Custom = 1,
	Force = 2,
}

internal enum StaticAccessorType
{
	Dot = 0,
	Arrow = 1,
	DoubleColon = 2,
	ArrowWithDefaultReturnIfNull = 3,
}

internal enum LightmapType
{
	StaticLightmap = 0,
	DynamicLightmap = 1,
}

public enum TypeInferenceRules
{
	TypeReferencedByFirstArgument = 0,
	TypeReferencedBySecondArgument = 1,
	ArrayOfTypeReferencedByFirstArgument = 2,
	TypeOfFirstArgument = 3,
}

public enum FileState
{
	Absent = 0,
	Exists = 1,
}

public enum AssetLoadingSubsystem
{
	Other = 0,
	Texture = 1,
	VirtualTexture = 2,
	Mesh = 3,
	Audio = 4,
	Scripts = 5,
	EntitiesScene = 6,
	EntitiesStreamBinaryReader = 7,
	FileInfo = 8,
}

public enum Priority
{
	PriorityLow = 0,
	PriorityHigh = 1,
}

public enum ProcessingState
{
	Unknown = 0,
	InQueue = 1,
	Reading = 2,
	Completed = 3,
	Failed = 4,
	Canceled = 5,
}

public enum FileReadType
{
	Sync = 0,
	Async = 1,
}

public enum Allocator
{
	Invalid = 0,
	None = 1,
	Temp = 2,
	TempJob = 3,
	Persistent = 4,
	AudioKernel = 5,
}

public enum SendMessageOptions
{
	RequireReceiver = 0,
	DontRequireReceiver = 1,
}

public enum PrimitiveType
{
	Sphere = 0,
	Capsule = 1,
	Cylinder = 2,
	Cube = 3,
	Plane = 4,
	Quad = 5,
}

public enum Space
{
	World = 0,
	Self = 1,
}

public enum RuntimePlatform
{
	OSXEditor = 0,
	OSXPlayer = 1,
	WindowsPlayer = 2,
	OSXWebPlayer = 3,
	OSXDashboardPlayer = 4,
	WindowsWebPlayer = 5,
	WindowsEditor = 7,
	IPhonePlayer = 8,
	XBOX360 = 10,
	PS3 = 9,
	Android = 11,
	NaCl = 12,
	FlashPlayer = 15,
	LinuxPlayer = 13,
	LinuxEditor = 16,
	WebGLPlayer = 17,
	MetroPlayerX86 = 18,
	WSAPlayerX86 = 18,
	MetroPlayerX64 = 19,
	WSAPlayerX64 = 19,
	MetroPlayerARM = 20,
	WSAPlayerARM = 20,
	WP8Player = 21,
	BlackBerryPlayer = 22,
	TizenPlayer = 23,
	PSP2 = 24,
	PS4 = 25,
	PSM = 26,
	XboxOne = 27,
	SamsungTVPlayer = 28,
	WiiU = 30,
	tvOS = 31,
	Switch = 32,
	Lumin = 33,
	Stadia = 34,
	CloudRendering = 35,
	GameCoreScarlett = 36,
	GameCoreXboxSeries = 36,
	GameCoreXboxOne = 37,
	PS5 = 38,
}

public enum SystemLanguage
{
	Afrikaans = 0,
	Arabic = 1,
	Basque = 2,
	Belarusian = 3,
	Bulgarian = 4,
	Catalan = 5,
	Chinese = 6,
	Czech = 7,
	Danish = 8,
	Dutch = 9,
	English = 10,
	Estonian = 11,
	Faroese = 12,
	Finnish = 13,
	French = 14,
	German = 15,
	Greek = 16,
	Hebrew = 17,
	Icelandic = 19,
	Indonesian = 20,
	Italian = 21,
	Japanese = 22,
	Korean = 23,
	Latvian = 24,
	Lithuanian = 25,
	Norwegian = 26,
	Polish = 27,
	Portuguese = 28,
	Romanian = 29,
	Russian = 30,
	SerboCroatian = 31,
	Slovak = 32,
	Slovenian = 33,
	Spanish = 34,
	Swedish = 35,
	Thai = 36,
	Turkish = 37,
	Ukrainian = 38,
	Vietnamese = 39,
	ChineseSimplified = 40,
	ChineseTraditional = 41,
	Unknown = 42,
	Hungarian = 18,
}

public enum LogType
{
	Error = 0,
	Assert = 1,
	Warning = 2,
	Log = 3,
	Exception = 4,
}

public enum LogOption
{
	None = 0,
	NoStacktrace = 1,
}

public enum WrapMode
{
	Once = 1,
	Loop = 2,
	PingPong = 4,
	Default = 0,
	ClampForever = 8,
	Clamp = 1,
}

public enum StackTraceLogType
{
	None = 0,
	ScriptOnly = 1,
	Full = 2,
}

public enum NetworkReachability
{
	NotReachable = 0,
	ReachableViaCarrierDataNetwork = 1,
	ReachableViaLocalAreaNetwork = 2,
}

public enum ApplicationInstallMode
{
	Unknown = 0,
	Store = 1,
	DeveloperBuild = 2,
	Adhoc = 3,
	Enterprise = 4,
	Editor = 5,
}

public enum ApplicationSandboxType
{
	Unknown = 0,
	NotSandboxed = 1,
	Sandboxed = 2,
	SandboxBroken = 3,
}

public enum AudioType
{
	UNKNOWN = 0,
	ACC = 1,
	AIFF = 2,
	IT = 10,
	MOD = 12,
	MPEG = 13,
	OGGVORBIS = 14,
	S3M = 17,
	WAV = 20,
	XM = 21,
	XMA = 22,
	VAG = 23,
	AUDIOQUEUE = 24,
}

public enum Camera.MonoOrStereoscopicEye
{
	Left = 0,
	Right = 1,
	Mono = 2,
}

public enum Camera.RenderRequestMode
{
	None = 0,
	ObjectId = 1,
	Depth = 2,
	VertexNormal = 3,
	WorldPosition = 4,
	EntityId = 5,
	BaseColor = 6,
	SpecularColor = 7,
	Metallic = 8,
	Emission = 9,
	Normal = 10,
	Smoothness = 11,
	Occlusion = 12,
	DiffuseColor = 13,
}

public enum Camera.RenderRequestOutputSpace
{
	UV0 = 0,
	UV1 = 1,
	UV2 = 2,
	UV3 = 3,
	UV4 = 4,
	UV5 = 5,
	UV6 = 6,
	UV7 = 7,
	UV8 = 8,
}

public enum ReflectionProbe.ReflectionProbeEvent
{
	ReflectionProbeAdded = 0,
	ReflectionProbeRemoved = 1,
}

internal enum EnabledOrientation
{
	kAutorotateToPortrait = 1,
	kAutorotateToPortraitUpsideDown = 2,
	kAutorotateToLandscapeLeft = 4,
	kAutorotateToLandscapeRight = 8,
}

public enum FullScreenMode
{
	ExclusiveFullScreen = 0,
	FullScreenWindow = 1,
	MaximizedWindow = 2,
	Windowed = 3,
}

public enum RenderingPath
{
	VertexLit = 0,
	Forward = 1,
	DeferredLighting = 2,
	DeferredShading = 3,
}

public enum TransparencySortMode
{
	Default = 0,
	Perspective = 1,
	Orthographic = 2,
	CustomAxis = 3,
}

public enum LightType
{
	Spot = 0,
	Directional = 1,
	Point = 2,
	Area = 3,
	Rectangle = 3,
	Disc = 4,
}

public enum LightShadows
{
	None = 0,
	Hard = 1,
	Soft = 2,
}

public enum FogMode
{
	Linear = 1,
	Exponential = 2,
	ExponentialSquared = 3,
}

public enum LightmapBakeType
{
	Realtime = 4,
	Baked = 2,
	Mixed = 1,
}

public enum MixedLightingMode
{
	IndirectOnly = 0,
	Shadowmask = 2,
	Subtractive = 1,
}

public enum ShadowResolution
{
	Low = 0,
	Medium = 1,
	High = 2,
	VeryHigh = 3,
}

public enum CameraClearFlags
{
	Skybox = 1,
	Color = 2,
	SolidColor = 2,
	Depth = 3,
	Nothing = 4,
}

public enum DepthTextureMode
{
	None = 0,
	Depth = 1,
	DepthNormals = 2,
	MotionVectors = 4,
}

public enum MeshTopology
{
	Triangles = 0,
	Quads = 2,
	Lines = 3,
	LineStrip = 4,
	Points = 5,
}

public enum ColorSpace
{
	Gamma = 0,
	Linear = 1,
}

public enum ScreenOrientation
{
	Unknown = 0,
	Portrait = 1,
	PortraitUpsideDown = 2,
	LandscapeLeft = 3,
	LandscapeRight = 4,
	AutoRotation = 5,
	Landscape = 3,
}

public enum FilterMode
{
	Point = 0,
	Bilinear = 1,
	Trilinear = 2,
}

public enum TextureWrapMode
{
	Repeat = 0,
	Clamp = 1,
	Mirror = 2,
	MirrorOnce = 3,
}

public enum TextureFormat
{
	Alpha8 = 1,
	ARGB4444 = 2,
	RGB24 = 3,
	RGBA32 = 4,
	ARGB32 = 5,
	RGB565 = 7,
	R16 = 9,
	DXT1 = 10,
	DXT5 = 12,
	RGBA4444 = 13,
	BGRA32 = 14,
	RHalf = 15,
	RGHalf = 16,
	RGBAHalf = 17,
	RFloat = 18,
	RGFloat = 19,
	RGBAFloat = 20,
	YUY2 = 21,
	RGB9e5Float = 22,
	BC4 = 26,
	BC5 = 27,
	BC6H = 24,
	BC7 = 25,
	DXT1Crunched = 28,
	DXT5Crunched = 29,
	PVRTC_RGB2 = 30,
	PVRTC_RGBA2 = 31,
	PVRTC_RGB4 = 32,
	PVRTC_RGBA4 = 33,
	ETC_RGB4 = 34,
	EAC_R = 41,
	EAC_R_SIGNED = 42,
	EAC_RG = 43,
	EAC_RG_SIGNED = 44,
	ETC2_RGB = 45,
	ETC2_RGBA1 = 46,
	ETC2_RGBA8 = 47,
	ASTC_4x4 = 48,
	ASTC_5x5 = 49,
	ASTC_6x6 = 50,
	ASTC_8x8 = 51,
	ASTC_10x10 = 52,
	ASTC_12x12 = 53,
	ETC_RGB4_3DS = 60,
	ETC_RGBA8_3DS = 61,
	RG16 = 62,
	R8 = 63,
	ETC_RGB4Crunched = 64,
	ETC2_RGBA8Crunched = 65,
	ASTC_HDR_4x4 = 66,
	ASTC_HDR_5x5 = 67,
	ASTC_HDR_6x6 = 68,
	ASTC_HDR_8x8 = 69,
	ASTC_HDR_10x10 = 70,
	ASTC_HDR_12x12 = 71,
	RG32 = 72,
	RGB48 = 73,
	RGBA64 = 74,
	ASTC_RGB_4x4 = 48,
	ASTC_RGB_5x5 = 49,
	ASTC_RGB_6x6 = 50,
	ASTC_RGB_8x8 = 51,
	ASTC_RGB_10x10 = 52,
	ASTC_RGB_12x12 = 53,
	ASTC_RGBA_4x4 = 54,
	ASTC_RGBA_5x5 = 55,
	ASTC_RGBA_6x6 = 56,
	ASTC_RGBA_8x8 = 57,
	ASTC_RGBA_10x10 = 58,
	ASTC_RGBA_12x12 = 59,
}

public enum CubemapFace
{
	PositiveX = 0,
	NegativeX = 1,
	PositiveY = 2,
	NegativeY = 3,
	PositiveZ = 4,
	NegativeZ = 5,
}

public enum RenderTextureFormat
{
	ARGB32 = 0,
	Depth = 1,
	ARGBHalf = 2,
	Shadowmap = 3,
	RGB565 = 4,
	ARGB4444 = 5,
	ARGB1555 = 6,
	Default = 7,
	ARGB2101010 = 8,
	DefaultHDR = 9,
	ARGB64 = 10,
	ARGBFloat = 11,
	RGFloat = 12,
	RGHalf = 13,
	RFloat = 14,
	RHalf = 15,
	R8 = 16,
	ARGBInt = 17,
	RGInt = 18,
	RInt = 19,
	BGRA32 = 20,
	RGB111110Float = 22,
	RG32 = 23,
	RGBAUShort = 24,
	RG16 = 25,
	BGRA10101010_XR = 26,
	BGR101010_XR = 27,
	R16 = 28,
}

public enum VRTextureUsage
{
	None = 0,
	OneEye = 1,
	TwoEyes = 2,
	DeviceSpecific = 3,
}

public enum RenderTextureCreationFlags
{
	MipMap = 1,
	AutoGenerateMips = 2,
	SRGB = 4,
	EyeTexture = 8,
	EnableRandomWrite = 16,
	CreatedFromScript = 32,
	AllowVerticalFlip = 128,
	NoResolvedColorSurface = 256,
	DynamicallyScalable = 1024,
	BindMS = 2048,
}

public enum RenderTextureReadWrite
{
	Default = 0,
	Linear = 1,
	sRGB = 2,
}

public enum RenderTextureMemoryless
{
	None = 0,
	Color = 1,
	Depth = 2,
	MSAA = 4,
}

public enum LightmapsMode
{
	NonDirectional = 0,
	CombinedDirectional = 1,
}

public enum LineTextureMode
{
	Stretch = 0,
	Tile = 1,
	DistributePerSegment = 2,
	RepeatPerSegment = 3,
}

public enum LineAlignment
{
	View = 0,
	Local = 1,
	TransformZ = 1,
}

public enum FullScreenMovieControlMode
{
	Full = 0,
	Minimal = 1,
	CancelOnInput = 2,
	Hidden = 3,
}

public enum FullScreenMovieScalingMode
{
	None = 0,
	AspectFit = 1,
	AspectFill = 2,
	Fill = 3,
}

public enum CursorLockMode
{
	None = 0,
	Locked = 1,
	Confined = 2,
}

public enum KeyCode
{
	None = 0,
	Backspace = 8,
	Delete = 127,
	Tab = 9,
	Clear = 12,
	Return = 13,
	Pause = 19,
	Escape = 27,
	Space = 32,
	Keypad0 = 256,
	Keypad1 = 257,
	Keypad2 = 258,
	Keypad3 = 259,
	Keypad4 = 260,
	Keypad5 = 261,
	Keypad6 = 262,
	Keypad7 = 263,
	Keypad8 = 264,
	Keypad9 = 265,
	KeypadPeriod = 266,
	KeypadDivide = 267,
	KeypadMultiply = 268,
	KeypadMinus = 269,
	KeypadPlus = 270,
	KeypadEnter = 271,
	KeypadEquals = 272,
	UpArrow = 273,
	DownArrow = 274,
	RightArrow = 275,
	LeftArrow = 276,
	Insert = 277,
	Home = 278,
	End = 279,
	PageUp = 280,
	PageDown = 281,
	F1 = 282,
	F2 = 283,
	F3 = 284,
	F4 = 285,
	F5 = 286,
	F6 = 287,
	F7 = 288,
	F8 = 289,
	F9 = 290,
	F10 = 291,
	F11 = 292,
	F12 = 293,
	F13 = 294,
	F14 = 295,
	F15 = 296,
	Alpha0 = 48,
	Alpha1 = 49,
	Alpha2 = 50,
	Alpha3 = 51,
	Alpha4 = 52,
	Alpha5 = 53,
	Alpha6 = 54,
	Alpha7 = 55,
	Alpha8 = 56,
	Alpha9 = 57,
	Exclaim = 33,
	DoubleQuote = 34,
	Hash = 35,
	Dollar = 36,
	Percent = 37,
	Ampersand = 38,
	Quote = 39,
	LeftParen = 40,
	RightParen = 41,
	Asterisk = 42,
	Plus = 43,
	Comma = 44,
	Minus = 45,
	Period = 46,
	Slash = 47,
	Colon = 58,
	Semicolon = 59,
	Less = 60,
	Equals = 61,
	Greater = 62,
	Question = 63,
	At = 64,
	LeftBracket = 91,
	Backslash = 92,
	RightBracket = 93,
	Caret = 94,
	Underscore = 95,
	BackQuote = 96,
	A = 97,
	B = 98,
	C = 99,
	D = 100,
	E = 101,
	F = 102,
	G = 103,
	H = 104,
	I = 105,
	J = 106,
	K = 107,
	L = 108,
	M = 109,
	N = 110,
	O = 111,
	P = 112,
	Q = 113,
	R = 114,
	S = 115,
	T = 116,
	U = 117,
	V = 118,
	W = 119,
	X = 120,
	Y = 121,
	Z = 122,
	LeftCurlyBracket = 123,
	Pipe = 124,
	RightCurlyBracket = 125,
	Tilde = 126,
	Numlock = 300,
	CapsLock = 301,
	ScrollLock = 302,
	RightShift = 303,
	LeftShift = 304,
	RightControl = 305,
	LeftControl = 306,
	RightAlt = 307,
	LeftAlt = 308,
	LeftCommand = 310,
	LeftApple = 310,
	LeftWindows = 311,
	RightCommand = 309,
	RightApple = 309,
	RightWindows = 312,
	AltGr = 313,
	Help = 315,
	Print = 316,
	SysReq = 317,
	Break = 318,
	Menu = 319,
	Mouse0 = 323,
	Mouse1 = 324,
	Mouse2 = 325,
	Mouse3 = 326,
	Mouse4 = 327,
	Mouse5 = 328,
	Mouse6 = 329,
	JoystickButton0 = 330,
	JoystickButton1 = 331,
	JoystickButton2 = 332,
	JoystickButton3 = 333,
	JoystickButton4 = 334,
	JoystickButton5 = 335,
	JoystickButton6 = 336,
	JoystickButton7 = 337,
	JoystickButton8 = 338,
	JoystickButton9 = 339,
	JoystickButton10 = 340,
	JoystickButton11 = 341,
	JoystickButton12 = 342,
	JoystickButton13 = 343,
	JoystickButton14 = 344,
	JoystickButton15 = 345,
	JoystickButton16 = 346,
	JoystickButton17 = 347,
	JoystickButton18 = 348,
	JoystickButton19 = 349,
	Joystick1Button0 = 350,
	Joystick1Button1 = 351,
	Joystick1Button2 = 352,
	Joystick1Button3 = 353,
	Joystick1Button4 = 354,
	Joystick1Button5 = 355,
	Joystick1Button6 = 356,
	Joystick1Button7 = 357,
	Joystick1Button8 = 358,
	Joystick1Button9 = 359,
	Joystick1Button10 = 360,
	Joystick1Button11 = 361,
	Joystick1Button12 = 362,
	Joystick1Button13 = 363,
	Joystick1Button14 = 364,
	Joystick1Button15 = 365,
	Joystick1Button16 = 366,
	Joystick1Button17 = 367,
	Joystick1Button18 = 368,
	Joystick1Button19 = 369,
	Joystick2Button0 = 370,
	Joystick2Button1 = 371,
	Joystick2Button2 = 372,
	Joystick2Button3 = 373,
	Joystick2Button4 = 374,
	Joystick2Button5 = 375,
	Joystick2Button6 = 376,
	Joystick2Button7 = 377,
	Joystick2Button8 = 378,
	Joystick2Button9 = 379,
	Joystick2Button10 = 380,
	Joystick2Button11 = 381,
	Joystick2Button12 = 382,
	Joystick2Button13 = 383,
	Joystick2Button14 = 384,
	Joystick2Button15 = 385,
	Joystick2Button16 = 386,
	Joystick2Button17 = 387,
	Joystick2Button18 = 388,
	Joystick2Button19 = 389,
	Joystick3Button0 = 390,
	Joystick3Button1 = 391,
	Joystick3Button2 = 392,
	Joystick3Button3 = 393,
	Joystick3Button4 = 394,
	Joystick3Button5 = 395,
	Joystick3Button6 = 396,
	Joystick3Button7 = 397,
	Joystick3Button8 = 398,
	Joystick3Button9 = 399,
	Joystick3Button10 = 400,
	Joystick3Button11 = 401,
	Joystick3Button12 = 402,
	Joystick3Button13 = 403,
	Joystick3Button14 = 404,
	Joystick3Button15 = 405,
	Joystick3Button16 = 406,
	Joystick3Button17 = 407,
	Joystick3Button18 = 408,
	Joystick3Button19 = 409,
	Joystick4Button0 = 410,
	Joystick4Button1 = 411,
	Joystick4Button2 = 412,
	Joystick4Button3 = 413,
	Joystick4Button4 = 414,
	Joystick4Button5 = 415,
	Joystick4Button6 = 416,
	Joystick4Button7 = 417,
	Joystick4Button8 = 418,
	Joystick4Button9 = 419,
	Joystick4Button10 = 420,
	Joystick4Button11 = 421,
	Joystick4Button12 = 422,
	Joystick4Button13 = 423,
	Joystick4Button14 = 424,
	Joystick4Button15 = 425,
	Joystick4Button16 = 426,
	Joystick4Button17 = 427,
	Joystick4Button18 = 428,
	Joystick4Button19 = 429,
	Joystick5Button0 = 430,
	Joystick5Button1 = 431,
	Joystick5Button2 = 432,
	Joystick5Button3 = 433,
	Joystick5Button4 = 434,
	Joystick5Button5 = 435,
	Joystick5Button6 = 436,
	Joystick5Button7 = 437,
	Joystick5Button8 = 438,
	Joystick5Button9 = 439,
	Joystick5Button10 = 440,
	Joystick5Button11 = 441,
	Joystick5Button12 = 442,
	Joystick5Button13 = 443,
	Joystick5Button14 = 444,
	Joystick5Button15 = 445,
	Joystick5Button16 = 446,
	Joystick5Button17 = 447,
	Joystick5Button18 = 448,
	Joystick5Button19 = 449,
	Joystick6Button0 = 450,
	Joystick6Button1 = 451,
	Joystick6Button2 = 452,
	Joystick6Button3 = 453,
	Joystick6Button4 = 454,
	Joystick6Button5 = 455,
	Joystick6Button6 = 456,
	Joystick6Button7 = 457,
	Joystick6Button8 = 458,
	Joystick6Button9 = 459,
	Joystick6Button10 = 460,
	Joystick6Button11 = 461,
	Joystick6Button12 = 462,
	Joystick6Button13 = 463,
	Joystick6Button14 = 464,
	Joystick6Button15 = 465,
	Joystick6Button16 = 466,
	Joystick6Button17 = 467,
	Joystick6Button18 = 468,
	Joystick6Button19 = 469,
	Joystick7Button0 = 470,
	Joystick7Button1 = 471,
	Joystick7Button2 = 472,
	Joystick7Button3 = 473,
	Joystick7Button4 = 474,
	Joystick7Button5 = 475,
	Joystick7Button6 = 476,
	Joystick7Button7 = 477,
	Joystick7Button8 = 478,
	Joystick7Button9 = 479,
	Joystick7Button10 = 480,
	Joystick7Button11 = 481,
	Joystick7Button12 = 482,
	Joystick7Button13 = 483,
	Joystick7Button14 = 484,
	Joystick7Button15 = 485,
	Joystick7Button16 = 486,
	Joystick7Button17 = 487,
	Joystick7Button18 = 488,
	Joystick7Button19 = 489,
	Joystick8Button0 = 490,
	Joystick8Button1 = 491,
	Joystick8Button2 = 492,
	Joystick8Button3 = 493,
	Joystick8Button4 = 494,
	Joystick8Button5 = 495,
	Joystick8Button6 = 496,
	Joystick8Button7 = 497,
	Joystick8Button8 = 498,
	Joystick8Button9 = 499,
	Joystick8Button10 = 500,
	Joystick8Button11 = 501,
	Joystick8Button12 = 502,
	Joystick8Button13 = 503,
	Joystick8Button14 = 504,
	Joystick8Button15 = 505,
	Joystick8Button16 = 506,
	Joystick8Button17 = 507,
	Joystick8Button18 = 508,
	Joystick8Button19 = 509,
}

public enum RuntimeInitializeLoadType
{
	AfterSceneLoad = 0,
	BeforeSceneLoad = 1,
	AfterAssembliesLoaded = 2,
	BeforeSplashScreen = 3,
	SubsystemRegistration = 4,
}

public enum HideFlags
{
	None = 0,
	HideInHierarchy = 1,
	HideInInspector = 2,
	DontSaveInEditor = 4,
	NotEditable = 8,
	DontSaveInBuild = 16,
	DontUnloadUnusedAsset = 32,
	DontSave = 52,
	HideAndDontSave = 61,
}

public enum BatteryStatus
{
	Unknown = 0,
	Charging = 1,
	Discharging = 2,
	NotCharging = 3,
	Full = 4,
}

public enum OperatingSystemFamily
{
	Other = 0,
	MacOSX = 1,
	Windows = 2,
	Linux = 3,
}

public enum DeviceType
{
	Unknown = 0,
	Handheld = 1,
	Console = 2,
	Desktop = 3,
}

public enum TouchScreenKeyboard.Status
{
	Visible = 0,
	Done = 1,
	Canceled = 2,
	LostFocus = 3,
}

public enum TouchScreenKeyboardType
{
	Default = 0,
	ASCIICapable = 1,
	NumbersAndPunctuation = 2,
	URL = 3,
	NumberPad = 4,
	PhonePad = 5,
	NamePhonePad = 6,
	EmailAddress = 7,
	NintendoNetworkAccount = 8,
	Social = 9,
	Search = 10,
	DecimalPad = 11,
	OneTimeCode = 12,
}

public enum DrivenTransformProperties
{
	None = 0,
	AnchoredPositionX = 2,
	AnchoredPositionY = 4,
	AnchoredPositionZ = 8,
	Rotation = 16,
	ScaleX = 32,
	ScaleY = 64,
	ScaleZ = 128,
	AnchorMinX = 256,
	AnchorMinY = 512,
	AnchorMaxX = 1024,
	AnchorMaxY = 2048,
	SizeDeltaX = 4096,
	SizeDeltaY = 8192,
	PivotX = 16384,
	PivotY = 32768,
	AnchoredPosition = 6,
	AnchoredPosition3D = 14,
	Scale = 224,
	AnchorMin = 768,
	AnchorMax = 3072,
	Anchors = 3840,
	SizeDelta = 12288,
	Pivot = 49152,
}

public enum RectTransform.Axis
{
	Horizontal = 0,
	Vertical = 1,
}

public enum SpriteMaskInteraction
{
	None = 0,
	VisibleInsideMask = 1,
	VisibleOutsideMask = 2,
}

public enum SpriteMeshType
{
	FullRect = 0,
	Tight = 1,
}

public enum SpritePackingMode
{
	Tight = 0,
	Rectangle = 1,
}

public enum SpriteSortPoint
{
	Center = 0,
	Pivot = 1,
}

public enum PersistentListenerMode
{
	EventDefined = 0,
	Void = 1,
	Object = 2,
	Int = 3,
	Float = 4,
	String = 5,
	Bool = 6,
}

public enum UnityEventCallState
{
	Off = 0,
	EditorAndRuntime = 1,
	RuntimeOnly = 2,
}

public enum LoadSceneMode
{
	Single = 0,
	Additive = 1,
}

public enum LocalPhysicsMode
{
	None = 0,
	Physics2D = 1,
	Physics3D = 2,
}

public enum UnloadSceneOptions
{
	None = 0,
	UnloadAllEmbeddedSceneObjects = 1,
}

public enum IndexFormat
{
	UInt16 = 0,
	UInt32 = 1,
}

public enum MeshUpdateFlags
{
	Default = 0,
	DontValidateIndices = 1,
	DontResetBoneBounds = 2,
	DontNotifyMeshUsers = 4,
	DontRecalculateBounds = 8,
}

public enum VertexAttributeFormat
{
	Float32 = 0,
	Float16 = 1,
	UNorm8 = 2,
	SNorm8 = 3,
	UNorm16 = 4,
	SNorm16 = 5,
	UInt8 = 6,
	SInt8 = 7,
	UInt16 = 8,
	SInt16 = 9,
	UInt32 = 10,
	SInt32 = 11,
}

public enum VertexAttribute
{
	Position = 0,
	Normal = 1,
	Tangent = 2,
	Color = 3,
	TexCoord0 = 4,
	TexCoord1 = 5,
	TexCoord2 = 6,
	TexCoord3 = 7,
	TexCoord4 = 8,
	TexCoord5 = 9,
	TexCoord6 = 10,
	TexCoord7 = 11,
	BlendWeight = 12,
	BlendIndices = 13,
}

public enum RenderBufferLoadAction
{
	Load = 0,
	Clear = 1,
	DontCare = 2,
}

public enum RenderBufferStoreAction
{
	Store = 0,
	Resolve = 1,
	StoreAndResolve = 2,
	DontCare = 3,
}

public enum CompareFunction
{
	Disabled = 0,
	Never = 1,
	Less = 2,
	Equal = 3,
	LessEqual = 4,
	Greater = 5,
	NotEqual = 6,
	GreaterEqual = 7,
	Always = 8,
}

public enum ColorWriteMask
{
	Alpha = 1,
	Blue = 2,
	Green = 4,
	Red = 8,
	All = 15,
}

public enum StencilOp
{
	Keep = 0,
	Zero = 1,
	Replace = 2,
	IncrementSaturate = 3,
	DecrementSaturate = 4,
	Invert = 5,
	IncrementWrap = 6,
	DecrementWrap = 7,
}

public enum AmbientMode
{
	Skybox = 0,
	Trilight = 1,
	Flat = 3,
	Custom = 4,
}

public enum CameraEvent
{
	BeforeDepthTexture = 0,
	AfterDepthTexture = 1,
	BeforeDepthNormalsTexture = 2,
	AfterDepthNormalsTexture = 3,
	BeforeGBuffer = 4,
	AfterGBuffer = 5,
	BeforeLighting = 6,
	AfterLighting = 7,
	BeforeFinalPass = 8,
	AfterFinalPass = 9,
	BeforeForwardOpaque = 10,
	AfterForwardOpaque = 11,
	BeforeImageEffectsOpaque = 12,
	AfterImageEffectsOpaque = 13,
	BeforeSkybox = 14,
	AfterSkybox = 15,
	BeforeForwardAlpha = 16,
	AfterForwardAlpha = 17,
	BeforeImageEffects = 18,
	AfterImageEffects = 19,
	AfterEverything = 20,
	BeforeReflections = 21,
	AfterReflections = 22,
	BeforeHaloAndLensFlares = 23,
	AfterHaloAndLensFlares = 24,
}

public enum BuiltinRenderTextureType
{
	None = 0,
	CurrentActive = 1,
	CameraTarget = 2,
	Depth = 3,
	DepthNormals = 4,
	ResolvedDepth = 5,
	PrepassNormalsSpec = 7,
	PrepassLight = 8,
	PrepassLightSpec = 9,
	GBuffer0 = 10,
	GBuffer1 = 11,
	GBuffer2 = 12,
	GBuffer3 = 13,
	Reflections = 14,
	MotionVectors = 15,
	GBuffer4 = 16,
	GBuffer5 = 17,
	GBuffer6 = 18,
	GBuffer7 = 19,
}

public enum ShadowCastingMode
{
	Off = 0,
	On = 1,
	TwoSided = 2,
	ShadowsOnly = 3,
}

public enum GraphicsDeviceType
{
	OpenGL2 = 0,
	Direct3D9 = 1,
	Direct3D11 = 2,
	PlayStation3 = 3,
	Null = 4,
	Xbox360 = 6,
	OpenGLES2 = 8,
	OpenGLES3 = 11,
	PlayStationVita = 12,
	PlayStation4 = 13,
	XboxOne = 14,
	PlayStationMobile = 15,
	Metal = 16,
	OpenGLCore = 17,
	Direct3D12 = 18,
	N3DS = 19,
	Vulkan = 21,
	Switch = 22,
	XboxOneD3D12 = 23,
	GameCoreXboxOne = 24,
	GameCoreScarlett = 25,
	GameCoreXboxSeries = 25,
	PlayStation5 = 26,
	PlayStation5NGGC = 27,
}

public enum ReflectionProbeUsage
{
	Off = 0,
	BlendProbes = 1,
	BlendProbesAndSkybox = 2,
	Simple = 3,
}

public enum ShadowSamplingMode
{
	CompareDepths = 0,
	RawDepth = 1,
	None = 2,
}

public enum LightProbeUsage
{
	Off = 0,
	BlendProbes = 1,
	UseProxyVolume = 2,
	CustomProvided = 4,
}

public enum TextureDimension
{
	None = 0,
	Any = 1,
	Tex2D = 2,
	Tex3D = 3,
	Cube = 4,
	Tex2DArray = 5,
	CubeArray = 6,
}

public enum CommandBufferExecutionFlags
{
	None = 0,
	AsyncCompute = 2,
}

public enum SupportedRenderingFeatures.ReflectionProbeModes
{
	None = 0,
	Rotation = 1,
}

public enum SupportedRenderingFeatures.LightmapMixedBakeModes
{
	None = 0,
	IndirectOnly = 1,
	Subtractive = 2,
	Shadowmask = 4,
}

public enum ShaderPropertyFlags
{
	None = 0,
	HideInInspector = 1,
	PerRendererData = 2,
	NoScaleOffset = 4,
	Normal = 8,
	HDR = 16,
	Gamma = 32,
	NonModifiableTextureData = 64,
	MainTexture = 128,
	MainColor = 256,
}

internal enum FrameData.Flags
{
	Evaluate = 1,
	SeekOccured = 2,
	Loop = 4,
	Hold = 8,
	EffectivePlayStateDelayed = 16,
	EffectivePlayStatePlaying = 32,
}

public enum DirectorUpdateMode
{
	DSPClock = 0,
	GameTime = 1,
	UnscaledGameTime = 2,
	Manual = 3,
}

public enum PlayState
{
	Paused = 0,
	Playing = 1,
	Delayed = 2,
}

public enum LightType
{
	Directional = 0,
	Point = 1,
	Spot = 2,
	Rectangle = 3,
	Disc = 4,
	SpotPyramidShape = 5,
	SpotBoxShape = 6,
}

public enum LightMode
{
	Realtime = 0,
	Mixed = 1,
	Baked = 2,
	Unknown = 3,
}

public enum FalloffType
{
	InverseSquared = 0,
	InverseSquaredNoRangeAttenuation = 1,
	Linear = 2,
	Legacy = 3,
	Undefined = 4,
}

public enum AngularFalloffType
{
	LUT = 0,
	AnalyticAndInnerAngle = 1,
}

public enum TextureCreationFlags
{
	None = 0,
	MipChain = 1,
	Crunch = 64,
}

public enum FormatUsage
{
	Sample = 0,
	Linear = 1,
	Sparse = 2,
	Render = 4,
	Blend = 5,
	GetPixels = 6,
	SetPixels = 7,
	SetPixels32 = 8,
	ReadPixels = 9,
	LoadStore = 10,
	MSAA2x = 11,
	MSAA4x = 12,
	MSAA8x = 13,
	StencilSampling = 16,
}

public enum DefaultFormat
{
	LDR = 0,
	HDR = 1,
}

public enum GraphicsFormat
{
	None = 0,
	R8_SRGB = 1,
	R8G8_SRGB = 2,
	R8G8B8_SRGB = 3,
	R8G8B8A8_SRGB = 4,
	R8_UNorm = 5,
	R8G8_UNorm = 6,
	R8G8B8_UNorm = 7,
	R8G8B8A8_UNorm = 8,
	R8_SNorm = 9,
	R8G8_SNorm = 10,
	R8G8B8_SNorm = 11,
	R8G8B8A8_SNorm = 12,
	R8_UInt = 13,
	R8G8_UInt = 14,
	R8G8B8_UInt = 15,
	R8G8B8A8_UInt = 16,
	R8_SInt = 17,
	R8G8_SInt = 18,
	R8G8B8_SInt = 19,
	R8G8B8A8_SInt = 20,
	R16_UNorm = 21,
	R16G16_UNorm = 22,
	R16G16B16_UNorm = 23,
	R16G16B16A16_UNorm = 24,
	R16_SNorm = 25,
	R16G16_SNorm = 26,
	R16G16B16_SNorm = 27,
	R16G16B16A16_SNorm = 28,
	R16_UInt = 29,
	R16G16_UInt = 30,
	R16G16B16_UInt = 31,
	R16G16B16A16_UInt = 32,
	R16_SInt = 33,
	R16G16_SInt = 34,
	R16G16B16_SInt = 35,
	R16G16B16A16_SInt = 36,
	R32_UInt = 37,
	R32G32_UInt = 38,
	R32G32B32_UInt = 39,
	R32G32B32A32_UInt = 40,
	R32_SInt = 41,
	R32G32_SInt = 42,
	R32G32B32_SInt = 43,
	R32G32B32A32_SInt = 44,
	R16_SFloat = 45,
	R16G16_SFloat = 46,
	R16G16B16_SFloat = 47,
	R16G16B16A16_SFloat = 48,
	R32_SFloat = 49,
	R32G32_SFloat = 50,
	R32G32B32_SFloat = 51,
	R32G32B32A32_SFloat = 52,
	B8G8R8_SRGB = 56,
	B8G8R8A8_SRGB = 57,
	B8G8R8_UNorm = 58,
	B8G8R8A8_UNorm = 59,
	B8G8R8_SNorm = 60,
	B8G8R8A8_SNorm = 61,
	B8G8R8_UInt = 62,
	B8G8R8A8_UInt = 63,
	B8G8R8_SInt = 64,
	B8G8R8A8_SInt = 65,
	R4G4B4A4_UNormPack16 = 66,
	B4G4R4A4_UNormPack16 = 67,
	R5G6B5_UNormPack16 = 68,
	B5G6R5_UNormPack16 = 69,
	R5G5B5A1_UNormPack16 = 70,
	B5G5R5A1_UNormPack16 = 71,
	A1R5G5B5_UNormPack16 = 72,
	E5B9G9R9_UFloatPack32 = 73,
	B10G11R11_UFloatPack32 = 74,
	A2B10G10R10_UNormPack32 = 75,
	A2B10G10R10_UIntPack32 = 76,
	A2B10G10R10_SIntPack32 = 77,
	A2R10G10B10_UNormPack32 = 78,
	A2R10G10B10_UIntPack32 = 79,
	A2R10G10B10_SIntPack32 = 80,
	A2R10G10B10_XRSRGBPack32 = 81,
	A2R10G10B10_XRUNormPack32 = 82,
	R10G10B10_XRSRGBPack32 = 83,
	R10G10B10_XRUNormPack32 = 84,
	A10R10G10B10_XRSRGBPack32 = 85,
	A10R10G10B10_XRUNormPack32 = 86,
	RGB_DXT1_SRGB = 96,
	RGBA_DXT1_SRGB = 96,
	RGB_DXT1_UNorm = 97,
	RGBA_DXT1_UNorm = 97,
	RGBA_DXT3_SRGB = 98,
	RGBA_DXT3_UNorm = 99,
	RGBA_DXT5_SRGB = 100,
	RGBA_DXT5_UNorm = 101,
	R_BC4_UNorm = 102,
	R_BC4_SNorm = 103,
	RG_BC5_UNorm = 104,
	RG_BC5_SNorm = 105,
	RGB_BC6H_UFloat = 106,
	RGB_BC6H_SFloat = 107,
	RGBA_BC7_SRGB = 108,
	RGBA_BC7_UNorm = 109,
	RGB_PVRTC_2Bpp_SRGB = 110,
	RGB_PVRTC_2Bpp_UNorm = 111,
	RGB_PVRTC_4Bpp_SRGB = 112,
	RGB_PVRTC_4Bpp_UNorm = 113,
	RGBA_PVRTC_2Bpp_SRGB = 114,
	RGBA_PVRTC_2Bpp_UNorm = 115,
	RGBA_PVRTC_4Bpp_SRGB = 116,
	RGBA_PVRTC_4Bpp_UNorm = 117,
	RGB_ETC_UNorm = 118,
	RGB_ETC2_SRGB = 119,
	RGB_ETC2_UNorm = 120,
	RGB_A1_ETC2_SRGB = 121,
	RGB_A1_ETC2_UNorm = 122,
	RGBA_ETC2_SRGB = 123,
	RGBA_ETC2_UNorm = 124,
	R_EAC_UNorm = 125,
	R_EAC_SNorm = 126,
	RG_EAC_UNorm = 127,
	RG_EAC_SNorm = 128,
	RGBA_ASTC4X4_SRGB = 129,
	RGBA_ASTC4X4_UNorm = 130,
	RGBA_ASTC5X5_SRGB = 131,
	RGBA_ASTC5X5_UNorm = 132,
	RGBA_ASTC6X6_SRGB = 133,
	RGBA_ASTC6X6_UNorm = 134,
	RGBA_ASTC8X8_SRGB = 135,
	RGBA_ASTC8X8_UNorm = 136,
	RGBA_ASTC10X10_SRGB = 137,
	RGBA_ASTC10X10_UNorm = 138,
	RGBA_ASTC12X12_SRGB = 139,
	RGBA_ASTC12X12_UNorm = 140,
	RGBA_ASTC4X4_UFloat = 145,
	RGBA_ASTC5X5_UFloat = 146,
	RGBA_ASTC6X6_UFloat = 147,
	RGBA_ASTC8X8_UFloat = 148,
	RGBA_ASTC10X10_UFloat = 149,
	RGBA_ASTC12X12_UFloat = 150,
}

private enum BigInteger.GetBytesMode
{
	AllocateArray = 0,
	Count = 1,
	Span = 2,
}

public enum TouchPhase
{
	Began = 0,
	Moved = 1,
	Stationary = 2,
	Ended = 3,
	Canceled = 4,
}

public enum IMECompositionMode
{
	Auto = 0,
	On = 1,
	Off = 2,
}

public enum TouchType
{
	Direct = 0,
	Indirect = 1,
	Stylus = 2,
}

public enum DeviceOrientation
{
	Unknown = 0,
	Portrait = 1,
	PortraitUpsideDown = 2,
	LandscapeLeft = 3,
	LandscapeRight = 4,
	FaceUp = 5,
	FaceDown = 6,
}

public enum RigidbodyConstraints2D
{
	None = 0,
	FreezePositionX = 1,
	FreezePositionY = 2,
	FreezeRotation = 4,
	FreezePosition = 3,
	FreezeAll = 7,
}

public enum RigidbodyType2D
{
	Dynamic = 0,
	Kinematic = 1,
	Static = 2,
}

public enum ForceMode2D
{
	Force = 0,
	Impulse = 1,
}

public enum ForceMode
{
	Force = 0,
	Acceleration = 5,
	Impulse = 1,
	VelocityChange = 2,
}

public enum CollisionFlags
{
	None = 0,
	Sides = 1,
	Above = 2,
	Below = 4,
	CollidedSides = 1,
	CollidedAbove = 2,
	CollidedBelow = 4,
}

public enum QueryTriggerInteraction
{
	UseGlobal = 0,
	Ignore = 1,
	Collide = 2,
}

public enum FontStyle
{
	Normal = 0,
	Bold = 1,
	Italic = 2,
	BoldAndItalic = 3,
}

internal enum TextGenerationError
{
	None = 0,
	CustomSizeOnNonDynamicFont = 1,
	CustomStyleOnNonDynamicFont = 2,
	NoFont = 4,
}

public enum TextAnchor
{
	UpperLeft = 0,
	UpperCenter = 1,
	UpperRight = 2,
	MiddleLeft = 3,
	MiddleCenter = 4,
	MiddleRight = 5,
	LowerLeft = 6,
	LowerCenter = 7,
	LowerRight = 8,
}

public enum HorizontalWrapMode
{
	Wrap = 0,
	Overflow = 1,
}

public enum VerticalWrapMode
{
	Truncate = 0,
	Overflow = 1,
}

internal enum UnityWebRequest.UnityWebRequestMethod
{
	Get = 0,
	Post = 1,
	Put = 2,
	Head = 3,
	Custom = 4,
}

internal enum UnityWebRequest.UnityWebRequestError
{
	OK = 0,
	Unknown = 1,
	SDKError = 2,
	UnsupportedProtocol = 3,
	MalformattedUrl = 4,
	CannotResolveProxy = 5,
	CannotResolveHost = 6,
	CannotConnectToHost = 7,
	AccessDenied = 8,
	GenericHttpError = 9,
	WriteError = 10,
	ReadError = 11,
	OutOfMemory = 12,
	Timeout = 13,
	HTTPPostError = 14,
	SSLCannotConnect = 15,
	Aborted = 16,
	TooManyRedirects = 17,
	ReceivedNoData = 18,
	SSLNotSupported = 19,
	FailedToSendData = 20,
	FailedToReceiveData = 21,
	SSLCertificateError = 22,
	SSLCipherNotAvailable = 23,
	SSLCACertError = 24,
	UnrecognizedContentEncoding = 25,
	LoginFailed = 26,
	SSLShutdownFailed = 27,
	NoInternetConnection = 28,
}

public enum UnityWebRequest.Result
{
	InProgress = 0,
	Success = 1,
	ConnectionError = 2,
	ProtocolError = 3,
	DataProcessingError = 4,
}

public enum AcceptRejectRule
{
	None = 0,
	Cascade = 1,
}

internal enum AggregateType
{
	None = 0,
	Sum = 4,
	Mean = 5,
	Min = 6,
	Max = 7,
	First = 8,
	Count = 9,
	Var = 10,
	StDev = 11,
}

public enum DataRowAction
{
	Nothing = 0,
	Delete = 1,
	Change = 2,
	Rollback = 4,
	Commit = 8,
	Add = 16,
	ChangeOriginal = 32,
	ChangeCurrentAndOriginal = 64,
}

public enum DataRowState
{
	Detached = 1,
	Unchanged = 2,
	Added = 4,
	Deleted = 8,
	Modified = 16,
}

public enum DataRowVersion
{
	Original = 256,
	Current = 512,
	Proposed = 1024,
	Default = 1536,
}

public enum SerializationFormat
{
	Xml = 0,
	Binary = 1,
}

public enum DataSetDateTime
{
	Local = 1,
	Unspecified = 2,
	UnspecifiedLocal = 3,
	Utc = 4,
}

public enum DataViewRowState
{
	None = 0,
	Unchanged = 2,
	Added = 4,
	Deleted = 8,
	ModifiedCurrent = 16,
	ModifiedOriginal = 32,
	OriginalRows = 42,
	CurrentRows = 22,
}

internal enum Aggregate
{
	Sum = 30,
	Avg = 31,
	Min = 32,
	Max = 33,
	Count = 34,
	StDev = 35,
	Var = 37,
}

private enum BinaryNode.DataTypePrecedence
{
	SqlDateTime = 25,
	DateTimeOffset = 24,
	DateTime = 23,
	TimeSpan = 20,
	SqlDouble = 19,
	Double = 18,
	SqlSingle = 17,
	Single = 16,
	SqlDecimal = 15,
	Decimal = 14,
	SqlMoney = 13,
	UInt64 = 12,
	SqlInt64 = 11,
	Int64 = 10,
	UInt32 = 9,
	SqlInt32 = 8,
	Int32 = 7,
	UInt16 = 6,
	SqlInt16 = 5,
	Int16 = 4,
	Byte = 3,
	SqlByte = 2,
	SByte = 1,
	Error = 0,
}

internal enum ValueType
{
	Null = 0,
	Bool = 1,
	Numeric = 2,
	Str = 3,
	Float = 4,
	Decimal = 5,
	Object = 6,
	Date = 7,
}

internal enum Nodes
{
	Noop = 0,
	Unop = 1,
	UnopSpec = 2,
	Binop = 3,
	BinopSpec = 4,
	Zop = 5,
	Call = 6,
	Const = 7,
	Name = 8,
	Paren = 9,
	Conv = 10,
}

internal enum Tokens
{
	None = 0,
	Name = 1,
	Numeric = 2,
	Decimal = 3,
	Float = 4,
	BinaryConst = 5,
	StringConst = 6,
	Date = 7,
	ListSeparator = 8,
	LeftParen = 9,
	RightParen = 10,
	ZeroOp = 11,
	UnaryOp = 12,
	BinaryOp = 13,
	Child = 14,
	Parent = 15,
	Dot = 16,
	Unknown = 17,
	EOS = 18,
}

internal enum FunctionId
{
	Ascii = 0,
	Char = 1,
	Charindex = 2,
	Difference = 3,
	Len = 4,
	Lower = 5,
	LTrim = 6,
	Patindex = 7,
	Replicate = 8,
	Reverse = 9,
	Right = 10,
	RTrim = 11,
	Soundex = 12,
	Space = 13,
	Str = 14,
	Stuff = 15,
	Substring = 16,
	Upper = 17,
	IsNull = 18,
	Iif = 19,
	Convert = 20,
	cInt = 21,
	cBool = 22,
	cDate = 23,
	cDbl = 24,
	cStr = 25,
	Abs = 26,
	Acos = 27,
	In = 28,
	Trim = 29,
	Sum = 30,
	Avg = 31,
	Min = 32,
	Max = 33,
	Count = 34,
	StDev = 35,
	Var = 37,
	DateTimeOffset = 38,
}

public enum MappingType
{
	Element = 1,
	Attribute = 2,
	SimpleContent = 3,
	Hidden = 4,
}

public enum MissingSchemaAction
{
	Add = 1,
	Ignore = 2,
	Error = 3,
	AddWithKey = 4,
}

internal enum RBTreeError
{
	InvalidPageSize = 1,
	PagePositionInSlotInUse = 3,
	NoFreeSlots = 4,
	InvalidStateinInsert = 5,
	InvalidNextSizeInDelete = 7,
	InvalidStateinDelete = 8,
	InvalidNodeSizeinDelete = 9,
	InvalidStateinEndDelete = 10,
	CannotRotateInvalidsuccessorNodeinDelete = 11,
	IndexOutOFRangeinGetNodeByIndex = 13,
	RBDeleteFixup = 14,
	UnsupportedAccessMethod1 = 15,
	UnsupportedAccessMethod2 = 16,
	UnsupportedAccessMethodInNonNillRootSubtree = 17,
	AttachedNodeWithZerorbTreeNodeId = 18,
	CompareNodeInDataRowTree = 19,
	CompareSateliteTreeNodeInDataRowTree = 20,
	NestedSatelliteTreeEnumerator = 21,
}

internal enum TreeAccessMethod
{
	KEY_SEARCH_AND_INDEX = 1,
	INDEX_ONLY = 2,
}

private enum RBTree.NodeColor<K>
{
}

public enum Rule
{
	None = 0,
	Cascade = 1,
	SetNull = 2,
	SetDefault = 3,
}

public enum SchemaSerializationMode
{
	IncludeSchema = 1,
	ExcludeSchema = 2,
}

public enum XmlReadMode
{
	Auto = 0,
	ReadSchema = 1,
	IgnoreSchema = 2,
	InferSchema = 3,
	DiffGram = 4,
	Fragment = 5,
	InferTypedSchema = 6,
}

public enum XmlWriteMode
{
	WriteSchema = 0,
	IgnoreSchema = 1,
	DiffGram = 2,
}

internal enum SchemaFormat
{
	Public = 1,
	Remoting = 2,
	WebService = 3,
	RemotingSkipSchema = 4,
	WebServiceSkipSchema = 5,
}

internal enum SqlBytesCharsState
{
	Null = 0,
	Buffer = 1,
	Stream = 3,
}

public enum SqlCompareOptions
{
	None = 0,
	IgnoreCase = 1,
	IgnoreNonSpace = 2,
	IgnoreKanaType = 8,
	IgnoreWidth = 16,
	BinarySort = 32768,
	BinarySort2 = 16384,
}

internal enum EComparison
{
	LT = 0,
	LE = 1,
	EQ = 2,
	GE = 3,
	GT = 4,
	NE = 5,
}

internal enum StorageType
{
	Empty = 0,
	Object = 1,
	DBNull = 2,
	Boolean = 3,
	Char = 4,
	SByte = 5,
	Byte = 6,
	Int16 = 7,
	UInt16 = 8,
	Int32 = 9,
	UInt32 = 10,
	Int64 = 11,
	UInt64 = 12,
	Single = 13,
	Double = 14,
	Decimal = 15,
	DateTime = 16,
	TimeSpan = 17,
	String = 18,
	Guid = 19,
	ByteArray = 20,
	CharArray = 21,
	Type = 22,
	DateTimeOffset = 23,
	BigInteger = 24,
	Uri = 25,
	SqlBinary = 26,
	SqlBoolean = 27,
	SqlByte = 28,
	SqlBytes = 29,
	SqlChars = 30,
	SqlDateTime = 31,
	SqlDecimal = 32,
	SqlDouble = 33,
	SqlGuid = 34,
	SqlInt16 = 35,
	SqlInt32 = 36,
	SqlInt64 = 37,
	SqlMoney = 38,
	SqlSingle = 39,
	SqlString = 40,
}

private enum ObjectStorage.Families
{
	DATETIME = 0,
	NUMBER = 1,
	STRING = 2,
	BOOLEAN = 3,
	ARRAY = 4,
}

public enum XObjectChange
{
	Add = 0,
	Remove = 1,
	Name = 2,
	Value = 3,
}

public enum LoadOptions
{
	None = 0,
	PreserveWhitespace = 1,
	SetBaseUri = 2,
	SetLineInfo = 4,
}

public enum SaveOptions
{
	None = 0,
	DisableFormatting = 1,
	OmitDuplicateNamespaces = 2,
}

public enum AndroidAssetPackStatus
{
	Unknown = 0,
	Pending = 1,
	Downloading = 2,
	Transferring = 3,
	Completed = 4,
	Failed = 5,
	Canceled = 6,
	WaitingForWifi = 7,
	NotInstalled = 8,
}

public enum AndroidAssetPackError
{
	NoError = 0,
}

public enum PlayMode
{
	StopSameLayer = 0,
	StopAll = 4,
}

public enum QueueMode
{
	CompleteOthers = 0,
	PlayNow = 2,
}

public enum AnimationBlendMode
{
	Blend = 0,
	Additive = 1,
}

internal enum AnimationEventSource
{
	NoSource = 0,
	Legacy = 1,
	Animator = 2,
}

public enum AvatarTarget
{
	Root = 0,
	Body = 1,
	LeftFoot = 2,
	RightFoot = 3,
	LeftHand = 4,
	RightHand = 5,
}

public enum AvatarIKGoal
{
	LeftFoot = 0,
	RightFoot = 1,
	LeftHand = 2,
	RightHand = 3,
}

internal enum StateInfoIndex
{
	CurrentState = 0,
	NextState = 1,
	ExitState = 2,
	InterruptedState = 3,
}

public enum AnimatorCullingMode
{
	AlwaysAnimate = 0,
	CullUpdateTransforms = 1,
	CullCompletely = 2,
}

public enum AnimatorUpdateMode
{
	Normal = 0,
	AnimatePhysics = 1,
	UnscaledTime = 2,
}

public enum HumanBodyBones
{
	Hips = 0,
	LeftUpperLeg = 1,
	RightUpperLeg = 2,
	LeftLowerLeg = 3,
	RightLowerLeg = 4,
	LeftFoot = 5,
	RightFoot = 6,
	Spine = 7,
	Chest = 8,
	UpperChest = 54,
	Neck = 9,
	Head = 10,
	LeftShoulder = 11,
	RightShoulder = 12,
	LeftUpperArm = 13,
	RightUpperArm = 14,
	LeftLowerArm = 15,
	RightLowerArm = 16,
	LeftHand = 17,
	RightHand = 18,
	LeftToes = 19,
	RightToes = 20,
	LeftEye = 21,
	RightEye = 22,
	Jaw = 23,
	LeftThumbProximal = 24,
	LeftThumbIntermediate = 25,
	LeftThumbDistal = 26,
	LeftIndexProximal = 27,
	LeftIndexIntermediate = 28,
	LeftIndexDistal = 29,
	LeftMiddleProximal = 30,
	LeftMiddleIntermediate = 31,
	LeftMiddleDistal = 32,
	LeftRingProximal = 33,
	LeftRingIntermediate = 34,
	LeftRingDistal = 35,
	LeftLittleProximal = 36,
	LeftLittleIntermediate = 37,
	LeftLittleDistal = 38,
	RightThumbProximal = 39,
	RightThumbIntermediate = 40,
	RightThumbDistal = 41,
	RightIndexProximal = 42,
	RightIndexIntermediate = 43,
	RightIndexDistal = 44,
	RightMiddleProximal = 45,
	RightMiddleIntermediate = 46,
	RightMiddleDistal = 47,
	RightRingProximal = 48,
	RightRingIntermediate = 49,
	RightRingDistal = 50,
	RightLittleProximal = 51,
	RightLittleIntermediate = 52,
	RightLittleDistal = 53,
	LastBone = 55,
}

public enum Axis
{
	None = 0,
	X = 1,
	Y = 2,
	Z = 4,
}

public enum EventType
{
	MouseDown = 0,
	MouseUp = 1,
	MouseMove = 2,
	MouseDrag = 3,
	KeyDown = 4,
	KeyUp = 5,
	ScrollWheel = 6,
	Repaint = 7,
	Layout = 8,
	DragUpdated = 9,
	DragPerform = 10,
	DragExited = 15,
	Ignore = 11,
	Used = 12,
	ValidateCommand = 13,
	ExecuteCommand = 14,
	ContextClick = 16,
	MouseEnterWindow = 20,
	MouseLeaveWindow = 21,
	TouchDown = 30,
	TouchUp = 31,
	TouchMove = 32,
	TouchEnter = 33,
	TouchLeave = 34,
	TouchStationary = 35,
	mouseDown = 0,
	mouseUp = 1,
	mouseMove = 2,
	mouseDrag = 3,
	keyDown = 4,
	keyUp = 5,
	scrollWheel = 6,
	repaint = 7,
	layout = 8,
	dragUpdated = 9,
	dragPerform = 10,
	ignore = 11,
	used = 12,
}

public enum EventModifiers
{
	None = 0,
	Shift = 1,
	Control = 2,
	Alt = 4,
	Command = 8,
	Numeric = 16,
	CapsLock = 32,
	FunctionKey = 64,
}

public enum PointerType
{
	Mouse = 0,
	Touch = 1,
	Pen = 2,
}

public enum GUI.ToolbarButtonSize
{
	Fixed = 0,
	FitToContents = 1,
}

public enum ScaleMode
{
	StretchToFill = 0,
	ScaleAndCrop = 1,
	ScaleToFit = 2,
}

public enum FocusType
{
	Native = 0,
	Keyboard = 1,
	Passive = 2,
}

internal enum GUILayoutOption.Type
{
	fixedWidth = 0,
	fixedHeight = 1,
	minWidth = 2,
	maxWidth = 3,
	minHeight = 4,
	maxHeight = 5,
	stretchWidth = 6,
	stretchHeight = 7,
	alignStart = 8,
	alignMiddle = 9,
	alignEnd = 10,
	alignJustify = 11,
	equalSize = 12,
	spacing = 13,
}

public enum ImagePosition
{
	ImageLeft = 0,
	ImageAbove = 1,
	ImageOnly = 2,
	TextOnly = 3,
}

public enum TextEditor.DblClickSnapping
{
	WORDS = 0,
	PARAGRAPHS = 1,
}

private enum TextEditor.CharacterType
{
	LetterLike = 0,
	Symbol = 1,
	Symbol2 = 2,
	WhiteSpace = 3,
}

private enum TextEditor.Direction
{
	Forward = 0,
	Backward = 1,
}

private enum TextEditor.TextEditOp
{
	MoveLeft = 0,
	MoveRight = 1,
	MoveUp = 2,
	MoveDown = 3,
	MoveLineStart = 4,
	MoveLineEnd = 5,
	MoveTextStart = 6,
	MoveTextEnd = 7,
	MovePageUp = 8,
	MovePageDown = 9,
	MoveGraphicalLineStart = 10,
	MoveGraphicalLineEnd = 11,
	MoveWordLeft = 12,
	MoveWordRight = 13,
	MoveParagraphForward = 14,
	MoveParagraphBackward = 15,
	MoveToStartOfNextWord = 16,
	MoveToEndOfPreviousWord = 17,
	SelectLeft = 18,
	SelectRight = 19,
	SelectUp = 20,
	SelectDown = 21,
	SelectTextStart = 22,
	SelectTextEnd = 23,
	SelectPageUp = 24,
	SelectPageDown = 25,
	ExpandSelectGraphicalLineStart = 26,
	ExpandSelectGraphicalLineEnd = 27,
	SelectGraphicalLineStart = 28,
	SelectGraphicalLineEnd = 29,
	SelectWordLeft = 30,
	SelectWordRight = 31,
	SelectToEndOfPreviousWord = 32,
	SelectToStartOfNextWord = 33,
	SelectParagraphBackward = 34,
	SelectParagraphForward = 35,
	Delete = 36,
	Backspace = 37,
	DeleteWordBack = 38,
	DeleteWordForward = 39,
	DeleteLineBack = 40,
	Cut = 41,
	Copy = 42,
	Paste = 43,
	SelectAll = 44,
	SelectNone = 45,
	ScrollStart = 46,
	ScrollEnd = 47,
	ScrollPageUp = 48,
	ScrollPageDown = 49,
}

public enum ParticleSystemRenderMode
{
	Billboard = 0,
	Stretch = 1,
	HorizontalBillboard = 2,
	VerticalBillboard = 3,
	Mesh = 4,
	None = 5,
}

public enum ParticleSystemCurveMode
{
	Constant = 0,
	Curve = 1,
	TwoCurves = 2,
	TwoConstants = 3,
}

public enum ParticleSystemGradientMode
{
	Color = 0,
	Gradient = 1,
	TwoColors = 2,
	TwoGradients = 3,
	RandomColor = 4,
}

public enum ParticleSystemSimulationSpace
{
	Local = 0,
	World = 1,
	Custom = 2,
}

public enum ParticleSystemStopBehavior
{
	StopEmittingAndClear = 0,
	StopEmitting = 1,
}

public enum ParticleSystemScalingMode
{
	Hierarchy = 0,
	Local = 1,
	Shape = 2,
}

public enum ParticleSystemStopAction
{
	None = 0,
	Disable = 1,
	Destroy = 2,
	Callback = 3,
}

public enum ParticleSystemCullingMode
{
	Automatic = 0,
	PauseAndCatchup = 1,
	Pause = 2,
	AlwaysSimulate = 3,
}

public enum ParticleSystemCustomData
{
	Custom1 = 0,
	Custom2 = 1,
}

public enum ParticleSystemForceFieldShape
{
	Sphere = 0,
	Hemisphere = 1,
	Cylinder = 2,
	Box = 3,
}

public enum ScreenCapture.StereoScreenCaptureMode
{
	LeftEye = 1,
	RightEye = 2,
	BothEyes = 3,
}

public enum RenderMode
{
	ScreenSpaceOverlay = 0,
	ScreenSpaceCamera = 1,
	WorldSpace = 2,
}

public enum UISystemProfilerApi.SampleType
{
	Layout = 0,
	Render = 1,
}

internal enum RemoteConfigSettingsHelper.Tag
{
	kUnknown = 0,
	kIntVal = 1,
	kInt64Val = 2,
	kUInt64Val = 3,
	kDoubleVal = 4,
	kBoolVal = 5,
	kStringVal = 6,
	kArrayVal = 7,
	kMixedArrayVal = 8,
	kMapVal = 9,
	kMaxTags = 10,
}

public enum AnalyticsSessionState
{
	kSessionStopped = 0,
	kSessionStarted = 1,
	kSessionPaused = 2,
	kSessionResumed = 3,
}

public enum VideoRenderMode
{
	CameraFarPlane = 0,
	CameraNearPlane = 1,
	RenderTexture = 2,
	MaterialOverride = 3,
	APIOnly = 4,
}

public enum Video3DLayout
{
	No3D = 0,
	SideBySide3D = 1,
	OverUnder3D = 2,
}

public enum VideoAspectRatio
{
	NoScaling = 0,
	FitVertically = 1,
	FitHorizontally = 2,
	FitInside = 3,
	FitOutside = 4,
	Stretch = 5,
}

public enum VideoTimeSource
{
	AudioDSPTimeSource = 0,
	GameTimeSource = 1,
}

public enum VideoTimeReference
{
	Freerun = 0,
	InternalTime = 1,
	ExternalTime = 2,
}

public enum VideoSource
{
	VideoClip = 0,
	Url = 1,
}

public enum VideoAudioOutputMode
{
	None = 0,
	AudioSource = 1,
	Direct = 2,
	APIOnly = 3,
}

public enum WindZoneMode
{
	Directional = 0,
	Spherical = 1,
}

public enum ConstructorHandling
{
	Default = 0,
	AllowNonPublicDefaultConstructor = 1,
}

public enum DateFormatHandling
{
	IsoDateFormat = 0,
	MicrosoftDateFormat = 1,
}

public enum DateParseHandling
{
	None = 0,
	DateTime = 1,
	DateTimeOffset = 2,
}

public enum DateTimeZoneHandling
{
	Local = 0,
	Utc = 1,
	Unspecified = 2,
	RoundtripKind = 3,
}

public enum DefaultValueHandling
{
	Include = 0,
	Ignore = 1,
	Populate = 2,
	IgnoreAndPopulate = 3,
}

public enum FloatFormatHandling
{
	String = 0,
	Symbol = 1,
	DefaultValue = 2,
}

public enum FloatParseHandling
{
	Double = 0,
	Decimal = 1,
}

public enum Formatting
{
	None = 0,
	Indented = 1,
}

internal enum JsonContainerType
{
	None = 0,
	Object = 1,
	Array = 2,
	Constructor = 3,
}

protected internal enum JsonReader.State
{
	Start = 0,
	Complete = 1,
	Property = 2,
	ObjectStart = 3,
	Object = 4,
	ArrayStart = 5,
	Array = 6,
	Closed = 7,
	PostValue = 8,
	ConstructorStart = 9,
	Constructor = 10,
	Error = 11,
	Finished = 12,
}

internal enum ReadType
{
	Read = 0,
	ReadAsInt32 = 1,
	ReadAsInt64 = 2,
	ReadAsBytes = 3,
	ReadAsString = 4,
	ReadAsDecimal = 5,
	ReadAsDateTime = 6,
	ReadAsDateTimeOffset = 7,
	ReadAsDouble = 8,
	ReadAsBoolean = 9,
}

public enum JsonToken
{
	None = 0,
	StartObject = 1,
	StartArray = 2,
	StartConstructor = 3,
	PropertyName = 4,
	Comment = 5,
	Raw = 6,
	Integer = 7,
	Float = 8,
	String = 9,
	Boolean = 10,
	Null = 11,
	Undefined = 12,
	EndObject = 13,
	EndArray = 14,
	EndConstructor = 15,
	Date = 16,
	Bytes = 17,
}

internal enum JsonWriter.State
{
	Start = 0,
	Property = 1,
	ObjectStart = 2,
	Object = 3,
	ArrayStart = 4,
	Array = 5,
	ConstructorStart = 6,
	Constructor = 7,
	Closed = 8,
	Error = 9,
}

public enum MemberSerialization
{
	OptOut = 0,
	OptIn = 1,
	Fields = 2,
}

public enum MetadataPropertyHandling
{
	Default = 0,
	ReadAhead = 1,
	Ignore = 2,
}

public enum MissingMemberHandling
{
	Ignore = 0,
	Error = 1,
}

public enum NullValueHandling
{
	Include = 0,
	Ignore = 1,
}

public enum ObjectCreationHandling
{
	Auto = 0,
	Reuse = 1,
	Replace = 2,
}

public enum PreserveReferencesHandling
{
	None = 0,
	Objects = 1,
	Arrays = 2,
	All = 3,
}

public enum ReferenceLoopHandling
{
	Error = 0,
	Ignore = 1,
	Serialize = 2,
}

public enum Required
{
	Default = 0,
	AllowNull = 1,
	Always = 2,
	DisallowNull = 3,
}

public enum StringEscapeHandling
{
	Default = 0,
	EscapeNonAscii = 1,
	EscapeHtml = 2,
}

public enum TypeNameAssemblyFormatHandling
{
	Simple = 0,
	Full = 1,
}

public enum TypeNameHandling
{
	None = 0,
	Objects = 1,
	Arrays = 2,
	All = 3,
	Auto = 4,
}

public enum WriteState
{
	Error = 0,
	Closed = 1,
	Object = 2,
	Array = 3,
	Constructor = 4,
	Property = 5,
	Start = 6,
}

internal enum PrimitiveTypeCode
{
	Empty = 0,
	Object = 1,
	Char = 2,
	CharNullable = 3,
	Boolean = 4,
	BooleanNullable = 5,
	SByte = 6,
	SByteNullable = 7,
	Int16 = 8,
	Int16Nullable = 9,
	UInt16 = 10,
	UInt16Nullable = 11,
	Int32 = 12,
	Int32Nullable = 13,
	Byte = 14,
	ByteNullable = 15,
	UInt32 = 16,
	UInt32Nullable = 17,
	Int64 = 18,
	Int64Nullable = 19,
	UInt64 = 20,
	UInt64Nullable = 21,
	Single = 22,
	SingleNullable = 23,
	Double = 24,
	DoubleNullable = 25,
	DateTime = 26,
	DateTimeNullable = 27,
	DateTimeOffset = 28,
	DateTimeOffsetNullable = 29,
	Decimal = 30,
	DecimalNullable = 31,
	Guid = 32,
	GuidNullable = 33,
	TimeSpan = 34,
	TimeSpanNullable = 35,
	BigInteger = 36,
	BigIntegerNullable = 37,
	Uri = 38,
	String = 39,
	Bytes = 40,
	DBNull = 41,
}

internal enum ParseResult
{
	None = 0,
	Success = 1,
	Overflow = 2,
	Invalid = 3,
}

internal enum ConvertUtils.ConvertResult
{
	Success = 0,
	CannotConvertNull = 1,
	NotInstantiableType = 2,
	NoValidConversion = 3,
}

internal enum ParserTimeZone
{
	Unspecified = 0,
	Utc = 1,
	LocalWestOfUtc = 2,
	LocalEastOfUtc = 3,
}

private enum StringUtils.SeparatedCaseState
{
	Start = 0,
	Lower = 1,
	Upper = 2,
	NewWord = 3,
}

internal enum JsonContractType
{
	None = 0,
	Object = 1,
	Array = 2,
	Primitive = 3,
	String = 4,
	Dictionary = 5,
	Dynamic = 6,
	Serializable = 7,
	Linq = 8,
}

internal enum JsonSerializerInternalReader.PropertyPresence
{
	None = 0,
	Null = 1,
	Value = 2,
}

public enum CommentHandling
{
	Ignore = 0,
	Load = 1,
}

public enum DuplicatePropertyNameHandling
{
	Replace = 0,
	Ignore = 1,
	Error = 2,
}

public enum JTokenType
{
	None = 0,
	Object = 1,
	Array = 2,
	Constructor = 3,
	Property = 4,
	Comment = 5,
	Integer = 6,
	Float = 7,
	String = 8,
	Boolean = 9,
	Null = 10,
	Undefined = 11,
	Date = 12,
	Raw = 13,
	Bytes = 14,
	Guid = 15,
	Uri = 16,
	TimeSpan = 17,
}

public enum LineInfoHandling
{
	Ignore = 0,
	Load = 1,
}

internal enum BsonType
{
	Number = 1,
	String = 2,
	Object = 3,
	Array = 4,
	Binary = 5,
	Undefined = 6,
	Oid = 7,
	Boolean = 8,
	Date = 9,
	Null = 10,
	Regex = 11,
	Reference = 12,
	Code = 13,
	Symbol = 14,
	CodeWScope = 15,
	Integer = 16,
	TimeStamp = 17,
	Long = 18,
	MaxKey = 127,
}

private enum Json.Parser.TOKEN
{
	NONE = 0,
	CURLY_OPEN = 1,
	CURLY_CLOSE = 2,
	SQUARED_OPEN = 3,
	SQUARED_CLOSE = 4,
	COLON = 5,
	COMMA = 6,
	STRING = 7,
	NUMBER = 8,
	TRUE = 9,
	FALSE = 10,
	NULL = 11,
}

public enum ServicesInitializationState
{
	Uninitialized = 0,
	Initializing = 1,
	Initialized = 2,
}

internal enum PlatformLogLevel
{
	Verbose = 0,
	Debug = 1,
	Info = 2,
	Warning = 3,
	Error = 4,
	Assert = 5,
}

internal enum ArrayPoolEventSource.BufferAllocatedReason
{
	Pooled = 0,
	OverMaximumSize = 1,
	PoolExhausted = 2,
}

internal enum AsyncOperationStatus
{
	None = 0,
	InProgress = 1,
	Succeeded = 2,
	Failed = 3,
	Cancelled = 4,
}

private enum DependencyTreeInitializeOrderSorter.ExplorationMark
{
	None = 0,
	Viewed = 1,
	Sorted = 2,
}

public enum CanvasUpdate
{
	Prelayout = 0,
	Layout = 1,
	PostLayout = 2,
	PreRender = 3,
	LatePreRender = 4,
	MaxUpdateValue = 5,
}

public enum GraphicRaycaster.BlockingObjects
{
	None = 0,
	TwoD = 1,
	ThreeD = 2,
	All = 3,
}

public enum Image.Type
{
	Simple = 0,
	Sliced = 1,
	Tiled = 2,
	Filled = 3,
}

public enum Image.FillMethod
{
	Horizontal = 0,
	Vertical = 1,
	Radial90 = 2,
	Radial180 = 3,
	Radial360 = 4,
}

public enum InputField.ContentType
{
	Standard = 0,
	Autocorrected = 1,
	IntegerNumber = 2,
	DecimalNumber = 3,
	Alphanumeric = 4,
	Name = 5,
	EmailAddress = 6,
	Password = 7,
	Pin = 8,
	Custom = 9,
}

public enum InputField.InputType
{
	Standard = 0,
	AutoCorrect = 1,
	Password = 2,
}

public enum InputField.CharacterValidation
{
	None = 0,
	Integer = 1,
	Decimal = 2,
	Alphanumeric = 3,
	Name = 4,
	EmailAddress = 5,
}

public enum InputField.LineType
{
	SingleLine = 0,
	MultiLineSubmit = 1,
	MultiLineNewline = 2,
}

protected enum InputField.EditState
{
	Continue = 0,
	Finish = 1,
}

public enum AspectRatioFitter.AspectMode
{
	None = 0,
	WidthControlsHeight = 1,
	HeightControlsWidth = 2,
	FitInParent = 3,
	EnvelopeParent = 4,
}

public enum CanvasScaler.ScaleMode
{
	ConstantPixelSize = 0,
	ScaleWithScreenSize = 1,
	ConstantPhysicalSize = 2,
}

public enum CanvasScaler.ScreenMatchMode
{
	MatchWidthOrHeight = 0,
	Expand = 1,
	Shrink = 2,
}

public enum CanvasScaler.Unit
{
	Centimeters = 0,
	Millimeters = 1,
	Inches = 2,
	Points = 3,
	Picas = 4,
}

public enum ContentSizeFitter.FitMode
{
	Unconstrained = 0,
	MinSize = 1,
	PreferredSize = 2,
}

public enum GridLayoutGroup.Corner
{
	UpperLeft = 0,
	UpperRight = 1,
	LowerLeft = 2,
	LowerRight = 3,
}

public enum GridLayoutGroup.Axis
{
	Horizontal = 0,
	Vertical = 1,
}

public enum GridLayoutGroup.Constraint
{
	Flexible = 0,
	FixedColumnCount = 1,
	FixedRowCount = 2,
}

public enum Navigation.Mode
{
	None = 0,
	Horizontal = 1,
	Vertical = 2,
	Automatic = 3,
	Explicit = 4,
}

public enum ScrollRect.MovementType
{
	Unrestricted = 0,
	Elastic = 1,
	Clamped = 2,
}

public enum ScrollRect.ScrollbarVisibility
{
	Permanent = 0,
	AutoHide = 1,
	AutoHideAndExpandViewport = 2,
}

public enum Scrollbar.Direction
{
	LeftToRight = 0,
	RightToLeft = 1,
	BottomToTop = 2,
	TopToBottom = 3,
}

private enum Scrollbar.Axis
{
	Horizontal = 0,
	Vertical = 1,
}

public enum Selectable.Transition
{
	None = 0,
	ColorTint = 1,
	SpriteSwap = 2,
	Animation = 3,
}

protected enum Selectable.SelectionState
{
	Normal = 0,
	Highlighted = 1,
	Pressed = 2,
	Selected = 3,
	Disabled = 4,
}

public enum Slider.Direction
{
	LeftToRight = 0,
	RightToLeft = 1,
	BottomToTop = 2,
	TopToBottom = 3,
}

private enum Slider.Axis
{
	Horizontal = 0,
	Vertical = 1,
}

public enum Toggle.ToggleTransition
{
	None = 0,
	Fade = 1,
}

public enum ColorTween.ColorTweenMode
{
	All = 0,
	RGB = 1,
	Alpha = 2,
}

public enum PointerEventData.InputButton
{
	Left = 0,
	Right = 1,
	Middle = 2,
}

public enum PointerEventData.FramePressState
{
	Pressed = 0,
	Released = 1,
	PressedAndReleased = 2,
	NotChanged = 3,
}

public enum EventTriggerType
{
	PointerEnter = 0,
	PointerExit = 1,
	PointerDown = 2,
	PointerUp = 3,
	PointerClick = 4,
	Drag = 5,
	Drop = 6,
	Scroll = 7,
	UpdateSelected = 8,
	Select = 9,
	Deselect = 10,
	Move = 11,
	InitializePotentialDrag = 12,
	BeginDrag = 13,
	EndDrag = 14,
	Submit = 15,
	Cancel = 16,
}

public enum StandaloneInputModule.InputMode
{
	Mouse = 0,
	Buttons = 1,
}

public enum MoveDirection
{
	Left = 0,
	Up = 1,
	Right = 2,
	Down = 3,
	None = 4,
}

public enum DependencyStatus
{
	Available = 0,
	UnavailableDisabled = 1,
	UnavailableInvalid = 2,
	UnavilableMissing = 3,
	UnavailablePermission = 4,
	UnavailableUpdaterequired = 5,
	UnavailableUpdating = 6,
	UnavailableOther = 7,
}

internal enum VariantExtension.KeyOptions
{
	UseObjectKeys = 0,
	UseStringKeys = 1,
}

internal enum FutureStatus
{
	Complete = 0,
	Pending = 1,
	Invalid = 2,
}

public enum InitResult
{
	Success = 0,
	FailedMissingDependency = 1,
}

public enum LogLevel
{
	Verbose = 0,
	Debug = 1,
	Info = 2,
	Warning = 3,
	Error = 4,
	Assert = 5,
}

internal enum GooglePlayServicesAvailability
{
	AvailabilityAvailable = 0,
	AvailabilityUnavailableDisabled = 1,
	AvailabilityUnavailableInvalid = 2,
	AvailabilityUnavailableMissing = 3,
	AvailabilityUnavailablePermissions = 4,
	AvailabilityUnavailableUpdateRequired = 5,
	AvailabilityUnavailableUpdating = 6,
	AvailabilityUnavailableOther = 7,
}

public enum Variant.Type
{
	Null = 0,
	Int64 = 1,
	Double = 2,
	Bool = 3,
	StaticString = 4,
	MutableString = 5,
	Vector = 6,
	Map = 7,
	StaticBlob = 8,
	MutableBlob = 9,
}

public enum CollisionType
{
	OnCollisionEnter = 0,
	OnCollisionStay = 1,
	OnCollisionExit = 2,
	OnControllerColliderHit = 3,
	OnParticleCollision = 4,
}

public enum TriggerType
{
	OnTriggerEnter = 0,
	OnTriggerStay = 1,
	OnTriggerExit = 2,
}

public enum Collision2DType
{
	OnCollisionEnter2D = 0,
	OnCollisionStay2D = 1,
	OnCollisionExit2D = 2,
	OnParticleCollision = 3,
}

public enum Trigger2DType
{
	OnTriggerEnter2D = 0,
	OnTriggerStay2D = 1,
	OnTriggerExit2D = 2,
}

public enum InterpolationType
{
	Linear = 0,
	EaseInOut = 1,
}

public enum MouseEventType
{
	OnMouseEnter = 0,
	OnMouseOver = 1,
	OnMouseExit = 2,
	OnMouseDown = 3,
	OnMouseUp = 4,
	OnMouseDrag = 5,
}

public enum ActionCategory
{
	Animation = 0,
	Audio = 1,
	Debug = 2,
	Events = 3,
	GameObject = 4,
	GUI = 5,
	Input = 6,
	Math = 7,
	Movement = 8,
	Physics = 9,
	Renderer = 10,
	ScriptControl = 11,
	StateMachine = 12,
	Effects = 13,
	Transform = 14,
	GameLogic = 15,
	String = 16,
	Convert = 17,
	GUIElement = 18,
	Vector3 = 19,
	Material = 20,
	Lights = 21,
	Camera = 22,
	RenderSettings = 23,
	Color = 24,
	Level = 25,
	GUILayout = 26,
	Logic = 27,
	World = 28,
	Screen = 29,
	Movie = 30,
	Time = 31,
	Character = 32,
	Device = 33,
	Controller = 34,
	CharacterController = 35,
	iTween = 36,
	AnimateVariables = 37,
	InputDevice = 38,
	Rect = 39,
	UnityObject = 40,
	Application = 41,
	NavMesh = 42,
	NavMeshAgent = 43,
	Network = 44,
	Vector2 = 45,
	Array = 46,
	Mecanim = 47,
	Animator = 48,
	Quaternion = 49,
	Enum = 50,
	Physics2D = 51,
	Trigonometry = 52,
	Scene = 53,
	UI = 54,
	Tween = 55,
}

public enum UIHint
{
	None = 0,
	TextArea = 1,
	Behaviour = 2,
	Script = 3,
	Method = 4,
	Coroutine = 5,
	Animation = 6,
	Tag = 7,
	Layer = 8,
	Description = 9,
	Variable = 10,
	ScriptComponent = 11,
	Comment = 12,
	NamedColor = 13,
	NamedTexture = 14,
	FsmName = 15,
	FsmEvent = 16,
	FsmFloat = 17,
	FsmInt = 18,
	FsmBool = 19,
	FsmString = 20,
	FsmVector3 = 21,
	FsmGameObject = 22,
	FsmColor = 23,
	FsmRect = 24,
	FsmMaterial = 25,
	FsmTexture = 26,
	FsmQuaternion = 27,
	FsmObject = 28,
	FsmVector2 = 29,
	FsmEnum = 30,
	FsmArray = 31,
	AnimatorFloat = 32,
	AnimatorBool = 33,
	AnimatorInt = 34,
	AnimatorTrigger = 35,
	SortingLayer = 36,
	TagMenu = 37,
}

public enum MouseButton
{
	Left = 0,
	Right = 1,
	Middle = 2,
}

public enum LogLevel
{
	Info = 0,
	Warning = 1,
	Error = 2,
}

public enum ColorBlendMode
{
	Normal = 0,
	Multiply = 1,
	Screen = 2,
}

public enum FsmEventTarget.EventTarget
{
	Self = 0,
	GameObject = 1,
	GameObjectFSM = 2,
	FSMComponent = 3,
	BroadcastAll = 4,
	HostFSM = 5,
	SubFSMs = 6,
}

public enum LayoutOption.LayoutOptionType
{
	Width = 0,
	Height = 1,
	MinWidth = 2,
	MaxWidth = 3,
	MinHeight = 4,
	MaxHeight = 5,
	ExpandWidth = 6,
	ExpandHeight = 7,
}

public enum None
{
	None = 0,
}

public enum OwnerDefaultOption
{
	UseOwner = 0,
	SpecifyGameObject = 1,
}

public enum ParamDataType
{
	Integer = 0,
	Boolean = 1,
	Float = 2,
	String = 3,
	Color = 4,
	ObjectReference = 5,
	LayerMask = 6,
	Enum = 7,
	Vector2 = 8,
	Vector3 = 9,
	Vector4 = 10,
	Rect = 11,
	Array = 12,
	Character = 13,
	AnimationCurve = 14,
	FsmFloat = 15,
	FsmInt = 16,
	FsmBool = 17,
	FsmString = 18,
	FsmGameObject = 19,
	FsmOwnerDefault = 20,
	FunctionCall = 21,
	FsmAnimationCurve = 22,
	FsmEvent = 23,
	FsmObject = 24,
	FsmColor = 25,
	Unsupported = 26,
	GameObject = 27,
	FsmVector3 = 28,
	LayoutOption = 29,
	FsmRect = 30,
	FsmEventTarget = 31,
	FsmMaterial = 32,
	FsmTexture = 33,
	Quaternion = 34,
	FsmQuaternion = 35,
	FsmProperty = 36,
	FsmVector2 = 37,
	FsmTemplateControl = 38,
	FsmVar = 39,
	CustomClass = 40,
	FsmArray = 41,
	FsmEnum = 42,
}

private enum Fsm.EditorFlags
{
	none = 0,
	nameIsExpanded = 1,
	controlsIsExpanded = 2,
	debugIsExpanded = 4,
	experimentalIsExpanded = 8,
}

public enum UiEvents
{
	None = 0,
	Click = 1,
	BeginDrag = 2,
	Drag = 4,
	EndDrag = 8,
	Drop = 16,
	PointerClick = 32,
	PointerDown = 64,
	PointerEnter = 128,
	PointerExit = 256,
	PointerUp = 512,
	EndEdit = 1024,
	BoolValueChanged = 2048,
	FloatValueChanged = 4096,
	IntValueChanged = 8192,
	Vector2ValueChanged = 16384,
	DragEvents = 14,
	PointerEvents = 992,
}

public enum FsmLogType
{
	Info = 0,
	Warning = 1,
	Error = 2,
	Event = 3,
	Transition = 4,
	ExitState = 5,
	EnterState = 6,
	Break = 7,
	SendEvent = 8,
	Start = 9,
	Stop = 10,
}

public enum FsmTransition.CustomLinkStyle
{
	Default = 0,
	Bezier = 1,
	Circuit = 2,
	Direct = 3,
}

public enum FsmTransition.CustomLinkConstraint
{
	None = 0,
	LockLeft = 1,
	LockRight = 2,
}

public enum VariableType
{
	Float = 0,
	Int = 1,
	Bool = 2,
	GameObject = 3,
	String = 4,
	Vector2 = 5,
	Vector3 = 6,
	Color = 7,
	Rect = 8,
	Material = 9,
	Texture = 10,
	Quaternion = 11,
	Object = 12,
	Array = 13,
	Enum = 14,
}

public enum VariableTypeNicified
{
	Float = 0,
	Int = 1,
	Bool = 2,
	GameObject = 3,
	String = 4,
	Vector2 = 5,
	Vector3 = 6,
	Color = 7,
	Rect = 8,
	Material = 9,
	Texture = 10,
	Quaternion = 11,
	Object = 12,
	Array = 13,
	Enum = 14,
}

public enum ArrayVariableTypesNicified
{
	Float = 0,
	Int = 1,
	Bool = 2,
	GameObject = 3,
	String = 4,
	Vector2 = 5,
	Vector3 = 6,
	Color = 7,
	Rect = 8,
	Material = 9,
	Texture = 10,
	Quaternion = 11,
	Object = 12,
	Enum = 14,
}

public enum LoopType
{
	None = 0,
	Loop = 1,
	PingPong = 2,
}

public enum RotationInterpolation
{
	Spherical = 0,
	Linear = 1,
}

public enum RotationOptions
{
	CurrentRotation = 0,
	WorldRotation = 1,
	LocalRotation = 2,
	WorldOffsetRotation = 3,
	LocalOffsetRotation = 4,
	MatchGameObjectRotation = 5,
}

public enum ScaleOptions
{
	CurrentScale = 0,
	LocalScale = 1,
	MultiplyScale = 2,
	AddToScale = 3,
	MatchGameObject = 4,
}

public enum PositionOptions
{
	CurrentPosition = 0,
	WorldPosition = 1,
	LocalPosition = 2,
	WorldOffset = 3,
	LocalOffset = 4,
	TargetGameObject = 5,
}

public enum TargetValueOptions
{
	CurrentValue = 0,
	Offset = 1,
	Value = 2,
}

internal enum ExceptionArgument
{
	length = 0,
	start = 1,
	minimumBufferSize = 2,
	elementIndex = 3,
	comparable = 4,
	comparer = 5,
	destination = 6,
	offset = 7,
	startSegment = 8,
	endSegment = 9,
	startIndex = 10,
	endIndex = 11,
	array = 12,
	culture = 13,
	manager = 14,
}

public enum InitializationFailureReason
{
	PurchasingUnavailable = 0,
	NoProductsAvailable = 1,
	AppNotKnown = 2,
}

public enum PayoutType
{
	Other = 0,
	Currency = 1,
	Item = 2,
	Resource = 3,
}

public enum ProductType
{
	Consumable = 0,
	NonConsumable = 1,
	Subscription = 2,
}

public enum PurchaseFailureReason
{
	PurchasingUnavailable = 0,
	ExistingPurchasePending = 1,
	ProductUnavailable = 2,
	SignatureInvalid = 3,
	UserCancelled = 4,
	PaymentDeclined = 5,
	DuplicateTransaction = 6,
	Unknown = 7,
}

public enum PurchaseProcessingResult
{
	Complete = 0,
	Pending = 1,
}

internal enum TelemetryMetricTypes
{
	Gauge = 0,
	Sum = 1,
	Histogram = 2,
}

public enum Asn1EndOfIndefiniteLengthNodeType
{
	EndOfStream = 0,
	EndOfNodeFooter = 1,
	NotEnd = 2,
}

public enum GooglePurchaseState
{
	Purchased = 0,
	Cancelled = 1,
	Refunded = 2,
	Deferred = 4,
}

public enum Easing.EasingType
{
	Linear = 0,
	QuadraticEaseOut = 1,
	QuadraticEaseIn = 2,
	QuadraticEaseInOut = 3,
	QuadraticEaseOutIn = 4,
	SineEaseOut = 5,
	SineEaseIn = 6,
	SineEaseInOut = 7,
	SineEaseOutIn = 8,
	ExponentialEaseOut = 9,
	ExponentialEaseIn = 10,
	ExponentialEaseInOut = 11,
	ExponentialEaseOutIn = 12,
	CirclicEaseOut = 13,
	CirclicEaseIn = 14,
	CirclicEaseInOut = 15,
	CirclicEaseOutIn = 16,
	CubicEaseOut = 17,
	CubicEaseIn = 18,
	CubicEaseInOut = 19,
	CubicEaseOutIn = 20,
	QuarticEaseOut = 21,
	QuarticEaseIn = 22,
	QuarticEaseInOut = 23,
	QuarticEaseOutIn = 24,
	QuinticEaseOut = 25,
	QuinticEaseIn = 26,
	QuinticEaseInOut = 27,
	QuinticEaseOutIn = 28,
	ElasticEaseOut = 29,
	ElasticEaseIn = 30,
	ElasticEaseInOut = 31,
	ElasticEaseOutIn = 32,
	BounceEaseOut = 33,
	BounceEaseIn = 34,
	BounceEaseInOut = 35,
	BounceEaseOutIn = 36,
	BackEaseOut = 37,
	BackEaseIn = 38,
	BackEaseInOut = 39,
	BackEaseOutIn = 40,
}

public enum ShakeType
{
	None = 0,
	Position = 1,
	Rotation = 2,
	Both = 3,
}

public enum TypeOfTransition
{
	Cut = 0,
	Dissolve = 1,
	WipeLeft = 2,
	WipeRight = 3,
	WipeUp = 4,
	WipeDown = 5,
}

public enum JSONBinaryTag
{
	Array = 1,
	Class = 2,
	Value = 3,
	IntValue = 4,
	DoubleValue = 5,
	BoolValue = 6,
	FloatValue = 7,
}

public enum AdjustEnvironment
{
	Sandbox = 0,
	Production = 1,
}

public enum AdjustLogLevel
{
	Verbose = 1,
	Debug = 2,
	Info = 3,
	Warn = 4,
	Error = 5,
	Assert = 6,
	Suppress = 7,
}

public enum AdjustUrlStrategy
{
	Default = 0,
	DataResidencyEU = 1,
	DataResidencyTK = 2,
	DataResidencyUS = 3,
	India = 4,
	China = 5,
}

public enum BacktraceResultStatus
{
	LimitReached = 0,
	ServerError = 1,
	Ok = 2,
	Empty = 3,
	NetworkError = 4,
}

internal enum BacktraceStackFrameType
{
	Unknown = 0,
	Dotnet = 1,
	Android = 2,
	Native = 3,
}

public enum DeduplicationStrategy
{
	None = 0,
	Default = 1,
	Classifier = 2,
	Message = 4,
}

internal enum MinidumpException
{
	None = 0,
	Present = 1,
}

public enum MiniDumpType
{
	None = 524286,
	Normal = 0,
	WithDataSegs = 1,
	WithFullMemory = 2,
	WithHandleData = 4,
	FilterMemory = 8,
	ScanMemory = 16,
	WithUnloadedModules = 32,
	WithIndirectlyReferencedMemory = 64,
	FilterModulePaths = 128,
	WithProcessThreadData = 256,
	WithPrivateReadWriteMemory = 512,
	WithoutOptionalData = 1024,
	WithFullMemoryInfo = 2048,
	WithThreadInfo = 4096,
	WithCodeSegs = 8192,
	WithoutAuxiliaryState = 16384,
	WithFullAuxiliaryState = 32768,
	WithPrivateWriteCopyMemory = 65536,
	IgnoreInaccessibleMemory = 131072,
	ValidTypeFlags = 262143,
}

public enum ReportFilterType
{
	None = 0,
	Message = 1,
	Exception = 2,
	UnhandledException = 4,
	Hang = 8,
	Error = 16,
}

public enum RetryBehavior
{
	ByInterval = 0,
	NoRetry = 1,
}

public enum RetryOrder
{
	Stack = 0,
	Queue = 1,
}

internal enum UnwindingMode
{
	LOCAL = 0,
	REMOTE = 1,
	REMOTE_DUMPWITHOUTCRASH = 2,
	LOCAL_DUMPWITHOUTCRASH = 3,
	LOCAL_CONTEXT = 4,
}

public enum BacktraceBreadcrumbType
{
	None = 0,
	Manual = 1,
	Log = 2,
	Navigation = 4,
	Http = 8,
	System = 16,
	User = 32,
	Configuration = 64,
}

public enum BreadcrumbLevel
{
	Manual = 1,
	Log = 2,
	Navigation = 4,
	Http = 8,
	System = 16,
	User = 32,
	Configuration = 64,
}

public enum UnityEngineLogLevel
{
	None = 0,
	Debug = 1,
	Warning = 2,
	Info = 4,
	Fatal = 8,
	Error = 16,
}

internal enum ObscuredPrefs.DataType
{
	Unknown = 0,
	Int = 5,
	UInt = 10,
	String = 15,
	Float = 20,
	Double = 25,
	Long = 30,
	Bool = 35,
	ByteArray = 40,
	Vector2 = 45,
	Vector3 = 50,
	Quaternion = 55,
	Color = 60,
	Rect = 65,
}

public enum ObscuredPrefs.DeviceLockLevel
{
	None = 0,
	Soft = 1,
	Strict = 2,
}

public enum DeflateStrategy
{
	Default = 0,
	Filtered = 1,
	HuffmanOnly = 2,
}

private enum GZipOutputStream.OutputState
{
	Header = 0,
	Footer = 1,
	Finished = 2,
	Closed = 3,
}

public enum NotificationStyle
{
	None = 0,
	BigTextStyle = 2,
}

public enum GroupAlertBehaviours
{
	GroupAlertAll = 0,
	GroupAlertSummary = 1,
	GroupAlertChildren = 2,
}

public enum Importance
{
	None = 0,
	Low = 2,
	Default = 3,
	High = 4,
}

public enum LockScreenVisibility
{
	Private = 0,
	Public = 1,
}

internal enum MetricType
{
	Gauge = 0,
	Sum = 1,
	Histogram = 2,
}

internal enum WebRequestResult
{
	Success = 0,
	ConnectionError = 1,
	ProtocolError = 2,
	UnknownError = 3,
}

internal enum GoogleBillingConnectionState
{
	Disconnected = 0,
	Connecting = 1,
	Connected = 2,
	Closed = 3,
}

public enum GooglePlayProrationMode
{
	UnknownSubscriptionUpgradeDowngradePolicy = 0,
	ImmediateWithTimeProration = 1,
	ImmediateAndChargeProratedPrice = 2,
	ImmediateWithoutProration = 3,
	Deferred = 4,
	ImmediateAndChargeFullPrice = 5,
}

public enum AppStore
{
	NotSpecified = 0,
	GooglePlay = 1,
	AmazonAppStore = 2,
	UDP = 3,
	MacAppStore = 4,
	AppleAppStore = 5,
	WinRT = 6,
	fake = 7,
}

public enum AppleStorePromotionVisibility
{
	Default = 0,
	Hide = 1,
	Show = 2,
}

public enum FakeStoreUIMode
{
	Default = 0,
	StandardUser = 1,
	DeveloperUser = 2,
}

protected enum FakeStore.DialogType
{
	Purchase = 0,
	RetrieveProducts = 1,
}

public enum TranslationLocale
{
	zh_TW = 0,
	cs_CZ = 1,
	da_DK = 2,
	nl_NL = 3,
	en_US = 4,
	fr_FR = 5,
	fi_FI = 6,
	de_DE = 7,
	iw_IL = 8,
	hi_IN = 9,
	it_IT = 10,
	ja_JP = 11,
	ko_KR = 12,
	no_NO = 13,
	pl_PL = 14,
	pt_PT = 15,
	ru_RU = 16,
	es_ES = 17,
	sv_SE = 18,
	zh_CN = 19,
	en_AU = 20,
	en_CA = 21,
	en_GB = 22,
	fr_CA = 23,
	el_GR = 24,
	id_ID = 25,
	ms_MY = 26,
	pt_BR = 27,
	es_MX = 28,
	th_TH = 29,
	tr_TR = 30,
	vi_VN = 31,
}

public enum ProductCatalogPayout.ProductCatalogPayoutType
{
	Other = 0,
	Currency = 1,
	Item = 2,
	Resource = 3,
}

public enum StoreSpecificPurchaseErrorCode
{
	SKErrorUnknown = 0,
	SKErrorClientInvalid = 1,
	SKErrorPaymentCancelled = 2,
	SKErrorPaymentInvalid = 3,
	SKErrorPaymentNotAllowed = 4,
	SKErrorStoreProductNotAvailable = 5,
	SKErrorCloudServicePermissionDenied = 6,
	SKErrorCloudServiceNetworkConnectionFailed = 7,
	SKErrorCloudServiceRevoked = 8,
	BILLING_RESPONSE_RESULT_OK = 9,
	BILLING_RESPONSE_RESULT_USER_CANCELED = 10,
	BILLING_RESPONSE_RESULT_SERVICE_UNAVAILABLE = 11,
	BILLING_RESPONSE_RESULT_BILLING_UNAVAILABLE = 12,
	BILLING_RESPONSE_RESULT_ITEM_UNAVAILABLE = 13,
	BILLING_RESPONSE_RESULT_DEVELOPER_ERROR = 14,
	BILLING_RESPONSE_RESULT_ERROR = 15,
	BILLING_RESPONSE_RESULT_ITEM_ALREADY_OWNED = 16,
	BILLING_RESPONSE_RESULT_ITEM_NOT_OWNED = 17,
	IABHELPER_ERROR_BASE = 18,
	IABHELPER_REMOTE_EXCEPTION = 19,
	IABHELPER_BAD_RESPONSE = 20,
	IABHELPER_VERIFICATION_FAILED = 21,
	IABHELPER_SEND_INTENT_FAILED = 22,
	IABHELPER_USER_CANCELLED = 23,
	IABHELPER_UNKNOWN_PURCHASE_RESPONSE = 24,
	IABHELPER_MISSING_TOKEN = 25,
	IABHELPER_UNKNOWN_ERROR = 26,
	IABHELPER_SUBSCRIPTIONS_NOT_AVAILABLE = 27,
	IABHELPER_INVALID_CONSUMPTION = 28,
	Amazon_ALREADY_PURCHASED = 29,
	Amazon_FAILED = 30,
	Amazon_INVALID_SKU = 31,
	Amazon_NOT_SUPPORTED = 32,
	Unknown = 33,
}

public enum Result
{
	True = 0,
	False = 1,
	Unsupported = 2,
}

public enum SubscriptionPeriodUnit
{
	Day = 0,
	Month = 1,
	Week = 2,
	Year = 3,
	NotAvailable = 4,
}

internal enum AppleStoreProductType
{
	NonConsumable = 0,
	Consumable = 1,
	NonRenewingSubscription = 2,
	AutoRenewingSubscription = 3,
}

internal enum GoogleRetrieveProductsFailureReason
{
	BillingServiceDisconnected = 0,
	BillingServiceUnavailable = 1,
}

internal enum GoogleBillingResponseCode
{
	Ok = 0,
	UserCanceled = 1,
	ServiceUnavailable = 2,
	BillingUnavailable = 3,
	ItemUnavailable = 4,
	DeveloperError = 5,
	FatalError = 6,
	ItemAlreadyOwned = 7,
	ItemNotOwned = 8,
}

internal enum Number.NumberBufferKind
{
	Unknown = 0,
	Integer = 1,
	Decimal = 2,
	FloatingPoint = 3,
}

public enum CurveAutoTangentModes
{
	None = 0,
	Smooth = 1,
	Flatten = 2,
	RightLinear = 3,
	RightConstant = 4,
	LeftLinear = 5,
	LeftConstant = 6,
	BothLinear = 7,
	BothConstant = 8,
	Count = 9,
}

public enum UILayer
{
	Front = 0,
	Middle = 1,
	Back = 2,
}

public enum UIPosition
{
	Center = 0,
	TopLeft = 1,
	TopRight = 2,
	BottomLeft = 3,
	BottomRight = 4,
}

public enum PropertyTypeInfo
{
	Int = 0,
	Long = 1,
	Float = 2,
	Double = 3,
	Bool = 4,
	Vec2 = 5,
	Vec3 = 6,
	Vec4 = 7,
	Quat = 8,
	Colour = 9,
}

public enum USRecord.PlayerResolution
{
	_1920x1080 = 0,
	_1280x720 = 1,
	_960x540 = 2,
	_854x480 = 3,
	_720x576 = 4,
	_640x480 = 5,
	_Custom = 6,
}

public enum USRecord.FrameRate
{
	_24 = 0,
	_25 = 1,
	_30 = 2,
	_50 = 3,
	_60 = 4,
}

public enum USRecord.Upscaling
{
	_1 = 0,
	_2 = 1,
	_4 = 2,
	_8 = 3,
}

public enum SplineOrientationMode
{
	ManualOrientation = 0,
	LookAtTransform = 1,
	LookAhead = 2,
}

public enum ApplicationChrome.States
{
	Unknown = 0,
	Visible = 1,
	VisibleOverContent = 2,
	TranslucentOverContent = 3,
	Hidden = 4,
}

public enum ChargeServicePluginScript.Response
{
	BILLING_RESPONSE_RESULT_OK = 0,
	BILLING_RESPONSE_RESULT_USER_CANCELED = 1,
	BILLING_RESPONSE_RESULT_BILLING_UNAVAILABLE = 3,
	BILLING_RESPONSE_RESULT_ITEM_UNAVAILABLE = 4,
	BILLING_RESPONSE_RESULT_DEVELOPER_ERROR = 5,
	BILLING_RESPONSE_RESULT_ERROR = 6,
	BILLING_RESPONSE_RESULT_ITEM_ALREADY_OWNED = 7,
	BILLING_RESPONSE_RESULT_ITEM_NOT_OWNED = 8,
}

public enum CriAtomOutputDeviceObserver.OutputDeviceType
{
	BuiltinSpeaker = 0,
	WiredDevice = 1,
	WirelessDevice = 2,
}

public enum CriAtomSource.Status
{
	Stop = 0,
	Prep = 1,
	Playing = 2,
	PlayEnd = 3,
	Error = 4,
}

public enum CriAtomEx.CharacterEncoding
{
	Utf8 = 0,
	Sjis = 1,
}

public enum CriAtomEx.SoundRendererType
{
	Default = 0,
	Native = 1,
	Asr = 2,
	Hw1 = 1,
	Hw2 = 9,
}

public enum CriAtomEx.VoiceAllocationMethod
{
	Once = 0,
	Retry = 1,
}

public enum CriAtomEx.BiquadFilterType
{
	Off = 0,
	LowPass = 1,
	HighPass = 2,
	Notch = 3,
	LowShelf = 4,
	HighShelf = 5,
	Peaking = 6,
}

public enum CriAtomEx.ResumeMode
{
	AllPlayback = 0,
	PausedPlayback = 1,
	PreparedPlayback = 2,
}

public enum CriAtomEx.PanType
{
	Pan3d = 0,
	Pos3d = 1,
	Auto = 2,
}

public enum CriAtomEx.VoiceControlMethod
{
	PreferLast = 0,
	PreferFirst = 1,
}

public enum CriAtomEx.Parameter
{
	Volume = 0,
	Pitch = 1,
	Pan3dAngle = 2,
	Pan3dDistance = 3,
	Pan3dVolume = 4,
	BusSendLevel0 = 9,
	BusSendLevel1 = 10,
	BusSendLevel2 = 11,
	BusSendLevel3 = 12,
	BusSendLevel4 = 13,
	BusSendLevel5 = 14,
	BusSendLevel6 = 15,
	BusSendLevel7 = 16,
	BandPassFilterCofLow = 17,
	BandPassFilterCofHigh = 18,
	BiquadFilterType = 19,
	BiquadFilterFreq = 20,
	BiquadFIlterQ = 21,
	BiquadFilterGain = 22,
	EnvelopeAttackTime = 23,
	EnvelopeHoldTime = 24,
	EnvelopeDecayTime = 25,
	EnvelopeReleaseTime = 26,
	EnvelopeSustainLevel = 27,
	StartTime = 28,
	Priority = 31,
}

public enum CriAtomEx.Speaker
{
	FrontLeft = 0,
	FrontRight = 1,
	FrontCenter = 2,
	LowFrequency = 3,
	SurroundLeft = 4,
	SurroundRight = 5,
	SurroundBackLeft = 6,
	SurroundBackRight = 7,
}

public enum CriAtomEx.Format
{
	ADX = 1,
	HCA = 3,
	HCA_MX = 4,
	WAVE = 5,
	RAW_PCM = 6,
}

private enum CriAtomEx.SpeakerSystem
{
	Surround_5_1 = 0,
	Surround_7_1 = 1,
}

public enum CriAtomEx.Randomize3dCalcType
{
	Rectangle = 0,
	Cuboid = 1,
	Circle = 2,
	Cylinder = 3,
	Sphere = 4,
	List = 6,
}

public enum CriAtomEx.Randomize3dParamType
{
	None = 0,
	Width = 1,
	Depth = 2,
	Height = 3,
	Radius = 4,
}

public enum CriAtomEx.CueType
{
	Polyphonic = 0,
	Sequential = 1,
	Shuffle = 2,
	Random = 3,
	RandomNoRepeat = 4,
	SwitchGameVariable = 5,
	ComboSequential = 6,
	SwitchSelector = 7,
	TrackTransitionBySelector = 8,
}

public enum CriAtomExCategory.ReactType
{
	Ducker = 0,
	AisacModulationTrigger = 1,
}

public enum CriAtomExCategory.ReactDuckerTargetType
{
	Volume = 0,
	AisacControlValue = 1,
}

public enum CriAtomExCategory.ReactDuckerCurveType
{
	Linear = 0,
	Square = 1,
	SquareReverse = 2,
	SCurve = 3,
	FlatAtHalf = 4,
}

public enum CriAtomExCategory.ReactHoldType
{
	WhilePlaying = 0,
	FixedTime = 1,
}

public enum CriAtomExCategory.ReactStatus
{
	Stop = 0,
	FadeOut = 1,
	Hold = 2,
	FadeIn = 3,
	Error = 4,
}

public enum CriAtomExLatencyEstimator.Status
{
	Stop = 0,
	Processing = 1,
	Done = 2,
	Error = 3,
}

public enum CriAtomExAcbLoader.Status
{
	Stop = 0,
	Loading = 1,
	Complete = 2,
	Error = 3,
}

public enum CriAtomExAcf.AcfDspBusLinkType
{
	preVolume = 0,
	postVolume = 1,
	postPan = 2,
}

public enum CriAtomExAcf.AcfAisacType
{
	normal = 0,
	autoModulation = 1,
}

public enum CriAtomExAcf.AisacGraphType
{
	none = 0,
	volume = 1,
	pitch = 2,
	bandpassHigh = 3,
	bandpassLow = 4,
	biquadFreq = 5,
	biquadQ = 6,
	busSend0 = 7,
	busSend1 = 8,
	busSend2 = 9,
	busSend3 = 10,
	busSend4 = 11,
	busSend5 = 12,
	busSend6 = 13,
	busSend7 = 14,
	pan3dAngel = 15,
	pan3dVolume = 16,
	pan3dInteriorDistance = 17,
	pan3dCenter = 18,
	pan3dLfe = 19,
	aisac0 = 20,
	aisac1 = 21,
	aisac2 = 22,
	aisac3 = 23,
	aisac4 = 24,
	aisac5 = 25,
	aisac6 = 26,
	aisac7 = 27,
	aisac8 = 28,
	aisac9 = 29,
	aisac10 = 30,
	aisac11 = 31,
	aisac12 = 32,
	aisac13 = 33,
	aisac14 = 34,
	aisac15 = 35,
	priority = 36,
	preDelayTime = 37,
	biquadGain = 38,
	pan3dMixdownCenter = 39,
	pan3dMixdownLfe = 40,
	egAttack = 41,
	egRelease = 42,
	playbackRatio = 43,
	drySendL = 44,
	drySendR = 45,
	drySendCenter = 46,
	drySendLfe = 47,
	drySendSl = 48,
	drySendSr = 49,
	drySendEx1 = 50,
	drySendEx2 = 51,
	panSpread = 52,
}

public enum CriAtomExAcf.CharacterEncoding
{
	utf8 = 0,
	sjis = 1,
}

public enum CriAtomExPlayback.Status
{
	Prep = 1,
	Playing = 2,
	Removed = 3,
}

public enum CriAtomExPlayer.Status
{
	Stop = 0,
	Prep = 1,
	Playing = 2,
	PlayEnd = 3,
	Error = 4,
}

public enum CriAtomExPlayer.TimeStretchParameterId
{
	Ratio = 0,
	FrameTime = 1,
	Quality = 2,
}

public enum CriAtomExPlayer.PitchShifterParameterId
{
	Pitch = 0,
	Formant = 1,
	Mode = 2,
}

public enum CriAtomExPlayerOutputAnalyzer.Type
{
	LevelMeter = 0,
	SpectrumAnalyzer = 1,
	PcmCapture = 2,
}

public enum CriAtomExTween.ParameterType
{
	Basic = 0,
	Aisac = 1,
}

public enum CriAtomExVoicePool.VoicePoolId
{
	StandardMemory = 0,
	StandardStreaming = 1,
	HcaMxMemory = 4,
	HcaMxStreaming = 5,
	LowLatencyMemory = 2,
	LowLatencyStreaming = 3,
}

public enum CriAtomExVoicePool.PitchShifterMode
{
	Music = 0,
	Vocal = 1,
	SoundEffect = 2,
	Speech = 3,
}

public enum CriAtomExRawPcmVoicePool.RawPcmFormat
{
	Sint16 = 0,
	Float32 = 1,
}

public enum CriFsLoader.Status
{
	Stop = 0,
	Loading = 1,
	Complete = 2,
	Error = 3,
}

public enum CriFsInstaller.Status
{
	Stop = 0,
	Busy = 1,
	Complete = 2,
	Error = 3,
}

private enum CriFsInstaller.CopyPolicy
{
	Always = 0,
}

public enum CriFsBinder.Status
{
	None = 0,
	Analyze = 1,
	Complete = 2,
	Unbind = 3,
	Removed = 4,
	Invalid = 5,
	Error = 6,
}

private enum CriFsLoadFileRequest.Phase
{
	Stop = 0,
	Bind = 1,
	Load = 2,
	Done = 3,
	Error = 4,
}

public enum CriFsBindRequest.BindType
{
	Cpk = 0,
	Directory = 1,
	File = 2,
}

public enum CriFsWebInstaller.Status
{
	Stop = 0,
	Busy = 1,
	Complete = 2,
	Error = 3,
}

public enum CriFsWebInstaller.Error
{
	None = 0,
	Timeout = 1,
	Memory = 2,
	LocalFs = 3,
	DNS = 4,
	Connection = 5,
	SSL = 6,
	HTTP = 7,
	Internal = 8,
}

public enum CriManaMovieMaterial.MaxFrameDrop
{
	Disabled = 0,
	One = 1,
	Two = 2,
	Three = 3,
	Four = 4,
	Five = 5,
	Six = 6,
	Seven = 7,
	Eight = 8,
	Nine = 9,
	Ten = 10,
}

public enum CriManaMovieMaterial.RenderMode
{
	Always = 0,
	OnVisibility = 1,
	Never = 2,
}

public enum CriAtomConfig.InGamePreviewSwitchMode
{
	Disable = 0,
	Enable = 1,
	FollowBuildSetting = 2,
	Default = 3,
}

public enum CriAtomConfig.LinuxOutput
{
	Default = 0,
	PulseAudio = 1,
	ALSA = 2,
}

public enum CriAtomExAcfDebug.AisacType
{
	Normal = 0,
	AutoModulation = 1,
}

public enum CriDisposableObjectManager.ModuleType
{
	Atom = 0,
	AtomMic = 1,
	Fs = 2,
	FsWeb = 3,
	Mana = 4,
	Lips = 5,
	Vip = 6,
}

public enum ContinuousGesturePhase
{
	None = 0,
	Started = 1,
	Updated = 2,
	Ended = 3,
}

public enum GestureRecognitionState
{
	Ready = 0,
	Started = 1,
	InProgress = 2,
	Failed = 3,
	Ended = 4,
	Recognized = 4,
	FailAndRetry = 5,
}

public enum GestureResetMode
{
	Default = 0,
	NextFrame = 1,
	EndOfTouchSequence = 2,
}

public enum GestureRecognizer.SelectionType
{
	Default = 0,
	StartSelection = 1,
	CurrentSelection = 2,
	None = 3,
}

public enum FingerHoverPhase
{
	None = 0,
	Enter = 1,
	Exit = 2,
}

public enum FingerMotionPhase
{
	None = 0,
	Started = 1,
	Updated = 2,
	Ended = 3,
}

private enum FingerMotionDetector.EventType
{
	Move = 0,
	Stationary = 1,
}

public enum FingerGestures.FingerPhase
{
	None = 0,
	Begin = 1,
	Moving = 2,
	Stationary = 3,
}

public enum FingerGestures.SwipeDirection
{
	Right = 1,
	Left = 2,
	Up = 4,
	Down = 8,
	UpperLeftDiagonal = 16,
	UpperRightDiagonal = 32,
	LowerRightDiagonal = 64,
	LowerLeftDiagonal = 128,
	None = 0,
	Vertical = 12,
	Horizontal = 3,
	Cross = 15,
	UpperDiagonals = 48,
	LowerDiagonals = 192,
	Diagonals = 240,
	All = 255,
}

public enum DistanceUnit
{
	Pixels = 0,
	Inches = 1,
	Centimeters = 2,
}

public enum TwistMethod
{
	Standard = 0,
	Pivot = 1,
}

public enum TBOrbit.PanMode
{
	Disabled = 0,
	OneFinger = 1,
	TwoFingers = 2,
}

public enum TBPinchZoom.ZoomMethod
{
	Position = 0,
	FOV = 1,
}

public enum TBDragToMove.DragPlaneType
{
	Camera = 0,
	UseCollider = 1,
}

public enum TBTwistToRotate.RotationAxis
{
	WorldX = 0,
	WorldY = 1,
	WorldZ = 2,
	ObjectX = 3,
	ObjectY = 4,
	ObjectZ = 5,
	CameraX = 6,
	CameraY = 7,
	CameraZ = 8,
}

public enum NewsFeedCampaignType
{
	Unknown = 0,
	PushNotification = 1,
	InAppMessage = 2,
	WebMessage = 4,
	All = 8,
}

public enum EventPropertySetIndicator
{
	CONTENT_ID = 1,
	CONTENT_NAME = 2,
	CONTENT_CATEGORY = 4,
	VALUE = 8,
	CURRENCY = 16,
	NUM_ITEMS = 32,
	SEARCH_STRING = 64,
	SERVICE_NAME = 128,
	STATUS = 256,
	EXTRAS = 512,
}

public enum Repro.LogLevel
{
	Debug = 0,
	Info = 1,
	Warn = 2,
	Error = 3,
	None = 4,
}

public enum Repro.FetchStatus
{
	Success = 0,
	TimeoutReached = 1,
	AlreadyFetched = 2,
}

public enum Bloom.LensFlareStyle
{
	Ghosting = 0,
	Anamorphic = 1,
	Combined = 2,
}

public enum Bloom.TweakMode
{
	Basic = 0,
	Complex = 1,
}

public enum Bloom.HDRBloomMode
{
	Auto = 0,
	On = 1,
	Off = 2,
}

public enum Bloom.BloomScreenBlendMode
{
	Screen = 0,
	Add = 1,
}

public enum Bloom.BloomQuality
{
	Cheap = 0,
	High = 1,
}

public enum SSAOEffect.SSAOSamples
{
	Low = 0,
	Medium = 1,
	High = 2,
}

public enum Vignetting.AberrationMode
{
	Simple = 0,
	Advanced = 1,
}

public enum CodecType
{
	Unknown = 0,
	SofdecPrime = 1,
	H264 = 5,
	VP9 = 9,
}

public enum AlphaType
{
	CompoOpaq = 0,
	CompoAlphaFull = 1,
	CompoAlpha3Step = 2,
	CompoAlpha32Bit = 3,
}

public enum Player.Status
{
	Stop = 0,
	Dechead = 1,
	WaitPrep = 2,
	Prep = 3,
	Ready = 4,
	Playing = 5,
	PlayEnd = 6,
	Error = 7,
	StopProcessing = 8,
	ReadyForRendering = 9,
}

public enum Player.SetMode
{
	New = 0,
	Append = 1,
	AppendRepeatedly = 2,
}

public enum Player.MovieEventSyncMode
{
	FrameTime = 0,
	PlayBackTime = 1,
}

public enum Player.AudioTrack
{
	Off = 0,
	Auto = 1,
}

public enum Player.TimerType
{
	None = 0,
	System = 1,
	Audio = 2,
	User = 3,
	Manual = 4,
}

public enum Player.CriManaUnityPlayer_RenderEventAction
{
	UPDATE = 0,
	INITIALIZE = 256,
	RENDER = 512,
	DESTROY = 768,
}

protected enum AchievementExchangeConditionsDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

private enum AssistEffectConfirmDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum BaseDialog.MaskType
{
	CLEAR = 0,
	MASK = 1,
	BLACK = 2,
}

public enum BoostSupportRequestItemListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	IMPOSSIBLE_SELECTION = 3,
	DISPLAY = 4,
}

public enum BoostSupportRequestItemListViewManager.ResultKind
{
	CANCEL = 0,
	UNSELECT = 1,
	SELECT = 2,
	IMPOSSIBLE_SELECT = 3,
}

protected enum BoostSupportRequestMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum CampaignInformation.UrlOpenType
{
	NONE = 0,
	WEBVIEW = 1,
	BROWSER = 2,
}

protected enum CenterEffectDetailDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

protected enum ClassCompatibilityInfoDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLASS_BOARD_EFFECT = 4,
	CLOSE = 5,
}

protected enum ClassCompatibilityMenu.State
{
	INIT = 0,
	INPUT = 1,
	SELECTED = 2,
	CLOSE = 3,
}

private enum CommandAssistConfirmDialogComponent.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum CompleteMissionComponent.Type
{
	COMPLETE = 0,
}

public enum CompleteMissionListViewManager.FilterStatus
{
	INIT = 0,
	CLEAR = 1,
	PROGRESS = 2,
	ACHIVE = 3,
}

public enum ConnectMark.Mode
{
	DEFAULT = 0,
	LOAD = 1,
	LOAD_TIP = 2,
	LOAD_PROFILE_BOOT = 3,
	LOAD_BAR = 4,
	LOAD_BAR_CANCEL = 5,
	LOAD_BAR_BOOT = 6,
	LOAD_BAR_PROFILE_BOOT = 7,
	MASK = 8,
	LOAD_MOVIE = 9,
	THINKING = 10,
}

public enum EquipGraphListMenu.ModeKind
{
	STATUS = 0,
	LOCK = 1,
	CHOICE = 2,
	SUM = 3,
}

public enum EquipGraphListMenu.ResultKind
{
	CANCEL = 0,
	DECIDE = 1,
}

protected enum EquipGraphListMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
	SHOW_STATUS = 5,
}

public enum EquipGraphListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum EquipGraphListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
	MODIFY = 3,
}

public enum EquipGraphListViewManager.ResultKind
{
	CANCEL = 0,
	DECIDE = 1,
	SELECT = 2,
	SHOW_STATUS = 3,
}

public enum EquipGraphListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	MODIFY = 4,
}

protected enum EquipGraphListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum EquipGraphServantItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

private enum EventInfoChronologyDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	CLOSE = 3,
}

public enum EventInfoCircleProgressControl.DispState
{
	FRONT = 0,
	BACK = 1,
}

public enum EventInfoCircleProgressControl.VoiceType
{
	NONE = 0,
	PROGRESS_UP = 1,
	COMPLETED = 2,
}

public enum EventInfoCircleProgressControl.ExCiarcleState
{
	HIDE = 0,
	INSERT = 1,
	DISP = 2,
}

public enum EventInfoDetectiveRankControl.DetectiveRank
{
	RANK_E = 0,
	RANK_D = 1,
	RANK_C = 2,
	RANK_B = 3,
	RANK_A = 4,
	RANK_EX = 5,
}

public enum EventInfoDistanceDispComponent.BorderType
{
	MORE_THAN = 1,
	OR_MORE = 2,
	OR_LESS = 3,
	LESS_THAN = 4,
}

public enum EventInfoJapaneseCushionControl.ServantType
{
	MAIN = 0,
	RIVAL = 1,
}

public enum EventInfoPointGaugeComponent.GaugeState
{
	NONE = 0,
	CLOSE = 1,
	OPEN = 2,
}

public enum EventInfoPointGaugeComponent.AnimeState
{
	NONE = 0,
	PLAY = 1,
}

public enum EventInfoSpotCooltimeRewardReceiveButton.Mode
{
	MAP = 0,
	EventReward = 1,
}

public enum EventInfoTipsArchiveDialog.TabKind
{
	CHARACTER = 0,
	TERMS = 1,
	WORLD = 2,
	SUM = 3,
}

private enum EventInfoTipsArchiveDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	CLOSE = 3,
}

public enum EventInfoTipsArchiveListViewItemDraw.Kind
{
	NONE = 0,
}

public enum EventInfoTipsArchiveListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum EventInfoTipsArchiveListViewManager.InitMode
{
	NONE = 0,
	INPUT = 1,
	VALID = 2,
	MODIFY = 3,
}

public enum EventInfoTipsArchiveListViewManager.ResultKind
{
	SELECT = 0,
}

public enum EventInfoTipsArchiveListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	MODIFY = 4,
}

protected enum EventInfoTipsArchiveListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum EventInfoUIBase.ValueType
{
	Nothing = 0,
	EventId = 1,
	ConquestInfos = 2,
	TotalBoxGacha = 3,
	EventPoint = 4,
}

public enum EventInfoUIBase.SetType
{
	Always = 0,
	Init = 1,
	BoxGachaReset = 2,
}

public enum EventInfoUIBase.PlayType
{
	None = 0,
	OnEventActionPlay = 1,
}

public enum EventInfoUIBase.AnimType
{
	None = 0,
	CountUp = 1,
}

public enum EventInfoUIVoicePlayer.State
{
	READY = 0,
	PLAY = 1,
}

private enum FriendCodeComponent.DispState
{
	INVISIBLE = 0,
	HIDDEN = 1,
	OPENED = 2,
}

protected enum FriendPointNoticeDlgComponent.State
{
	INIT = 0,
	OPEN = 1,
}

public enum FriendPointNoticeDlgComponent.ResultClicked
{
	RIGHT = 0,
	MIDDLE = 1,
	CANCEL = 2,
}

private enum GiftButtonCtrl.BOX_STATE
{
	EMPTY = 0,
	MANY = 1,
	ALMOST_FULL = 2,
	MAX = 3,
}

public enum ServantCoinConfirmDialog.DispType
{
	SERVANT_COIN_GET = 1,
	SERVANT_COIN_OVERFLOW = 2,
}

public enum MaskFade.Kind
{
	NONE = 0,
	BLACK = 1,
	WHITE = 2,
}

public enum MasterMissionComponent.Type
{
	DAILY = 0,
	WEEKLY = 1,
	EXTRA = 2,
	LIMITED = 3,
}

public enum MasterMissionListViewManager.FilterStatus
{
	INIT = 0,
	CLEAR = 1,
	PROGRESS = 2,
	ACHIVE = 3,
}

protected enum MasterMissionReceiveConfirmDialog.State
{
	Open = 0,
	Decide = 1,
	Close = 2,
}

public enum MasterMissionReceiveConfirmListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum MasterMissionReceiveConfirmListViewManager.InitMode
{
	NONE = 0,
	INPUT = 1,
	VALID = 2,
}

public enum MasterMissionReceiveConfirmListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

protected enum MasterMissionReceiveConfirmListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

protected enum MasterMissionReceiveResultDialog.State
{
	Open = 0,
	Close = 1,
}

public enum MissionInfoMaker.ProgStatus
{
	LOCK = 0,
	NOSTART = 1,
	PROGRESS = 2,
	CLEAR = 3,
	ACHIVE = 4,
	END = 5,
}

protected enum MissionRewardGetDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	CLOSE = 3,
}

public enum MissionListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum MissionListViewManager.InitMode
{
	NONE = 0,
	INTO = 1,
	VALID = 2,
	INPUT = 3,
	ENTER = 4,
	EXIT = 5,
	MODIFY = 6,
}

public enum MissionListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	INTO = 4,
	ENTER = 5,
	EXIT = 6,
	MODIFY = 7,
}

protected enum MissionListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum MissionNotifyComponent.STATE
{
	NONE = 0,
	FRAME_IN = 1,
	SHOWING = 2,
	FRAME_OUT = 3,
	SIZEOF = 4,
}

public enum MovieConfirmDialog.Mode
{
	Play = 0,
	Download = 1,
}

public enum PresentBoxNotificationListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum PresentBoxNotificationListViewManager.Kind
{
	NORMAL = 0,
}

public enum PresentBoxNotificationListViewManager.InitMode
{
	NONE = 0,
	INPUT = 1,
}

public enum PresentBoxNotificationListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

protected enum PresentBoxNotificationListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum PresentBoxNotificationMenu.Result
{
	CANCEL = 0,
}

protected enum PresentBoxNotificationMenu.State
{
	INIT = 0,
	OPEN = 1,
	INIT_PRESENT_CHECK = 2,
	INIT_PRESENT_CHECK2 = 3,
	INPUT_PRESENT_CHECK = 4,
	QUIT_PRESENT_CHECK = 5,
	QUIT_PRESENT_CHECK2 = 6,
}

public enum QuestPhaseRewardComponent.STATE
{
	NONE = 0,
	PLAY = 1,
	SIZEOF = 2,
}

private enum ApRecoverConfirmDlgComponent.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum RecoverDlgComponent.Result
{
	CANCEL = 0,
	ERROR = 1,
	RECOVER = 2,
}

public enum RecoverItemComponent.CMDSPELL_TYPE
{
	AP_RECOVER = 3,
	AP_ADD = 4,
}

public enum ServantEquipFramePurchaseConfirmMenu.Kind
{
	FRAME = 0,
	STONE = 1,
	PURCHASE = 2,
	MAX_FRAME = 3,
	NO_INFO = 4,
}

protected enum ServantEquipFramePurchaseConfirmMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum ServantEquipFramePurchaseMenu.Result
{
	CANCEL = 0,
	ERROR = 1,
	PURCHASE = 2,
}

protected enum ServantEquipFramePurchaseMenu.State
{
	INIT = 0,
	INPUT_NO_SHOP_CONFIRM = 1,
	INPUT_MAX_FRAME_CONFIRM = 2,
	INPUT_BUY_FRAME_CONFIRM = 3,
	INPUT_BUY_STONE_CONFIRM = 4,
	INPUT_BUY_STONE = 5,
	REQUEST_BUY_FRAME = 6,
	RESULT_BUY_FRAME = 7,
}

public enum ServantFramePurchaseConfirmMenu.Kind
{
	FRAME = 0,
	STONE = 1,
	PURCHASE = 2,
	MAX_FRAME = 3,
	NO_INFO = 4,
}

protected enum ServantFramePurchaseConfirmMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum ServantFramePurchaseMenu.Result
{
	CANCEL = 0,
	ERROR = 1,
	PURCHASE = 2,
}

protected enum ServantFramePurchaseMenu.State
{
	INIT = 0,
	INPUT_NO_SHOP_CONFIRM = 1,
	INPUT_MAX_FRAME_CONFIRM = 2,
	INPUT_BUY_FRAME_CONFIRM = 3,
	INPUT_BUY_STONE_CONFIRM = 4,
	INPUT_BUY_STONE = 5,
	REQUEST_BUY_FRAME = 6,
	RESULT_BUY_FRAME = 7,
}

protected enum ServantFrameShortDlgComponent.State
{
	INIT = 0,
	OPEN = 1,
}

public enum ServantFrameShortDlgComponent.resultClicked
{
	POWERUP = 0,
	WAREHOUSE = 1,
	SELL = 2,
	CANCEL = 3,
}

public enum ServantFrameShortDlgComponent.Type
{
	SERVANT = 0,
	EQUIP = 1,
	COMMAND_CODE = 2,
}

public enum ServantFrameShortDlgComponent.EventType
{
	NONE = 0,
	EXPEDITION = 1,
	AREA_IMPROVE = 2,
	EVENT_RECIPE = 3,
}

public enum ServantLimitUpVoiceCache.Type
{
	NONE = 0,
	MATERIAL = 1,
	SERVANT_DETAIL = 2,
}

public enum OtherUserSortDialog.ModeKind
{
	SUPPORT_SELECT = 0,
	FRIEND_MEMBER_LIST = 1,
	FRIEND_REQUEST_LIST = 2,
}

private enum OtherUserSortDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

protected enum PresentBoxFilterSelectMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum ServantBonusFilterSelectMenu.Kind
{
	SUPPORT = 0,
}

protected enum ServantBonusFilterSelectMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum ServantFilterSelectMenu.Kind
{
	SERVANT_KEEP = 0,
	SERVANT = 1,
	SERVANT_BASE = 2,
	SERVANT_MATERIAL = 3,
	SERVANT_COSTUME = 4,
	SERVANT_EQUIP = 5,
	COMMANDCODE = 6,
	SERVANT_SELL = 7,
	SERVANT_FAVORITE = 8,
	SERVANT_MULTIPLE = 9,
	SERVANT_SUPPORT_BY_CLASS = 10,
	SERVANT_SUPPORT_BY_EXTRA_CLASS = 11,
	SERVANT_SUMMON_NOT_EXTRA = 12,
	SERVANT_SUMMON_EXTRA1 = 13,
	SERVANT_SUMMON_EXTRA2 = 14,
}

protected enum ServantFilterSelectMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum ServantSortSelectMenu.Kind
{
	SERVANT_COMBINE_BASE_SELECT = 0,
	SERVANT_COMBINE_SELECT = 1,
	SERVANT_COMBINE_EQUIP_SELECT = 2,
	SERVANT_NORMAL_SELECT = 3,
	SERVANT_EQUIP_NORMAL_SELECT = 4,
	SERVANT_COSTUME_BASE_SELECT = 5,
	COMMAND_CODE_SELECT = 6,
	SERVANT_RECOVERY_FATIGUE = 7,
	SERVANT_BUDDY_POINT_SELECT = 8,
}

protected enum ServantSortSelectMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum ServantStatusBattleListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum ServantStatusBattleListViewManager.InitMode
{
	NONE = 0,
	INPUT = 1,
	MODIFY = 2,
}

public enum ServantStatusBattleListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	MODIFY = 4,
}

protected enum ServantStatusBattleListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum ServantStatusCharaGraphListViewItem.ItemDataType
{
	NORMAL = 0,
	EX = 1,
}

public enum ServantStatusCharaGraphListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum ServantStatusCharaGraphListViewManager.Kind
{
	NORMAL = 0,
}

public enum ServantStatusCharaGraphListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
}

public enum ServantStatusCharaGraphListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	MAXIM = 4,
	FADEOUT_FRAME = 5,
	USUALLY = 6,
	VIEWER = 7,
	VIEWER_HIDE_FRAME = 8,
	VIEWER_FADEOUT_FRAME = 9,
	VIEWER_EX = 10,
}

protected enum ServantStatusCharaGraphListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum ServantStatusCharaGraphViewer.DispType
{
	NONE = 0,
	DRAG_OBJ = 1,
	SCROLL_VIEW = 2,
}

public enum ServantStatusCharaGraphViewerListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
}

private enum ServantStatusCharaGraphViewerListViewManager.Phase
{
	NORMAL = 0,
	HIDE_FRAME = 1,
}

public enum ServantStatusDialog.MaskType
{
	NONE = 0,
	RANDOM_LIMIT_COUNT_SETTING = 1,
	SELECT_RANDOM_LIMIT_COUNT_SUPPORT = 2,
	RANDOM_LIMIT_COUNT_OTHER_SETTING = 3,
}

public enum ServantStatusDialog.Kind
{
	NORMAL = 0,
	PARTY = 1,
	COLLECTION = 2,
	STORAGE = 3,
	FRIEND = 4,
	FOLLOWER = 5,
	FIRST_SINGLE_GET = 6,
	DROP = 7,
	SUMMON = 8,
	COMBINE = 9,
	COMBINE_MATERIAL = 10,
	SERVANT_EQUIP = 11,
	STORAGE_SERVANT_EQUIP = 12,
	FRIEND_SERVANT_EQUIP = 13,
	FOLLOWER_SERVANT_EQUIP = 14,
	FIRST_SINGLE_GET_SERVANT_EQUIP = 15,
	DROP_SERVANT_EQUIP = 16,
	SUMMON_SERVANT_EQUIP = 17,
	COMBINE_SERVANT_EQUIP = 18,
	NPC_FOLLOWER_SERVANT_EQUIP = 19,
	COMMAND_CODE = 20,
	STORAGE_COMMAND_CODE = 21,
	FRIEND_COMMAND_CODE = 22,
	FOLLOWER_COMMAND_CODE = 23,
	FIRST_SINGLE_GET_COMMAND_CODE = 24,
	DROP_COMMAND_CODE = 25,
	SUMMON_COMMAND_CODE = 26,
	COMBINE_COMMAND_CODE = 27,
	ENEMY_COLLECTION_DETAIL = 28,
	CONFIRM_DIALOG_SVT = 29,
	CONFIRM_DIALOG_NOSVT = 30,
	CONFIRM_DIALOG_EQUIP = 31,
	CONFIRM_DIALOG_COMMAND_CODE = 32,
	COLLECTION_PROFILE = 33,
	SHOP = 34,
	COMBINE_SERVANT_SELECTED = 35,
	COMBINE_MATERIAL_SELECTED = 36,
}

public enum ServantStatusDialog.TabKind
{
	STATUS = 0,
	PROFILE = 1,
	BATTLE = 2,
	VOICE = 3,
	SUM = 4,
}

protected enum ServantStatusDialog.VoiceAssetType
{
	BATTLE = 0,
	HOME = 1,
	NP = 2,
}

public enum ServantStatusFlavorTextListViewItemDraw.Kind
{
	NONE = 0,
	TEXT = 1,
	TEXT2 = 2,
	VOICE = 3,
	VOICE2 = 4,
	PARAM = 5,
	TERMINAL = 6,
}

public enum ServantStatusFlavorTextListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum ServantStatusFlavorTextListViewManager.InitMode
{
	NONE = 0,
	INPUT = 1,
	VALID = 2,
}

public enum ServantStatusFlavorTextListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

protected enum ServantStatusFlavorTextListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

private enum ServantStatusListViewItem.RandomLimitCountSetting
{
	CONFORM_GLOBAL = 0,
	LOCAL_ON = 1,
	LOCAL_OFF = 2,
}

private enum ServantStatusListViewItem.RandomLimitCountButton
{
	OWN_CONFORM_GLOBAL = 0,
	OWN_LOCAL_ON = 1,
	OWN_LOCAL_OFF = 2,
	SUPPORT_CONFORM_GLOBAL = 3,
	SUPPORT_LOCAL_ON = 4,
	SUPPORT_LOCAL_OFF = 5,
}

public enum ServantStatusListViewItemDraw.Kind
{
	NONE = 0,
	MAIN = 1,
	EQUIP_MAIN = 2,
	EQUIP = 3,
	SKILL = 4,
	CLASS_SKILL = 5,
	KIND_0801 = 6,
	NP = 7,
	COMMAND = 8,
	FACE = 9,
	FLAVOR_TEXT = 10,
	TERMINAL = 11,
	EQUIP_SKILL = 12,
	PORTRAIT = 13,
	COMMAND_CODE_SKILL = 14,
	SERVANT_QUEST = 15,
	TREASURE_DEVICE_SPEED = 16,
	CHANGE_VOICE = 17,
	RANDOM_LIMIT_COUNT_SUPPORT = 18,
	RANDOM_LIMIT_COUNT_SETTING = 19,
}

public enum ServantStatusListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

private enum ServantStatusListViewItemDrawRandomLimitCountSetting.MaskType
{
	NONE = 0,
	NOT_COMBINE = 1,
}

private enum ServantStatusListViewItemDrawRandomLimitCountSetting.RandomLimitCountSetting
{
	CONFORM_GLOBAL = 0,
	LOCAL_ON = 1,
	LOCAL_OFF = 2,
}

private enum ServantStatusListViewItemDrawRandomLimitCountSupport.MaskType
{
	NONE = 0,
	NOT_COMBINE = 1,
	ENABLE_SUPPORT_ALL_OPTION = 2,
	ENABLE_SUPPORT_SETTING = 3,
}

public enum ServantStatusListViewManager.InitMode
{
	NONE = 0,
	INPUT = 1,
	VALID = 2,
	BATTLE = 3,
	COMMAND = 4,
	FACE = 5,
	STATUS = 6,
	PORTRAIT = 7,
	MODIFY = 8,
	RANDOM_LIMIT_COUNT_SUPPORT = 9,
	RANDOM_LIMIT_COUNT_SETTING = 10,
}

public enum ServantStatusListViewManager.ResultKind
{
	SELECT = 0,
	EQUIP1 = 1,
	EQUIP1_STATUS = 2,
	COMMAND = 3,
	FACE = 4,
	PORTRAIT = 5,
	COMMAND_CODE = 6,
	SERVANT_QUEST = 7,
	TREASURE_DEVICE_SPEED = 8,
	CHANGE_VOICE = 9,
	RANDOM_LIMIT_COUNT_SUPPORT = 10,
	RANDOM_LIMIT_COUNT_SETTING = 11,
	RANDOM_LIMIT_COUNT_MASK = 12,
	SERVANT_COMBINE = 13,
	SERVANT_EQ_COMBINE = 14,
	SERVANT_SKILL_COMBINE = 15,
	SERVANT_LIMIT_COUNT_UP = 16,
	FRIENDSHIP_EXCEED = 17,
	COMMAND_CARD_EQUIP = 18,
	COMMAND_CARD_EXCEED = 19,
	APPEND_SKILL_COMBINE = 20,
	SERVANT_NP_COMBINE = 21,
	SERVANT_LV_EXCEED = 22,
}

public enum ServantStatusListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	BATTLE = 4,
	COMMAND = 5,
	FACE = 6,
	STATUS = 7,
	PORTRAIT = 8,
	MODIFY = 9,
	RANDOM_LIMIT_COUNT_SUPPORT = 10,
	RANDOM_LIMIT_COUNT_SETTING = 11,
}

protected enum ServantStatusListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum ServantStatusParameterGauge.Kind
{
	POWER = 0,
	DEFENSE = 1,
	AGILITY = 2,
	MAGIC = 3,
	LUCK = 4,
	NP = 5,
}

public enum ServantStatusVoiceListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum ServantStatusVoiceListViewManager.InitMode
{
	NONE = 0,
	INPUT = 1,
	PLAY = 2,
	MODIFY = 3,
}

public enum ServantStatusVoiceListViewManager.ResultKind
{
	NONE = 0,
	PLAY = 1,
	STOP = 2,
}

public enum ServantStatusVoiceListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	PLAY = 4,
	MODIFY = 5,
}

protected enum ServantStatusVoiceListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

protected enum AgeVerificationMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	CONFIRM = 3,
	SELECTED = 4,
	CLOSE = 5,
}

protected enum SpendLimitMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum StonePurchaseListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum StonePurchaseListViewManager.Kind
{
	BANK = 0,
}

public enum StonePurchaseListViewManager.InitMode
{
	NONE = 0,
	INPUT = 1,
}

public enum StonePurchaseListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

protected enum StonePurchaseListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum StonePurchaseMenu.Result
{
	CANCEL = 0,
	ERROR = 1,
	PURCHASE = 2,
	WAIT = 3,
	BLOCK = 4,
}

protected enum StonePurchaseMenu.State
{
	INIT = 0,
	INIT_BUY_STONE = 1,
	INPUT_BUY_STONE = 2,
	QUIT_BUY_STONE = 3,
	INIT_BUY_STONE_CONFIRM = 4,
	INPUT_BUY_STONE_CONFIRM = 5,
	QUIT_BUY_STONE_CONFIRM = 6,
	INIT_AGE_VERIFICATION = 7,
	INIT_AGE_VERIFICATION2 = 8,
	INPUT_AGE_VERIFICATION = 9,
	INPUT_SPEND_LIMIT = 10,
	INIT_RECIVE_BUY_STONE_CONFIRM = 11,
	INPUT_RECIVE_BUY_STONE_CONFIRM = 12,
	QUIT_RECIVE_BUY_STONE_CONFIRM = 13,
	INPUT_BUY_STONE_WARNING = 14,
}

public enum StonePurchaseNotificationMenu.Kind
{
	CANCEL = 0,
	SUCCESS = 1,
	WAIT = 2,
	FAIL = 3,
	SUSPEND = 4,
	INIT_ERROR = 5,
	DUPLICATE_TRANSACTION = 6,
	GOOGLE_PLAY_ACCOUNT_ID_ERROR = 7,
	GOOGLE_PLAY_PENDING_AFTER_PURCHASE = 8,
}

protected enum StonePurchaseNotificationMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

protected enum TermsOfUseDlg.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum TitleInfoEventBulletinBoardComponent.DispType
{
	TERMINAL = 0,
	EVENT = 1,
}

private enum TitleInfoEventDailyPoint.STATE
{
	NONE = 0,
	PLAY = 1,
	TOUCH_WAIT = 2,
}

private enum TitleInfoEventFactory.EffectId
{
	NONE = 0,
	FACTORY = 1,
	RATE = 2,
}

public enum TitleInfoEventItemComponent.DispType
{
	ITEM = 0,
	POINT = 1,
	MISSION = 2,
	RAID_DAMAGE_POINT = 3,
	EVENT_GROUP_POINT = 4,
	DAILY_MISSION = 5,
}

public enum TitleInfoEventLeagueVsGaugeEffect.GaugeType
{
	BLUE = 0,
	RED = 1,
	GOLD = 2,
	SILVER = 3,
}

public enum TitleInfoEventLeagueVsGaugeFlashEffect.GaugeType
{
	BLUE = 0,
	RED = 1,
}

public enum TitleInfoEventRaidDayComponent.DayType
{
	YESTERDAY = 0,
	TODAY = 1,
	TOMORROW = 2,
}

public enum TitleInfoEventRaidHpComponent.HpType
{
	UNKNOWN = 0,
	RESULT_OK = 1,
	RESULT_NG = 2,
}

public enum TitleInfoEventSubmarineStatusComponent.AnimType
{
	NONE = 0,
	START = 1,
	LOOP = 2,
	END = 3,
}

public enum TitleInfoEventTimeImgListComponent.TimeState
{
	DAY_TIME_FREE = 0,
	DAY_TIME_SCENARIO = 1,
	NIGHT_TIME_FREE = 2,
	NIGHT_TIME_SCENARIO = 3,
}

private enum TitleInfoEventTowerReward.STATE
{
	NONE = 0,
	PLAY = 1,
	TOUCH_WAIT = 2,
}

public enum TitleInfoWarBoardTitleComponent.STATE
{
	NONE = 0,
	MOVIE_FADE = 1,
	MOVIE = 2,
	PLAY = 3,
	TOUCH_WAIT = 4,
	SIZEOF = 5,
}

private enum TitleInfoWarBoardTitleComponent.StateMovie.MovieState
{
	NONE = 0,
	START = 1,
	PLAY = 2,
	END = 3,
}

private enum TitleInfoControl.SideItemKind
{
	NONE = 0,
	TOTAL_POINT_EVENT = 1,
	BUFF_EVENT = 2,
}

private enum TitleInfoControl.SuperBossAnimeState
{
	NONE = 0,
	PLAY = 1,
	END = 2,
	WAIT = 3,
}

public enum TitleInfoControl.TitleKind
{
	NONE = 0,
	TERMINAL = 1,
	HEROICTALE = 2,
	STORY = 3,
	CALDEAGATE = 4,
	INTERLUDE = 5,
	RANK_UP_QUEST = 6,
	DAILY_QUEST = 7,
	WAR100 = 8,
	WAR101 = 9,
	WAR102 = 10,
	WAR103 = 11,
	WAR104 = 12,
	WAR105 = 13,
	WAR106 = 14,
	WAR107 = 15,
	WAR11000 = 16,
	WAR12000 = 17,
	FORMATION = 18,
	FORM_MASTER = 19,
	PARTY_CHECK = 20,
	FORM_SVT_LIST = 21,
	FORM_SVT_EQUIP_LIST = 22,
	FORM_SVT_EQUIP_SELECT = 23,
	COMBINE = 24,
	SERVANT_COMBINE = 25,
	SKILL_COMBINE = 26,
	NP_COMBINE = 27,
	LIMIT_COMBINE = 28,
	SVT_EQUIP_COMBINE = 29,
	LVEXCEED_COMBINE = 30,
	SVT_COSTUME = 31,
	COMMANDCARD_COMBINE = 32,
	FRIENDSHIP_EXCEED_COMBINE = 33,
	SPECIAL_ASCENSION_COMBINE = 34,
	COMMAND_CARD_EXCEED = 35,
	SUMMON = 36,
	SHOP = 37,
	SHOP_SELL_SERVANT = 38,
	FRIEND = 39,
	MYROOM = 40,
	MYROOM_MATERIAL = 41,
	PRESENTBOX = 42,
	MYROOM_USERITEM = 43,
	USER_SERVANT_COIN = 44,
	PROFILE = 45,
	GAMEOPTION = 46,
	MYROOM_NOTICE = 47,
	SERIAL_CODE = 48,
	CONTINUE_DEVICE = 49,
	FAVORITE_CHANGE = 50,
	SOUND_PLAYER = 51,
	BLACKLIST = 52,
	MATERIAL_COSTUME = 53,
	MYROOM_SAINTGRAF = 54,
	MATERIAL_MAIN_QUEST = 55,
	MATERIAL_MAIN_QUEST_PART = 56,
	MATERIAL_EVENT_QUEST = 57,
	MATERIAL_SERVANT = 58,
	MATERIAL_MAIN_INTERLUDE = 59,
	SELECT_MULTIPLE_SERVANT = 60,
	SERVANT_PROFILE = 61,
	BATTLE_CHARACTER = 62,
	FOLLOWER = 63,
	BATTLE_SETUP_CONFIRM = 64,
	ORGANIZATION = 65,
	MASTER_ORGANIZATION = 66,
	PARTY_ORGANIZATION = 67,
	PARTY_ORGANIZATION_CHANGE = 68,
	PARTY_ORGANIZATION_SWAP = 69,
	PARTY_ORGANIZATION_SERVANT = 70,
	EVENT_REWARD = 71,
	EVENT_BOX_GACHA = 72,
	EVENT_MISSION = 73,
	EVENT_RAID = 74,
	EVENT_SHOP = 75,
	EVENT_RANKING = 76,
	EVENT_TOWER = 77,
	RECOVERY_FATIGUE = 78,
	SERVANT_FATIGUE_LIST = 79,
	SUPPORT_SELECT = 80,
	FRIEND_SUPPORT_INFO = 81,
	MASTER_MISSION = 82,
	WAREHOUSE = 83,
	MAIN_INTERLUDE = 84,
	COIN_ROOM = 85,
	ADVANCED = 86,
	RECOLLECTION = 87,
	BONUS_SELECT_SUMMON = 88,
	ACCOUNT_LINKAGE = 89,
}

public enum TitleInfoControl.BackKind
{
	NONE = 0,
	TERMINAL = 1,
	CLOSE = 2,
	BACK = 3,
}

protected enum TripleButtonDlgComponent.State
{
	INIT = 0,
	OPEN = 1,
}

public enum TripleButtonDlgComponent.ResultClicked
{
	RIGHT = 0,
	MIDDLE = 1,
	CANCEL = 2,
}

public enum TutorialBigDialog.TutrialWindowSize
{
	NONE = 0,
	DEFAULT = 1,
	SMALL = 2,
}

public enum UserGameActRecoverConfirmMenu.Kind
{
	USER_GAME_ACT = 0,
	STONE = 1,
	RECOVER = 2,
	MAX_ACT = 3,
	NO_INFO = 4,
}

protected enum UserGameActRecoverConfirmMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum UserGameActRecoverMenu.Result
{
	CANCEL = 0,
	ERROR = 1,
	RECOVER = 2,
}

protected enum UserGameActRecoverMenu.State
{
	INIT = 0,
	INPUT_NO_SHOP_CONFIRM = 1,
	INPUT_MAX_FRAME_CONFIRM = 2,
	INPUT_BUY_FRAME_CONFIRM = 3,
	INPUT_BUY_STONE_CONFIRM = 4,
	INPUT_BUY_STONE = 5,
	REQUEST_BUY_FRAME = 6,
	RESULT_BUY_FRAME = 7,
}

protected enum PresentSelectableBulkItemConfirmDlg.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum PresentSelectableDlgComponent.Result
{
	CANCEL = 0,
	ERROR = 1,
	RECOVER = 2,
}

protected enum PresentSelectableItemConfirmDlg.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

protected enum TextLabelScrollDialog.State
{
	Open = 0,
	Decide = 1,
	Close = 2,
}

public enum UserPresentBoxErrorDialog.JUMP_TYPE
{
	SERVANT = 0,
	EQUIP = 1,
	COMMAND_CODE = 2,
}

public enum UserPresentBoxWindow.PRESENT_OVERFLOW_TYPE
{
	NONE = 0,
	SVT = 1,
	SVT_EQUIP = 2,
	ITEM = 3,
	COMMAND_CODE = 4,
}

protected enum UserPresentBoxWindow.QUESTTYPE
{
	FRIENDSHIP = 3,
	HEROBALLAD = 6,
}

public enum UserPresentListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum UserPresentListViewManager.InitMode
{
	NONE = 0,
	INPUT = 1,
	HOLD = 2,
}

public enum UserPresentListViewManager.KIND
{
	NORMAL = 0,
	ALL = 1,
	ITEM = 2,
	CHECK = 3,
}

public enum UserPresentListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	HOLD = 4,
}

protected enum UserPresentListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum FGOSwapShaderPropertyWhenEnemy.RendererType
{
	Renderer = 0,
	ParticleSystemRenderer = 1,
	MeshRenderer = 2,
	SkinnedMeshRenderer = 3,
	SpriteRenderer = 4,
}

public enum FGOSwapShaderPropertyWhenEnemy.FGONobleGUI_CullMode
{
	Off = 0,
	Front = 1,
	Back = 2,
}

public enum ActionType.Type
{
	TALK = 1,
	SYSTEM_WINDOW = 2,
	SCROLL_MISSION = 3,
	TRANSITION_TERMINAL = 4,
	VOICE = 5,
	IMAGE_WINDOW = 6,
	MASTER_MISSION_VOICE = 7,
	WAIT_VOICE = 8,
}

public enum Ai.COND
{
	NONE = 0,
	HP_HIGHER = 10,
	HP_LOWER = 11,
	ACTCOUNT = 20,
	ACTCOUNT_MULTIPLE = 21,
	TURN = 30,
	TURN_MULTIPLE = 31,
	BEFORE_ACT_ID = 40,
	BEFORE_ACT_TYPE = 41,
	BEFORE_NOT_ACT_ID = 42,
	BEFORE_NOT_ACT_TYPE = 43,
	CHECK_SELF_BUFF = 50,
	CHECK_SELF_INDIVIDUALITY = 51,
	CHECK_PT_BUFF = 52,
	CHECK_PT_INDIVIDUALITY = 53,
	CHECK_OPPONENT_BUFF = 55,
	CHECK_OPPONENT_INDIVIDUALITY = 56,
	CHECK_SELF_BUFF_INDIVIDUALITY = 57,
	CHECK_PT_BUFF_INDIVIDUALITY = 58,
	CHECK_OPPONENT_BUFF_INDIVIDUALITY = 59,
	CHECK_SELF_NPTURN = 60,
	CHECK_PT_LOWER_NPTURN = 61,
	CHECK_OPPONENT_HEIGHT_NPGAUGE = 62,
	ACTCOUNT_THISTURN = 63,
	CHECK_PT_HP_HIGHER = 64,
	CHECK_PT_HP_LOWER = 65,
	CHECK_SELF_NOT_BUFF_INDIVIDUALITY = 66,
	TURN_AND_ACTCOUNT_THISTURN = 67,
	FIELDTURN = 68,
	FIELDTURN_MULTIPLE = 69,
	CHECK_PT_LOWER_TDTURN = 70,
	RAID_HP_HIGHER = 71,
	RAID_HP_LOWER = 72,
	RAID_COUNT_HIGHER = 73,
	RAID_COUNT_LOWER = 74,
	RAID_COUNT_VALUE_HIGHER = 75,
	RAID_COUNT_VALUE_LOWER = 76,
	CHECK_SPACE = 77,
	TURN_HIGHER = 78,
	TURN_LOWER = 79,
	CHARACTOR_TURN_HIGHER = 80,
	CHARACTOR_TURN_LOWER = 81,
	COUNT_ALIVE_PT = 82,
	COUNT_ALIVE_OPPONENT = 83,
	COUNT_PT_REST_HIGHER = 84,
	COUNT_PT_REST_LOWER = 85,
	COUNT_OPPONENT_REST_HIGHER = 86,
	COUNT_OPPONENT_REST_LOWER = 87,
	COUNT_ITEM_HIGHER = 88,
	COUNT_ITEM_LOWER = 89,
	CHECK_SELF_BUFFCOUNT_INDIVIDUALITY = 90,
	CHECK_PT_BUFFCOUNT_INDIVIDUALITY = 91,
	CHECK_SELF_BUFF_ACTIVE = 92,
	CHECK_PT_BUFF_ACTIVE = 93,
	CHECK_OPPONENT_BUFF_ACTIVE = 94,
	COUNT_ENEMY_COMMAND_SPELL_HIGHER = 95,
	CHECK_PT_ALL_INDIVIDUALITY = 96,
	CHECK_OPPONENT_ALL_INDIVIDUALITY = 97,
	STAR_HIGHER = 98,
	STAR_LOWER = 99,
	CHECK_OPPONENT_HP_HIGHER = 100,
	CHECK_OPPONENT_HP_LOWER = 101,
	CHECK_TARGET_POSITION = 102,
	CHECK_SELF_BUFF_ACTIVE_AND_PASSIVE_INDIVIDUALITY = 103,
	CHECK_PT_BUFF_ACTIVE_AND_PASSIVE_INDIVIDUALITY = 104,
	CHECK_OPPONENT_BUFF_ACTIVE_AND_PASSIVE_INDIVIDUALITY = 105,
	CHECK_PT_ALL_BUFF = 106,
	CHECK_OPPONENT_ALL_BUFF = 107,
	CHECK_PT_ALL_BUFF_INDIVIDUALITY = 108,
	CHECK_OPPONENT_ALL_BUFF_INDIVIDUALITY = 109,
	COUNT_ALIVE_PT_ALL = 110,
	COUNT_ALIVE_OPPONENT_ALL = 111,
	CHECK_PT_ALL_BUFF_ACTIVE = 112,
	CHECK_OPPONENT_ALL_BUFF_ACTIVE = 113,
	COUNT_HIGHER_BUFF_INDIVIDUALITY_SUM_PT = 114,
	COUNT_HIGHER_BUFF_INDIVIDUALITY_SUM_PT_ALL = 115,
	COUNT_HIGHER_BUFF_INDIVIDUALITY_SUM_OPPONENT = 116,
	COUNT_HIGHER_BUFF_INDIVIDUALITY_SUM_OPPONENT_ALL = 117,
	COUNT_HIGHER_BUFF_INDIVIDUALITY_SUM_SELF = 118,
	COUNT_LOWER_BUFF_INDIVIDUALITY_SUM_PT = 119,
	COUNT_LOWER_BUFF_INDIVIDUALITY_SUM_PT_ALL = 120,
	COUNT_LOWER_BUFF_INDIVIDUALITY_SUM_OPPONENT = 121,
	COUNT_LOWER_BUFF_INDIVIDUALITY_SUM_OPPONENT_ALL = 122,
	COUNT_LOWER_BUFF_INDIVIDUALITY_SUM_SELF = 123,
	COUNT_EQUAL_BUFF_INDIVIDUALITY_SUM_PT = 124,
	COUNT_EQUAL_BUFF_INDIVIDUALITY_SUM_PT_ALL = 125,
	COUNT_EQUAL_BUFF_INDIVIDUALITY_SUM_OPPONENT = 126,
	COUNT_EQUAL_BUFF_INDIVIDUALITY_SUM_OPPONENT_ALL = 127,
	COUNT_EQUAL_BUFF_INDIVIDUALITY_SUM_SELF = 128,
	EXIST_INDIVIDUALITY_OPPONENT_FRONT = 129,
	EXIST_INDIVIDUALITY_OPPONENT_CENTER = 130,
	EXIST_INDIVIDUALITY_OPPONENT_BACK = 131,
	TOTAL_COUNT_HIGHER_INDIVIDUALITY_PT = 132,
	TOTAL_COUNT_HIGHER_INDIVIDUALITY_PT_ALL = 133,
	TOTAL_COUNT_HIGHER_INDIVIDUALITY_OPPONENT = 134,
	TOTAL_COUNT_HIGHER_INDIVIDUALITY_OPPONENT_ALL = 135,
	TOTAL_COUNT_HIGHER_INDIVIDUALITY_ALL_FIELD = 136,
	TOTAL_COUNT_LOWER_INDIVIDUALITY_PT = 137,
	TOTAL_COUNT_LOWER_INDIVIDUALITY_PT_ALL = 138,
	TOTAL_COUNT_LOWER_INDIVIDUALITY_OPPONENT = 139,
	TOTAL_COUNT_LOWER_INDIVIDUALITY_OPPONENT_ALL = 140,
	TOTAL_COUNT_LOWER_INDIVIDUALITY_ALL_FIELD = 141,
	TOTAL_COUNT_EQUAL_INDIVIDUALITY_PT = 142,
	TOTAL_COUNT_EQUAL_INDIVIDUALITY_PT_ALL = 143,
	TOTAL_COUNT_EQUAL_INDIVIDUALITY_OPPONENT = 144,
	TOTAL_COUNT_EQUAL_INDIVIDUALITY_OPPONENT_ALL = 145,
	TOTAL_COUNT_EQUAL_INDIVIDUALITY_ALL_FIELD = 146,
	PT_FRONT_DEAD_EQUAL = 147,
	PT_CENTER_DEAD_EQUAL = 148,
	PT_BACK_DEAD_EQUAL = 149,
	COUNT_HIGHER_INDIVIDUALITY_PT_FRONT = 150,
	COUNT_HIGHER_INDIVIDUALITY_PT_CENTER = 151,
	COUNT_HIGHER_INDIVIDUALITY_PT_BACK = 152,
	COUNT_HIGHER_INDIVIDUALITY_OPPONENT_FRONT = 153,
	COUNT_HIGHER_INDIVIDUALITY_OPPONENT_CENTER = 154,
	COUNT_HIGHER_INDIVIDUALITY_OPPONENT_BACK = 155,
	COUNT_LOWER_INDIVIDUALITY_PT_FRONT = 156,
	COUNT_LOWER_INDIVIDUALITY_PT_CENTER = 157,
	COUNT_LOWER_INDIVIDUALITY_PT_BACK = 158,
	COUNT_LOWER_INDIVIDUALITY_OPPONENT_FRONT = 159,
	COUNT_LOWER_INDIVIDUALITY_OPPONENT_CENTER = 160,
	COUNT_LOWER_INDIVIDUALITY_OPPONENT_BACK = 161,
	COUNT_EQUAL_INDIVIDUALITY_PT_FRONT = 162,
	COUNT_EQUAL_INDIVIDUALITY_PT_CENTER = 163,
	COUNT_EQUAL_INDIVIDUALITY_PT_BACK = 164,
	COUNT_EQUAL_INDIVIDUALITY_OPPONENT_FRONT = 165,
	COUNT_EQUAL_INDIVIDUALITY_OPPONENT_CENTER = 166,
	COUNT_EQUAL_INDIVIDUALITY_OPPONENT_BACK = 167,
	CHECK_PRECEDING_ENEMY = 168,
	COUNT_HIGHER_REMAIN_TURN = 169,
	COUNT_LOWER_REMAIN_TURN = 170,
	COUNT_HIGHER_PLAYER_COMMAND_SPELL = 171,
	COUNT_LOWER_PLAYER_COMMAND_SPELL = 172,
	COUNT_EQUAL_PLAYER_COMMAND_SPELL = 173,
	CHECK_MASTER_SKILL_THISTURN = 174,
	CHECK_SELF_NPTURN_HIGHER = 175,
	CHECK_SELF_NPTURN_LOWER = 176,
	CHECK_USE_SKILL_THISTURN = 177,
	COUNT_CHAIN_HIGHER = 178,
	COUNT_CHAIN_LOWER = 179,
	COUNT_CHAIN_EQUAL = 180,
	CHECK_SELECT_CHAIN = 181,
	COUNT_PLAYER_NP_HIGHER = 182,
	COUNT_PLAYER_NP_LOWER = 183,
	COUNT_PLAYER_NP_EQUAL = 184,
	COUNT_PLAYER_SKILL_HIGHER = 185,
	COUNT_PLAYER_SKILL_LOWER = 186,
	COUNT_PLAYER_SKILL_EQUAL = 187,
	COUNT_PLAYER_SKILL_HIGHER_INCLUDE_MASTER_SKILL = 188,
	COUNT_PLAYER_SKILL_LOWER_INCLUDE_MASTER_SKILL = 189,
	COUNT_PLAYER_SKILL_EQUAL_INCLUDE_MASTER_SKILL = 190,
	TOTAL_TURN_HIGHER = 191,
	TOTAL_TURN_LOWER = 192,
	TOTAL_TURN_EQUAL = 193,
	CHECK_WAR_BOARD_SQUARE_INDIVIDUALITY = 194,
	CHECK_PT_HIGHER_NPGAUGE = 195,
	CHECK_SELF_HIGHER_NPGAUGE = 196,
	CHECK_BATTLE_VALUE_ABOVE = 197,
	CHECK_BATTLE_VALUE_EQUAL = 198,
	CHECK_BATTLE_VALUE_NOT_EQUAL = 199,
	CHECK_BATTLE_VALUE_BELOW = 200,
	CHECK_BATTLE_VALUE_BETWEEN = 201,
	CHECK_BATTLE_VALUE_NOT_BETWEEN = 202,
	CHECK_USE_MASTER_SKILL_INDEX = 203,
	CHECK_USE_MASTER_SKILL_INDEX_THIS_TURN = 204,
	COUNT_MASTER_SKILL_HIGHER_THIS_TURN = 205,
	COUNT_MASTER_SKILL_LOWER_THIS_TURN = 206,
	COUNT_MASTER_SKILL_EQUAL_THIS_TURN = 207,
	COUNT_MASTER_SKILL_HIGHER_THIS_WAVE = 208,
	COUNT_MASTER_SKILL_LOWER_THIS_WAVE = 209,
	COUNT_MASTER_SKILL_EQUAL_THIS_WAVE = 210,
}

public enum Ai.ACT_NUM
{
	NOMAL = 0,
}

public enum Ai.TIMING
{
	NONE = 0,
	WAVE_START = 1,
	TURN_START = 2,
	TURN_PLAYER_START = 3,
	TURN_PLAYER_END = 4,
	TURN_ENEMY_START = 5,
	TURN_ENEMY_END = 6,
	ENTRY_UNIT = 7,
	BEFORE_MOVE_WAVE = 8,
	BEFORE_WAVE_START_ANIMATION = 9,
}

public enum AiAct.TYPE
{
	NONE = 0,
	RANDOM = 1,
	ATTACK = 2,
	SKILL_RANDOM = 10,
	SKILL1 = 11,
	SKILL2 = 12,
	SKILL3 = 13,
	PLAY_MOTION = 71,
	NOBLE_PHANTASM = 80,
	CHANGE_THINKING = 99,
	ATTACK_CRITICAL = 30,
	SKILL_ID = 40,
	BATTLE_END = 90,
	LOSE_END = 91,
	BATTLE_END_NOT_RELATED_SURVIVAL_STATUS = 92,
	ATTACK_A = 14,
	ATTACK_B = 15,
	ATTACK_Q = 16,
	ATTACK_A_CRITICAL = 17,
	ATTACK_B_CRITICAL = 18,
	ATTACK_Q_CRITICAL = 19,
	SKILL_ID_CHECKBUFF = 41,
	RESURRECTION = 42,
	MESSAGE = 72,
	MESSAGE_GROUP = 73,
}

public enum AiAct.TARGET
{
	NONE = 0,
	RANDOM = 1,
	HP_HIGHER = 2,
	HP_LOWER = 3,
	NPTURN_LOWER = 10,
	NPGAUGE_HIGHER = 11,
	REVENGE = 12,
	INDIVIDUALITY_ACTIVE = 13,
	BUFF_ACTIVE = 14,
	FRONT = 15,
	CENTER = 16,
	BACK = 17,
}

public enum AiAct.NO_TARGET_NO_ACTION_TYPE
{
	NONE = 0,
	OPPONENT = 1,
	PARTY = 2,
	BOTH = 3,
}

public enum AnimationList.NAME
{
	attack_a = 0,
	attack_b = 1,
	attack_q = 2,
	attack_gen = 3,
	damage_01 = 4,
	spell = 5,
	step_back = 6,
	step_front = 7,
	treasure_arms = 8,
	wait = 9,
	death_01 = 10,
	attack_ex = 11,
	attack_a02 = 12,
	attack_b02 = 13,
	attack_q02 = 14,
	attack_gen02 = 15,
	attack_ex02 = 16,
	attack_a03 = 17,
	attack_b03 = 18,
	attack_q03 = 19,
	attack_gen03 = 20,
	attack_ex03 = 21,
	spell02 = 22,
	spell03 = 23,
	step_back02 = 24,
	step_front02 = 25,
	attack_a04 = 26,
	attack_b04 = 27,
	attack_q04 = 28,
	attack_gen04 = 29,
	attack_ex04 = 30,
	damage_02 = 31,
	spell_loop = 32,
	treasureArms1_a = 33,
	treasureArms2_a = 34,
	treasureArms3_a = 35,
	treasureArms4_a = 36,
	treasureArms5_a = 37,
	wait02 = 38,
	wait03 = 39,
	attack_a05 = 40,
	attack_b05 = 41,
	attack_q05 = 42,
	attack_gen05 = 43,
	attack_ex05 = 44,
	spell04 = 45,
	spell05 = 46,
	sleep_wait01 = 47,
	counter_wait01 = 48,
	counter_attack01 = 49,
	max = 50,
}

public enum AssetsFile.Path
{
	NONE = 0,
	SERVANTS = 1,
	BG = 2,
}

public enum Bank.Type
{
	NONE = 0,
	AU_GAMES = 1,
	GOOGLE_PLAY = 2,
	APP_STORE = 3,
}

public enum BattleActionCondType.Kind
{
	NONE = 0,
	FUNC_TARGET_ALL_DEAD = 1,
}

public enum BattleCommand.TYPE
{
	NONE = 0,
	ARTS = 1,
	BUSTER = 2,
	QUICK = 3,
	ADDATTACK = 4,
	BLANK = 5,
	WEAK = 10,
	STRENGTH = 11,
}

public enum CommandCardTypeChange
{
	NONE = 0,
	ARTS_TO_BUSTER = 1,
	ARTS_TO_QUICK = 2,
	BUSTER_TO_ARTS = 3,
	BUSTER_TO_QUICK = 4,
	QUICK_TO_ARTS = 5,
	QUICK_TO_BUSTER = 6,
}

public enum BehaviorType.Kind
{
	SKILL = 1,
	ENABLE_CONTINUE = 2,
	BATTLE_BG = 3,
	INDIVIDUALITY = 4,
	NOT_GIVE_QUEST_CLEAR_GIFT = 5,
	DISP_NEXT_ICON = 6,
	GO_TERMINAL_QUEST_AFTER = 7,
}

public enum BuffList.TYPE
{
	NONE = 0,
	UP_COMMANDATK = 1,
	UP_STARWEIGHT = 2,
	UP_CRITICALPOINT = 3,
	DOWN_CRITICALPOINT = 4,
	REGAIN_NP = 5,
	REGAIN_STAR = 6,
	REGAIN_HP = 7,
	REDUCE_HP = 8,
	UP_ATK = 9,
	DOWN_ATK = 10,
	UP_DAMAGE = 11,
	DOWN_DAMAGE = 12,
	ADD_DAMAGE = 13,
	SUB_DAMAGE = 14,
	UP_NPDAMAGE = 15,
	DOWN_NPDAMAGE = 16,
	UP_DROPNP = 17,
	UP_CRITICALDAMAGE = 18,
	DOWN_CRITICALDAMAGE = 19,
	UP_SELFDAMAGE = 20,
	DOWN_SELFDAMAGE = 21,
	ADD_SELFDAMAGE = 22,
	SUB_SELFDAMAGE = 23,
	AVOIDANCE = 24,
	BREAK_AVOIDANCE = 25,
	INVINCIBLE = 26,
	UP_GRANTSTATE = 27,
	DOWN_GRANTSTATE = 28,
	UP_TOLERANCE = 29,
	DOWN_TOLERANCE = 30,
	AVOID_STATE = 31,
	DONOT_ACT = 32,
	DONOT_SKILL = 33,
	DONOT_NOBLE = 34,
	DONOT_RECOVERY = 35,
	DISABLE_GENDER = 36,
	GUTS = 37,
	UP_HATE = 38,
	ADD_INDIVIDUALITY = 40,
	SUB_INDIVIDUALITY = 41,
	UP_DEFENCE = 42,
	DOWN_DEFENCE = 43,
	UP_COMMANDSTAR = 50,
	UP_COMMANDNP = 51,
	UP_COMMANDALL = 52,
	DOWN_COMMANDALL = 60,
	DOWN_STARWEIGHT = 61,
	REDUCE_NP = 62,
	DOWN_DROPNP = 63,
	UP_GAIN_HP = 64,
	DOWN_GAIN_HP = 65,
	DOWN_COMMANDATK = 66,
	DOWN_COMMANSTAR = 67,
	DOWN_COMMANDNP = 68,
	UP_CRITICALRATE = 70,
	DOWN_CRITICALRATE = 71,
	PIERCE_INVINCIBLE = 72,
	AVOID_INSTANTDEATH = 73,
	UP_RESIST_INSTANTDEATH = 74,
	UP_NONRESIST_INSTANTDEATH = 75,
	DELAY_FUNCTION = 76,
	REGAIN_NP_USED_NOBLE = 77,
	DEAD_FUNCTION = 78,
	UP_MAXHP = 79,
	DOWN_MAXHP = 80,
	ADD_MAXHP = 81,
	SUB_MAXHP = 82,
	BATTLESTART_FUNCTION = 83,
	WAVESTART_FUNCTION = 84,
	SELFTURNEND_FUNCTION = 85,
	UP_GIVEGAIN_HP = 87,
	DOWN_GIVEGAIN_HP = 88,
	COMMANDATTACK_AFTER_FUNCTION = 89,
	DEADATTACK_FUNCTION = 90,
	UP_SPECIALDEFENCE = 91,
	DOWN_SPECIALDEFENCE = 92,
	UP_DAMAGEDROPNP = 93,
	DOWN_DAMAGEDROPNP = 94,
	ENTRY_FUNCTION = 95,
	UP_CHAGETD = 96,
	REFLECTION_FUNCTION = 97,
	UP_GRANT_SUBSTATE = 98,
	DOWN_GRANT_SUBSTATE = 99,
	UP_TOLERANCE_SUBSTATE = 100,
	DOWN_TOLERANCE_SUBSTATE = 101,
	UP_GRANT_INSTANTDEATH = 102,
	DOWN_GRANT_INSTANTDEATH = 103,
	GUTS_RATIO = 104,
	DAMAGE_FUNCTION = 86,
	UP_DEFENCECOMMANDALL = 105,
	DOWN_DEFENCECOMMANDALL = 106,
	OVERWRITE_BATTLECLASS = 107,
	OVERWRITE_CLASSRELATIO_ATK = 108,
	OVERWRITE_CLASSRELATIO_DEF = 109,
	UP_DAMAGE_INDIVIDUALITY = 110,
	DOWN_DAMAGE_INDIVIDUALITY = 111,
	UP_DAMAGE_INDIVIDUALITY_ACTIVEONLY = 112,
	DOWN_DAMAGE_INDIVIDUALITY_ACTIVEONLY = 113,
	UP_NPTURNVAL = 114,
	DOWN_NPTURNVAL = 115,
	MULTIATTACK = 116,
	UP_GIVE_NP = 117,
	DOWN_GIVE_NP = 118,
	UP_RESISTANCE_DELAY_NPTURN = 119,
	DOWN_RESISTANCE_DELAY_NPTURN = 120,
	PIERCE_DEFENCE = 121,
	UP_GUTS_HP = 122,
	DOWN_GUTS_HP = 123,
	UP_FUNCGAIN_NP = 124,
	DOWN_FUNCGAIN_NP = 125,
	UP_FUNC_HP_REDUCE = 126,
	DOWN_FUNC_HP_REDUCE = 127,
	UP_DEFENCE_COMMANDDAMAGE = 128,
	DOWN_DEFENCE_COMMANDDAMAGE = 129,
	NPATTACK_PREV_BUFF = 130,
	FIX_COMMANDCARD = 131,
	DONOT_GAINNP = 132,
	FIELD_INDIVIDUALITY = 133,
	DONOT_ACT_COMMANDTYPE = 134,
	UP_DAMAGE_EVENT_POINT = 135,
	UP_DAMAGE_SPECIAL = 136,
	ATTACK_AFTER_FUNCTION = 137,
	COMMANDCODEATTACK_BEFORE_FUNCTION = 138,
	DONOT_NOBLE_COND_MISMATCH = 139,
	DONOT_SELECT_COMMANDCARD = 140,
	DONOT_REPLACE = 141,
	SHORTEN_USER_EQUIP_SKILL = 142,
	TD_TYPE_CHANGE = 143,
	OVERWRITE_CLASS_RELATION = 144,
	TD_TYPE_CHANGE_ARTS = 145,
	TD_TYPE_CHANGE_BUSTER = 146,
	TD_TYPE_CHANGE_QUICK = 147,
	COMMANDATTACK_BEFORE_FUNCTION = 148,
	GUTS_FUNCTION = 149,
	UP_CRITICAL_RATE_DAMAGE_TAKEN = 150,
	DOWN_CRITICAL_RATE_DAMAGE_TAKEN = 151,
	UP_CRITICAL_STAR_DAMAGE_TAKEN = 152,
	DOWN_CRITICAL_STAR_DAMAGE_TAKEN = 153,
	SKILL_RANK_UP = 154,
	AVOIDANCE_INDIVIDUALITY = 155,
	CHANGE_COMMAND_CARD_TYPE = 156,
	SPECIAL_INVINCIBLE = 157,
	PREVENT_DEATH_BY_DAMAGE = 158,
	COMMANDCODEATTACK_AFTER_FUNCTION = 159,
	ATTACK_BEFORE_FUNCTION = 160,
	DONOT_SKILL_SELECT = 161,
	INVISIBLE_BATTLE_CHARA = 163,
	BUFF_RATE = 162,
	COUNTER_FUNCTION = 165,
	NOT_TARGET_SKILL = 166,
	HP_REDUCE_TO_REGAIN = 167,
	SELFTURNSTART_FUNCTION = 168,
	OVERWRITE_DEAD_TYPE = 169,
	UP_ACTION_COUNT = 170,
	DOWN_ACTION_COUNT = 171,
	SHIFT_GUTS = 172,
	SHIFT_GUTS_RATIO = 173,
	MASTER_SKILL_VALUE_UP = 174,
	BUFF_CONVERT = 175,
	SUB_FIELD_INDIVIDUALITY = 176,
	COMMANDCODEATTACK_BEFORE_FUNCTION_MAIN_ONLY = 177,
	COMMANDCODEATTACK_AFTER_FUNCTION_MAIN_ONLY = 178,
	COMMANDATTACK_BEFORE_FUNCTION_MAIN_ONLY = 179,
	COMMANDATTACK_AFTER_FUNCTION_MAIN_ONLY = 180,
	ATTACK_BEFORE_FUNCTION_MAIN_ONLY = 181,
	ATTACK_AFTER_FUNCTION_MAIN_ONLY = 182,
	WAR_BOARD_NOT_ATTACKED = 183,
	WAR_BOARD_IGNORE_DEFEATPOINT = 184,
	SKILL_AFTER_FUNCTION = 185,
	TREASURE_DEVICE_AFTER_FUNCTION = 186,
	SKILL_AFTER_FUNCTION_MAIN_ONLY = 187,
	TREASURE_DEVICE_AFTER_FUNCTION_MAIN_ONLY = 188,
	PREVENT_INVISIBLE_WHEN_INSTANT_DEATH = 189,
	OVERWRITE_SUBATTRIBUTE = 190,
	AVOIDANCE_ATTACK_DEATH_DAMAGE = 191,
	AVOID_FUNCTION_EXECUTE_SELF = 192,
	PIERCE_SUBDAMAGE = 193,
	CONTINUE_FUNCTION = 194,
	ADD_SPECIALDAMAGE = 195,
	SUB_SPECIALDAMAGE = 196,
	ADD_FUNC_HP_REDUCE = 197,
	SUB_FUNC_HP_REDUCE = 198,
	CHANGE_BGM = 199,
	TO_FIELD_CHANGE_FIELD = 10001,
	TO_FIELD_AVOID_BUFF = 10002,
	TO_FIELD_SUB_INDIVIDUALITY_FIELD = 10003,
}

public enum BuffList.LIMIT
{
	NONE = 0,
	UPPER = 1,
	LOWER = 2,
	NORMAL = 3,
}

public enum BuffList.ACTION
{
	NONE = 0,
	COMMAND_ATK = 1,
	COMMAND_DEF = 2,
	ATK = 3,
	DEFENCE = 4,
	DEFENCE_PIERCE = 5,
	SPECIALDEFENCE = 6,
	DAMAGE = 7,
	DAMAGE_INDIVIDUALITY = 8,
	DAMAGE_INDIVIDUALITY_ACTIVEONLY = 9,
	SELFDAMAGE = 10,
	CRITICAL_DAMAGE = 11,
	NPDAMAGE = 12,
	GIVEN_DAMAGE = 13,
	RECEIVE_DAMAGE = 14,
	PIERCE_INVINCIBLE = 15,
	INVINCIBLE = 16,
	BREAK_AVOIDANCE = 17,
	AVOIDANCE = 18,
	OVERWRITE_BATTLECLASS = 19,
	OVERWRITE_CLASSRELATIO_ATK = 20,
	OVERWRITE_CLASSRELATIO_DEF = 21,
	COMMAND_NP_ATK = 22,
	COMMAND_NP_DEF = 23,
	DROP_NP = 24,
	DROP_NP_DAMAGE = 25,
	COMMAND_STAR_ATK = 26,
	COMMAND_STAR_DEF = 27,
	CRITICAL_POINT = 28,
	STARWEIGHT = 29,
	TURNEND_NP = 30,
	TURNEND_STAR = 31,
	TURNEND_HP_REGAIN = 32,
	TURNEND_HP_REDUCE = 33,
	GAIN_HP = 34,
	TURNVAL_NP = 35,
	GRANT_STATE = 36,
	RESISTANCE_STATE = 37,
	AVOID_STATE = 38,
	DONOT_ACT = 39,
	DONOT_SKILL = 40,
	DONOT_NOBLE = 41,
	DONOT_RECOVERY = 42,
	INDIVIDUALITY_ADD = 43,
	INDIVIDUALITY_SUB = 44,
	HATE = 45,
	CRITICAL_RATE = 46,
	AVOID_INSTANTDEATH = 47,
	RESIST_INSTANTDEATH = 48,
	NONRESIST_INSTANTDEATH = 49,
	REGAIN_NP_USED_NOBLE = 50,
	FUNCTION_DEAD = 51,
	MAXHP_RATE = 52,
	MAXHP_VALUE = 53,
	FUNCTION_WAVESTART = 54,
	FUNCTION_SELFTURNEND = 55,
	GIVE_GAIN_HP = 56,
	FUNCTION_COMMANDATTACK_AFTER = 57,
	FUNCTION_DEADATTACK = 58,
	FUNCTION_ENTRY = 59,
	CHAGETD = 60,
	GRANT_SUBSTATE = 61,
	TOLERANCE_SUBSTATE = 62,
	GRANT_INSTANTDEATH = 63,
	FUNCTION_DAMAGE = 64,
	FUNCTION_REFLECTION = 65,
	MULTIATTACK = 66,
	GIVE_NP = 67,
	RESISTANCE_DELAY_NPTURN = 68,
	PIERCE_DEFENCE = 69,
	GUTS_HP = 70,
	FUNCGAIN_NP = 71,
	FUNC_HP_REDUCE = 72,
	FUNCTION_NPATTACK = 73,
	FIX_COMMANDCARD = 74,
	DONOT_GAINNP = 75,
	FIELD_INDIVIDUALITY = 76,
	DONOT_ACT_COMMANDTYPE = 77,
	DAMAGE_EVENT_POINT = 78,
	DAMAGE_SPECIAL = 79,
	FUNCTION_ATTACK_AFTER = 80,
	FUNCTION_COMMANDCODEATTACK_BEFORE = 81,
	DONOT_NOBLE_COND_MISMATCH = 82,
	DONOT_SELECT_COMMANDCARD = 83,
	DONOT_REPLACE = 84,
	SHORTEN_USER_EQUIP_SKILL = 85,
	TD_TYPE_CHANGE = 86,
	OVERWRITE_CLASS_RELATION = 87,
	FUNCTION_COMMANDATTACK_BEFORE = 88,
	FUNCTION_GUTS = 89,
	CRITICAL_RATE_DAMAGE_TAKEN = 90,
	CRITICAL_STAR_DAMAGE_TAKEN = 91,
	SKILL_RANK_CHANGE = 92,
	AVOIDANCE_INDIVIDUALITY = 93,
	CHANGE_COMMAND_CARD_TYPE = 94,
	SPECIAL_INVINCIBLE = 95,
	PREVENT_DEATH_BY_DAMAGE = 96,
	FUNCTION_COMMANDCODEATTACK_AFTER = 97,
	FUNCTION_ATTACK_BEFORE = 98,
	DONOT_SKILL_SELECT = 99,
	INVISIBLE_BATTLE_CHARA = 100,
	BUFF_RATE = 101,
	COUNTER_FUNCTION = 102,
	NOT_TARGET_SKILL = 103,
	TO_FIELD_CHANGE_FIELD = 104,
	TO_FIELD_AVOID_BUFF = 105,
	GRANT_STATE_UP_ONLY = 106,
	TURNEND_HP_REDUCE_TO_REGAIN = 107,
	FUNCTION_SELFTURNSTART = 108,
	OVERWRITE_DEAD_TYPE = 109,
	ACTION_COUNT = 110,
	SHIFT_GUTS = 111,
	TO_FIELD_SUB_INDIVIDUALITY_FIELD = 112,
	MASTER_SKILL_VALUE_UP = 113,
	BUFF_CONVERT = 114,
	SUB_FIELD_INDIVIDUALITY = 115,
	FUNCTION_COMMANDCODEATTACK_BEFORE_MAIN_ONLY = 116,
	FUNCTION_COMMANDCODEATTACK_AFTER_MAIN_ONLY = 117,
	FUNCTION_COMMANDATTACK_BEFORE_MAIN_ONLY = 118,
	FUNCTION_COMMANDATTACK_AFTER_MAIN_ONLY = 119,
	FUNCTION_ATTACK_BEFORE_MAIN_ONLY = 120,
	FUNCTION_ATTACK_AFTER_MAIN_ONLY = 121,
	FUNCTION_SKILL_AFTER = 122,
	FUNCTION_SKILL_AFTER_MAIN_ONLY = 123,
	FUNCTION_TREASURE_DEVICE_AFTER = 124,
	FUNCTION_TREASURE_DEVICE_AFTER_MAIN_ONLY = 125,
	GUTS = 126,
	PREVENT_INVISIBLE_WHEN_INSTANT_DEATH = 127,
	OVERWRITE_SUBATTRIBUTE = 128,
	AVOIDANCE_ATTACK_DEATH_DAMAGE = 129,
	AVOID_FUNCTION_EXECUTE_SELF = 130,
	FUNCTION_CONTINUE = 131,
	PIERCE_SUBDAMAGE = 132,
	RECEIVE_DAMAGE_PIERCE = 133,
	SPECIAL_RECEIVE_DAMAGE = 134,
	FUNC_HP_REDUCE_VALUE = 135,
	CHANGE_BGM = 136,
}

public enum BuffList.DEL_AFTER_TYPE
{
	NONE = 0,
	UPDATE_FIELD = 1,
	UPDATE_VIEW = 2,
	UPDATE_BGM = 3,
}

public enum BuffList.INVOKE_COND_TYPE
{
	INDIVIDUALITY = 0,
	BUFF_TYPE = 1,
}

public enum BuffList.CONDITIONS
{
	HP_HIGHER = 0,
	HP_LOWER = 1,
	INDIVIDUALITIE = 2,
	INDIVIDUALITIE_OR = 3,
	INDIVIDUALITIE_AND = 4,
}

public enum BuffList.CHANGEVALUE
{
	RATIO_HP_HIGH = 0,
	RATIO_HP_LOW = 1,
}

public enum BuffList.ProgressTurnCond
{
	NONE = 0,
	ALIVE_ENEMY_ALLY = 1,
	ALIVE_SELF = 2,
}

public enum CacheFolderName.FOLDER_NAME
{
	ASSET = 0,
	MASTER_DATA = 1,
	PAYMENT_HISTORYS = 2,
}

public enum CameraPosition
{
	Players = 0,
	Enemies = 1,
	PlayerNp = 2,
	EnemyNp = 3,
	All = 4,
}

public enum CollectionStatus.Kind
{
	NOT_GET = 0,
	FIND = 1,
	GET = 2,
	ENEMY_COLLECTION_DETAIL = 3,
	HIDE = 4,
	NPC = 5,
	SECRET = 6,
	DATA_LOST = 7,
	LINK_LOST = 8,
	LINK_BAD = 9,
}

public enum CombineAdjustTarget.TYPE
{
	COMBINE_QP = 1,
	COMBINE_EXP = 2,
	ACTIVE_SKILL = 3,
	LARGE_SUCCESS = 4,
	SUPER_SUCCESS = 5,
	LIMIT_QP = 6,
	LIMIT_ITEM = 7,
	SKILL_QP = 8,
	SKILL_ITEM = 9,
	TREASURE_DEVICE_QP = 10,
	TREASURE_DEVICE_ITEM = 11,
	QUEST_AP = 12,
	QUEST_EXP = 13,
	QUEST_QP = 14,
	QUEST_DROP = 15,
	SVTEQUIP_COMBINE_QP = 16,
	SVTEQUIP_COMBINE_EXP = 17,
	SVTEQUIP_LARGE_SUCCESS = 18,
	SVTEQUIP_SUPER_SUCCESS = 19,
	QUEST_EVENT_POINT = 20,
	ENEMY_SVT_CLASS_PICK_UP = 21,
	EVENT_EACH_DROP_NUM = 22,
	EVENT_EACH_DROP_RATE = 23,
	QUEST_FP = 24,
	QUEST_AP_FIRST_TIME = 25,
	DAILY_DROP_UP = 26,
	EXCHANGE_SVT_COMBINE_EXP = 27,
	QUEST_USE_CONTINUE_ITEM = 28,
	FRIEND_POINT_GACHA_FREE_DRAW_NUM = 29,
	QUEST_USE_FRIENDSHIP_UP_ITEM = 30,
	QUEST_FRIENDSHIP = 31,
	LARGE_SUCCESS_BY_CLASS = 32,
	SUPER_SUCCESS_BY_CLASS = 33,
	EXCHANGE_SVT = 34,
}

public enum CondType.Kind
{
	NONE = 0,
	QUEST_CLEAR = 1,
	ITEM_GET = 2,
	USE_ITEM_ETERNITY = 3,
	USE_ITEM_TIME = 4,
	USE_ITEM_COUNT = 5,
	SVT_LEVEL = 6,
	SVT_LIMIT = 7,
	SVT_GET = 8,
	SVT_FRIENDSHIP = 9,
	SVT_GROUP = 10,
	EVENT = 11,
	DATE = 12,
	WEEKDAY = 13,
	PURCHASE_QP_SHOP = 14,
	PURCHASE_STONE_SHOP = 15,
	WAR_CLEAR = 16,
	FLAG = 17,
	SVT_COUNT_STOP = 18,
	BIRTH_DAY = 19,
	EVENT_END = 20,
	SVT_EVENT_JOIN = 21,
	MISSION_CONDITION_DETAIL = 22,
	EVENT_MISSION_CLEAR = 23,
	EVENT_MISSION_ACHIEVE = 24,
	QUEST_CLEAR_NUM = 25,
	NOT_QUEST_GROUP_CLEAR = 26,
	RAID_ALIVE = 27,
	RAID_DEAD = 28,
	RAID_DAMAGE = 29,
	QUEST_CHALLENGE_NUM = 30,
	MASTER_MISSION = 31,
	QUEST_GROUP_CLEAR = 32,
	SUPER_BOSS_DAMAGE = 33,
	SUPER_BOSS_DAMAGE_ALL = 34,
	PURCHASE_SHOP = 35,
	QUEST_NOT_CLEAR = 36,
	NOT_SHOP_PURCHASE = 37,
	NOT_SVT_GET = 38,
	NOT_EVENT_SHOP_PURCHASE = 39,
	SVT_HAVING = 40,
	NOT_SVT_HAVING = 41,
	QUEST_CHALLENGE_NUM_EQUAL = 42,
	QUEST_CHALLENGE_NUM_BELOW = 43,
	QUEST_CLEAR_NUM_EQUAL = 44,
	QUEST_CLEAR_NUM_BELOW = 45,
	QUEST_CLEAR_PHASE = 46,
	NOT_QUEST_CLEAR_PHASE = 47,
	EVENT_POINT_GROUP_WIN = 48,
	EVENT_NORMA_POINT_CLEAR = 49,
	QUEST_AVAILABLE = 50,
	QUEST_GROUP_AVAILABLE_NUM = 51,
	EVENT_NORMA_POINT_NOT_CLEAR = 52,
	NOT_ITEM_GET = 53,
	COSTUME_GET = 54,
	QUEST_RESET_AVAILABLE = 55,
	SVT_GET_BEFORE_EVENT_END = 56,
	QUEST_CLEAR_RAW = 57,
	QUEST_GROUP_CLEAR_RAW = 58,
	EVENT_GROUP_POINT_RATIO_IN_TERM = 59,
	EVENT_GROUP_RANK_IN_TERM = 60,
	NOT_EVENT_RACE_QUEST_OR_NOT_ALL_GROUP_GOAL = 61,
	EVENT_GROUP_TOTAL_WIN_EACH_PLAYER = 62,
	EVENT_SCRIPT_PLAY = 63,
	SVT_COSTUME_RELEASED = 64,
	QUEST_NOT_CLEAR_AND = 65,
	SVT_RECOVERD = 66,
	SHOP_RELEASED = 67,
	EVENT_POINT = 68,
	EVENT_REWARD_DISP_COUNT = 69,
	EQUIP_WITH_TARGET_COSTUME = 70,
	RAID_GROUP_DEAD = 71,
	NOT_SVT_GROUP = 72,
	NOT_QUEST_RESET_AVAILABLE = 73,
	NOT_QUEST_CLEAR_RAW = 74,
	NOT_QUEST_GROUP_CLEAR_RAW = 75,
	NOT_EVENT_MISSION_CLEAR = 76,
	NOT_EVENT_MISSION_ACHIEVE = 77,
	NOT_COSTUME_GET = 78,
	NOT_SVT_COSTUME_RELEASED = 79,
	NOT_EVENT_RACE_QUEST_OR_NOT_TARGET_RANK_GOAL = 80,
	PLAYER_GENDER_TYPE = 81,
	SHOP_GROUP_LIMIT_NUM = 82,
	EVENT_GROUP_POINT = 83,
	EVENT_GROUP_POINT_BELOW = 84,
	EVENT_TOTAL_POINT = 85,
	EVENT_TOTAL_POINT_BELOW = 86,
	EVENT_VALUE = 87,
	EVENT_VALUE_BELOW = 88,
	EVENT_FLAG = 89,
	EVENT_STATUS = 90,
	NOT_EVENT_STATUS = 91,
	FORCE_FALSE = 92,
	SVT_HAVING_LIMIT_MAX = 93,
	EVENT_POINT_BELOW = 94,
	SVT_EQUIP_FRIENDSHIP_HAVING = 95,
	MOVIE_NOT_DOWNLOAD = 96,
	MULTIPLE_DATE = 97,
	SVT_FRIENDSHIP_ABOVE = 98,
	SVT_FRIENDSHIP_BELOW = 99,
	MOVIE_DOWNLOADED = 100,
	ROUTE_SELECT = 101,
	NOT_ROUTE_SELECT = 102,
	LIMIT_COUNT = 103,
	LIMIT_COUNT_ABOVE = 104,
	LIMIT_COUNT_BELOW = 105,
	BAD_END_PLAY = 106,
	COMMAND_CODE_GET = 107,
	NOT_COMMAND_CODE_GET = 108,
	ALL_USERS_BOX_GACHA_COUNT = 109,
	TOTAL_TD_LEVEL = 110,
	TOTAL_TD_LEVEL_ABOVE = 111,
	TOTAL_TD_LEVEL_BELOW = 112,
	COMMON_RELEASE = 113,
	BATTLE_RESULT_WIN = 114,
	BATTLE_RESULT_LOSE = 115,
	EVENT_VALUE_EQUAL = 116,
	BOARD_GAME_TOKEN_HAVING = 117,
	BOARD_GAME_TOKEN_GROUP_HAVING = 118,
	EVENT_FLAG_ON = 119,
	EVENT_FLAG_OFF = 120,
	QUEST_STATUS_FLAG_ON = 121,
	QUEST_STATUS_FLAG_OFF = 122,
	EVENT_VALUE_NOT_EQUAL = 123,
	LIMIT_COUNT_MAX_EQUAL = 124,
	LIMIT_COUNT_MAX_ABOVE = 125,
	LIMIT_COUNT_MAX_BELOW = 126,
	BOARD_GAME_TOKEN_GET_NUM = 127,
	BATTLE_LINE_WIN_ABOVE = 128,
	BATTLE_LINE_LOSE_ABOVE = 129,
	BATTLE_LINE_CONTINUE_WIN = 130,
	BATTLE_LINE_CONTINUE_LOSE = 131,
	BATTLE_LINE_CONTINUE_WIN_BELOW = 132,
	BATTLE_LINE_CONTINUE_LOSE_BELOW = 133,
	BATTLE_GROUP_WIN_AVOVE = 134,
	BATTLE_GROUP_LOSE_AVOVE = 135,
	SVT_LIMIT_CLASS_NUM = 136,
	OVER_TIME_LIMIT_RAID_ALIVE = 137,
	ON_TIME_LIMIT_RAID_DEAD = 138,
	ON_TIME_LIMIT_RAID_DEAD_NUM = 139,
	RAID_BATTLE_PROGRESS_ABOVE = 140,
	SVT_EQUIP_RARITY_LEVEL_NUM = 141,
	LATEST_MAIN_SCENARIO_WAR_CLEAR = 142,
	EVENT_MAP_VALUE_CONTAINS = 143,
	RESET_BIRTH_DAY = 144,
	SHOP_FLAG_ON = 145,
	SHOP_FLAG_OFF = 146,
	PURCHASE_VALID_SHOP_GROUP = 147,
	SVT_LEVEL_CLASS_NUM = 148,
	SVT_LEVEL_ID_NUM = 149,
	LIMIT_COUNT_IMAGE_EQUAL = 150,
	LIMIT_COUNT_IMAGE_ABOVE = 151,
	LIMIT_COUNT_IMAGE_BELOW = 152,
	EVENT_TYPE_START_TIME_TO_END_DATE = 153,
	EXIST_BOX_GACHA_SCRIPT_REPLACE_GIFT_ID = 154,
	NOT_EXIST_BOX_GACHA_SCRIPT_REPLACE_GIFT_ID = 155,
	LIMITED_PERIOD_VOICE_CHANGE_TYPE_ON = 156,
	START_RANDOM_MISSION = 157,
	RANDOM_MISSION_CLEAR_NUM = 158,
	PROGRESS_VALUE_EQUAL = 159,
	PROGRESS_VALUE_ABOVE = 160,
	PROGRESS_VALUE_BELOW = 161,
	RANDOM_MISSION_TOTAL_CLEAR_NUM = 162,
	WEEKDAYS = 166,
	EVENT_FORTIFICATION_REWARD_NUM = 167,
	QUEST_CLEAR_BEFORE_EVENT_START = 168,
	NOT_QUEST_CLEAR_BEFORE_EVENT_START = 169,
	EVENT_TUTORIAL_FLAG_ON = 170,
	EVENT_TUTORIAL_FLAG_OFF = 171,
	EVENT_SUPER_BOSS_VALUE_EQUAL = 172,
	NOT_EVENT_SUPER_BOSS_VALUE_EQUAL = 173,
	ALL_SVT_TARGET_SKILL_LV_NUM = 174,
	SUPER_BOSS_DAMAGE_ABOVE = 175,
	SUPER_BOSS_DAMAGE_BELOW = 176,
	EVENT_MISSION_GROUP_ACHIEVE = 177,
	SVT_FRIENDSHIP_CLASS_NUM_ABOVE = 178,
	NOT_WAR_CLEAR = 179,
	SVT_SKILL_LV_CLASS_NUM_ABOVE = 180,
	SVT_CLASS_LV_UP_COUNT = 181,
	SVT_CLASS_SKILL_LV_UP_COUNT = 182,
	SVT_CLASS_LIMIT_UP_COUNT = 183,
	SVT_CLASS_FRIENDSHIP_COUNT = 184,
	COMPLETE_HEEL_PORTRAIT = 185,
	NOT_COMPLETE_HEEL_PORTRAIT = 186,
	CLASS_BOARD_SQUARE_RELEASED = 187,
	SVT_LEVEL_EXCHANGE_SVT = 188,
	SVT_LIMIT_EXCHANGE_SVT = 189,
	SKILL_LV_EXCHANGE_SVT = 190,
	SVT_FRIENDSHIP_EXCHANGE_SVT = 191,
	EXCHANGE_SVT = 192,
	RAID_DAMAGE_ABOVE = 193,
	RAID_DAMAGE_BELOW = 194,
	RAID_GROUP_DAMAGE_ABOVE = 195,
	RAID_GROUP_DAMAGE_BELOW = 196,
	RAID_DAMAGE_RATE_ABOVE = 197,
	RAID_DAMAGE_RATE_BELOW = 198,
	RAID_DAMAGE_RATE_NOT_ABOVE = 199,
	RAID_DAMAGE_RATE_NOT_BELOW = 200,
	RAID_GROUP_DAMAGE_RATE_ABOVE = 201,
	RAID_GROUP_DAMAGE_RATE_BELOW = 202,
	RAID_GROUP_DAMAGE_RATE_NOT_ABOVE = 203,
	RAID_GROUP_DAMAGE_RATE_NOT_BELOW = 204,
	NOT_QUEST_GROUP_CLEAR_NUM = 205,
	RAID_GROUP_OPEN_ABOVE = 206,
	RAID_GROUP_OPEN_BELOW = 207,
	TREASURE_DEVICE_ACCELERATE = 208,
	PLAY_QUEST_PHASE = 209,
	NOT_PLAY_QUEST_PHASE = 210,
	EVENT_START_TO_END = 211,
	COMMON_VALUE_ABOVE = 212,
	COMMON_VALUE_BELOW = 213,
	COMMON_VALUE_EQUAL = 214,
	ELAPSED_TIME_AFTER_QUEST_CLEAR = 215,
	WITH_STARTING_MEMBER = 216,
	LATEST_QUEST_PHASE_EQUAL = 217,
	NOT_LATEST_QUEST_PHASE_EQUAL = 218,
}

public enum CondType.CheckType
{
	EQUAL = 0,
	ABOVE = 1,
	BELOW = 2,
}

public enum ConnectMarkFadeInLagType
{
	IMMEDIATE = 0,
	DEFAULT = 1,
}

public enum CostumeListType.FlagKind
{
	OUT_OF_COSTUME_TIME = 1,
	CLOSED_HIDE_COSTUME_BANNER = 2,
	HIDE_COSTUME_SCENE = 3,
	NOT_RELEASE_COSTUME_HIDE = 4,
	NOT_GET_OPEN_RIGHT_SECRET = 5,
	NOT_GET_OPEN_RIGHT_HIDE = 6,
	CHANGE_FIGURE_ONLY = 7,
}

public enum CostumeListType.Flag
{
	OUT_OF_COSTUME_TIME = 2,
	CLOSED_HIDE_COSTUME_BANNER = 4,
	HIDE_COSTUME_SCENE = 8,
	NOT_RELEASE_COSTUME_HIDE = 16,
	NOT_GET_OPEN_RIGHT_SECRET = 32,
	NOT_GET_OPEN_RIGHT_HIDE = 64,
	CHANGE_FIGURE_ONLY = 128,
}

public enum CostumeReleaseType.Kind
{
	COSTUME_RELEASE = 1,
	COSTUME_CHANGE = 2,
}

public enum CuriousFuncEffectTiming
{
	BEFORE_CURIOUS_FUNC = 0,
	JUST_CURIOUS_FUNC = 1,
	AFTER_CURIOUS_FUNC = 2,
}

public enum CutInType
{
	CutIn1 = 0,
	CutIn2 = 1,
	CutIn3 = 2,
	CutIn4 = 3,
	CutIn5 = 4,
	CutIn6 = 5,
	CutIn7 = 6,
	CutIn8 = 7,
	CutIn9 = 8,
	CutIn10 = 9,
	CutIn11 = 10,
	CutIn12 = 11,
	CutIn13 = 12,
	CutIn14 = 13,
	CutIn15 = 14,
	CutIn16 = 15,
	CutIn17 = 16,
	CutIn18 = 17,
	CutIn19 = 18,
	CutIn20 = 19,
	CutIn21 = 20,
	CutIn22 = 21,
	CutIn23 = 22,
	CutIn24 = 23,
	CutIn25 = 24,
	CutIn26 = 25,
	CutIn27 = 26,
	CutIn28 = 27,
	CutIn29 = 28,
	CutIn30 = 29,
}

public enum DatFileName.FILE_NAME
{
	SCRIPT_SAVE = 0,
	PURCHASE_BY_BANK_REQUEST_SAVE = 1,
	BATTLE_USE_CONTINUE_REQUEST_SAVE = 2,
	BATTLE_COMMAND_SPELL_REQUEST_SAVE = 3,
	USER_SERVANT_COMBINE_VOICE_SAVE = 4,
	USER_SERVANT_NEW_SAVE = 5,
	USER_SERVANT_LOCK_SAVE = 6,
	USER_SERVANT_COLLECTION_SAVE = 7,
	USER_EQUIP_LV_SAVE = 8,
	USER_COMMANDCODE_NEW_SAVE = 9,
	USER_COMMANDCODE_COLLECTION_SAVE = 10,
	USER_SERVANT_COMMENT_SAVE = 11,
	OTHER_USER_NEW_SAVE = 12,
	MASTER_DATA_CHECK = 13,
	MASTER_DATA_LIST = 14,
	MASTER_DATA = 15,
	AUTHSAVE = 16,
	AUTHSAVE_2 = 17,
	SIGNUP_SAVE = 18,
	SERVER_SAVE = 19,
	FRIENDCODE_SAVE = 20,
	PAYMENT_SAVE = 21,
	PAYMENT_TIME_SAVE = 22,
	USER_MISSION_PROG_SAVE_EVENTID = 23,
	USER_MISSION_PROG_SAVE_EVENTID_SLOT = 24,
	USER_MISSION_NEW_SAVE = 25,
	MATERIAL_SERVANT_LIMIT_COUNT = 26,
	SERVANT_PROFILE_LIMIT_COUNT = 27,
	SERVANT_PROFILE_EVENT_JOIN = 28,
	BATTLE_USE_CONTINUE_ITEM_REQUEST_SAVE = 29,
	BATTLE_USE_ITEM_REQUEST = 30,
	UNCONFIRMED_PAYMENT = 31,
	SERVANT_CHARA_GRAPH_EX_OPEN = 32,
	QUEST_HINT_DIALOG_OPEN_SAVE = 33,
	LAST_USED_DECK_NUMBER_SAVE = 34,
	MATERIAL_BRANCH_ROUTE_SAVE = 35,
	CLEAR_RANDOM_MISSION_SAVE = 36,
	MATERIAL_GROUP_CLEAR_HISTORY_SAVE = 37,
	WARBOARD_MESSAGE_HISTORY_SAVE = 38,
	WARBOARD_MOVIE_HISTORY_SAVE = 39,
	TIPS_ARCHIVE_STATE_SAVE = 40,
	WAR_BOARD_CONTINUE_SAVE = 41,
	QUEST_FOCUS_STATE_SAVE = 42,
	SUM = 43,
}

public enum DataNameKind.Kind
{
	NONE = 0,
	SERVANT = 1,
	SERVANT_COMMENT = 2,
	SERVANT_PROFILE = 3,
	WAR = 4,
	BATTLE = 5,
	TREASUREDEVICE = 6,
	SERVANT_LIMIT = 7,
	SERVANT_TREASUREDEVICE = 8,
	SERVANT_CLASS = 9,
	SERVANT_SCRIPT = 10,
	SERVANT_CARD = 11,
	SERVANT_SKILL = 12,
	SERVANT_PASSIVE_SKILL = 13,
	USER_SERVANT = 14,
	USER_SERVANT_STORAGE = 15,
	STAGE = 16,
	SERVANT_GROUP = 17,
	BLANK_EARTH_SPOT = 18,
	BLANK_EARTH_SPOT_ADD = 19,
	SPOT = 20,
	SPOT_IMAGE = 21,
	SPOT_ROAD = 22,
	MAP_GIMMICK = 23,
	GIFT = 24,
	GIFT_ADD = 25,
	SUB_EQUIP = 26,
	USER = 27,
	USER_GAME = 28,
	USER_DECK = 29,
	USER_SERVANT_COLLECTION = 30,
	FRIENDSHIP = 31,
	GACHA = 32,
	GACHA_IMAGE = 33,
	USER_GACHA = 34,
	USER_ITEM = 35,
	ITEM = 36,
	GACHA_TICKET = 37,
	ACCESSORY = 38,
	USER_ACCESSORY = 39,
	USER_SUB_EQUIP = 40,
	TBL_USER_GAME = 41,
	SHOP = 42,
	STONE_SHOP = 43,
	BANK_SHOP = 44,
	SHOP_SCRIPT = 45,
	EQUIP = 46,
	EQUIP_EXP = 47,
	EQUIP_SKILL = 48,
	USER_EQUIP = 49,
	USER_FORMATION = 50,
	SKILL = 51,
	SKILL_LEVEL = 52,
	SKILL_DETAIL = 53,
	FUNCTION = 54,
	BUFF = 55,
	GACHA_RELEASE = 56,
	USER_QUEST = 57,
	USER_QUEST_INFO = 58,
	USER_QUEST_RECORD = 59,
	USER_EXP = 60,
	NEWS = 61,
	TELOP = 62,
	OTHER_USER_GAME = 63,
	TBL_FRIEND = 64,
	USER_PRESENT_BOX = 65,
	EVENT = 66,
	QUEST = 67,
	QUEST_ADD = 68,
	QUEST_RELEASE = 69,
	QUEST_PHASE = 70,
	QUEST_PHASE_DETAIL = 71,
	QUEST_GROUP = 72,
	QUEST_RANDOM_GROUP = 73,
	QUEST_CONSUME_ITEM = 74,
	QUEST_MESSAGE = 75,
	VIEW_QUEST_INFO = 76,
	VIEW_ENEMY = 77,
	VIEW_QUEST_ENEMY_INFO = 78,
	AREA = 79,
	BGM = 80,
	EVENT_QUEST = 81,
	EVENT_CAMPAIGN = 82,
	COMBINE_QP = 83,
	COMBINE_MATERIAL = 84,
	EVENT_COMBINE = 85,
	SERVANT_EXP = 86,
	COMBINE_SKILL = 87,
	COMBINE_TREASUREDEVICE = 88,
	ILLUSTRATOR = 89,
	CV = 90,
	TREASUREDEVICE_LEVEL = 91,
	TREASUREDEVICE_DETAIL = 92,
	USER_FOLLOWER = 93,
	NPC_FOLLOWER = 94,
	NPC_SERVANT_FOLLOWER = 95,
	USER_EVENT = 96,
	USER_PROFILE = 97,
	USER_SHOP = 98,
	USER_CONTINUE = 99,
	CONSTANT = 100,
	CONSTANT_LONG = 101,
	CONSTANT_STR = 102,
	COMMAND_SPELL = 103,
	AI = 104,
	AI_ACT = 105,
	SERVANT_VOICE = 106,
	ATTRI_RELATION = 107,
	CLASS_RELATION = 108,
	EFFECT = 109,
	EQUIP_IMAGE = 110,
	COMBINE_LIMIT = 111,
	CARD = 112,
	COMBINE_QP_SVT_EQUIP = 113,
	SERVANT_LIMIT_ADD = 114,
	SERVANT_RARITY = 115,
	SET_ITEM = 116,
	RECOVER = 117,
	BANNER = 118,
	SHOP_RELEASE = 119,
	EVENT_REWARD = 120,
	EVENT_DETAIL = 121,
	EVENT_SERVANT = 122,
	BOX_GACHA = 123,
	BOX_GACHA_BASE = 124,
	BOX_GACHA_TALK = 125,
	USER_BOX_GACHA = 126,
	BOX_GACHA_HISTORY = 127,
	BATTLE_BG = 128,
	TIPS_BATTLE = 129,
	USER_LOGIN = 130,
	VOICE = 131,
	EVENT_REWARD_EXTRA = 132,
	EVENT_MISSION = 133,
	EVENT_MISSION_CONDITION = 134,
	EVENT_MISSION_COND_DETAIL = 135,
	EVENT_MISSION_ACTION = 136,
	EVENT_MISSION_ACTION_ADD = 137,
	EVENT_MISSION_ADD = 138,
	EVENT_REWARD_SET = 139,
	COMPLETE_MISSION = 140,
	USER_EVENT_MISSION = 141,
	USER_EVENT_MISSION_COND_DETAIL = 142,
	BOX_GACHA_BASE_DETAIL = 143,
	CLOSED_MESSAGE = 144,
	USER_SERVANT_LEADER = 145,
	FUNCTION_GROUP = 146,
	EVENT_RAID = 147,
	TOTAL_EVENT_RAID = 148,
	USER_EVENT_RAID = 149,
	EVENT_POINT = 150,
	EVENT_POINT_GROUP = 151,
	TOTAL_EVENT_POINT = 152,
	USER_EVENT_POINT = 153,
	USER_PRESENT_HISTORY = 154,
	MASTER_MISSION = 155,
	SERVANT_EXCEED = 156,
	PARTIAL_MAINTENANCE = 157,
	GUIDE = 158,
	MASTER_MISSION_DISPLAY_INFO = 159,
	GACHA_GROUP = 160,
	QUEST_RESET = 161,
	WAR_ADD = 162,
	EVENT_ITEM_DISPLAY = 163,
	EVENT_ITEM_DISPLAY_GROUP = 164,
	EVENT_ITEM_DISPLAY_RELEASE = 165,
	EVENT_TUTORIAL = 166,
	EVENT_TUTORIAL_COND = 167,
	VOICE_RELEASE = 168,
	EVENT_SUPER_BOSS = 169,
	USER_SUPER_BOSS = 170,
	QUEST_SCRIPT = 171,
	QUEST_SCRIPT_RELEASE = 172,
	MATERIAL_FOLDER = 173,
	RESTRICTION = 174,
	QUEST_RESTRICTION = 175,
	SERVANT_VOICE_RELATION = 176,
	SHOP_DETAIL = 177,
	SERVANT_SCRIPT_ADD = 178,
	COMBINE = 179,
	AI_FIELD = 180,
	SERVANT_COMMENT_ADD = 181,
	EVENT_FILTER = 182,
	USER_SUPPORT_DECK = 183,
	EVENT_REWARD_SCENE = 184,
	EVENT_VOICE_PLAY = 185,
	GACHA_SUB = 186,
	GACHA_DETAIL = 187,
	GACHA_BONUS_SELECT = 188,
	GACHA_BONUS_SELECT_LINEUP = 189,
	SERVANT_CHANGE = 190,
	VOICE_COND = 191,
	BGM_RELEASE = 192,
	MYROOM_ADD = 193,
	SHOP_ACTION = 194,
	EVENT_REWARD_SCENE_RELEASE = 195,
	MAP = 196,
	MAP_COND = 197,
	MAP_BUTTON = 198,
	BANNER_ADD = 199,
	QUEST_BEHAVIOR = 200,
	EVENT_ADD = 201,
	TOTAL_LOGIN = 202,
	SERVANT_FILTER = 203,
	COMBINE_COSTUME = 204,
	SERVANT_COSTUME = 205,
	SERVANT_COSTUME_RELEASE = 206,
	USER_FRIEND_REQUEST_HISTORY = 207,
	USER_BLACKLIST = 208,
	ITEM_SELECT = 209,
	EVENT_RACE = 210,
	EVENT_RACE_RESULT = 211,
	QUEST_RACE_POINT = 212,
	USER_EVENT_RACE = 213,
	EVENT_SCRIPT = 214,
	EVENT_SCRIPT_RELEASE = 215,
	SPOT_PATH = 216,
	SPOT_ADD = 217,
	TOTAL_EVENT_RACE = 218,
	EVENT_POINT_GROUP_ADD = 219,
	VOICE_PLAY_GROUP = 220,
	VOICE_PLAY_COND = 221,
	GACHA_STORY_ADJUST = 222,
	SERVANT_FLAG = 223,
	SERVANT_FLAG_RELEASE = 224,
	EVENT_LOCATION_CAMPAIGN = 225,
	CAMPAIGN_INFO = 226,
	DIALOG_MESSAGE = 227,
	SERVANT_INDIVIDUALITY = 228,
	BOARD_MESSAGE = 229,
	BOARD_MESSAGE_RELEASE = 230,
	EVENT_SERVANT_FATIGUE = 231,
	USER_EVENT_DECK = 232,
	EVENT_TOWER = 233,
	EVENT_TOWER_REWARD = 234,
	EVENT_BULLETIN_BOARD = 235,
	EVENT_BULLETIN_BOARD_RELEASE = 236,
	EVENT_FACTORY = 237,
	SHOP_GROUP = 238,
	AURA_EFFECT = 239,
	AURA_EFFECT_POS_OVERWRITE = 240,
	USER_EVENT_MISSION_FIX = 241,
	NOT_END_EVENT_MISSION_FIX = 242,
	ENEMY_MASTER = 243,
	ENEMY_MASTER_BATTLE = 244,
	SERVANT_SKILL_RELEASE = 245,
	SERVANT_PASSIVE_SKILL_RELEASE = 246,
	SERVANT_TREASUREDEVICE_RELEASE = 247,
	MAP_GIMMICK_RELEASE = 248,
	COMMAND_CODE = 249,
	SERVANT_COMMAND_CODE_UNLOCK = 250,
	USER_COMMAND_CODE = 251,
	USER_COMMAND_CODE_COLLECTION = 252,
	USER_SERVANT_COMMAND_CODE = 253,
	COMMAND_CODE_SKILL = 254,
	COMMAND_CODE_SKILL_RELEASE = 255,
	COMMAND_CODE_COMMENT = 256,
	EVENT_STATUS = 257,
	EVENT_STATUS_QUEST = 258,
	COMMON_RESTRICTION = 259,
	EVENT_POINT_BUFF = 260,
	USER_FOLLOW = 261,
	EVENT_REWARD_GUIDE_RELEASE = 262,
	NPC_SERVANT_EQUIP = 263,
	EVENT_CAMPAIGN_RELEASE = 264,
	SERVANT_MATERIAL_FOLDER = 265,
	EVENT_EQUIP_SKILL_RELEASE = 266,
	EVENT_POINT_ACTIVITY = 267,
	FUNCTION_CATEGORY = 268,
	QUEST_PICKUP = 269,
	EVENT_UI = 270,
	EVENT_UI_RELEASE = 271,
	EVENT_UI_VALUE = 272,
	EVENT_CONQUEST_REWARD = 273,
	NPC_FOLLOWER_RELEASE = 274,
	EVENT_BONUS_FILTER = 275,
	EVENT_BONUS_FILTER_GROUP_INFO = 276,
	EVENT_BONUS_FILTER_GROUP_MEMBER = 277,
	USER_GACHA_EXTRA_COUNT = 278,
	COMMAND_CARD_RANK_PARAM = 279,
	USER_SERVANT_COMMAND_CARD = 280,
	PRIVILEGE = 281,
	USER_PRIVILEGE = 282,
	QUEST_DATE_RANGE = 283,
	EVENT_POINT_UPPER = 284,
	EVENT_POINT_UPPER_RELEASE = 285,
	USER_QUEST_ROUTE = 286,
	EVENT_BOSS_STATUS_UI = 287,
	COMMON_RELEASE = 288,
	QUEST_SPOT_RELEASE = 289,
	VOICE_MATERIAL_COND = 290,
	CLASS_RELATION_OVERWRITE = 291,
	EVENT_GROUP = 292,
	ASSETBUNDLE_KEY = 293,
	TOTAL_BOX_GACHA = 294,
	SERVANT_TREASURE_DEVICE_DAMAGE = 295,
	USER_EVENT_SERVANT_FATIGUE = 296,
	EVENT_REWARD_BG = 297,
	EVENT_FATIGUE_RECOVERY = 298,
	EVENT_BOOST_ITEM_USED = 299,
	STATUS_EFFECT_POS_OVERWRITE = 300,
	QUEST_PHASE_DETAIL_ADD = 301,
	VOICE_CLOSED_MESSAGE = 302,
	STAGE_REMAP = 303,
	USER_COMBINE_EXP = 304,
	EVENT_BOARD_GAME_CELL = 305,
	EVENT_BOARD_GAME_TOKEN = 306,
	EVENT_BOARD_GAME_TOKEN_REWARD = 307,
	USER_EVENT_BOARD_GAME_TOKEN = 308,
	SERVANT_ANIMATION_OVERWRITE = 309,
	OPENING_MOVIE = 310,
	SERVANT_LIMIT_SPOILER_PROTECTION = 311,
	PICKUP_USER_FOLLOWER = 312,
	SERVANT_COLLECTION = 313,
	GACHA_BEHAVIOR = 314,
	EVENT_QUEST_COOLTIME = 315,
	USER_EVENT_QUEST_COOLTIME = 316,
	BOOST = 317,
	WARBOARD = 318,
	WARBOARD_SQUARE = 319,
	WARBOARD_ROAD = 320,
	WARBOARD_STAGE = 321,
	WARBOARD_ACTION_POINT = 322,
	WARBOARD_ACTION_TREND = 323,
	WARBOARD_TACTICAL_TREND = 324,
	WARBOARD_STAGE_LAYOUT = 325,
	WARBOARD_STAGE_NPC = 326,
	WAR_BOARD_STAGE_WALL = 327,
	WARBOARD_AI = 328,
	WARBOARD_RATING_BASE = 329,
	WARBOARD_RATING_OFFSET = 330,
	WARBOARD_ITEM = 331,
	WARBOARD_TREASURE = 332,
	WARBOARD_QUEST = 333,
	WARBOARD_DATA = 334,
	WARBOARD_INDIVIDUALITY_CLASS = 335,
	WARBOARD_ACTION_TREND_COND = 336,
	WARBOARD_ACTION_POINT_CLASS = 337,
	WAR_BOARD_REINFORCEMENTS = 338,
	WAR_BOARD_STAGE_REINFORCEMENTS = 339,
	EVENT_PANEL_MAP = 340,
	EVENT_PANEL_MAP_DETAIL = 341,
	EVENT_PANEL_SPOT = 342,
	EVENT_PANEL_SCAN = 343,
	EVENT_DIGGING = 344,
	EVENT_DIGGING_REWARD = 345,
	EVENT_DIGGING_BLOCK = 346,
	USER_EVENT_DIGGING = 347,
	COMMON_CONSUME = 348,
	USER_EVENT_MAP = 349,
	USER_EVENT_SPOT = 350,
	WAR_GROUP = 351,
	SERVANT_LIMIT_IMAGE = 352,
	FRIENDSHIP_QUEST_DIALOG_INFO = 353,
	QUEST_RESTRICTION_INFO = 354,
	ASSIST = 355,
	WARBOARD_EFFECT = 356,
	WARBOARD_ONBOARD_SKILL = 357,
	BEFORE_BIRTH_DAY = 358,
	LOGIN_QUEST = 359,
	EVENT_COMBINE_COSTUME = 360,
	WARBOARD_STAGE_PIECE_DETAIL = 361,
	SERVANT_TREASURE_DEVICE_ADD = 362,
	SKILL_ADD = 363,
	SERVANT_LEVEL_DETAIL = 364,
	GACHA_APPEND = 365,
	USER_GACHA_DRAW_LOG = 366,
	SERVANT_APPEND_PASSIVE_SKILL = 367,
	USER_SERVANT_APPEND_PASSIVE_SKILL = 368,
	USER_SERVANT_APPEND_PASSIVE_SKILL_LV = 369,
	SVT_APPEND_PASSIVE_SKILL_UNLOCK = 370,
	COMBINE_APPEND_PASSIVE_SKILL = 371,
	SVT_COIN = 372,
	USER_SVT_COIN = 373,
	SERVANT_ADD = 374,
	TREASURE_BOX = 375,
	TREASURE_BOX_GIFT = 376,
	TREASURE_BOX_TALK = 377,
	USER_EVENT_EXPEDITION = 378,
	EVENT_EXPEDITION = 379,
	EVENT_EXPEDITION_PIECE = 380,
	EVENT_RECIPE = 381,
	EVENT_RECIPE_GIFT = 382,
	USER_EVENT_FORTIFICATION = 383,
	EVENT_FORTIFICATION = 384,
	EVENT_FORTIFICATION_DETAIL = 385,
	EVENT_FORTIFICATION_SVT = 386,
	USER_SERVANT_VOICE_PLAYED = 387,
	UPDATE_PROFILE_DIALOG_INFO = 388,
	SVT_MATERIAL_TD = 389,
	BATTLE_MASTER_IMAGE = 390,
	USER_FRIEND_POINT_GACHA_FREE_DRAW_CAMPAIGN_LOG = 391,
	USER_EVENT_RANDOM_MISSION = 392,
	EVENT_PROGRESS_VALUE = 393,
	SVT_MULTI_PORTRAIT = 394,
	EVENT_RANDOM_MISSION = 395,
	USER_GACHA_HISTORY = 396,
	USER_COIN_ROOM = 397,
	EVENT_BUDDY_POINT = 398,
	EVENT_SERVANT_POINT_RANK = 399,
	USER_EVENT_SERVANT_POINT = 400,
	FIELD_MOTION = 401,
	USER_DELETE_RESERVATION = 402,
	SERVANT_SCRIPT_MULTIPLE = 403,
	EQUIP_ADD = 404,
	QUEST_RELEASE_OVERWRITE = 405,
	USER_EVENT_ALLOUT_BATTLE = 406,
	QUEST_SCRIPT_MATERIAL_NEXT = 407,
	BATTLE_MESSAGE = 408,
	BATTLE_MESSAGE_GROUP = 409,
	USER_NPC_SVT_RECORD = 410,
	BUFF_TYPE_DETAIL = 411,
	WARBOARD_MESSAGE = 412,
	WARBOARD_PARTY_SKILL = 413,
	WARBOARD_MESSAGE_SCRIPT = 414,
	WAR_QUEST_SELECTION = 415,
	WARBOARD_STAGE_DETAIL = 416,
	QUEST_SCRIPT_MATERIAL_OVERWRITE = 417,
	QUEST_SCRIPT_BRANCH_MATERIAL = 418,
	AD_CHECK_POINT = 419,
	GIFT_DETAIL = 420,
	COMBINE_LIMIT_GIFT = 421,
	EVENT_COOLTIME_REWARD = 422,
	USER_EVENT_COOLTIME_REWARD = 423,
	CLASS_BOARD_CLASS = 424,
	CLASS_BOARD_BASE = 425,
	CLASS_BOARD_LINE = 426,
	CLASS_BOARD_LOCK = 427,
	CLASS_BOARD_SQUARE = 428,
	CLASS_BOARD_COMMAND_SPELL = 429,
	USER_CLASS_BOARD_SQUARE = 430,
	SERVANT_CARD_ADD = 431,
	MAP_LAYER = 432,
	SPOT_LAYER = 433,
	MAP_GIMMICK_LAYER = 434,
	EVENT_DATA_LOST_BATTLE = 435,
	EVENT_DATA_LOST_BATTLE_RESET = 436,
	USER_EVENT_DATA_LOST = 437,
	QUEST_HINT = 438,
	FUNC_TYPE_DETAIL = 439,
	BUFF_CONVERT = 440,
	SKILL_GROUP = 441,
	SKILL_GROUP_OVERWRITE = 442,
	SKILL_INDIVIDUALITY = 443,
	RESTRICTION_BASE = 444,
	RESTRICTION_SLOT = 445,
	RESTRICTION_SLOT_DETAIL = 446,
	RESTRICTION_MESSAGE = 447,
	RESTRICTION_WHOLE = 448,
	FUNC_DISP = 449,
	EVENT_COMMAND_ASSIST = 450,
	EVENT_MISSION_GROUP = 451,
	COMBINE_LIMIT_RELEASE = 452,
	TREASURE_DEVICE_SEQUENCE_WEIGHT = 453,
	HEEL_PORTRAIT = 454,
	USER_HEEL_PORTRAIT = 455,
	NPC_SERVANT_FOLLOWER_INDIVIDUALITY = 456,
	GACHA_EXTRA_GIFT = 457,
	EVENT_MURAL = 458,
	VIEW_WAVE_ENEMY = 459,
	BLANK_EARTH_SPOT_NAVIMENU = 460,
	BLANK_EARTH_GIMMICK = 461,
	TERMINAL_OVERWRITE = 462,
	USER_EXCHANGE_SVT = 463,
	WAR_BOARD_COMMON_RELEASE = 464,
	WAR_BOARD_EVENT = 465,
	WAR_BOARD_EVENT_SCRIPT = 466,
	WAR_BOARD_STAGE_BOSS = 467,
	WAR_BOARD_SQUARE_INDEX_GROUP = 468,
	WAR_BOARD_ACTION_TREND_GROUP = 469,
	WAR_BOARD_RATING_OFFSET_GROUP = 470,
	WAR_BOARD_FUTURE_ACTION_TREND = 471,
	SERVANT_PROFILE_PUSH = 472,
	MAP_GIMMICK_PATH = 473,
	MAP_GIMMICK_PATH_RELEASE = 474,
	SERVANT_OVERWRITE = 475,
	INDIVIDUALITY_POLICY = 476,
	INDIVIDUALITY_PERSONALITY = 477,
	ATTRI = 478,
	SERVANT_VOICE_PATTERN = 479,
	USER_GAME_COMMON = 480,
	SERVANT_PHOTO = 481,
	MASTER_PHOTO = 482,
	WAR_MESSAGE = 483,
	QUEST_AUTO_ORGANIZATION_ADJUST = 484,
	EXCLUDE_MOTION = 485,
	USER_INTERRUPTION_QUEST = 486,
	SERVANT_TRANSFORM = 487,
	MAP_UPDATE_SCHEDULE = 488,
	QUEST_PHASE_PRESENT = 489,
	USER_ACCOUNT_LINKAGE = 490,
}

public enum Device.Type
{
	ALL = 0,
	ANDROID = 1,
	IOS = 2,
	OTHER = 9,
}

public enum DisplayType.Type
{
	NORMAL = 1,
	SHADOW = 2,
	CHOCO = 3,
}

public enum EventMissionAddChangeType.Type
{
	BOARD_IMAGE = 1,
	BOARD_MESSAGE = 2,
	REWARD_ICON = 3,
}

public enum EventPointActivity.Type
{
	QUEST_CLEAR = 1,
	USE_EQUIP_SKILL = 2,
	PURCHASE_SHOP = 3,
	QUEST_PHASE_CLEAR = 4,
}

public enum EventStatus.Type
{
	NONE = 0,
	PURCHASED_RARE_PRI = 1,
	STRICT_CAMPAIGN_END = 2,
	IS_COMEBACK_TARGET_USER = 3,
	BATTLE_LINE_LOSE = 4,
	BATTLE_LINE_RESULT_END = 5,
	BATTLE_LINE_RESULT_WIN = 6,
	USE_EVENT_ITEM = 7,
	VIEW_OPENING_MOVIE = 8,
	RAID_PARTICIPATE = 9,
}

public enum EventStatus.TypeFlag
{
	PURCHASED_RARE_PRI = 2,
	STRICT_CAMPAIGN_END = 4,
	IS_COMEBACK_TARGET_USER = 8,
	BATTLE_LINE_LOSE = 16,
	BATTLE_LINE_RESULT_END = 32,
	BATTLE_LINE_RESULT_WIN = 64,
	USE_EVENT_ITEM = 128,
	VIEW_OPENING_MOVIE = 256,
	RAID_PARTICIPATE = 512,
}

public enum EventWorkType.Type
{
	MILITSRY_AFFAIRS = 1,
	INTERNAL_AFFAIRS = 2,
	FARMMING = 3,
}

public enum Face.Type
{
	NORMAL = 0,
	PLEASURE = 1,
	CRY = 2,
	EMBARRASSED = 3,
	SAD = 4,
	ANGRY = 5,
	FACE_6 = 6,
	FACE_7 = 7,
	FACE_8 = 8,
	FACE_9 = 9,
	FACE_10 = 10,
	FACE_11 = 11,
	FACE_12 = 12,
	FACE_13 = 13,
	FACE_14 = 14,
	FACE_15 = 15,
	FACE_16 = 16,
	FACE_17 = 17,
	FACE_18 = 18,
	FACE_19 = 19,
	FACE_20 = 20,
	FACE_21 = 21,
	FACE_22 = 22,
	FACE_23 = 23,
	FACE_24 = 24,
	FACE_25 = 25,
	FACE_26 = 26,
	FACE_27 = 27,
	FACE_28 = 28,
	FACE_29 = 29,
	FACE_30 = 30,
	FACE_31 = 31,
	FACE_32 = 32,
	FACE_33 = 33,
	FACE_34 = 34,
	FACE_35 = 35,
	FACE_36 = 36,
	FACE_37 = 37,
	FACE_38 = 38,
	FACE_39 = 39,
	FACE_40 = 40,
	FACE_41 = 41,
	FACE_42 = 42,
	FACE_43 = 43,
	FACE_44 = 44,
	FACE_45 = 45,
	FACE_46 = 46,
	FACE_47 = 47,
	FACE_48 = 48,
	FACE_49 = 49,
	FACE_50 = 50,
	FACE_51 = 51,
	FACE_52 = 52,
	FACE_53 = 53,
	FACE_54 = 54,
	FACE_55 = 55,
	FACE_56 = 56,
	FACE_57 = 57,
	FACE_58 = 58,
	FACE_59 = 59,
	FACE_60 = 60,
	FACE_61 = 61,
	FACE_62 = 62,
	FACE_63 = 63,
	FACE_64 = 64,
	FACE_65 = 65,
	FACE_66 = 66,
	FACE_67 = 67,
	FACE_68 = 68,
	FACE_69 = 69,
	FACE_70 = 70,
	FACE_71 = 71,
	FACE_72 = 72,
	FACE_73 = 73,
	FACE_74 = 74,
	FACE_75 = 75,
	FACE_76 = 76,
	FACE_77 = 77,
	FACE_78 = 78,
	FACE_79 = 79,
	FACE_80 = 80,
	FACE_81 = 81,
	FACE_82 = 82,
	FACE_83 = 83,
	FACE_84 = 84,
	FACE_85 = 85,
	FACE_86 = 86,
	FACE_87 = 87,
	FACE_88 = 88,
	FACE_89 = 89,
	FACE_90 = 90,
	FACE_91 = 91,
	FACE_92 = 92,
	FACE_93 = 93,
	FACE_94 = 94,
	FACE_95 = 95,
	FACE_96 = 96,
	FACE_97 = 97,
	FACE_98 = 98,
	FACE_99 = 99,
	FACE_100 = 100,
	FACE_101 = 101,
	FACE_102 = 102,
	FACE_103 = 103,
	FACE_104 = 104,
	FACE_105 = 105,
	FACE_106 = 106,
	FACE_107 = 107,
	FACE_108 = 108,
	FACE_109 = 109,
	FACE_110 = 110,
	FACE_111 = 111,
	FACE_112 = 112,
	FACE_113 = 113,
	FACE_114 = 114,
	FACE_115 = 115,
	FACE_116 = 116,
	FACE_117 = 117,
	FACE_118 = 118,
	FACE_119 = 119,
	FACE_120 = 120,
	FACE_121 = 121,
	FACE_122 = 122,
	FACE_123 = 123,
	FACE_124 = 124,
	FACE_125 = 125,
	FACE_126 = 126,
	FACE_127 = 127,
	FACE_128 = 128,
	FACE_129 = 129,
	FACE_130 = 130,
	FACE_131 = 131,
	FACE_132 = 132,
	SUM = 133,
}

public enum FileName.HIT_EFFECT
{
	NONE = 0,
	SLASH_VERTICAL = 1,
	SLASH_HORIZON = 2,
	BLOW = 3,
}

public enum FlipMode
{
	Y_ROT = 0,
	X_SCALE = 1,
	Z_SCALE = 2,
}

public enum Follower.Type
{
	NONE = 0,
	FRIEND = 1,
	NOT_FRIEND = 2,
	NPC = 3,
	NPC_NO_TD = 4,
	FOLLOW = 5,
}

public enum Frequency.Type
{
	NONE = 0,
	ONCE = 1,
	ONCE_UNTIL_REBOOT = 2,
	EVERY_TIME = 3,
	VALENTINE = 4,
	EVERY_TIME_AFTER = 5,
	EVERY_TIME_BEFORE = 6,
}

public enum FriendStatus.Kind
{
	SEARCH = 0,
	OFFER = 1,
	OFFERED = 2,
	FRIEND = 3,
	REJECT = 4,
	CANCEL = 5,
	REMOVE = 6,
	FRIEND_HISTORY = 7,
	BLACKLIST = 8,
	FOLLOW = 9,
	SUM = 10,
}

public enum FuncList.TYPE
{
	NONE = 0,
	ADD_STATE = 1,
	SUB_STATE = 2,
	DAMAGE = 3,
	DAMAGE_NP = 4,
	GAIN_STAR = 5,
	GAIN_HP = 6,
	GAIN_NP = 7,
	LOSS_NP = 8,
	SHORTEN_SKILL = 9,
	EXTEND_SKILL = 10,
	RELEASE_STATE = 11,
	LOSS_HP = 12,
	INSTANT_DEATH = 13,
	DAMAGE_NP_PIERCE = 14,
	DAMAGE_NP_INDIVIDUAL = 15,
	ADD_STATE_SHORT = 16,
	GAIN_HP_PER = 17,
	DAMAGE_NP_STATE_INDIVIDUAL = 18,
	HASTEN_NPTURN = 19,
	DELAY_NPTURN = 20,
	FRIEND_POINT_UP = 104,
	FRIEND_POINT_UP_DUPLICATE = 123,
	EXP_UP = 101,
	QP_UP = 102,
	DROP_UP = 103,
	EVENT_DROP_UP = 105,
	EVENT_DROP_RATE_UP = 106,
	DAMAGE_NP_HPRATIO_HIGH = 21,
	DAMAGE_NP_HPRATIO_LOW = 22,
	EVENT_POINT_UP = 107,
	EVENT_POINT_RATE_UP = 108,
	CARD_RESET = 23,
	REPLACE_MEMBER = 24,
	TRANSFORM_SERVANT = 109,
	QP_DROP_UP = 110,
	SERVANT_FRIENDSHIP_UP = 111,
	USER_EQUIP_EXP_UP = 112,
	CLASS_DROP_UP = 113,
	ENEMY_ENCOUNT_COPY_RATE_UP = 114,
	ENEMY_ENCOUNT_RATE_UP = 115,
	LOSS_HP_SAFE = 25,
	DAMAGE_NP_COUNTER = 26,
	DAMAGE_NP_STATE_INDIVIDUAL_FIX = 27,
	DAMAGE_NP_SAFE = 28,
	CALL_SERVANT = 29,
	PT_SHUFFLE = 30,
	ENEMY_PROB_DOWN = 116,
	LOSS_STAR = 31,
	CHANGE_SERVANT = 32,
	CHANGE_BG = 33,
	DAMAGE_VALUE = 34,
	WITHDRAW = 35,
	FIX_COMMANDCARD = 36,
	SHORTEN_BUFFTURN = 37,
	EXTEND_BUFFTURN = 38,
	SHORTEN_BUFFCOUNT = 39,
	EXTEND_BUFFCOUNT = 40,
	CHANGE_BGM = 41,
	DISPLAY_BUFFSTRING = 42,
	RESURRECTION = 43,
	GAIN_NP_BUFF_INDIVIDUAL_SUM = 44,
	SET_SYSTEM_ALIVE_FLAG = 45,
	FORCE_INSTANT_DEATH = 46,
	DAMAGE_NP_RARE = 47,
	GAIN_NP_FROM_TARGETS = 48,
	GAIN_HP_FROM_TARGETS = 49,
	LOSS_HP_PER = 50,
	LOSS_HP_PER_SAFE = 51,
	SHORTEN_USER_EQUIP_SKILL = 52,
	QUICK_CHANGE_BG = 53,
	SHIFT_SERVANT = 54,
	DAMAGE_NP_AND_CHECK_INDIVIDUALITY = 55,
	ABSORB_NPTURN = 56,
	OVERWRITE_DEAD_TYPE = 57,
	FORCE_ALL_BUFF_NOACT = 58,
	BREAK_GAUGE_UP = 59,
	BREAK_GAUGE_DOWN = 60,
	MOVE_TO_LAST_SUBMEMBER = 61,
	EXTEND_USER_EQUIP_SKILL = 62,
	UPDATE_ENEMY_ENTRY_MAX_COUNT_EACH_TURN = 63,
	GET_REWARD_GIFT = 117,
	SEND_SUPPORT_FRIEND_POINT = 118,
	MOVE_POSITION = 119,
	REVIVAL = 120,
	DAMAGE_NP_INDIVIDUAL_SUM = 121,
	DAMAGE_VALUE_SAFE = 122,
	MOVE_STATE = 124,
	CHANGE_BGM_COSTUME = 125,
	LOSS_COMMAND_SPELL = 126,
	GAIN_COMMAND_SPELL = 127,
	UPDATE_ENTRY_POSITIONS = 128,
	BUDDY_POINT_UP = 129,
	ADD_FIELD_CHANGE_TO_FIELD = 130,
	SUB_FIELD_BUFF = 131,
	EVENT_FORTIFICATION_POINT_UP = 132,
	GAIN_NP_INDIVIDUAL_SUM = 133,
	SET_QUEST_ROUTE_FLAG = 134,
	LAST_USE_PLAYER_SKILL_COPY = 135,
	CHANGE_ENEMY_MASTER_FACE = 136,
	DAMAGE_VALUE_SAFE_ONCE = 137,
	ADD_BATTLE_VALUE = 138,
	SET_BATTLE_VALUE = 139,
	GAIN_MULTIPLY_NP = 140,
	LOSS_MULTIPLY_NP = 141,
}

public enum FuncList.COND
{
	NONE = 0,
	INVARIABLY = 1,
	PROB = 2,
	MOREHP = 3,
	LESSHP = 4,
}

public enum GachaExtraGiftBonusType.Type
{
	NONE = 0,
	USE_STONE_BONUS = 1,
	SPECIAL_BONUS = 2,
}

public enum GachaExtraGiftResultType.Type
{
	GIVE_DIRECT = 1,
	GIVE_PRESENT_BOX = 2,
	OVERFLOW = 3,
}

public enum GameEventType.TYPE
{
	NONE = 0,
	RAID_BOSS = 1,
	PVP = 2,
	POINT = 3,
	LOGIN_BONUS = 4,
	COMBINE_CAMPAIGN = 5,
	SHOP = 6,
	QUEST_CAMPAIGN = 7,
	BANK = 8,
	SERIAL_CAMPAIGN = 9,
	LOGIN_CAMPAIGN = 10,
	LOGIN_CAMPAIGN_REPEAT = 11,
	EVENT_QUEST = 12,
	SVTEQUIP_COMBINE_CAMPAIGN = 13,
	TERMINAL_BANNER = 14,
	BOX_GACHA = 15,
	BOX_GACHA_POINT = 16,
	LOGIN_CAMPAIGN_STRICT = 17,
	TOTAL_LOGIN = 18,
	COMEBACK_CAMPAIGN = 19,
	LOCATION_CAMPAIGN = 20,
	WAR_BOARD = 22,
	COMBINE_COSUTUME_ITEM = 23,
	MYROOM_MULTIPLE_VIEW_CAMPAIGN = 24,
	INTERLUDE_CAMPAIGN = 25,
	MYROOM_PHOTO_CAMPAIGN = 26,
}

public enum GamePurchase.Type
{
	ALL = 0,
	NONE = 0,
	ITEM = 1,
	EQUIP = 2,
	FRIEND_GACHA = 3,
	SERVANT = 4,
	SET_ITEM = 5,
	QUEST = 6,
	EVENT_SHOP = 7,
	EVENT_SVT_GET = 8,
	MANA_SHOP = 9,
	STORAGE_SVT = 10,
	STORAGE_SVTEQUIP = 11,
	BGM = 12,
	COSTUME_RELEASE = 14,
	BGM_RELEASE = 15,
	LOTTERY_SHOP = 16,
	EVENT_FACTORY = 17,
	ITEM_AS_PRESENT = 18,
	COMMAND_CODE = 19,
	GIFT = 20,
	EVENT_SVT_JOIN = 21,
	ASSIST = 22,
}

public enum Gender.Type
{
	MALE = 1,
	FEMALE = 2,
	OTHER = 3,
}

public enum Gift.Type
{
	SERVANT = 1,
	ITEM = 2,
	FRIENDSHIP = 3,
	USER_EXP = 4,
	EQUIP = 5,
	EVENT_SVT_JOIN = 6,
	EVENT_SVT_GET = 7,
	QUEST_REWARD_ICON = 8,
	COSTUME_RELEASE = 9,
	COSTUME_GET = 10,
	COMMAND_CODE = 11,
	EVENT_POINT_BUFF = 12,
	EVENT_BOARD_GAME_TOKEN = 13,
	EVENT_COMMAND_ASSIST = 14,
	EVENT_HEEL_PORTRAIT = 15,
	BATTLE_ITEM = 16,
}

public enum Grade.Kind
{
	NONE = 0,
	FES = 1,
}

public enum Individuality.TYPE
{
	NONE = 0,
}

public enum ItemType.Type
{
	QP = 1,
	STONE = 2,
	AP_RECOVER = 3,
	AP_ADD = 4,
	MANA = 5,
	KEY = 6,
	GACHA_CLASS = 7,
	GACHA_RELIC = 8,
	GACHA_TICKET = 9,
	LIMIT = 10,
	SKILL_LV_UP = 11,
	TD_LV_UP = 12,
	FRIEND_POINT = 13,
	EVENT_POINT = 14,
	EVENT_ITEM = 15,
	QUEST_REWARD_QP = 16,
	CHARGE_STONE = 17,
	RP_ADD = 18,
	BOOST_ITEM = 19,
	STONE_FRAGMENTS = 20,
	ANONYMOUS = 21,
	RARE_PRI = 22,
	COSTUME_RELEASE = 23,
	ITEM_SELECT = 24,
	COMMAND_CARD_PRM_UP = 25,
	DICE = 26,
	CONTINUE_ITEM = 27,
	EUQIP_SKILL_USE_ITEM = 28,
	SVT_COIN = 29,
	FRIENDSHIP_UP_ITEM = 30,
	PP = 31,
	TRADE_AP = 32,
	RI = 33,
	STORMPOD = 34,
	BATTLE_ITEM = 35,
}

public enum MissionProgressType.Type
{
	NONE = 0,
	REGIST = 1,
	OPEN_CONDITION = 2,
	START = 3,
	CLEAR = 4,
	ACHIEVE = 5,
}

public enum MissionType.Type
{
	NONE = 0,
	EVENT = 1,
	WEEKLY = 2,
	DAILY = 3,
	EXTRA = 4,
	LIMITED = 5,
	COMPLETE = 6,
	RANDOM = 7,
}

public enum News.Type
{
	NONE = 0,
	HTML_TEXT = 1,
	HTML_URL = 2,
	TEMPLATE = 3,
	DATA = 4,
}

public enum NpcSvtType.Type
{
	SVT = 1,
	ENEMY = 2,
	ENEMY_LARGE = 3,
}

public enum OptionalFPSType
{
	NORMAL = 30,
	HIGH = 60,
}

public enum PayType.Type
{
	STONE = 1,
	QP = 2,
	FRIEND_POINT = 3,
	MANA = 4,
	TICKET = 5,
	EVENT_ITEM = 6,
	CHARGE_STONE = 7,
	STONE_FRAGMENTS = 8,
	ANONYMOUS = 9,
	RARE_PRI = 10,
	ITEM = 11,
	GRAIL_FRAGMENTS = 12,
	FREE = 13,
	COMMON_CONSUME = 14,
}

public enum QuestGroupType.Type
{
	NONE = 0,
	EVENT_QUEST = 1,
	QUEST_RELEASE = 2,
	EVENT_POINT_QUEST = 3,
	EVENT_POINT_GROUP_QUEST = 4,
	EVENT_RACE_QUEST = 5,
	EVENT_RACE_GROUP_QUEST = 6,
	MISSION_GROUP_QUEST = 7,
	EVENT_TOWER = 8,
	EVENT_TOWER_FLOOR = 9,
	HIGHLIGHT_QUEST = 10,
	EVENT_DAILY_POINT = 11,
	EVENT_ACTIVITY_POINT_GAUGE = 12,
	INTERLUDE = 13,
	EVENT_BATTLE_LINE = 14,
	BATTLE_GROUP = 15,
	SHARE_QUEST_INFO = 16,
	ALLOUT_BATTLE_QUEST = 17,
	EVENT_FORTIFICATION = 18,
}

public enum Rarity.TYPE
{
	NONE = 0,
	COMMON = 1,
	UNCOMMON = 2,
	RARE = 3,
	SRARE = 4,
	SSRARE = 5,
	ACCESSORY = 101,
	SUB_EQUIP = 102,
}

public enum RecoverType.Type
{
	COMMAND_SPELL = 1,
	STONE = 2,
	ITEM = 3,
}

public enum ResourceFolder
{
	COMMON_EFFECT = 0,
	ACTOR_EFFECT = 1,
	BATTLE_EFFECT = 2,
}

public enum ResponseCommandKind.Kind
{
	NONE = 0,
	SIGNUP = 1,
	ACCOUNT_REGIST = 2,
	GAME_DATA = 3,
	LOGIN = 4,
	HOME = 5,
	GACHA_DRAW = 6,
	DECK_SETUP = 7,
	USER_FORMATION = 8,
	PURCHASE = 9,
	PURCHASE_BY_STONE = 10,
	PURCHASE_BY_BANK = 11,
	SELL_SERVANT = 12,
	FRIEND_OFFER = 13,
	FRIEND_ACCEPT = 14,
	FRIEND_REJECT = 15,
	FRIEND_CANCEL = 16,
	FRIEND_REMOVE = 17,
	PROFILE = 18,
	CHANGE_USERNAME = 19,
	BATTLE_SETUP = 20,
	BATTLE_TURN = 21,
	BATTLE_RESULT = 22,
	BATTLE_COMMANDSPELL = 23,
	BATTLE_USECONTINUE = 24,
	COMBINE_SERVANT = 25,
	CARD_COMBINE_SKILL = 26,
	CARD_COMBINE_TREASUREDVC = 27,
	CARD_FRIENDSHIP_EXCEED = 28,
	PRESENT_RECEIVE = 29,
	CODE_INPUT = 30,
	CONTINUE_PREPARE = 31,
	CONTINUE_INPUT = 32,
	CONTINUE_DECIDE = 33,
	SET_FAVORITE_SERVANT = 34,
	RANDOM_LIMIT_COUNT = 35,
	TUTORIAL_SET = 36,
	TUTORIAL_CLEAR = 37,
	BATTLE_RESUME = 38,
	CARD_LIMIT = 39,
	SERVANT_EQUIP_SET = 40,
	SERVANT_EQUIP_COMBINE = 41,
	DEBUG_QUEST = 42,
	SET_BIRTHDAY = 43,
	ITEM_USE = 44,
	ITEM_RECOVER = 45,
	COMMANDSPELL_USE = 46,
	BOX_GACHA_DRAW = 47,
	BOX_GACHA_RESET = 48,
	MISSION_NOTIFY = 49,
	EV_MISSION_REWARD = 50,
	SUPPORT_SERVANT = 51,
	BATTLE_SCENARIO = 52,
	DECK_EDIT_NAME = 53,
	DEBUG_SERVER_TIME = 54,
	CARD_COMBINE_EXCEED = 55,
	SET_LOCK_SERVANT = 56,
	TUTORIAL_EVENT_FLAG_SET = 57,
	TAKEIN_STORAGE = 58,
	TAKEOUT_STORAGE = 59,
	FOLLOWER_EDIT_NAME = 60,
	BANK_STATUS = 61,
	CARD_COMBINE_COSTUME = 62,
	BLACKLIST_TOP = 63,
	BLACKLIST_REGIST = 64,
	BLACKLIST_REMOVE = 65,
	FRIEND_MESSAGE_HIDE_SYNC = 66,
	EVENT_SCRIPT_FLAG = 67,
	CARD_SVT_FLAG = 68,
	EVENT_LOCATION = 69,
	SET_STATUS_SERVANT = 70,
	SET_STATUS_COMMAND_CODE = 71,
	STATUS_SYNC_COMMAND_CODE = 72,
	SERVANT_RECOVERY_SYNC = 73,
	EVENT_DECK_SETUP = 74,
	USER_STATUS_FLAG_SET = 75,
	FRIEND_TOP = 76,
	COMMAND_CODE_ATTACH = 77,
	COMMAND_CODE_DETACH = 78,
	COMMAND_CODE_UNLOCK = 79,
	DEBUG_UPDATE_USER = 80,
	FOLLOW_ASSIGN = 81,
	FOLLOW_REMOVE = 82,
	EVENT_DAILY_POINT = 83,
	COMMAND_CARD_EXCEED = 84,
	CARD_COMBINE_LIMIT_SPECIAL = 85,
	BATTLE_QUEST_ROUTE = 86,
	FRIEND_LOCK_SYNC = 87,
	RAID_AUTO_UPDATE = 88,
	COMMAND_CODE_LOCK = 89,
	WARBOARD_START = 90,
	WARBOARD_SETUP = 91,
	WARBOARD_BUFF_SAVE = 92,
	WARBOARD_MOVE = 93,
	WARBOARD_TREASURE = 94,
	WARBOARD_TURN_END = 95,
	WARBOARD_MASTER_ATTACK = 96,
	WARBOARD_WALL_ATTACK = 97,
	WARBOARD_COMMAND_SPELL = 98,
	WARBOARD_BATTLE_RESULT = 99,
	WARBOARD_FINISH = 100,
	WARBOARD_RESUME = 101,
	WARBOARD_CONTINUE = 102,
	WARBOARD_REINFORCEMENTS = 103,
	EVENT_SCAN_PANEL_MAP = 104,
	BATTLE_USE_CONTINUE_ITEM = 105,
	CHECK_DATE_VERSION = 106,
	BATTLE_USE_ITEM = 107,
	COMBINE_APPEND_PASSIVE_SKILL = 108,
	TREASURE_BOX_DRAW = 109,
	EVENT_MISSION_RANDOM_CANCEL = 110,
	COIN_ROOM = 111,
	USER_DELETE = 112,
	BATTLE_RESET = 113,
	EVENT_DIGGING = 114,
	EVENT_RESET_DIGGING = 115,
	EVENT_EXPEDITION_START = 116,
	EVENT_EXPEDITION_FINISH = 117,
	CLIENT_API_ERROR_DIALOG = 118,
	EVENT_RECEIVE_COOLTIME_REWARD = 119,
	EVENT_CREATE_RECIPE = 120,
	EVENT_FORTIFICATION = 121,
	CLASS_BOARD_RELEASE_SQUARE = 122,
	CLASS_BOARD_RELEASE_LOCK = 123,
	EVENT_RESET_DATA_LOST_BATTLE = 124,
	DEBUG_ADD_SERVANT = 125,
	DEBUG_EDIT_SERVANT = 126,
	DEBUG_DELETE_SERVANT = 127,
	BATTLE_INTERRUPTION = 128,
}

public enum Restriction.Type
{
	INDIVIDUALITY = 1,
	RARITY = 2,
	TOTAL_COST = 3,
	LV = 4,
	SUPPORT_ONLY = 5,
	UNIQUE_SVT_ONLY = 6,
	FIXED_SUPPORT_POSITION = 7,
	FIXED_MY_SVT_INDIVIDUALITY_POSITION_MAIN = 8,
	FIXED_MY_SVT_INDIVIDUALITY_SINGLE = 9,
	SVT_NUM = 10,
	MY_SVT_NUM = 11,
	MY_SVT_OR_NPC = 12,
	ALLOUT_BATTLE_UNIQUE_SVT = 13,
	FIXED_SVT_INDIVIDUALITY_POSITION_MAIN = 14,
	UNIQUE_INDIVIDUALITY = 15,
	MY_SVT_OR_SUPPORT = 16,
	DATA_LOST_BATTLE_UNIQUE_SVT = 17,
}

public enum Restriction.RangeType
{
	NONE = 0,
	EQUAL = 1,
	NOT_EQUAL = 2,
	ABOVE = 3,
	BELOW = 4,
	BETWEEN = 5,
}

public enum Restriction.TargetType
{
	MY_SVT = 1,
	OTHERS_SVT = 2,
	NPC_SVT = 99,
}

public enum RewardType.Type
{
	GIFT = 1,
	EXTRA = 2,
	SET = 3,
}

public enum SceneList.Type
{
	Init = 0,
	DebugTest = 4,
	Title = 9,
	Battle = 10,
	DebugTitle = 19,
	Summon = 20,
	Shop = 22,
	Friend = 23,
	MyRoom = 30,
	Combine = 32,
	Terminal = 34,
	Follower = 35,
	BattleScript = 38,
	Formation = 39,
	PartyOrganization = 40,
	ServantList = 41,
	ServantEquipList = 42,
	MasterFormation = 44,
	BattleDemoScene = 50,
	SupportSelect = 60,
	Warehouse = 71,
	EventReward = 72,
	WarBoard = 80,
	CoinRoom = 90,
	ClassBoard = 91,
	ClassBoardSelect = 92,
	MasterMission = 100,
	Empty = 1000,
	SummonEffect = 1001,
	RegulationChecker = 1002,
	BattleCharaViewScene = 1003,
}

public enum ScriptSceneType.Kind
{
	BATTLE_SETUP = 1,
	BATTLE_RESULT = 2,
	MATERIAL = 3,
	NOT_PROGRESS = 4,
	IS_INTERLUDE = 5,
}

public enum ScriptSceneType.Flag
{
	BATTLE_SETUP = 2,
	BATTLE_RESULT = 4,
	MATERIAL = 8,
	NOT_PROGRESS = 16,
	IS_INTERLUDE = 32,
}

public enum ShopFlag.FlagKind
{
	CLOSED_HIDE_CHANGE_ITEM_IMAGE = 1,
	CLOSED_HIDE_CHANGE_ITEM_NAME = 2,
	CLOSED_HIDE_CHANGE_ITEM_DETAIL = 3,
	CLOSED_HIDE_CHANGE_NUM = 4,
	CLOSED_HIDE_NEED_ITEM = 5,
	CLOSED_HIDE_NEED_ITEM_NUM = 6,
	RESET_QUEST_REWARD = 7,
	CLOSED_SHOP_PRIORITY_LOW = 8,
	HIDDEN_IN_CASE_OF_BUYING = 9,
	HIDDEN_IN_CASE_OF_BUYING_SHOP_ID = 10,
	LIMITED_ICON_DISPLAY_TARGET = 11,
	MONTHLY_ICON_DISPLAY_TARGET = 12,
	NOT_HAVING_SHOP_ITEM_RECEIVE = 13,
	SHOW_HAVE_ICON = 14,
	SOLD_OUT = 15,
	COMMIT_AFTER_SCRIPT = 16,
	EXCHANGESERVANT_ICON_DISPLAY_TARGET = 17,
	SHOW_INDEFINITE_PERIOD = 18,
	FLAG_ON_USED_ADD_BUFF_ITEM_BY_ANOTHER_PAY = 19,
}

public enum ShopFlag.Flag
{
	CLOSED_HIDE_CHANGE_ITEM_IMAGE = 2,
	CLOSED_HIDE_CHANGE_ITEM_NAME = 4,
	CLOSED_HIDE_CHANGE_ITEM_DETAIL = 8,
	CLOSED_HIDE_CHANGE_NUM = 16,
	CLOSED_HIDE_NEED_ITEM = 32,
	CLOSED_HIDE_NEED_ITEM_NUM = 64,
	RESET_QUEST_REWARD = 128,
	CLOSED_SHOP_PRIORITY_LOW = 256,
	HIDDEN_IN_CASE_OF_BUYING = 512,
	HIDDEN_IN_CASE_OF_BUYING_SHOP_ID = 1024,
	LIMITED_ICON_DISPLAY_TARGET = 2048,
	MONTHLY_ICON_DISPLAY_TARGET = 4096,
	NOT_HAVING_SHOP_ITEM_RECEIVE = 8192,
	SHOW_HAVE_ICON = 16384,
	SOLD_OUT = 32768,
	COMMIT_AFTER_SCRIPT = 65536,
	EXCHANGESERVANT_ICON_DISPLAY_TARGET = 131072,
	SHOW_INDEFINITE_PERIOD = 262144,
	FLAG_ON_USED_ADD_BUFF_ITEM_BY_ANOTHER_PAY = 524288,
}

public enum ShopType.Type
{
	NONE = 0,
	EVENT_ITEM = 1,
	MANA = 2,
	RARE_PRI = 3,
	SVT_STORAGE = 4,
	SVT_EQUIP_STORAGE = 5,
	STONE_FRAGMENTS = 6,
	SVT_ANONYMOUS = 7,
	BGM = 8,
	LIMIT_MATERIAL = 9,
	GRAIL_FRAGMENTS = 10,
	SVT_COSTUME = 11,
	START_UP_SUMMON = 12,
	SHOP13 = 13,
	TRADE_AP = 14,
	SHOP15 = 15,
	EVENT_SVT_EQUIP = 16,
}

public enum StatusRank.Kind
{
	A = 11,
	A_PLUS = 12,
	A_PLUS2 = 13,
	A_MINUS = 14,
	A_PLUS3 = 15,
	A_QUESTION = 16,
	B = 21,
	B_PLUS = 22,
	B_PLUS2 = 23,
	B_MINUS = 24,
	B_PLUS3 = 25,
	B_QUESTION = 26,
	C = 31,
	C_PLUS = 32,
	C_PLUS2 = 33,
	C_MINUS = 34,
	C_PLUS3 = 35,
	C_QUESTION = 36,
	D = 41,
	D_PLUS = 42,
	D_PLUS2 = 43,
	D_MINUS = 44,
	D_PLUS3 = 45,
	D_QUESTION = 46,
	E = 51,
	E_PLUS = 52,
	E_PLUS2 = 53,
	E_MINUS = 54,
	E_PLUS3 = 55,
	E_QUESTION = 56,
	EX = 61,
	QUESTION = 98,
	NONE = 99,
}

public enum StoneShopEffect.Kind
{
	CONTINUE = 1,
	ACT_RECOVER = 2,
	CHANGE_GACHA = 3,
	EXTEND_FRIEND_MAX = 11,
	EXTEND_SVT_MAX = 12,
	EXTEND_SVT_EQUIP_MAX = 13,
	RP_RECOVER = 14,
}

public enum StrengthStatus.Kind
{
	NONE = 0,
	POSSIBLE = 1,
	MAXIMUM = 99,
}

public enum SvtAttri.TYPE
{
	HUMAN = 1,
	SKY = 2,
	GROUND = 3,
	STAR = 4,
	BEAST = 5,
	VOID = 10,
}

public enum SvtClassAttri.TYPE
{
	SABER = 1,
	ARCHER = 2,
	LANCER = 3,
	RIDER = 4,
	CASTER = 5,
	ASSASIN = 6,
	BERSERKER = 7,
	SHIELDER = 8,
	RULER = 9,
	ALTEREGO = 10,
	AVENGER = 11,
	MOONCANCER = 23,
	FOREIGNER = 25,
	PRETENDER = 28,
	BEAST = 33,
	OTHER = 1000,
	ALL = 1001,
	EXTRA1 = 1004,
	EXTRA2 = 1005,
}

public enum SvtClassGroupType.TYPE
{
	NORMAL = 1,
	OTHER = 2,
	ALL = 3,
}

public enum SvtType.Type
{
	NORMAL = 1,
	HEROINE = 2,
	COMBINE_MATERIAL = 3,
	ENEMY = 4,
	ENEMY_COLLECTION = 5,
	SERVANT_EQUIP = 6,
	STATUS_UP = 7,
	SVT_EQUIP_MATERIAL = 8,
	ENEMY_COLLECTION_DETAIL = 9,
	ALL = 10,
	COMMAND_CODE = 11,
	SVT_MATERIAL_TD = 12,
}

public enum SvtVoiceType.Type
{
	HOME = 1,
	GROETH = 2,
	FIRST_GET = 3,
	EVENT_JOIN = 4,
	EVENT_REWARD = 5,
	BATTLE = 6,
	TREASURE_DEVICE = 7,
	MASTER_MISSION = 8,
	EVENT_SHOP = 9,
	HOME_COSTUME = 10,
	BOX_GACHA_TALK = 11,
	BATTLE_ENTRY = 12,
	BATTLE_WIN = 13,
	EVENT_TOWER_REWARD = 14,
	GUIDE = 15,
	EVENT_DAILY_POINT = 16,
	TDDAMAGE = 17,
	TREASURE_BOX = 18,
	WAR_BOARD = 19,
	EVENT_DIGGING = 20,
	EVENT_EXPEDITION = 21,
	EVENT_RECIPE = 22,
	EVENT_FORTIFICATION = 23,
	SUM = 24,
}

public enum Target.PlayerTypeFlag
{
	NONE = 0,
	PLAYER = 1,
	ENEMY = 2,
	ALL = 3,
}

public enum Target.TYPE
{
	SELF = 0,
	PT_ONE = 1,
	PT_ANOTHER = 2,
	PT_ALL = 3,
	ENEMY = 4,
	ENEMY_ANOTHER = 5,
	ENEMY_ALL = 6,
	PT_FULL = 7,
	ENEMY_FULL = 8,
	PT_OTHER = 9,
	PT_ONE_OTHER = 10,
	PT_RANDOM = 11,
	ENEMY_OTHER = 12,
	ENEMY_RANDOM = 13,
	PT_OTHER_FULL = 14,
	ENEMY_OTHER_FULL = 15,
	PTSELECT_ONE_SUB = 16,
	PTSELECT_SUB = 17,
	PT_ONE_ANOTHER_RANDOM = 18,
	PT_SELF_ANOTHER_RANDOM = 19,
	ENEMY_ONE_ANOTHER_RANDOM = 20,
	PT_SELF_ANOTHER_FIRST = 21,
	PT_SELF_BEFORE = 22,
	PT_SELF_AFTER = 23,
	PT_SELF_ANOTHER_LAST = 24,
	COMMAND_TYPE_SELF_TREASURE_DEVICE = 25,
	FIELD_OTHER = 26,
	ENEMY_ONE_NO_TARGET_NO_ACTION = 27,
	PT_ONE_HP_LOWEST_VALUE = 28,
	PT_ONE_HP_LOWEST_RATE = 29,
	ENEMY_RANGE = 30,
}

public enum TutorialFlag.Progress
{
	_1 = 1,
	_2 = 2,
	_3 = 3,
	_4 = 4,
	COMPLETE = 4,
}

public enum TutorialFlag.LocalId
{
	TUTORIAL_LABEL_BOOST_ITEM = 101,
}

public enum TutorialFlag.Id
{
	TUTORIAL_LABEL_STONE_GACHA = 101,
	TUTORIAL_LABEL_END = 102,
	TUTORIAL_LABEL_SHOP = 103,
	TUTORIAL_LABEL_COMBINE = 104,
	TUTORIAL_LABEL_FAVORITE1 = 105,
	TUTORIAL_LABEL_FAVORITE2 = 106,
	TUTORIAL_LABEL_GACHA_SCENE = 107,
	TUTORIAL_LABEL_GACHA_SVT_EQUIP = 108,
	TUTORIAL_LABEL_DECK_SCENE = 109,
	TUTORIAL_LABEL_DECK_SVT_EQUIP = 110,
	TUTORIAL_LABEL_EVENT_GACHA = 111,
	TUTORIAL_LABEL_EVENT_REWARD = 112,
	TUTORIAL_LABEL_DECK_IN_SVT_EQUIP = 113,
	TUTORIAL_LABEL_EVENT_MISSION = 114,
	TUTORIAL_LABEL_MASHU_CHANGE = 115,
	TUTORIAL_LABEL_IBARAKI_RAID_TERMINAL = 116,
	TUTORIAL_LABEL_IBARAKI_RAID_BATTLE = 117,
	TUTORIAL_LABEL_IBARAKI_RAID_EVENT_REWARD = 118,
	TUTORIAL_LABEL_RAID2_MAP = 119,
	TUTORIAL_LABEL_RAID2_BATTLE = 120,
	TUTORIAL_LABEL_RAID2_EVENT_REWARD = 121,
	TUTORIAL_LABEL_RAID2_BATTLE_2 = 122,
	TUTORIAL_LABEL_SVT_LEAVE = 126,
	TUTORIAL_LABEL_FES = 127,
	TUTORIAL_LABEL_MYROOM = 128,
	TUTORIAL_LABEL_CALDEA_GATE = 129,
	TUTORIAL_LABEL_DAILY_QUEST = 130,
	TUTORIAL_LABEL_FREIND_STORY_QUEST = 131,
	TUTORIAL_LABEL_PRESENT_BOX = 201,
	TUTORIAL_LABEL_DECK = 202,
	TUTORIAL_LABEL_CHAPTER2_PROLOGUE = 204,
	TUTORIAL_LABEL_DECK2 = 205,
	TUTORIAL_LABEL_FIX_COSTUME = 206,
	TUTORIAL_LABEL_MASTER_MISSION = 207,
}

public enum TutorialFlag.EventId
{
	TUTORIAL_LABEL_BOOST_ITEM = 0,
	TUTORIAL_LABEL_HELP = 1,
	TUTORIAL_LABEL_QUEST = 2,
	TUTORIAL_LABEL_RESET_QUEST = 3,
	TUTORIAL_LABEL_REWARD_HELP = 4,
	TUTORIAL_LABEL_SHOP_HELP = 5,
	TUTORIAL_LABEL_MISSION_SPOT_OPEN = 6,
	TUTORIAL_LABEL_MISSION_OPEN_ANOTHER = 7,
	TUTORIAL_LABEL_BATTLE_START = 8,
	TUTORIAL_LABEL_BATTLE_TURN = 9,
	TUTORIAL_LABEL_BATTLE_RESULT = 10,
	TUTORIAL_LABEL_BATTLE_RESULT_WIN = 11,
	TUTORIAL_LABEL_BATTLE_RESULT_LOSE = 12,
	TUTORIAL_LABEL_QUEST2 = 13,
	TUTORIAL_LABEL_SVTGET = 14,
	TUTORIAL_LABEL_SHOP = 15,
	TUTORIAL_LABEL_SUPPORT_SELECT = 16,
	EVENT_TAB1 = 18,
	TUTORIAL_LABEL_EVENT_TAB1_EFFECT = 25,
	TUTORIAL_LABEL_EVENT_TAB2_EFFECT = 26,
	TUTORIAL_LABEL_EVENT_TAB3_EFFECT = 27,
	TUTORIAL_LABEL_BATTLE_WAVE = 28,
	TUTORIAL_LABEL_COSTUME = 29,
	TUTORIAL_LABEL_OPEN_SORT_WINDOW = 30,
	TUTORIAL_LABEL_GACHA = 32,
	TUTORIAL_LABEL_SVT_COMBINE = 33,
	TUTORIAL_LABEL_SVT_LIMIT_UP = 34,
	TUTORIAL_LABEL_SVT_SKILL = 35,
	TUTORIAL_LABEL_SVT_EQUIP = 36,
	TUTORIAL_LABEL_SVT_NP = 37,
	TUTORIAL_LABEL_SVT_LVEXCEED = 38,
	TUTORIAL_LABEL_OPEN_CHOICE_WINDOW = 39,
	TUTORIAL_LABEL_OPEN_SMART_CHOICE_WINDOW = 40,
	TUTORIAL_LABEL_EVENT_TAB4 = 41,
	TUTORIAL_LABEL_EVENT_TAB4_HELP = 42,
	TUTORIAL_LABEL_OPEN_QUEST_START = 43,
	TUTORIAL_LABEL_OPEN_SUPPORT_SETTING = 45,
	TUTORIAL_LABEL_SVT_EQUIP_FRIENDSHIP_SELECT = 52,
	SVT_COMBINE_LIMIT_SPECIAL = 53,
	WAR_BOARD_MAP = 59,
	WAR_BOARD_SETUP = 60,
	WAR_BOARD_START = 61,
	WAR_BOARD_MAP_SETUP = 62,
	LOGIN_BONUS = 63,
	OPEN_SPECIFIC_QUEST = 64,
	EVENT_FUNCTION01 = 65,
	EVENT_FUNCTION02 = 66,
	EVENT_FUNCTION03 = 67,
	EVENT_FUNCTION04 = 68,
	EVENT_FUNCTION05 = 69,
	EVENT_FUNCTION06 = 70,
	EVENT_FUNCTION07 = 71,
	EVENT_FUNCTION08 = 72,
	EVENT_FUNCTION09 = 73,
	EVENT_FUNCTION10 = 74,
	EVENT_FUNCTION11 = 75,
	EVENT_FUNCTION12 = 76,
	EVENT_FUNCTION13 = 77,
	EVENT_FUNCTION14 = 78,
	EVENT_FUNCTION15 = 79,
	EVENT_FUNCTION16 = 80,
	EVENT_FUNCTION17 = 81,
	EVENT_FUNCTION18 = 82,
	EVENT_FUNCTION19 = 83,
	EVENT_FUNCTION20 = 84,
}

public enum TutorialFlag.ImageId
{
	NULL = 0,
	SUMMON_TOP = 1,
	FIRST_EQUIP = 2,
	FORMATION_TOP = 3,
	EQUIP_INFO_1 = 4,
	EQUIP_INFO_2 = 5,
	SHOP_TOP = 6,
	COMBINE_TOP = 7,
	BATTLE_STATUS = 8,
	BATTLE_COMMANDSPELL = 9,
	BATTLE_MENU = 10,
	EVENT_GACHA = 11,
	EVENT_REWARD = 12,
	EVENT_MISSION = 13,
	EVENT_RAID = 14,
	TERMINAL_RAID_1 = 15,
	TERMINAL_RAID_2 = 16,
	TERMINAL_RAID_3 = 17,
	BOOST_ITEM = 18,
	ANONYMOUS_HELP = 19,
	RARE_PRI_HELP = 20,
	CALDEA_FOLDER_GATE = 21,
	CALDEA_FOLDER_WEEKLY = 22,
	SUPPORT_FORMATION = 23,
	CALDEA_FOLDER_FRIEND_STORY = 33,
	DECK_1 = 37,
	DECK_2 = 38,
	PRESENT_BOX_1 = 39,
	PRESENT_BOX_2 = 40,
	PRESENT_BOX_3 = 41,
	MASTER_MISSION = 42,
	SELECT_SORT_HELP = 43,
	SVT_SKILL_COMBINE_HELP = 44,
	GOLEM_SKILL_HELP = 45,
	OVERWRITE_LIMIT_HELP = 46,
	SPECIAL_ITEM_HELP = 47,
	COIN_ROOM = 57,
	DECK2_1 = 644,
	SHOP15_HELP = 1029,
}

public enum TutorialFlag.EventTutorialFlag
{
	FORCE_SAVE = 1,
	EVERYTIME_TUTORIAL = 2,
}

public enum UserShopFlag.FlagKind
{
	RECEIVED_SHOP_ITEM = 1,
	USED_ADD_BUFF_ITEM = 2,
	RETURN_EXCHANGE_ITEM = 3,
	RETURN_RARE_PRI_SHOP = 4,
}

public enum UserShopFlag.Flag
{
	RECEIVED_SHOP_ITEM = 2,
	USED_ADD_BUFF_ITEM = 4,
	RETURN_EXCHANGE_ITEM = 8,
	RETURN_RARE_PRI_SHOP = 16,
}

public enum UserStatusFlag.Kind
{
	COMBINE_MATERIAL_C = 0,
	COMBINE_MATERIAL_UC = 1,
	COMBINE_MATERIAL_R = 2,
	STATUS_UP_C = 3,
	STATUS_UP_UC = 4,
	STATUS_UP_R = 5,
	SVT_EQUIP_C = 6,
	SVT_EQUIP_UC = 7,
	SVT_EQUIP_R = 8,
	COSTUME_DISPLAY_SETTING = 9,
	FIRST_NP_SPEED = 10,
	FIX_MAIN_SUPPORT_DECK = 11,
	FIX_EVENT_SUPPORT_DECK = 12,
	QUEST_DROP_AUTOSEL_COMBINE_MATERIAL_C = 13,
	QUEST_DROP_AUTOSEL_COMBINE_MATERIAL_UC = 14,
	QUEST_DROP_AUTOSEL_COMBINE_MATERIAL_R = 15,
	QUEST_DROP_AUTOSEL_COMBINE_MATERIAL_SR = 16,
	RANDOM_LIMIT_COUNT = 17,
	RANDOM_LIMIT_COUNT_SUPPORT = 18,
	SVT_LIMIT_SPOILER_PROTECTION = 19,
	SVT_LIMIT_DISPLAY_SETTING = 20,
	BIRTHDAY_SETTING = 21,
	ISSUED_DELETE_PASSWORD = 22,
	DELETED = 23,
}

public enum UserStatusFlag.Mask
{
	COMBINE_MATERIAL_C = 1,
	COMBINE_MATERIAL_UC = 2,
	COMBINE_MATERIAL_R = 4,
	STATUS_UP_C = 8,
	STATUS_UP_UC = 16,
	STATUS_UP_R = 32,
	SVT_EQUIP_C = 64,
	SVT_EQUIP_UC = 128,
	SVT_EQUIP_R = 256,
	COSTUME_DISPLAY_SETTING = 512,
	FIRST_NP_SPEED = 1024,
	FIX_MAIN_SUPPORT_DECK = 2048,
	FIX_EVENT_SUPPORT_DECK = 4096,
	QUEST_DROP_AUTOSEL_COMBINE_MATERIAL_C = 8192,
	QUEST_DROP_AUTOSEL_COMBINE_MATERIAL_UC = 16384,
	QUEST_DROP_AUTOSEL_COMBINE_MATERIAL_R = 32768,
	QUEST_DROP_AUTOSEL_COMBINE_MATERIAL_SR = 65536,
	RANDOM_LIMIT_COUNT = 131072,
	RANDOM_LIMIT_COUNT_SUPPORT = 262144,
	SVT_LIMIT_SPOILER_PROTECTION = 524288,
	SVT_LIMIT_DISPLAY_SETTING = 1048576,
	BIRTHDAY_SETTING = 2097152,
	ISSUED_DELETE_PASSWORD = 4194304,
	DELETED = 8388608,
}

public enum Voice.BATTLE
{
	NONE = 0,
	ATTACK1 = 10,
	ATTACK2 = 11,
	ATTACK3 = 12,
	EX1 = 20,
	EX2 = 21,
	EX3 = 22,
	HOUGU1_1 = 111,
	HOUGU1_2 = 112,
	HOUGU1_3 = 113,
	HOUGU1_4 = 114,
	HOUGU1_5 = 115,
	HOUGU2_1 = 121,
	HOUGU2_2 = 122,
	HOUGU2_3 = 123,
	HOUGU2_4 = 124,
	HOUGU2_5 = 125,
	HOUGU3_1 = 131,
	HOUGU3_2 = 132,
	HOUGU3_3 = 133,
	HOUGU3_4 = 134,
	HOUGU3_5 = 135,
	HOUGU4_1 = 141,
	HOUGU5_1 = 151,
	HOUGU6_1 = 161,
	HOUGU7_1 = 171,
	HOUGU8_1 = 181,
	HOUGU9_1 = 191,
	SKILL1 = 31,
	SKILL2 = 32,
	START1 = 41,
	START2 = 42,
	WIN1 = 51,
	WIN2 = 52,
	DAMAGE1 = 61,
	HDAMAGE1 = 71,
	DEAD1 = 81,
	DEAD2 = 82,
	CARD1 = 201,
	CARD2 = 202,
	CARD3 = 203,
	HCARD1 = 211,
	HCARD2 = 212,
	HCARD3 = 213,
	EENTRY1 = 214,
	EENTRY2 = 215,
	HCARD4 = 216,
	ATTACK4 = 217,
	ATTACK5 = 218,
	ATTACK6 = 219,
	EX4 = 220,
	EX5 = 221,
	EX6 = 222,
	SKILL3 = 223,
	SKILL4 = 224,
	START3 = 225,
	START4 = 226,
	WIN3 = 227,
	WIN4 = 228,
	DAMAGE2 = 229,
	DEAD3 = 230,
	DEAD4 = 231,
	EENTRY_310 = 232,
	EENTRY_320 = 233,
	EENTRY_330 = 234,
	EENTRY_331 = 235,
	EENTRY_340 = 236,
	EENTRY_341 = 237,
	EENTRY_342 = 238,
	HDAMAGE2 = 239,
	ATTACK7 = 240,
	ATTACK8 = 241,
	ATTACK9 = 242,
	SKILL5 = 243,
	SKILL6 = 244,
	CARD4 = 245,
	CARD5 = 246,
	CARD6 = 247,
	EX7 = 248,
	EX8 = 249,
	EX9 = 250,
	HCARD5 = 251,
	HEROINECHANGE_HCARD = 252,
	HCARD6 = 253,
	SKILL7 = 254,
	SKILL8 = 255,
	SKILL9 = 256,
	EX10 = 257,
	EX11 = 258,
	EX12 = 259,
	EX13 = 260,
	EX14 = 261,
	EX15 = 262,
	EX16 = 263,
	EX17 = 264,
	EX18 = 265,
	ATTACK10 = 266,
	ATTACK11 = 267,
	ATTACK12 = 268,
	ATTACK13 = 269,
	ATTACK14 = 270,
	ATTACK15 = 271,
	ATTACK16 = 272,
	ATTACK17 = 273,
	ATTACK18 = 274,
	START5 = 275,
	START6 = 276,
	START7 = 277,
	START8 = 278,
	ATTACK19 = 279,
	ATTACK20 = 280,
	ATTACK21 = 281,
	ATTACK22 = 282,
	ATTACK23 = 283,
	ATTACK24 = 284,
	DEAD5 = 285,
	DEAD6 = 286,
	DEAD7 = 287,
	DEAD8 = 288,
	WIN5 = 289,
	WIN6 = 290,
	WIN7 = 291,
	WIN8 = 292,
	DAMAGE3 = 293,
	DAMAGE4 = 294,
	HDAMAGE3 = 295,
	HDAMAGE4 = 296,
	COUNTER1 = 297,
	COUNTER2 = 298,
	COUNTER3 = 299,
	HCARD7 = 300,
	HCARD8 = 301,
	HCARD9 = 302,
	HCARD10 = 303,
	HCARD11 = 304,
	HCARD12 = 305,
	START3_1 = 306,
	START4_1 = 307,
	HOUGU10_1 = 1001,
}

public enum VoiceClosedType.Type
{
	GRAY = 1,
	HIDE = 2,
}

public enum VoiceCondType.Type
{
	BIRTH_DAY = 1,
	EVENT = 2,
	FRIENDSHIP = 3,
	SVT_GET = 4,
	SVT_GROUP = 5,
	QUEST_CLEAR = 6,
	NOT_QUEST_CLEAR = 7,
	LEVEL_UP = 8,
	LIMIT_COUNT = 9,
	LIMIT_COUNT_COMMON = 10,
	COUNT_STOP = 11,
	ISNEW_WAR = 12,
	EVENT_END = 13,
	EVENT_NOEND = 14,
	EVENT_MISSION_ACTION = 15,
	MASTER_MISSION = 16,
	LIMIT_COUNT_ABOVE = 17,
	EVENT_SHOP_PURCHASE = 18,
	EVENT_PERIOD = 19,
	FRIENDSHIP_ABOVE = 20,
	SPACIFIC_SHOP_PURCHASE = 21,
	FRIENDSHIP_BELOW = 22,
	COSTUME = 23,
	LEVEL_UP_LIMIT_COUNT = 24,
	LEVEL_UP_LIMIT_COUNT_ABOVE = 25,
	LEVEL_UP_LIMIT_COUNT_BELOW = 26,
}

public enum ImageItem.Id
{
	NONE = 0,
	TREASURE_1 = 1,
	TREASURE_2 = 2,
	TREASURE_3 = 3,
	SERVANT = 4,
	QP = 5,
	STONE = 6,
	MANA = 7,
	NP = 8,
	SKILL = 9,
	SVT_EQUIP = 10,
	GACHA_TICKET = 11,
	FRIEND_POINT = 12,
	STONE_FRAGMENTS = 16,
	ANONYMOUS = 17,
	RARE_PRI = 18,
	SVT_COSTUME_RELEASE = 23,
	QUESTION_MARK = 99,
	QUESTION_MARK2 = 8007,
	SERVANT_SVT = 8008,
	SERVANT_EQ = 8009,
	COMMAND_CODE = 8014,
	TRADE_AP_SEED = 103,
	TRADE_AP_FRUIT = 104,
	AP = 47,
}

public enum AssetData.Type
{
	ASSET_STORAGE = 0,
	ASSET_RESOURCE = 1,
	ASSET_AUDIO = 2,
}

public enum AtlasManager.CARD_ICON_TYPE
{
	S = 0,
	M = 1,
	L = 2,
	THICK = 3,
}

public enum AtlasManager.SkinType
{
	DIALOG = 0,
	TERMINAL_UI = 1,
	COMMON_BG_01 = 2,
	TEX_BACK_BG = 3,
	COMMON_BG_02 = 4,
	MINI_DIALOG = 5,
	MID_DIALOG = 6,
	TERMINAL_BG = 7,
}

public enum AtlasManager.FrameType
{
	BLACK = 0,
	BRONZE = 1,
	SILVER = 2,
	GOLD = 3,
	FRAME_0801 = 4,
	FRAME_0802 = 5,
	FRAME_0803 = 6,
	FRAME_0804 = 7,
	HIDE = 8,
	BLANK = 9,
	SUPPORT = 10,
	SUPPORT_ONLY = 11,
	DEFAULT = 2,
}

public enum AtlasManager.UIChangeType
{
	Default = 0,
	CosmosInTheLostbelt = 1,
}

public enum ServantAssetLoadManager.RetryStatus
{
	None = 0,
	RetryButtonPressed = 1,
	SupporterListSelected = 2,
	Forbid = 3,
	RetryBattleStarted = 4,
}

public enum SpawnerOverflowPolicy
{
	Instantiate = 0,
	Recycle = 1,
}

protected enum StandFigureCamera.State
{
	IDLE = 0,
	START = 1,
	RENDER = 2,
	SEND = 3,
	ERROR = 4,
}

protected enum SwitchParameterDisplayManager.State
{
	FADE_IN = 0,
	DISP = 1,
	FADE_OUT = 2,
}

public enum MapCameraViewAdjusterUtil.FailedReason
{
	NONE = 0,
	HAS_INTERSECT = 1,
	OVERFLOW_CAMERA_RECT_UNAVOIDABLE = 2,
}

public enum CharaGraphListMenuBase.ResultKind
{
	CANCEL = 0,
	DECIDE = 1,
	SERVANT_QUEST = 2,
}

public enum CharaGraphListMenuBase.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
	EQUIP_SELECT = 5,
	SHOW_STATUS = 6,
}

public enum CharaGraphListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
	MODIFY = 3,
}

public enum CharaGraphListViewManager.ResultKind
{
	DECIDE = 0,
	LONG_TAP = 1,
}

public enum CharaGraphListViewObject.InitMode
{
	INVISIBLE = 0,
	VALID = 1,
	INPUT = 2,
	MODIFY = 3,
}

public enum BattleModelObjectVisibleControlComponent.Timing
{
	INITIALIZE = 0,
	BECOME_TARGET_TREASURE_DEVICE_ACTIVE = 1,
}

private enum BillBoardGroupManager.phase
{
	NONE = 0,
	ADDING = 1,
	USING = 2,
}

protected enum BillBoardGrouped.SP_GROUP
{
	FIXED = 0,
	FIXED_CAM = 1,
	SIZE_OF = 2,
}

public enum EventUpValIconComponent.Alignment
{
	CENTER = 0,
	LEFT = 1,
	RIGHT = 2,
}

public enum IconLabelInfo.IconKind
{
	CLEAR = 0,
	DATA = 1,
	LEVEL = 2,
	HP = 3,
	HP_COMMA = 4,
	ATK = 5,
	ATK_COMMA = 6,
	COST = 7,
	ID = 8,
	LIMIT_COUNT = 9,
	FREE = 10,
	UNIT = 11,
	STONE_UNIT = 12,
	MANA_UNIT = 13,
	QP_UNIT = 14,
	BANK_UNIT = 15,
	FRIEND_POINT_UNIT = 16,
	FRIEND_RANK_UNIT = 17,
	EVENT_ITEM_UNIT = 18,
	STONE_FRAGMENTS_UNIT = 19,
	ANONYMOUS_UNIT = 20,
	RARE_PRI_UNIT = 21,
	STONE = 22,
	MANA = 23,
	QP = 24,
	BANK = 25,
	FRIEND_POINT = 26,
	EVENT_ITEM = 27,
	STONE_FRAGMENTS = 28,
	ANONYMOUS = 29,
	RARE_PRI = 30,
	GRAIL_FRAGMENTS = 31,
	FRIEND_RANK = 32,
	NP_LEVEL = 33,
	NP_ICON_LEVEL = 34,
	RARITY = 35,
	RARITY_EXCEED = 36,
	AMOUNT = 37,
	ADD_HP = 38,
	ADD_ATK = 39,
	ADD_COST = 40,
	DIFFER_HP = 41,
	DIFFER_ATK = 42,
	DIFFER_COST = 43,
	REINFORCEMENT_HP = 44,
	REINFORCEMENT_ATK = 45,
	EXTENTION_HP = 46,
	EXTENTION_ATK = 47,
	FOLLOWER_SKILL_LEVEL = 48,
	YEAR_DATE = 49,
	ALL_COSTUME = 50,
	HAVE_COSTUME = 51,
	NOT_HAVE_COSTUME = 52,
	NOT_HAVE_RELEASE_ITEM = 53,
	LIMIT_COUNT2 = 54,
	FOLLOWER_FRIEND_POINT = 55,
	NOT_HAVING_SHOP_ITEM_RECEIVE = 56,
	DISP_NO = 57,
}

public enum SendEventToFsm.Trigger
{
	OnClick = 0,
	OnMouseOver = 1,
	OnMouseOut = 2,
	OnPress = 3,
	OnRelease = 4,
	OnDoubleClick = 5,
}

public enum ServantClassCompatibilityIconComponent.DispMode
{
	EDIT = 0,
	LIST = 1,
	SUPPORT = 2,
	SUPPORT_GROUP = 3,
	WAR_BOARD = 4,
	NONE = 5,
}

public enum AdManager.AdLibrary
{
	ADJUST = 0,
	REPRO = 1,
	ALL = 2,
	SIZE = 3,
}

public enum AdManager.Category
{
	TEST = 0,
	PURCHASE = 1,
	TUTORIAL = 2,
	MASTER_LEVEL_UP = 3,
	PHASE_CLEAR = 4,
	QUEST_CLEAR = 5,
	WAR_CLEAR = 6,
	LOGIN = 7,
	MASTER_MISSION = 8,
	EVENT_QUEST = 9,
	STORY_QUEST = 10,
	SERVANT_COMBINE = 11,
	SKILL_COMBINE = 12,
	LIMIT_COMBINE = 13,
	CLICK = 14,
}

public enum AdManager.CheckPoint
{
	purchase = 0,
	id_ = 1,
	level_ = 2,
	accept_terms = 3,
	finish_first_battle = 4,
	start_gacha = 5,
	first_login_of_the_day = 6,
	complete_tutorial = 7,
	complete_daily_mission = 8,
	start_quest = 9,
	clear_quest = 10,
	lose_quest = 11,
	continue_quest = 12,
	terminal_banner = 13,
}

public enum AvalonSceneManager.FadeType
{
	NONE = 0,
	BLACK = 1,
	WHITE = 2,
	DEFAULT = 1,
}

protected enum AvalonSceneManager.ChangeType
{
	RELEASE = 0,
	CLEAR = 1,
	TRANS = 2,
	PUSH = 3,
	POP = 4,
	POP_RELEASE = 5,
}

public enum GeoLocation.ResultState
{
	NOT_STARTED = 0,
	GETTING_INFO = 1,
	DISABLED_BY_USER = 2,
	TIME_OUT = 3,
	FAILED = 4,
	SUCEED = 5,
}

public enum MainMenuBar.Kind
{
	NONE = 0,
	TERMINAL = 1,
	AREA = 2,
	FORMATION = 3,
	SUMMON = 4,
	COMBINE = 5,
	SHOP = 6,
	FRIEND = 7,
	MYROOM = 8,
	LATEST_SCENARIO = 9,
}

public enum NetworkManager.ReadResult
{
	OK = 0,
	NONE = 1,
	READ_ERROR = 2,
	CRYPT_ERROR = 3,
	JSON_ERROR = 4,
	VERSION_ERROR = 5,
	MD5_ERROR = 6,
}

public enum NetworkManager.WebViewAddressType
{
	NEWS = 0,
	SUMMON_DETAIL = 1,
	HELP = 2,
	CONTACT = 3,
	TERMS = 4,
	CREDIT = 5,
	RIGHTS = 6,
	TERMINAL_BANNER = 7,
	SP_DEAL = 8,
	BOX_GACHA = 9,
	DIALOG_BANNER = 10,
	PRIVACY_POLICY = 11,
	DELETE_ACCOUNT = 12,
	WARBOARD = 13,
}

private enum NetworkManager.DataServerAddressType
{
	IS_OFFLINE = 0,
	IS_ONLINE = 1,
	SCRIPT = 2,
	REDIRECT = 3,
}

public enum OptionManager.SOUND_MASK
{
	NONE = 0,
	SE = 1,
	VOICE = 2,
	BGM = 4,
}

public enum AccountingManager.Result
{
	NONE = 0,
	BUSY = 1,
	SUCCESS = 2,
	WAIT = 3,
	CANCEL = 4,
	ERROR = 5,
	SUSPEND = 6,
	BLOCK = 7,
	LIMIT_OVER = 8,
	INIT_ERROR = 9,
}

public enum PurchaseBehaviour.Result
{
	NONE = 0,
	BUSY = 1,
	SUCCESS = 2,
	SUCCESS_WITHOUT_NOTICE = 3,
	WAIT = 4,
	CANCEL = 5,
	ERROR = 6,
	SUSPEND = 7,
	BLOCK = 8,
	LIMIT_OVER = 9,
	INIT_ERROR = 10,
	PRODUCT_NOT_AVAILABLE = 11,
	DUPLICATE_TRANSACTION = 12,
	GOOGLE_PLAY_ACCOUNT_ID_ERROR = 13,
	GOOGLE_PLAY_PENDING_AFTER_PURCHASE = 14,
	GOOGLE_PLAY_PENDING_ON_RESTORE_PURCHASE = 15,
	GOOGLE_PLAY_CANCELED_ON_RESTORE_PURCHASE = 16,
}

public enum PurchaseLogic.PurchaseAvailablilty
{
	UNKNOWN = 0,
	AVAILABLE_FOR_PURCHASE = 1,
	BANK_UNAVAILABLE = 2,
	MONTHLY_LIMIT_OVER = 3,
	BANK_STATUS_RESULT_ERROR = 4,
}

public enum ResolutionManager.ResolutionType
{
	NORMAL = 0,
	LOW = 1,
}

private enum SeManager.SeType
{
	RESIDENT_SE = 0,
	SE = 1,
}

public enum SeManager.SystemSeKind
{
	BTN_COMMON = 0,
	BTN_CANCEL = 1,
	BTN_WARNING = 2,
	METER = 3,
	GET_ITEM = 4,
	LEVEL_UP = 5,
	STATUS_OPEN = 6,
	WINDOW_SLIDE = 7,
	BTN_DECIDE = 8,
	UNIOPEN = 9,
	UNICLOSE = 10,
	LOCK = 11,
}

public enum SeManager.CommonSeKind
{
	BATTLE_NORMAL_WAVE_FADE_IN = 0,
	BATTLE_BOSS_WAVE_FADE_IN = 1,
	BATTLE_CHARGE_SKILL = 2,
	BATTLE_GAMEOVER = 3,
	BATTLE_SET_COMMAND_CARD = 4,
	BATTLE_OPEN_COMMAND_CARD = 5,
	BATTLE_DECIDE_COMMANDO_CARD = 6,
	BATTLE_CHANGE_CRITICAL = 7,
	BATTLE_CHARGE_NP = 8,
	BATTLE_BTN_COMMON = 9,
	BATTLE_BTN_CANCEL = 10,
	BATTLE_OPEN_STATUS = 11,
	BATTLE_CLOSE_STATUS = 12,
	BATTLE_ADD_EXTRA_CARD = 13,
	BATTLE_USE_NP = 14,
	BATTLE_INCREMENT_MERTER = 15,
	BATTLE_COUNT_UP_NUM = 16,
	AREA_OPEN_QUEST_SPOT = 17,
	AREA_BTN_DISE = 18,
	COMBINE = 19,
	MISSION_POP_BAR = 20,
	TEST_SE = 21,
	WORLD_MOVE_MAP_PT1 = 22,
	WORLD_MOVE_MAP_PT2 = 23,
	BATTLE_SKILL_SHIFT = 24,
	BATTLE_DECIDE_ORDER_1 = 25,
	BATTLE_DECIDE_ORDER_2 = 26,
	BATTLE_ERROR_ORDER = 27,
	AREA_DECIDE_TITLE_WAR_BOARD = 28,
	EVENT_CONQUEST_GET_SE = 29,
}

public enum SePlayer.SeType
{
	NORMAL = 0,
	VOICE = 1,
}

public enum SoundManager.CueType
{
	ACB_ONLY = 0,
	ALL = 1,
}

public enum BezierControlPointMode
{
	Free = 0,
	Aligned = 1,
	Mirrored = 2,
}

public enum Custom2dSplineMesh.FlattenAxis
{
	X = 0,
	Y = 1,
	Z = 2,
}

public enum AiAllocationInfo.ApplySvtFlag
{
	ALL = 0,
	OWN = 1,
	FRIEND = 2,
	NPC = 4,
}

public enum DataManager.ReadMasterVersionResult
{
	BUSY = 0,
	OK = 1,
	CRYPT_ERROR = 2,
	JSON_ERROR = 3,
	READ_ERROR = 4,
	EMPTY_MASTER_ERROR = 5,
}

public enum DataManager.ReadMasterDataResult
{
	BUSY = 0,
	OK = 1,
	CRYPT_ERROR = 2,
	JSON_ERROR = 3,
	READ_ERROR = 4,
	EMPTY_MASTER_ERROR = 5,
}

public enum DataManager.UpdateMasterDataResult
{
	BUSY = 0,
	OK = 1,
	CRYPT_ERROR = 2,
	JSON_ERROR = 3,
	WRITE_ERROR = 4,
	EMPTY_MASTER_ERROR = 5,
	EMPTY_MASTER_DATA_ERROR = 6,
}

public enum DataVals.TYPE
{
	Rate = 0,
	Turn = 1,
	Count = 2,
	Value = 3,
	Value2 = 4,
	UseRate = 5,
	Target = 6,
	Correction = 7,
	ParamAdd = 8,
	ParamMax = 9,
	HideMiss = 10,
	OnField = 11,
	HideNoEffect = 12,
	Unaffected = 13,
	ShowState = 14,
	AuraEffectId = 15,
	ActSet = 16,
	ActSetWeight = 17,
	ShowQuestNoEffect = 18,
	CheckDead = 19,
	RatioHPHigh = 20,
	RatioHPLow = 21,
	SetPassiveFrame = 22,
	ProcPassive = 23,
	ProcActive = 24,
	HideParam = 25,
	SkillID = 26,
	SkillLV = 27,
	ShowCardOnly = 28,
	EffectSummon = 29,
	RatioHPRangeHigh = 30,
	RatioHPRangeLow = 31,
	TargetList = 32,
	OpponentOnly = 33,
	StatusEffectId = 34,
	EndBattle = 35,
	LoseBattle = 36,
	AddIndividualty = 37,
	AddLinkageTargetIndividualty = 38,
	SameBuffLimitTargetIndividuality = 39,
	SameBuffLimitNum = 40,
	CheckDuplicate = 41,
	OnFieldCount = 42,
	TargetRarityList = 43,
	DependFuncId = 44,
	DependFuncVals = 45,
	InvalidHide = 46,
	OutEnemyNpcId = 47,
	InEnemyNpcId = 48,
	OutEnemyPosition = 49,
	IgnoreIndividuality = 50,
	StarHigher = 51,
	ChangeTDCommandType = 52,
	ShiftNpcId = 53,
	DisplayLastFuncInvalidType = 54,
	AndCheckIndividualityList = 55,
	WinBattleNotRelatedSurvivalStatus = 56,
	ForceSelfInstantDeath = 57,
	ChangeMaxBreakGauge = 58,
	ParamAddMaxValue = 59,
	ParamAddMaxCount = 60,
	LossHpChangeDamage = 61,
	IncludePassiveIndividuality = 62,
	MotionChange = 63,
	PopLabelDelay = 64,
	NoTargetNoAct = 65,
	CardIndex = 66,
	CardIndividuality = 67,
	WarBoardTakeOverBuff = 68,
	ParamAddSelfIndividuality = 69,
	ParamAddOpIndividuality = 70,
	ParamAddFieldIndividuality = 71,
	ParamAddValue = 72,
	MultipleGainStar = 73,
	NoCheckIndividualityIfNotUnit = 74,
	ForcedEffectSpeedOne = 75,
	SetLimitCount = 76,
	CheckEnemyFieldSpace = 77,
	TriggeredFuncPosition = 78,
	DamageCount = 79,
	DamageRates = 80,
	OnPositions = 81,
	OffPositions = 82,
	TargetIndiv = 83,
	IncludeIgnoreIndividuality = 84,
	EvenIfWinDie = 85,
	CallSvtEffectId = 86,
	ForceAddState = 87,
	UnSubState = 88,
	ForceSubState = 89,
	IgnoreIndivUnreleaseable = 90,
	OnParty = 91,
	CounterId = 92,
	CounterLv = 93,
	CounterOc = 94,
	UseTreasureDevice = 95,
	SkillReaction = 96,
	BehaveAsFamilyBuff = 97,
	UnSubStateWhileLinkedToOthers = 98,
	NotAccompanyWhenLinkedTargetMoveState = 99,
	NotTargetSkillIdArray = 100,
	ShortTurn = 101,
	FieldIndividuality = 102,
	BGId = 103,
	BGType = 104,
	BgmId = 105,
	TakeOverFieldState = 106,
	TakeOverNextWaveBGAndBGM = 107,
	RemoveFieldBuffActorDeath = 108,
	FieldBuffGrantType = 109,
	Priority = 110,
	AddIndividualityEx = 111,
	IgnoreResistance = 112,
	GainNpTargetPassiveIndividuality = 113,
	HpReduceToRegainIndiv = 114,
	DisplayActualRecoveryHpFlag = 115,
	ShiftDeckIndex = 116,
	PopValueText = 117,
	IsLossHpPerNow = 118,
	CopyTargetFunctionType = 119,
	CopyFunctionTargetPTOnly = 120,
	IgnoreValueUp = 121,
	ApplyValueUp = 122,
	ActNoDamageBuff = 123,
	ActSelectIndex = 124,
	CopyTargetBuffType = 125,
	NotSkillCopyTargetFuncIds = 126,
	NotSkillCopyTargetIndividualities = 127,
	ClassIconAuraEffectId = 128,
	ActMasterGenderType = 129,
	IntervalTurn = 130,
	IntervalCount = 131,
	TriggeredFieldCountTarget = 132,
	TriggeredFieldCountRange = 133,
	TargetEnemyRange = 134,
	TriggeredFuncPositionSameTarget = 135,
	TriggeredFuncPositionAll = 136,
	TriggeredTargetHpRange = 137,
	TriggeredTargetHpRateRange = 138,
	ExcludeUnSubStateIndiv = 139,
	ProgressTurnOnBoard = 140,
	CheckTargetResurrectable = 141,
	CancelTransform = 142,
	UnSubStateWhenContinue = 143,
	CheckTargetHaveDefeatPoint = 144,
	NPFixedDamageValue = 145,
	IgnoreShiftSafeDamage = 146,
	ActAttackFunction = 147,
	DelayRemoveBuffExpiredOnPlayerTurn = 148,
	AllowRemoveBuff = 149,
	NotExecFunctionIfKeepAliveOnWarBoard = 150,
	SnapShotParamAddSelfIndv = 151,
	SnapShotParamAddOpIndv = 152,
	SnapShotParamAddFieldIndv = 153,
	SnapShotParamAddValue = 154,
	SnapShotParamAddMaxValue = 155,
	SnapShotParamAddMaxCount = 156,
	NotExecOnTransform = 157,
	NotRemoveOnTransform = 158,
	PriorityBgm = 159,
	BgmAllowSubPlaying = 160,
	BgPriority = 161,
	PriorityBg = 162,
	ResetBgmPriorityAtWaveStart = 163,
}

public enum DataVals.OverChargeState
{
	VALUE = 1,
	VALUE2 = 2,
	RATE = 4,
	CORRECTION = 8,
	TARGET = 16,
	COUNT = 32,
}

public enum DataVals.FieldCountTarget
{
	PARTY_SIDE = 0,
	OPPONENT_SIDE = 1,
	ALL = 2,
	TERM = 3,
}

public enum DropInfo.DropEffectType
{
	NORMAL = 0,
	JUMPING = 1,
	HIGH_POSITION = 2,
}

public enum FollowerInfo.ReturnSupportServantType
{
	MainQuest = 0,
	EventQuest = 1,
}

public enum AiFieldEntity.EffectType
{
	NONE = 0,
	ENEMY_MASTER = 1,
	ENEMY_MASTER_COMMAND_SPELL = 2,
}

public enum BannerAddEntity.DispType
{
	EVENT_BANNER = 1,
	EVENT_SHOP_BANNER = 2,
}

public enum BannerEntity.LinkType
{
	NONE = 0,
	WEBVIEW = 1,
	APPLI = 2,
	DIALOG = 3,
}

public enum BgmEntity.Flag
{
	IS_NOT_RELEASE = 1,
}

public enum BlankEarthSpotAddEntity.OverwriteType
{
	NONE = 0,
	ANIMATION = 1,
}

public enum BlankEarthSpotEntity.FlagKind
{
	NONE = 0,
	FORCE_TOUCH_DISABLED = 1,
}

public enum BlankEarthSpotEntity.Flag
{
	NONE = 1,
	FORCE_TOUCH_DISABLED = 2,
}

public enum BoardMessageEntity.ReferenceType
{
	MESSAGE_CLOSE = 1,
	QUEST_OPEN = 2,
	QUEST_CLOSE = 3,
	EVENT_CLOSE = 4,
	DAILY_DROP_UP = 5,
}

public enum BoxGachaEntity.Flag
{
	NONE = 1,
	LIMIT_RESET = 2,
}

public enum BuffConvertEntity.ConvertType
{
	NONE = 0,
	BUFF = 1,
	INDIVIDUALITY = 2,
}

public enum BuffConvertEntity.BuffLimitType
{
	ALL = 0,
	SELF = 1,
}

public enum BuffEntity.CheckIndvType
{
	OR_TYPE = 0,
	AND_TYPE = 1,
	BOTH_OR_TYPE = 2,
	BOTH_AND_TYPE = 3,
}

public enum BuffMaster.UnSubBuffWhenContinueStatus
{
	DEAD = 1,
	ALIVE = 2,
}

public enum ClassBoardSquareEntity.Flag
{
	START = 1,
	BLANK = 2,
}

public enum ClassBoardSkillType
{
	NONE = 0,
	PASSIVE = 1,
	COMMAND_SPELL = 2,
}

public enum ClassRelationOverwriteEntity.TYPE
{
	OVERWRITE_FORCE = 0,
	OVERWRITE_MORE_THAN_TARGET = 1,
	OVERWRITE_LESS_THAN_TARGET = 2,
}

public enum ClosedMessageEntity.Flag
{
	CHANGE_DISP_CLOSED_MESSAGE = 2,
	CHANGE_DISP_POSITION_LEFT = 4,
}

public enum CombineEntity.CombineType
{
	NORMAL = 1,
	ADD_TOTAL_EXP = 2,
	DEFAULT_MAX_LIMIT_COUNT = 3,
}

public enum CommonConsumeEntity.CommonConsumeType
{
	ITEM = 1,
	AP = 2,
}

public enum DialogMessageMaster.OpenType
{
	LOGIN = 1,
}

public enum EventAddEntity.OverwriteType
{
	BG_IMAGE = 1,
	BGM = 2,
	NAME = 3,
	BANNER = 4,
	NOTICE_BANNER = 5,
}

public enum EventBoardGameCellMaster.EventBoardGameCellType
{
	FORCE_STOP = 1,
	MOVE = 2,
	QUEST = 3,
}

public enum EventBoardGameTokenEntity.EventBoardGameTokenFlag
{
	FIRST_GAME = 1,
	SECOND_GAME = 2,
	THIRD_GAME = 4,
	FOURTH_GAME = 8,
	FIFTH_GAME = 16,
	SIXTH_GAME = 32,
}

public enum EventBonusFilterEntity.EventBonusFilterType
{
	SVT_EQUIP = 1,
	FILTER_GROUP = 2,
	SVT_EQUIP_EXP = 3,
	SVT_BONUS_SKILL = 4,
	SKILL_FILTER_GROUP = 5,
}

public enum EventBuddyPointEntity.EventBuddyPointFlag
{
	HIDE_BUDDY_POINT_RESULT = 1,
	NOT_BUDDY_POINT_BUFF = 2,
}

public enum EventCampaignMaster.FriendPointGetType
{
	NORMAL = 0,
	FUTURE = 1,
	INCLUDE_MATCH = 2,
}

public enum EventCombineEntity.CalcType
{
	ADDITION = 1,
	MULTIPLICATION = 2,
	FIXED_VALUE = 3,
}

public enum EventConquestRewardEntity.GiftType
{
	NONE = 1,
	ITEM = 2,
}

public enum EventDetailEntity.EventGaugeType
{
	NONE = 1,
	NORMAL_RAID = 2,
	LAST_WAR_RAID = 3,
	EVENT_GROUP_POINT = 4,
	RASHOMON_RAID = 5,
	EVENT_RACE = 6,
}

public enum EventDetailEntity.FlagKind
{
	TYPE_POINT = 0,
	TYPE_EXCHANGE_SHOP = 1,
	TYPE_BOX_GACHA = 2,
	TYPE_RANKING = 3,
	TYPE_BONUS_SKILL = 4,
	TYPE_MISSION = 5,
	TYPE_RAID = 6,
	TYPE_EVENT_SHOP = 7,
	MATERIAL_ADD_QUEST_GROUP = 8,
	MATERIAL_ADD_EVENT_END = 9,
	SUPER_BOSS = 10,
	RAID_DEFEAT_COUNT = 11,
	BP = 12,
	NO_MATERIAL_BANNER = 13,
	EVENT_POINT = 14,
	EVENT_GROUP_POINT = 15,
	EVENT_VOICE_PLAY = 16,
	DAILY_MISSION = 17,
	EVENT_GROUP_RANKING = 18,
	EVENT_TOWER = 19,
	EVENT_FATIGUE = 20,
	NO_DISP_ARROW = 21,
	FORCED_ADJUSTMENT_DIALOG = 22,
	SHIFT_HELP_INFO = 23,
	CLOSE_PURCHASE_SHOP = 24,
	TIME_STATUS_RECORD = 25,
	USE_EVENT_SUPPORT_DECK = 26,
	EVENT_DAIRY_POINT = 27,
	EVENT_ACTIVITY_POINT = 28,
	EVENT_ONLY_EQUIP = 29,
	MAP_SWITCH_BUTTON_TOP = 30,
	EVENT_REVIVAL = 31,
	EVENT_CONQUEST = 32,
	EVENT_POINT_BY_QP = 33,
	ALL_USERS_BOX_GACHA_COUNT = 34,
	NOT_DISPLAY_BONUS_ON_SUPPORT_SET = 35,
	FRIEND_POINT_BOOST_ITEM = 36,
	EVENT_BOARD_GAME = 37,
	NOT_DISPLAY_DA_VINCI = 38,
	IS_MAIN_INTERLUDE = 39,
	QUEST_COOLTIME = 41,
	EVENT_PANEL = 42,
	EVENT_ASSIST = 43,
	TREASURE_BOX = 44,
	HIDE_AFTER_PURCHASE = 45,
	ALLOUT_BATTLE = 46,
	SPOT_COOLTIME = 47,
}

public enum EventDetailEntity.Flag
{
	TYPE_POINT = 1,
	TYPE_EXCHANGE_SHOP = 2,
	TYPE_BOX_GACHA = 4,
	TYPE_RANKING = 8,
	TYPE_BONUS_SKILL = 16,
	TYPE_MISSION = 32,
	TYPE_RAID = 64,
	TYPE_EVENT_SHOP = 128,
	MATERIAL_ADD_QUEST_GROUP = 256,
	MATERIAL_ADD_EVENT_END = 512,
	SUPER_BOSS = 1024,
	RAID_DEFEAT_COUNT = 2048,
	BP = 4096,
	NO_MATERIAL_BANNER = 8192,
	EVENT_POINT = 16384,
	EVENT_GROUP_POINT = 32768,
	EVENT_VOICE_PLAY = 65536,
	DAILY_MISSION = 131072,
	EVENT_GROUP_RANKING = 262144,
	EVENT_TOWER = 524288,
	EVENT_FATIGUE = 1048576,
	NO_DISP_ARROW = 2097152,
	FORCED_ADJUSTMENT_DIALOG = 4194304,
	SHIFT_HELP_INFO = 8388608,
	CLOSE_PURCHASE_SHOP = 16777216,
	TIME_STATUS_RECORD = 33554432,
	USE_EVENT_SUPPORT_DECK = 67108864,
	EVENT_DAIRY_POINT = 134217728,
	EVENT_ACTIVITY_POINT = 268435456,
	EVENT_ONLY_EQUIP = 536870912,
	MAP_SWITCH_BUTTON_TOP = 1073741824,
	EVENT_REVIVAL = 2147483648,
	EVENT_CONQUEST = 4294967296,
	EVENT_POINT_BY_QP = 8589934592,
	ALL_USERS_BOX_GACHA_COUNT = 17179869184,
	NOT_DISPLAY_BONUS_ON_SUPPORT_SET = 34359738368,
	FRIEND_POINT_BOOST_ITEM = 68719476736,
	EVENT_BOARD_GAME = 137438953472,
	NOT_DISPLAY_DA_VINCI = 274877906944,
	IS_MAIN_INTERLUDE = 549755813888,
	QUEST_COOLTIME = 2199023255552,
	EVENT_PANEL = 4398046511104,
	EVENT_ASSIST = 8796093022208,
	TREASURE_BOX = 17592186044416,
	HIDE_AFTER_PURCHASE = 35184372088832,
	ALLOUT_BATTLE = 70368744177664,
	SPOT_COOLTIME = 140737488355328,
}

public enum EventEntity.EventOpenType
{
	ONCE = 1,
	REPEAT = 2,
}

public enum EventFilterEntity.FlagKind
{
	SUPPORT_NO_DISPLAY = 1,
	SELECT_SVT_NO_DISPLAY = 2,
	SELECT_EQUIP_NO_DISPLAY = 3,
	SUPPORT_SELECT_SVT_NO_DISPLAY = 4,
	SUPPORT_SELECT_EQUIP_NO_DISPLAY = 5,
}

public enum EventFilterEntity.FlagMask
{
	SUPPORT_NO_DISPLAY = 2,
	SELECT_SVT_NO_DISPLAY = 4,
	SELECT_EQUIP_NO_DISPLAY = 8,
	SUPPORT_SELECT_SVT_NO_DISPLAY = 16,
	SUPPORT_SELECT_EQUIP_NO_DISPLAY = 32,
}

public enum EventItemDisplayEntity.ScreenFlag
{
	TERMINAL_MAP_REWARD = 2,
	SHOP = 4,
	EVENT_SHOP = 8,
	TERMINAL = 16,
	EVENT_MAP = 32,
	EVENT_REWARD = 64,
}

public enum EventItemDisplayEntity.DisplayPoinstType
{
	ITEM = 1,
	EVENT_POINT = 2,
	RAID = 3,
	MISSION = 4,
}

public enum EventMissionCondDetailEntity.MissionCondType
{
	ENEMY_KILL_NUM = 1,
	ENEMY_INDIVIDUALITY_KILL_NUM = 2,
	ITEM_GET_TOTAL = 3,
	BATTLE_SVT_IN_DECK = 4,
	BATTLE_SVT_EQUIP_IN_DECK = 5,
	TARGET_QUEST_ENEMY_KILL_NUM = 6,
	TARGET_QUEST_ENEMY_INDIVIDUALITY_KILL_NUM = 7,
	TARGET_QUEST_ITEM_GET_TOTAL = 8,
	QUEST_CLEAR = 9,
	QUEST_CLEAR_NUM = 10,
	SVT_GET_NUM = 11,
	ALL_QUEST_ITEM_GET_TOTAL = 12,
	ALL_INDIVIDUALITY_IN_ENEMY_KILL_NUM = 13,
	TARGET_ENEMY_CLASS_KILL_NUM = 14,
	TARGET_SVT_ENEMY_CLASS_KILL_NUM = 15,
	TARGET_ENEMY_INDIVIDUALITY_CLASS_KILL_NUM = 16,
	BATTLE_SVT_INDIVIDUALITY_SPECIFIC_NUM = 17,
	BATTLE_SVT_CLASS_SPECIFIC_NUM = 18,
	ALL_QUEST_SVT_GET_TOTAL = 19,
	QUEST_GROUP_CLEAR_NUM = 20,
	GACHA_DRAW_NUM = 21,
	QUEST_CLEAR_WITH_SVT_IN_DEC = 22,
	QUEST_CLEAR_WITH_SVT_IN_DECK_NONE_FOLLOWER = 23,
	QUEST_PHASE_CLEAR_NUM = 24,
	EVENT_ITEM_USE_NUM = 25,
	EVENT_BOARD_GAME_CELL_NUM = 26,
	FRIEND_AND_FOLLOW_NUM = 27,
	QUEST_PHASE_CLEAR_NUM_QUEST_TYPE = 28,
	QUEST_PHASE_CLEAR_NUM_QUEST_GROUP = 29,
	QUEST_PHASE_CLEAR_NUM_WAR_ID = 30,
	QUEST_PHASE_CLEAR_NUM_WITH_WAR_BOARD = 31,
	QUEST_CLEAR_WITH_SVT_IN_DECK_ONLY_STARTING_MEMBER = 34,
	QUEST_CLEAR_WITH_SVT_IN_DECK_NONE_FOLLOWER_ONLY_STARTING_MEMBER = 35,
	BATTLE_EXCHANGE_SVT_IN_DECK = 37,
	USE_TREASURE_DEVICE_EXCHANGE_SVT = 38,
	PLAY_VOICE_EXCHANGE_SVT = 39,
	MAP_GIMMICK_COUNT = 40,
}

public enum EventMissionCondDetailEntity.MissionConditionLinkType
{
	EVENT_START = 1,
	MISSION_START = 2,
	MASTER_MISSION_START = 3,
	RANDOM_MISSION_START = 4,
}

public enum EventMissionConditionEntity.Flag
{
	NONE = 1,
	NO_DISPLAY_NOTIFY_BATTLE_OPEN = 2,
	NO_DISPLAY_NOTIFY_BATTLE_START = 4,
	NO_DISPLAY_NOTIFY_BATTLE_PROGRESS = 8,
	NO_DISPLAY_NOTIFY_BATTLE_CLEAR = 16,
	UNLOCK_COND_TEXT_COLOR_CHANGE = 64,
}

public enum EventMissionEntity.MissionFlag
{
	NONE = 1,
	CLOSED_HIDE_REWARD = 2,
	IGNORE_START_CONDITION = 8,
	IS_DIRECT_REWARD = 16,
	IS_DAILY = 32,
}

public enum EventPanelMapDetailEntity.EventPanelMapDetailFlag
{
	START_SCAN = 1,
	IGNORE_RANDOM_SPOT = 2,
}

public enum EventPanelSpotEntity.EventPanelSpotType
{
	NORMAL = 1,
	RANDOM = 2,
	CROSSLINE = 3,
}

public enum EventPointEntity.Flag
{
	NONE = 1,
	BOSS_BATTLE = 2,
}

public enum EventPointGroupAddEntity.OverwriteType
{
	ICON = 1,
}

public enum EventRewardSceneEntity.eventType
{
	EVENT_ITEM = 1,
	BOX_GACHA = 2,
	EVENT_POINT = 3,
	EVENT_MISSION = 4,
	DAMAGE_POINT = 5,
	RACE_RANKING = 6,
	EVENT_TOWER = 7,
	FATIGUE_RECOVERY = 8,
	EVENT_BOARD_GAME_TOKEN = 9,
	TREASURE_BOX = 10,
	RANDOM_MISSION = 11,
	DIGGING_MISSION = 12,
	EVENT_EXPEDITION = 13,
	EVENT_RECIPE = 14,
	EVENT_FORTIFICATION = 15,
	EVENT_HEEL_PORTRAIT = 16,
}

public enum EventRewardSceneEntity.RewardSceneFlag
{
	IS_NPC_GUIDE = 1,
	IS_CHANGE_SVT_BY_CHANGED_TAB = 2,
	IS_HIDE_TAB = 3,
}

public enum EventRewardSceneEntity.Flag
{
	NPC_GUIDE = 2,
	IS_CHANGE_SVT_BY_CHANGED_TAB = 4,
	IS_HIDE_TAB = 8,
}

public enum EventRewardSetEntity.RewardSetType
{
	BOX_GACHA = 1,
	EVENT_POINT = 2,
	EVENT_MISSION = 3,
}

public enum EventScriptEntity.PlayType
{
	RACE_WIN = 1,
	RACE_RESULT = 2,
	RACE_TOTAL_RESULT = 3,
}

public enum EventServantEntity.TYPE
{
	NONE = 0,
	JOIN = 1,
	COND_JOIN = 2,
	DIRECT_JOIN = 3,
}

public enum EventStatusEntity.EventTimeStatusKind
{
	IS_SCENARIO = 0,
	IS_NIGHT = 1,
	DAY_1 = 2,
	DAY_2 = 3,
	DAY_3 = 4,
	DAY_4 = 5,
	DAY_5 = 6,
	DAY_6 = 7,
	DAY_7 = 8,
}

public enum EventStatusEntity.EventTimeStatus
{
	IS_SCENARIO = 1,
	IS_NIGHT = 2,
	DAY_1 = 4,
	DAY_2 = 8,
	DAY_3 = 16,
	DAY_4 = 32,
	DAY_5 = 64,
	DAY_6 = 128,
	DAY_7 = 256,
}

public enum EventTowerEntity.Flag
{
	HIDDEN_CLEAR_TOWER = 1,
	STAMP = 2,
}

public enum EventTowerEntity.EventTowerFlag
{
	HIDDEN_CLEAR_TOWER = 0,
	STAMP = 1,
}

public enum EventTutorialMaster.OpenType
{
	ON_MAP = 1,
	ON_TERMINAL = 2,
	ON_SPOT = 3,
	ON_EVENT_SCENE = 4,
	BATTLE_START = 5,
	BATTLE_TURN = 6,
	BATTLE_RESULT = 7,
	BATTLE_RESULT_WIN = 8,
	BATTLE_RESULT_LOSE = 9,
	ON_EVENT_SHOP_HELP = 10,
	SVT_GET = 11,
	ON_EVENT_SCENE_HELP = 12,
	ON_QUEST_SELECT = 13,
	ON_EVENT_SHOP = 14,
	ON_SUPPORT_SELECT = 15,
	QUEST_START = 16,
	SHOP_BUY_AFTER = 17,
	ON_CALDEA_GATE = 18,
	ON_EVENT_POINT = 19,
	EVENT_TAB1 = 20,
	EVENT_TAB2 = 21,
	EVENT_TAB3 = 22,
	EVENT_TAB1_HELP = 23,
	EVENT_TAB2_HELP = 24,
	EVENT_TAB3_HELP = 25,
	BATTLE_GIMMICK = 26,
	BATTLE_WAVE = 27,
	EVENT_TAB1_EFFECT = 28,
	EVENT_TAB2_EFFECT = 29,
	EVENT_TAB3_EFFECT = 30,
	COSTUME = 31,
	OPEN_SORT_WINDOW = 32,
	ON_EVENT_FOLDER_HELP = 33,
	GACHA = 34,
	SVT_COMBINE = 35,
	SVT_LIMIT_UP = 36,
	SVT_SKILL_COMBINE = 37,
	SVT_EQUIP_COMBINE = 38,
	SVT_NP_COMBINE = 39,
	SVT_LVEXCEED = 40,
	OPEN_CHOICE_WINDOW = 41,
	OPEN_SMART_CHOICE_WINDOW = 42,
	EVENT_TAB4 = 43,
	EVENT_TAB4_HELP = 44,
	OPEN_QUEST_START = 45,
	BATTLE_BREAK_GAUGE_CHARACTER = 46,
	COMMAND_CODE = 47,
	SUPPORT_SETTING = 48,
	ON_FOLLOW = 49,
	USER_SEARCH_SUCCESS = 50,
	ON_FRIENDSHIP = 51,
	ON_EVENT_POINT_EFFECT_VIEW = 52,
	NO_COST_AT_DEFEAT = 53,
	ON_SVT_LIST_EQUIP_SELECT = 54,
	ON_SVT_STORAGE_EQUIP_SELECT = 55,
	ON_SVT_SELL_EQUIP_SELECT = 56,
	ON_SVT_EQUIP_COMBINE_BASE_SELECT = 57,
	ON_SVT_COMBINE_LIMIT_SPECIAL = 58,
	COMMAND_CARD_EXCEED = 59,
	ON_TERMINAL_WITH_SVT_COMBINE_LIMIT_SPECIAL = 60,
	MY_ROOM_SERVANTS_RECORDS_EPISODES_LIST = 61,
	WAR_BOARD_MAP = 62,
	WAR_BOARD_SETUP = 63,
	WAR_BOARD_START = 64,
	WAR_BOARD_MAP_SETUP = 65,
	LOGIN_BONUS_CLOSED = 66,
	OPEN_SPECIFIC_QUEST = 67,
	ON_PUSH_SVT_SELECT = 68,
	ON_NP_COMBINE_SVT_SELECT = 69,
	ON_APPEND_PASSIVE_SKILL_COMBINE = 70,
	ON_PARTY_CONFIRM = 71,
	BOX_GACHA_RESET = 72,
	ON_COIN_ROOM = 73,
	ON_MYROOM = 74,
	QUEST_CLEAR_REWARD = 75,
	GACHA_RESULT = 76,
	WAR_BOARD_HELP = 77,
	ON_PRESENT_BOX = 78,
	ON_EVENT_START = 79,
	ON_TERMINAL_AFTER_SHOP_FREE_DIALOG = 80,
	ON_CLASS_BOARD_TOP = 81,
	ON_CLASS_BOARD_CLASS_SELECT = 82,
	ON_BLANK_EARTH_TOP = 83,
	CALLED_BY_OTHER = 84,
	ON_TRANSFORM_SKILL_COMBINE = 85,
	ON_TRANSFORM_SVT_STATUS = 86,
	ON_TRANSFORM_COMMAND_CODE = 87,
	ON_TRANSFORM_COMMAND_CARD_EXCEED = 88,
	ON_TRANSFORM_TREASURE_DEVICE_COMBINE = 89,
	ON_MAP_WITHOUT_AFTER_ACTION = 90,
}

public enum EventUiEntity.ObjectType
{
	NONE = 1,
	IMAGE = 2,
	GAMEOBJECT = 3,
}

public enum EventUiEntity.DispAreaType
{
	MAP = 1,
	EVENT_REWARD = 2,
	CALDEA_GATE = 4,
	SPOT = 8,
}

public enum EventUiValueEntity.ValueType
{
	NONE = 0,
	ITEM = 1,
	EVENT_POINT = 2,
	EVENT_TOWER = 3,
	VALUE_LONG = 4,
	BATTLE_LINE = 5,
	ASSIST = 6,
}

public enum ExcludeMotionEntity.TargetSvtType
{
	ENEMY = 2,
	NPC = 4,
	PLAYER = 8,
}

public enum FieldMotionEntity.Flag
{
	NOT_START_BATTLE_SKIP = 1,
}

public enum FunctionCategoryEntity.GroupType
{
	NONE = 0,
	ATTACK = 1,
	DEFENCE = 2,
	STATUS_EFFECT = 3,
	OTHER = 4,
	ATTACK_DEBUFF = 5,
	DEFENCE_DEBUFF = 6,
	STATUS_EFFECT_DEBUFF = 7,
	STRENGTH_OTHER = 8,
}

public enum FunctionCategoryEntity.FuncCategoryFlag
{
	SVT_EQUIP_FILTER = 0,
	COMMAND_CODE_FILTER = 1,
	SVT_FILTER = 2,
}

public enum FunctionCategoryEntity.Flag
{
	SVT_EQUIP_FILTER = 1,
	COMMAND_CODE_FILTER = 2,
	SVT_FILTER = 4,
}

public enum GachaAppendMaster.STATE
{
	NONE = 0,
	END = 1,
	OK = 2,
}

public enum GachaEntity.FlagKind
{
	PC_MESSAGE = 1,
	BONUS_SELECT = 3,
}

public enum GachaEntity.Flag
{
	PC_MESSAGE = 2,
	BONUS_SELECT = 8,
}

public enum GachaExtraGiftEntity.GachaExtraGiftFlag
{
	NOT_APPEND_WHEN_TICKET = 0,
}

public enum GuideEntity.GuideType
{
	COMBINE = 1,
	SHOP = 2,
	SVT_COSTUME = 3,
}

public enum MapCondEntity.ChangeType
{
	BUTTON_DISPLAY = 1,
	CHANGE_MAP_IMAGE = 2,
	CHANGE_BGM = 3,
	HEADER_IMAGE = 4,
	ON_MAP_CAMERA_OFFSET_X = 5,
	ON_MAP_CAMERA_OFFSET_Y = 6,
}

public enum MapEntity.StartType
{
	NONE = 1,
	SCRIPT = 2,
	QUEST = 4,
}

public enum MapGimmickEntity.GimmickType
{
	NORMAL = 0,
	EVENT_MISSION = 1,
}

public enum MapGimmickPathEntity.MapGimmickPathType
{
	NONE = 0,
	EVENT_TIME_LIMIT_RAID = 1,
	QUEST_GROUP_CLEAR_STEP = 2,
}

public enum MstMissionMaster.CurrentType
{
	NOT_OPEN = 0,
	OPEN = 1,
	NONE_NEXT = 2,
}

public enum MyRoomAddEntity.OverwriteType
{
	BG_IMAGE = 1,
	BGM = 2,
	SERVANT_OVERLAY_OBJECT = 6,
	BG_IMAGE_MULTIPLE = 7,
	BACK_OBJECT = 8,
}

public enum NewsEntity.enType
{
	HTML_BODY = 1,
	HTML_URL = 2,
	TEMPLATE = 3,
	DATA_ANY = 4,
}

private enum NpcFollowerEntity.Flag
{
	RECOMMENDED_ICON = 1,
	IS_MY_SVT_OR_NPC = 2,
	FIXED_NPC = 4,
}

public enum NpcServantFollowerEntity.FlagKind
{
	HIDE_SUPPORT = 1,
	NOT_USED_TREASURE_DEVICE = 2,
	NO_DISPLAY_BONUS_ICON = 3,
	APPLY_SVT_CHANGE = 4,
	HIDE_EQUIP = 5,
	NO_DISPLAY_BONUS_ICON_EQUIP = 6,
	HIDE_TREASURE_DEVICE_LV = 8,
	HIDE_TREASURE_DEVICE_DETAIL = 9,
	HIDE_RARITY = 10,
	NOT_CLASS_BOARD = 11,
	NPC = 0,
}

public enum NpcServantFollowerEntity.FlagField
{
	HIDE_SUPPORT = 2,
	NOT_USED_TREASURE_DEVICE = 4,
	NO_DISPLAY_BONUS_ICON = 8,
	APPLY_SVT_CHANGE = 16,
	HIDE_EQUIP = 32,
	NO_DISPLAY_BONUS_ICON_EQUIP = 64,
	HIDE_TREASURE_DEVICE_LV = 256,
	HIDE_TREASURE_DEVICE_DETAIL = 512,
	HIDE_RARITY = 1024,
	NOT_CLASS_BOARD = 2048,
	NPC = 1,
}

public enum OpeningMovieEntity.Flag
{
	DISPLAY_SEEK_BAR = 1,
}

public enum OpeningMovieEntity.MaterialPosType
{
	NONE = 0,
	MAIN_RECORD_TOP = 1,
	STORY_BOTTOM = 2,
}

public enum OpeningMovieMaster.SortType
{
	ID = 0,
	PRIORITY = 1,
}

public enum OtherUserGameEntity.ReturnSupportServantType
{
	MainQuest = 0,
	EventQuest = 1,
}

public enum PartialMaintenanceEntity.PartialMaintenanceType
{
	STONE_GACHA = 1,
	CHALICE = 2,
	GOOGLE_BANK = 3,
	APPLE_BANK = 4,
	AU_BANK = 5,
	ANIPLEX_PLUS_ACCOUNT_LINKAGE = 6,
}

public enum QuestEntity.enType
{
	MAIN = 1,
	FREE = 2,
	FRIENDSHIP = 3,
	EVENT = 5,
	HEROBALLAD = 6,
	WAR_BOARD = 7,
}

public enum QuestEntity.TypeFlag
{
	NONE = 0,
	MAIN = 2,
	FREE = 4,
	FRIENDSHIP = 8,
	EVENT = 32,
	HEROBALLAD = 64,
	WAR_BOARD = 128,
	ALL = 238,
}

public enum QuestEntity.enForceOperation
{
	NONE = 0,
	FORCE_OPEN = 1,
	FORCE_CLOSE = 2,
}

public enum QuestEntity.enAfterClear
{
	CLOSE = 1,
	REPEAT_FIRST = 2,
	REPEAT_LAST = 3,
	RESET_INTERVAL = 4,
	CLOSE_DISP = 5,
}

public enum QuestEntity.Flag
{
	NONE = 1,
	NO_BATTLE = 2,
	RAID = 4,
	RAID_CONNECTION = 8,
	NO_CONTINUE = 16,
	NO_DISPLAY_REMAIN = 32,
	RAID_LAST_DAY = 64,
	CLOSED_HIDE_COST_ITEM = 128,
	CLOSED_HIDE_COST_NUM = 256,
	CLOSED_HIDE_PROGRESS = 512,
	CLOSED_HIDE_RECOMMEND_LV = 1024,
	CLOSED_HIDE_TREND_CLASS = 2048,
	CLOSED_HIDE_REWARD = 4096,
	NO_DISPLAY_CONSUME = 8192,
	SUPER_BOSS = 16384,
	NO_DISPLAY_MISSION_NOTIFY = 32768,
	HIDE_PROGRESS = 65536,
	DROP_FIRST_TIME_ONLY = 131072,
	CHAPTER_SUB_ID_JAPANESE_NUMERALS_CALLIGRAPHY = 262144,
	SUPPORT_ONLY_FORCE_BATTLE = 524288,
	EVENT_DECK_NO_SUPPORT = 1048576,
	FATIGUE_BATTLE = 2097152,
	SUPPORT_SELECT_AFTER_SCRIPT = 4194304,
	BRANCH = 8388608,
	USER_EVENT_DECK = 16777216,
	NO_DISPLAY_RAID_REMAIN = 33554432,
	QUEST_MAX_DAMAGE_RECORD = 67108864,
	ENABLE_FOLLOW_QUEST = 134217728,
	SUPPORT_SVT_MULTIPLE_SET = 268435456,
	SUPPORT_ONLY_BATTLE = 536870912,
	ACT_CONSUME_BATTLE_WIN = 1073741824,
	VOTE = 2147483648,
	HIDE_MASTER = 4294967296,
	DISABLE_MASTER_SKILL = 8589934592,
	DISABLE_COMMAND_SPEEL = 17179869184,
	SUPPORT_SVT_EDITABLE_POSITION = 34359738368,
	BRANCH_SCENARIO = 68719476736,
	QUEST_KNOCKDOWN_RECORD = 137438953472,
	NOT_RETRIEVABLE = 274877906944,
	DISPLAY_LOOPMARK = 549755813888,
	BOOST_ITEM_CONSUME_BATTLE_WIN = 1099511627776,
	PLAY_SCENARIO_WITH_MAPSCREEN = 2199023255552,
	BATTLE_RETREAT_QUEST_CLEAR = 4398046511104,
	BATTLE_RESULT_LOSE_QUEST_CLEAR = 8796093022208,
	BRANCH_HAVING = 35184372088832,
	NO_DISPLAY_NEXT_ICON = 70368744177664,
	WINDOW_ONLY = 140737488355328,
	CHANGE_MASTERS = 281474976710656,
	NOT_DISPLAY_RESULT_GET_POINT = 562949953421312,
	FORCE_TO_NO_DROP = 1125899906842624,
	DISPLAY_CONSUME_ICON = 2251799813685248,
	HARVEST = 4503599627370496,
	RECONSTRUCTION = 9007199254740992,
	ENEMY_IMMEDIATE_APPEAR = 18014398509481984,
	NO_SUPPORT_LIST = 36028797018963968,
	LIVE = 72057594037927936,
	FORCE_DISPLAY_ENEMY_INFO = 144115188075855872,
	ALLOUT_BATTLE = 288230376151711744,
	RECOLLECTION = 576460752303423488,
	NOT_SINGLE_SUPPORT_ONLY = 1152921504606846976,
	DISABLE_CHAPTER_SUB = 2305843009213693952,
}

public enum QuestEntity.ConsumeType
{
	NONE = 0,
	AP = 1,
	RP = 2,
	ITEM = 3,
	AP_AND_ITEM = 4,
}

public enum QuestMessageEntity.QuestMessageDisplayType
{
	NONE = 0,
	DIALOG = 1,
	WINDOW_BEFORE = 2,
	WINDOW_AFTER = 3,
	MOVIE_DIALOG = 4,
	MOVIE_DELETE_DIALOG = 5,
	SCRIPT_BEFORE = 6,
}

public enum QuestPhaseDetailAddEntity.OverwriteType
{
	AFTER_ACITON = 1,
	BEFORE_ACITON = 2,
}

public enum QuestPhaseEntity.SCREEN_EFFECT_TYPE
{
	NONE = 0,
	ALL_MONOCHROME = 1,
	BG_CHARA_MONOCHROME = 2,
	BG_MONOCHROME = 3,
}

public enum QuestPhaseMaster.MoviePlayType
{
	BeforeBattle = 1,
	AfterBattle = 2,
}

public enum QuestScriptBranchMaterialMaster.PlayType
{
	BEFORE = 0,
	AFTER = 1,
}

public enum QuestScriptEntity.FolderType
{
	NONE = 0,
	MATERIAL_FOLDER = 1,
	EVENT = 2,
	SVT = 3,
	NEW_FOLDER = 4,
}

public enum QuestScriptMaterialNextMaster.MaterialNextType
{
	NONE = 0,
	DIRECT = 1,
	BRANCH_GROUP = 2,
}

public enum RecoverEntity.RecoverTarget
{
	AP = 1,
	RP = 2,
}

public enum RestrictionBaseEntity.RestrictionBaseFlag
{
	NO_SUPPORT_LIST = 2,
	USER_EVENT_DECK = 4,
	NOT_STARTING_MEMBER = 8,
	UNIQUE_SVT = 16,
	NOT_SINGLE_SUPPORT_ONLY = 32,
}

public enum RestrictionSlotDetailEntity.RestrictionSlotDetailType
{
	INDIVIDUALITY = 1,
	FIXED_POSITION = 2,
}

public enum RestrictionSlotEntity.RestrictionSlotType
{
	MY_SVT = 1,
	SUPPORT_SVT = 2,
	NPC_SVT = 3,
}

public enum RestrictionWholeEntity.RestrictionWholeType
{
	NONE = 0,
	INDIVIDUALITY = 1,
	ALL_OUT_BATTLE_UNIQUE_SVT = 2,
	IMPOSSIBLE_POS = 3,
	INDIVIDUALITY_POS = 4,
	MY_SVT_INDIVIDUALITY_POS = 5,
	SUPPORT_SVT_INDIVIDUALITY_POS = 6,
	NPC_SVT_INDIVIDUALITY_POS = 7,
	INDIVIDUALITY_STARTING_MEMBER = 8,
	UNIQUE_SVT = 9,
	DATA_LOST_BATTLE_UNIQUE_SVT = 10,
}

public enum ServantAnimationOverwriteEntity.PhaseType
{
	NONE = 0,
	TACTICAL = 1,
	COMMAND = 2,
	BATTLE = 3,
	BATTLE_NOBLE_PHANTASM = 4,
}

public enum ServantAnimationOverwriteEntity.ApplyType
{
	NONE = 0,
	PLAYER = 1,
	ENEMY = 2,
	ALL = 3,
}

public enum ServantCardEntity.CommandCardAttackType
{
	ONE = 1,
	ALL = 2,
}

public enum ServantChangeEntity.FlagType
{
	NONE = 1,
	NONE_EFFECT = 2,
	NONE_MATERIAL_SPLIT = 4,
	TRUE_NAME_IS_KNOWN = 8,
	NONE_BATTLE_VOICE_SELECT = 16,
}

public enum ServantClassEntity.SupportGroupType
{
	ALL = 0,
	SABER = 1,
	ARCHER = 2,
	LANCER = 3,
	RIDER = 4,
	CASTER = 5,
	ASSASSIN = 6,
	BERSERKER = 7,
	EXTRA = 8,
	MIX = 9,
	NOT_SUPPORT = 999,
}

public enum ServantCollectionEntity.CollectionEffectType
{
	NONE = 0,
	DATA_LOST = 1,
	HIDE = 2,
	LINK_LOST = 3,
	LINK_BAD = 4,
}

private enum ServantCommentEntity.ProfileLabelType
{
	NONE = 0,
	DETAIL = 1,
	PROFILE = 2,
}

public enum ServantEntity.FlagKind
{
	ONLY_USE_FOR_NPC = 1,
	SVT_EQUIP_FRIEND_SHIP = 2,
	IGNORE_COMBINE_LIMIT_SPECIAL = 3,
	SVT_EQUIP_EXP = 4,
	SVT_EQUIP_CHOCOLATE = 5,
	FORCE_LOCK = 6,
	SVT_EQUIP_MANA_EXCHANGE = 7,
	SVT_EQUIP_CAMPAIGN = 8,
	SVT_EQUIP_EVENT = 9,
	SVT_EQUIP_EVENT_REWARD = 10,
}

public enum ServantEntity.FlagField
{
	ONLY_USE_FOR_NPC = 2,
	SVT_EQUIP_FRIEND_SHIP = 4,
	IGNORE_COMBINE_LIMIT_SPECIAL = 8,
	SVT_EQUIP_EXP = 16,
	SVT_EQUIP_CHOCOLATE = 32,
	SVT_EQUIP_MANA_EXCHANGE = 128,
	SVT_EQUIP_CAMPAIGN = 256,
	SVT_EQUIP_EVENT = 512,
	SVT_EQUIP_EVENT_REWARD = 1024,
}

public enum ServantExceedEntity.FRAMETYPE
{
	BLACK = 0,
	BRONZE = 1,
	SILVER = 2,
	GOLD = 3,
	FRAME_0801 = 4,
	FRAME_0802 = 5,
	FRAME_0803 = 6,
	FRAME_0804 = 7,
}

public enum ServantFlagEntity.SvtScriptFlagType
{
	SECRET_TREASURE_DEVICE_GET = 1,
}

public enum ServantOverwriteEntity.ServantOverwriteType
{
	TREASURE_DEVICE = 1,
}

public enum ServantScriptEntity.OffsetKind
{
	NORMAL = 0,
	MYROOM = 1,
	BATTLE = 2,
	EVENT_REWORD = 3,
	EVENT_SHOP = 4,
	MISSON = 5,
	TERMINAL = 6,
	BATTLE_BOND = 7,
}

public enum ServantTreasureDvcEntity.Flag
{
	NONE = 1,
	WITH_PLAYER_PROGRESS = 2,
	NONE_TREASURE_DEVICE_EFFECT = 4,
	SECRET_TREASURE_DEVICE = 8,
	NOT_DISPLAY_SKILL_ICON = 16,
	NOT_TREASURE_DEVICE_GRADE_UP = 32,
	ONLY_MY_SVT = 64,
}

public enum ServantVoicePatternEntity.VoicePatternType
{
	REMOVE = 0,
	ADD_COND = 1,
}

public enum SkillEntity.CutinCameraSide
{
	ENEMY_ALL = 0,
	PLAYER_ALL = 1,
	FIELD_ALL = 2,
}

public enum SkillLvMaster.AddInvokeSkillActorType
{
	FIELD = 1,
}

public enum SpotAddEntity.SpotOverwriteType
{
	NONE = 0,
	FLAG = 1,
	PATH_POINT_RATIO = 2,
	PATH_POINT_RATIO_LIMIT = 3,
	NAME_PANEL_OFFSET_X = 4,
	NAME_PANEL_OFFSET_Y = 5,
	NAME = 6,
}

public enum SpotEntity.enSpotCondType
{
	NONE = 1,
	QUEST_CLEAR = 2,
	NOT_QUEST_CLEAR = 3,
	INVALID = 4,
	MISSION_ACHIEVE = 5,
	QUEST_RELEASED = 6,
	NOT_QUEST_GROUP_CLEAR = 7,
	QUEST_GROUP_CLEAR = 8,
	ITEM_GET = 9,
	QUEST_CLEAR_RAW = 10,
	QUEST_GROUP_CLEAR_RAW = 11,
	EVENT_GROUP_POINT_RATIO_IN_TERM = 12,
	EVENT_RACE_SCRIPT_PLAYED = 13,
	QUEST_CLEAR_PHASE = 14,
	NOT_QUEST_CLEAR_PHASE = 15,
	NOT_MISSION_ACHIEVE = 16,
	QUEST_AVAILABLE = 17,
	EVENT_GROUP_POINT = 18,
	EVENT_GROUP_POINT_BELOW = 19,
	EVENT_TOTAL_POINT = 20,
	EVENT_TOTAL_POINT_BELOW = 21,
	EVENT_VALUE = 22,
	EVENT_VALUE_BELOW = 23,
	EVENT_FLAG = 24,
	EVENT_STATUS = 25,
	NOT_EVENT_STATUS = 26,
	MISSION_CLEAR = 27,
	NOT_MISSION_CLEAR = 28,
	MISSION_CLEAR_ONLY = 29,
	MULTIPLE_DATE = 30,
	COMMON_RELEASE = 31,
}

public enum SpotEntity.FlagKind
{
	NONE = 0,
	NOT_DISPLAY = 1,
	MOVE_SPOT = 2,
	HIDE_NAME = 3,
	INACTIVE_DISPLAY_NAME = 4,
	SORTED_BY_RELEASE_QUEST = 5,
	FOLDER_SPOT_HIDDEN = 6,
}

public enum SpotEntity.Flag
{
	NONE = 1,
	NOT_DISPLAY = 2,
	MOVE_SPOT = 4,
	HIDE_NAME = 8,
	INACTIVE_DISPLAY_NAME = 16,
	SORTED_BY_RELEASE_QUEST = 32,
	FOLDER_SPOT_HIDDEN = 64,
}

public enum SpotPathEntity.ValueType
{
	NONE = 0,
	EVENT_RACE = 1,
	EVENT_TIME_LIMIT_RAID = 2,
}

public enum StageEntity.FadeType
{
	SlideIn = 0,
	AlphaFadeIn = 1,
	FadeOff = 2,
}

public enum TblFriendEntity.Flag
{
	NONE = 1,
	FRIEND_ID_MES_HIDE = 2,
	USER_ID_MES_HIDE = 4,
	TO_FRIENDID_LOCK = 8,
	TO_USERID_LOCK = 16,
}

public enum TerminalOverwriteEntity.OverwriteType
{
	BGM = 1,
	TERMINAL_BG = 2,
	COMMON_BG_TYPE1 = 3,
	COMMON_BG_TYPE2 = 4,
	TERMINAL_SPRITE = 5,
	TERMINAL_EFFECT = 6,
	COMMON_EFFECT_TYPE1 = 7,
	COMMON_EFFECT_TYPE2 = 8,
}

public enum TreasureDvcEntity.EffectFlagKind
{
	ATTACK_ENEMY_ALL = 0,
	ATTACK_ENEMY_ONE = 1,
}

public enum TreasureDvcEntity.EffectFlag
{
	ATTACK_ENEMY_ALL = 1,
	ATTACK_ENEMY_ONE = 2,
}

public enum UserCommandCodeEntity.StatusKind
{
	LOCK = 0,
	CHOICE = 4,
}

public enum UserCommandCodeEntity.StatusFlag
{
	LOCK = 1,
	CHOICE = 16,
}

public enum UserEventRandomMissionEntity.Status
{
	NONE = 0,
	START = 1,
}

public enum UserFollowEntity.Flag
{
	NONE = 1,
	IS_LOCK = 2,
}

public enum UserGachaEntity.StatusKind
{
	PC_END = 1,
}

public enum UserGachaEntity.Status
{
	PC_END = 2,
}

public enum UserQuestEntity.StatusKind
{
	RESET = 1,
	RESET_REWARD = 2,
	PURCHASED_RARE_PRI = 3,
	CHALLENGED_NEWEST_PHASE = 4,
	BATTLE_RESULT_WIN = 5,
	BATTLE_RESULT_LOSE = 6,
	LATEST_RESULT_WIN = 7,
	LATEST_RESULT_LOSE = 8,
	NOT_GET_QUEST_CLEAR_GIFT = 9,
}

public enum UserQuestEntity.StatusFlag
{
	RESET = 2,
	RESET_REWARD = 4,
	PURCHASED_RARE_PRI = 8,
	CHALLENGED_NEWEST_PHASE = 16,
	BATTLE_RESULT_WIN = 32,
	BATTLE_RESULT_LOSE = 64,
	LATEST_RESULT_WIN = 128,
	LATEST_RESULT_LOSE = 256,
	NOT_GET_QUEST_CLEAR_GIFT = 512,
}

public enum UserQuestRecordEntity.QuestRecordType
{
	QUEST_MAX_DAMAGE = 1,
	QUEST_KNOCKDOWN = 2,
}

private enum UserServantCollectionEntity.SVT_COMMON_KIND
{
	ENABLE_TD_SPEED = 1,
	TD_SPEED = 2,
}

public enum UserServantCollectionEntity.SVT_COMMON_FLAG
{
	ENABLE_TD_SPEED = 2,
	TD_SPEED = 4,
}

public enum UserServantEntity.StatusKind
{
	LOCK = 0,
	EVENT_JOIN = 1,
	WITHDRAWAL = 2,
	APRIL_FOOL_CANCEL = 3,
	CHOICE = 4,
	NO_PERIOD = 5,
	COND_JOIN = 6,
	ADD_FRIENDSHIP_HEROINE = 7,
}

public enum UserServantEntity.StatusFlag
{
	LOCK = 1,
	EVENT_JOIN = 2,
	WITHDRAWAL = 4,
	APRIL_FOOL_CANCEL = 8,
	CHOICE = 16,
	NO_PERIOD = 32,
	COND_JOIN = 64,
	ADD_FRIENDSHIP_HEROINE = 128,
}

private enum UserServantEntity.RandomLimitCountKind
{
	IMAGE_LIMIT_COUNT = 0,
	DISP_LIMIT_COUNT = 1,
	COMMANDCARD_LIMIT_COUNT = 2,
	ICON_LIMIT_COUNT = 3,
	PORTRAIT_LIMIT_COUNT = 4,
}

public enum VoiceEntity.Flag
{
	MATERIAL_OPEN = 2,
}

public enum WarAddEntity.WarOverwriteType
{
	BGM = 1,
	PARENT_WAR = 2,
	BANNER = 3,
	BG_IMAGE = 4,
	SVT_IMAGE = 5,
	FLAG = 6,
	BASE_MAP_ID = 7,
	NAME = 8,
	LONG_NAME = 9,
	MATERIAL_PARENT_WAR = 10,
	COORDINATES = 11,
	EFFECT_CHANGE_BLACK_MARK = 12,
	QUEST_BOARD_SECTION_IMAGE = 13,
	WAR_FORCE_DISP = 14,
	WAR_FORCE_HIDE = 15,
	START_TYPE = 16,
	NOTICE_DIALOG_TEXT = 17,
	CLEAR_MARK = 18,
	EFFECT_CHANGE_WHITE_MARK = 19,
	COMMAND_SPELL_ICON = 20,
	MASTER_FACE_ICON = 21,
}

public enum WarBoardActionTrendConditionEntity.ConditionType
{
	NONE = 0,
	ATTACK_RANGE = 1,
	NOT_ATTACK_RANGE = 2,
	MOVE_BY_ATTACK_RANGE = 3,
	NOT_MOVE_BY_ATTACK_RANGE = 4,
	REPLACE = 5,
	NOT_REPLACE = 6,
	DEFENSE_AREA_ON_ENEMY = 7,
	NOT_DEFENSE_AREA_ENEMY = 8,
	MOVE_BY_DEFENSE_AREA_ON_ENEMY = 9,
	NOT_MOVE_BY_DEFENSE_AREA_ON_ENEMY = 10,
	DEFENSE_AREA_ON_MY_SERVANT = 11,
	NOT_DEFENSE_AREA_ON_MY_SERVANT = 12,
	MOVE_BY_DEFENSE_AREA_ON_MY_SERVANT = 13,
	NOT_MOVE_BY_DEFENSE_AREA_ON_MY_SERVANT = 14,
	BENEFIT_RANGE = 15,
	NOT_BENEFIT_RANGE = 16,
	MOVE_BY_BENEFIT_RANGE = 17,
	NOT_MOVE_BY_BENEFIT_RANGE = 18,
	EXIST_CLASS_ADVANTAGE_SERVANT = 19,
	NOT_EXIST_CLASS_ADVANTAGE_SERVANT = 20,
	EXIST_CLASS_DIS_ADVANTAGE_SERVANT = 21,
	NOT_EXIST_CLASS_DIS_ADVANTAGE_SERVANT = 22,
	EXIST_DESIGNATION_ITEM = 23,
	NOT_EXIST_DESIGNATION_ITEM = 24,
	MOVE_BY_MASTER_AND_ENEMY_RANGE_APPROACH = 25,
	MOVE_BY_MASTER_AND_ENEMY_RANGE_LEAVE = 26,
	MOVE_BY_MASTER_AND_ENEMY_RANGE_NO_CHANGE = 27,
	MOVE_BY_MY_SERVANT_AND_ENEMY_RANGE_APPROACH = 28,
	MOVE_BY_MY_SERVANT_AND_ENEMY_RANGE_LEAVE = 29,
	MOVE_BY_MY_SERVANT_AND_ENEMY_RANGE_NO_CHANGE = 30,
	MOVE_BY_MY_SERVANT_AND_MASTER_RANGE_APPROACH = 31,
	MOVE_BY_MY_SERVANT_AND_MASTER_RANGE_LEAVE = 32,
	MOVE_BY_MY_SERVANT_AND_MASTER_RANGE_NO_CHANGE = 33,
	MOVE_BY_SERVANT_AND_CLASS_ADVANTAGE_SERVANT_RANGE_APPROACH = 34,
	MOVE_BY_SERVANT_AND_CLASS_ADVANTAGE_SERVANT_RANGE_LEAVE = 35,
	MOVE_BY_SERVANT_AND_CLASS_ADVANTAGE_SERVANT_RANGE_NO_CHANGE = 36,
	MOVE_BY_SERVANT_AND_CLASS_DIS_ADVANTAGE_SERVANT_RANGE_APPROACH = 37,
	MOVE_BY_SERVANT_AND_CLASS_DIS_ADVANTAGE_SERVANT_RANGE_LEAVE = 38,
	MOVE_BY_SERVANT_AND_CLASS_DIS_ADVANTAGE_SERVANT_RANGE_NO_CHANGE = 39,
	MOVE_BY_SERVANT_AND_DESIGNATION_ITEM_RANGE_APPROACH = 40,
	MOVE_BY_SERVANT_AND_DESIGNATION_ITEM_RANGE_LEAVE = 41,
	MOVE_BY_SERVANT_AND_DESIGNATION_ITEM_RANGE_NO_CHANGE = 42,
	EXIST_ATTACK_ADVANTAGE_SERVANT = 43,
	NOT_EXIST_ATTACK_ADVANTAGE_SERVANT = 44,
	EXIST_ATTACK_DIS_ADVANTAGE_SERVANT = 45,
	NOT_EXIST_ATTACK_DIS_ADVANTAGE_SERVANT = 46,
	EXIST_DEFENSE_ADVANTAGE_SERVANT = 47,
	NOT_EXIST_DEFENSE_ADVANTAGE_SERVANT = 48,
	EXIST_DEFENSE_DIS_ADVANTAGE_SERVANT = 49,
	NOT_EXIST_DEFENSE_DIS_ADVANTAGE_SERVANT = 50,
	MOVE_BY_SERVANT_AND_ATTACK_ADVANTAGE_SERVANT_RANGE_APPROACH = 51,
	MOVE_BY_SERVANT_AND_ATTACK_ADVANTAGE_SERVANT_RANGE_LEAVE = 52,
	MOVE_BY_SERVANT_AND_ATTACK_ADVANTAGE_SERVANT_RANGE_NO_CHANGE = 53,
	MOVE_BY_SERVANT_AND_ATTACK_DIS_ADVANTAGE_SERVANT_RANGE_APPROACH = 54,
	MOVE_BY_SERVANT_AND_ATTACK_DIS_ADVANTAGE_SERVANT_RANGE_LEAVE = 55,
	MOVE_BY_SERVANT_AND_ATTACK_DIS_ADVANTAGE_SERVANT_RANGE_NO_CHANGE = 56,
	MOVE_BY_SERVANT_AND_DEFENSE_ADVANTAGE_SERVANT_RANGE_APPROACH = 57,
	MOVE_BY_SERVANT_AND_DEFENSE_ADVANTAGE_SERVANT_RANGE_LEAVE = 58,
	MOVE_BY_SERVANT_AND_DEFENSE_ADVANTAGE_SERVANT_RANGE_NO_CHANGE = 59,
	MOVE_BY_SERVANT_AND_DEFENSE_DIS_ADVANTAGE_SERVANT_RANGE_APPROACH = 60,
	MOVE_BY_SERVANT_AND_DEFENSE_DIS_ADVANTAGE_SERVANT_RANGE_LEAVE = 61,
	MOVE_BY_SERVANT_AND_DEFENSE_DIS_ADVANTAGE_SERVANT_RANGE_NO_CHANGE = 62,
	MOVE_BY_ATTACK_RQANGE_ENEMY_MASTER = 63,
	NOT_MOVE_BY_ATTACK_RQANGE_ENEMY_MASTER = 64,
	MOVE_BY_ENEMY_MASTER_RANGE_APPROACH = 65,
	MOVE_BY_ENEMY_MASTER_RANGE_LEAVE = 66,
	MOVE_BY_ENEMY_MASTER_RANGE_NO_CHANGE = 67,
	ATTACK_MASTER = 68,
	NOT_ATTACK_MASTER = 69,
	ACTION_TYPE = 70,
	ACTION_COUNT_ON_THIS_TURN = 71,
	ACTION_COUNT_ON_THIS_TURN_OVER = 72,
	ACTION_COUNT_ON_THIS_TURN_UNDER = 73,
	EXIST_TARGET = 74,
	NOT_EXIST_TARGET = 75,
	IS_TARGET_ENEMY = 76,
	IS_NOT_TARGET_ENEMY = 77,
	AROUND_TARGET = 78,
	NOR_AROUND_TARGET = 79,
	MOVE_BY_TARGET_RANGE_APPROACH = 80,
	MOVE_BY_TARGET_RANGE_LEAVE = 81,
	MOVE_BY_TARGET_RANGE_NO_CHANGE = 82,
	DETOUR_TARGET_ROUTE = 83,
	NOT_DETOUR_TARGET_ROUTE = 84,
	MOVE_BY_USE_DRTOUR_TARGET_RANGE_APPROACH = 85,
	MOVE_BY_USE_DRTOUR_TARGET_RANGE_LEAVE = 86,
	MOVE_BY_USE_DRTOUR_TARGET_RANGE_NO_CHANGE = 87,
	ALLY_BLOCK_SHORTEST_ROUTE_ENEMY_AND_MASTER = 88,
	NOT_ALLY_BLOCK_SHORTEST_ROUTE_ENEMY_AND_MASTER = 89,
	MOBE_BY_ALLY_BLOCK_SHORTEST_ROUTE_ENEMY_AND_MASTER = 90,
	MOBE_BY_NOT_ALLY_BLOCK_SHORTEST_ROUTE_ENEMY_AND_MASTER = 91,
	ON_SHORTEST_ROUTE_ENEMY_AND_MASTER = 92,
	NOT_ON_SHORTEST_ROUTE_ENEMY_AND_MASTER = 93,
	MOVE_BY_ON_SHORTEST_ROUTE_ENEMY_AND_MASTER = 94,
	MOVE_BY_NOT_ON_SHORTEST_ROUTE_ENEMY_AND_MASTER = 95,
	ENEMY_IN_SHORTEST_ROUTE_TARGET = 96,
	NOT_ENEMY_IN_SHORTEST_ROUTE_TARGET = 97,
	EXIST_ENEMY_IN_RANGE_UNDER = 98,
	NOT_EXIST_ENEMY_IN_RANGE_UNDER = 99,
	ATTACK_COUNT_ON_THIS_TURN = 100,
	ATTACK_COUNT_ON_THIS_TURN_OVER = 101,
	ATTACK_COUNT_ON_THIS_TURN_UNDER = 102,
	AROUND_ALLY_MASTER = 103,
	NOT_AROUND_ALLY_MASTER = 104,
	AROUND_ALLY_SERVANT = 105,
	NOT_AROUND_ALLY_SERVANT = 106,
	MOVE_BY_MASTER_ENEMY_SHORTEST_ROUTE_WITHIN_ALLY_SERVANT = 107,
	NOT_MOVE_BY_MASTER_ENEMY_SHORTEST_ROUTE_WITHIN_ALLY_SERVANT = 108,
	DEFENSE_AREA_WITHIN_ENEMY_ALL_BLOCK = 109,
	NOT_DEFENSE_AREA_WITHIN_ENEMY_ALL_BLOCK = 110,
	IS_TARGET_ALLY = 111,
	IS_NOT_TARGET_ALLY = 112,
	MOVE_BY_ON_DETOUR_ROUTE = 113,
	MOVE_BY_NOT_ON_DETOUR_ROUTE = 114,
	ACTION_TYPE_ADVANCE = 115,
	ACTION_TYPE_MIDDLE = 116,
	ACTION_TYPE_REAR = 117,
	IS_ALL_DEFENSE_AREA_ENEMY_ROUTE_BLOCK = 118,
	IS_NOT_ALL_DEFENSE_AREA_ENEMY_ROUTE_BLOCK = 119,
	IS_COME_BACK_SQUARE = 120,
	IS_NOT_COME_BACK_SQUARE = 121,
	MOVE_BY_USE_DRTOUR_TARGET_RANGE_APPROACH_DRTOUR = 122,
	MOVE_BY_USE_DRTOUR_TARGET_RANGE_LEAVE_DRTOUR = 123,
	MOVE_BY_USE_DRTOUR_TARGET_RANGE_NO_CHANGE_DRTOUR = 124,
	IS_MOVE_BY_ALL_DEFENSE_AREA_ENEMY_ROUTE_BLOCK = 125,
	IS_NOT_MOVE_BY_ALL_DEFENSE_AREA_ENEMY_ROUTE_BLOCK = 126,
	TARGET_INDIVIDUALITY = 127,
	NOT_TARGET_INDIVIDUALITY = 128,
	EXIST_TARGET_IN_RANGE_UNDER = 129,
	NOT_EXIST_TARGET_IN_RANGE_UNDER = 130,
	ELAPSED_TURNS_SINCE_PLACEMENT = 131,
	ELAPSED_TURNS_SINCE_PLACEMENT_OVER = 132,
	ELAPSED_TURNS_SINCE_PLACEMENT_UNDER = 133,
	STAY = 134,
	NOT_STAY = 135,
	WITHIN_WARNING_AREA = 136,
	OUT_OF_WARNING_AREA = 137,
	REPLACE_TARGET = 138,
	NOT_REPLACE_TARGET = 139,
	MOVE_BY_OUT_OF_WARNING_AREA_RANGE_APPROACH = 140,
	MOVE_BY_OUT_OF_WARNING_AREA_RANGE_LEAVE = 141,
	MOVE_BY_OUT_OF_WARNING_AREA_RANGE_NO_CHANGE = 142,
	MOVE_BY_WITHIN_WARNING_AREA = 143,
	MOVE_BY_OUT_OF_WARNING_AREA = 144,
}

public enum WarBoardActionTrendEntity.ActionType
{
	ATTACK = 1,
	MASTER_DEFENSE = 2,
}

public enum WarBoardDataEntity.ProgressType
{
	NORMAL = 1,
	BATTLE = 2,
	PREPARE = 3,
}

public enum WarBoardMessageMaster.WarBoardMessageSceneType
{
	NONE = 0,
	WAR_BOARD_START_BEFORE = 1,
	WAR_BOARD_START_AFTER = 2,
	WAR_BOARD_WIN_BEFORE = 3,
	WAR_BOARD_WIN_AFTER = 4,
	GET_TREASURE_BOX_BEFORE = 5,
	GET_TREASURE_BOX_AFTER = 6,
	DEFEAT_HALF_ENEMY_BEFORE = 7,
	DEFEAT_HALF_ENEMY_AFTER = 8,
	ATTACK_ENEMY_MASTER_BEFORE = 9,
	ATTACK_ENEMY_MASTER_AFTER = 10,
	ATTACKED_MY_MASTER_BEFORE = 11,
	ATTACKED_MY_MASTER_AFTER = 12,
	WAR_BOARD_LOSE_BEFORE = 13,
	WAR_BOARD_LOSE_AFTER = 14,
}

public enum WarBoardMessageMaster.WarBoardMessageCondType
{
	NONE = 0,
	MY_MASTER_HP_EQUAL = 1,
	MY_MASTER_HP_BELOW = 2,
	MY_MASTER_HP_ABOVE = 3,
	ENEMY_MASTER_HP_EQUAL = 4,
	ENEMY_MASTER_HP_BELOW = 5,
	ENEMY_MASTER_HP_ABOVE = 6,
}

public enum WarBoardOnboardSkillEntity.SkillTiming
{
	BATTLE_START = 0,
	PLAYER_TURN = 1,
	ENEMY_TURN = 2,
	EVENT_ACTIVE = 3,
}

public enum WarBoardOnboardSkillEntity.SkillEffect
{
	NONE = 0,
	BUFF = 1,
	DEBUFF = 2,
}

public enum WarBoardPartySkillEntity.TargetType
{
	Both = 0,
	Player = 1,
	Enemy = 2,
}

public enum WarBoardRatingBaseEntity.Type
{
	ALLY_SERVANT_SHORTEST_DISTANCE = 0,
	ENEMY_SERVANT_SHORTEST_DISTANCE = 1,
	ALLY_MASTER_SHORTEST_DISTANCE = 2,
	ENEMY_MASTER_SHORTEST_DISTANCE = 3,
	ITEM_SHORTEST_DISTANCE = 4,
	PRIORITY_SPACE_SHORTEST_DISTANCE = 5,
}

public enum WarBoardRatingBaseEntity.Viewpoint
{
	WARSITUATION = 0,
	BENEFIT = 1,
}

public enum WarBoardRatingOffsetEntity.Type
{
	BASE_POINT = 0,
	ATTACK_MULTIPLE_ENEMY_WITH_BATTLE = 1,
	ATTACK_MULTIPLE_ALLY_WITH_BATTLE = 2,
	REPLACE = 3,
	NO_REPLACE = 4,
	ATTACK_TARGET_SERVANT_BREAK_POINT_UNDER_OVER = 5,
	ATTACK_TARGET_SERVANT_BREAK_POINT_LESSTHAN_OVER = 6,
	ATTACK_TARGET_MASTER = 7,
	NO_ATTACK_TARGET_MASTER = 8,
	ATTACK_TARGET_SERVANT_ATTACK_DEFENSE_ADVANTAGE = 9,
	ATTACK_TARGET_SERVANT_NOT_ATTACK_DEFENSE_ADVANTAGE_ATTACK_ADVANTAGE = 10,
	ATTACK_TARGET_SERVANT_NOT_ATTACK_DEFENSE_ADVANTAGE_NOT_ATTACK_ADVANTAGE_DEFENSE_DISADVANTAGE = 11,
	ATTACK_TARGET_SERVANT_ADVANTAGE_OTHER = 12,
	ACTION_PIECE_BREAK_POINT_UNDER_OVER = 13,
	ACTION_PIECE_BREAK_POINT_LESSTHAN_OVER = 14,
	ACTION_PIECE_NP_OVER = 15,
	NO_ACTION_PIECE_NP_OVER = 16,
	MOVE_AROUND_ENEMY_SERVANT_NONE = 17,
	MOVE_AROUND_ENEMY_SERVANT_EXIST = 18,
	MOVE_AROUND_ENEMY_SERVANT_OVER = 19,
	MOVE_AROUND_ALLY_SERVANT_NONE = 20,
	MOVE_AROUND_ALLY_SERVANT_EXIST = 21,
	MOVE_AROUND_ALLY_SERVANT_OVER = 22,
	MOVE_AROUND_ALLY_SERVANT_RANGE = 23,
	MOVE_AROUND_ALLY_SERVANT_RANGE_OVER = 24,
	MOVE_GET_DESIGNATION_ITEM = 25,
	NO_MOVE_GET_DESIGNATION_ITEM = 26,
	MOVE_AROUND_ALLY_SERVANT_RANGE_UNDER = 27,
	MOVE_AROUND_ALLY_SERVANT_RANGE_OVER_UNDER = 28,
	REPLACE_BETWEEN_SERVANT = 29,
	NO_REPLACE_BETWEEN_SERVANT = 30,
	MOVE_AROUND_ITEM = 31,
	MOVE_ON_ITEM = 32,
	MOVE_ON_EFFECT = 33,
}

public enum WarBoardRatingOffsetEntity.Category
{
	ATTACK = 0,
	MOVE = 1,
}

private enum WarBoardReinforcementsEntity.Flag
{
	NOT_INCLUDE_WIN = 1,
}

public enum WarBoardStageLayoutEntity.Type
{
	NORMAL = 1,
	ITEM = 2,
	EFFECT = 3,
	TREASURE = 4,
	WALL = 5,
}

public enum WarBoardStageLayoutEntity.ActionType
{
	ADVANCE = 1,
	MIDDLE = 2,
	REAR = 3,
}

private enum WarBoardStagePieceDetailEntity.Flag
{
	NOT_INCLUDE_WIN = 1,
}

public enum WarBoardStagePieceDetailEntity.MoveAfterActionType
{
	MOVE = 0,
	STAY = 1,
}

public enum WarBoardStagePieceDetailEntity.MovedAfterDefendType
{
	MOVE = 0,
	STAY = 1,
}

public enum WarBoardStageReinforcementsEntity.RepeatType
{
	ONCE = 0,
	REPEAT = 1,
}

public enum WarBoardTacticalTrendEntity.Type
{
	EVAL_VALUE = 0,
	ATTACK = 1,
	WARSITUATION = 2,
	BENEFIT = 3,
	MASTER_ATTACK = 4,
	MASTER_DEFENSE = 5,
}

public enum WarEntity.Flag
{
	WITH_MAP = 2,
	SHOW_ON_MATERIAL = 4,
	FOLDER_SORT_PRIOR = 8,
	STORY_SHORTCUT = 16,
	IS_EVENT = 32,
	CLOSE_AFTER_CLEAR = 64,
	MAIN_SCENARIO = 128,
	IS_WAR_ICON_LEFT = 256,
	CLEARED_RETURN_TO_TITLE = 512,
	NO_CLEAR_MARK_WITH_CLEAR = 1024,
	NO_CLEAR_MARK_WITH_COMPLETE = 2048,
	NOT_ENTRY_BANNER_ACTIVE = 4096,
	SHOP = 8192,
	BLACK_MARK_WITH_CLEAR = 16384,
	DISP_FIRST_QUEST = 32768,
	EFFECT_DISAPPEAR_BANNER = 65536,
	WHITE_MARK_WITH_CLEAR = 131072,
	WHITE_MARK_UNDER_BOARD = 262144,
	SUB_FOLDER = 524288,
	DISP_EARTH_POINT_WITHOUT_MAP = 1048576,
	IS_WAR_ICON_FREE = 2097152,
	IS_WAR_ICON_CENTER = 4194304,
	NOTICE_BOARD = 8388608,
	CHANGE_DISP_CLOSED_MESSAGE = 16777216,
	CHAPTER_SUB_ID_JAPANESE_NUMERALS_NORMAL = 33554432,
}

public enum WarEntity.StartType
{
	NONE = 0,
	SCRIPT = 1,
	QUEST = 2,
}

public enum QuestFocusStateManager.StateType
{
	READY = 0,
	COMPLETE = 1,
}

public enum QuestRestrictionInfo.SlotInfo.SlotType
{
	MY_SVT = 0,
	NPC = 1,
	SUPPORT = 2,
	MY_SVT_OR_NPC = 3,
	MY_SVT_OR_SUPPORT = 4,
	NOT_SET = 5,
}

private enum ServantLeaderInfo.RandomLimitCountKind
{
	IMAGE_LIMIT_COUNT = 0,
	DISP_LIMIT_COUNT = 1,
	COMMANDCARD_LIMIT_COUNT = 2,
	ICON_LIMIT_COUNT = 3,
	PORTRAIT_LIMIT_COUNT = 4,
}

private enum SkillDetailParamFormatResolver.SuffixType
{
	None = 0,
	Percent = 1,
}

public enum UserMissionProgressInfo.ProgStatus
{
	LOCK = 0,
	NOSTART = 1,
	PROGRESS = 2,
	CLEAR = 3,
	ACHIVE = 4,
	END = 5,
}

public enum DebugMenuComponent.TYPE
{
	SELECT = 0,
	TGR = 1,
	PARAM = 2,
	PARAM_TGR = 3,
	PARAM_STR = 4,
	PARAM_CHANGE = 5,
}

public enum DebugPanelRootComponent.TAG
{
	SVT = 0,
	AI = 1,
}

protected enum CommonEffectComponent.Status
{
	INIT = 0,
	PAUSE = 1,
	DESTORY = 2,
	START = 3,
	LOOP = 4,
	TOUCH = 5,
	END = 6,
}

public enum CommonEffectManager.FlipKind
{
	NORMAL = 0,
	HORIZONTAL = 1,
	VERTICAL = 2,
	FULL = 3,
}

public enum RaceResultEffectParam.ParamIndex
{
	EVENT_ID = 0,
	TERM_ID = 1,
	GROUP_ID = 2,
	RANK = 3,
	TIME = 4,
}

public enum UICamera.ControlScheme
{
	Mouse = 0,
	Touch = 1,
	Controller = 2,
}

public enum UICamera.ClickNotification
{
	None = 0,
	Always = 1,
	BasedOnDelta = 2,
}

public enum UICamera.EventType
{
	World_3D = 0,
	UI_3D = 1,
	World_2D = 2,
	UI_2D = 3,
}

public enum ListViewItemSeed.Arrangement
{
	Horizontal = 0,
	Vertical = 1,
}

public enum ListViewSort.ListKind
{
	SERVANT = 0,
	SERVANT_EQUIP = 1,
	SERVANT_COSTUME = 2,
	COMMAND_CODE = 3,
	PRESENT_BOX = 4,
	SERVANT_COIN = 5,
}

public enum ListViewSort.SortKind
{
	PARTY = 0,
	CREATE = 1,
	RARITY = 2,
	LEVEL = 3,
	NP_LEVEL = 4,
	HP = 5,
	ATK = 6,
	COST = 7,
	CLASS = 8,
	LIMIT_COUNT = 9,
	FRIENDSHIP = 10,
	LOGIN_ACCESS = 11,
	USER_LEVEL = 12,
	ID = 13,
	AMOUNT = 14,
	HP_ADJUST = 15,
	ATK_ADJUST = 16,
	REGIST_DATE = 17,
	REQUEST_DATE = 18,
	COSUME = 19,
	HAVING_COSTUME = 20,
	NOT_HAVING_COSTUME = 21,
	NOT_HAVING_RELEASE_ITEM = 22,
	LIMIT_COUNT_2 = 23,
	EVENT_ORDER = 24,
	RECOVERY_FATIGUE = 25,
	SERVANT_NAME = 26,
	DISP_NO = 27,
	BUDDY_POINT = 28,
}

public enum ListViewSort.FilterClassKind
{
	CLASS_SABER = 1,
	CLASS_SABER_2 = 13,
	CLASS_ARCHER = 2,
	CLASS_ARCHER_2 = 14,
	CLASS_LANCER = 3,
	CLASS_LANCER_2 = 15,
	CLASS_RIDER = 4,
	CLASS_RIDER_2 = 16,
	CLASS_CASTER = 5,
	CLASS_CASTER_2 = 17,
	CLASS_ASSASSIN = 6,
	CLASS_ASSASSIN_2 = 18,
	CLASS_BERSERKER = 7,
	CLASS_BERSERKER_2 = 19,
	CLASS_SHIELDER = 8,
	CLASS_RULER = 9,
	CLASS_AVENGER = 10,
	CLASS_MOONCANCER = 11,
	CLASS_ALTEREGO = 23,
	CLASS_FOREIGNER = 25,
	CLASS_PRETENDER = 28,
	CLASS_BEAST = 33,
}

public enum ListViewSort.FilterKind
{
	CLASS_1_13 = 0,
	CLASS_2_14 = 1,
	CLASS_3_15 = 2,
	CLASS_4_16 = 3,
	CLASS_5_17 = 4,
	CLASS_6_18 = 5,
	CLASS_7_19 = 6,
	CLASS_ETC = 7,
	CLASS_EXP_UP = 8,
	CLASS_STATUS_UP = 9,
	COLLECTION_NOT_GET = 10,
	COLLECTION_FIND = 11,
	COLLECTION_GET = 12,
	MISSION_CLEAR = 13,
	MISSION_PROGRESS = 14,
	MISSION_NOSTART = 15,
	MISSION_COMPLETE = 16,
	MISSION_END = 17,
	BONUS_SERVANT = 18,
	BONUS_EQUIP = 19,
	BONUS_NONE = 20,
	LV_NOTMAX = 21,
	FIRST_HP = 22,
	SECOND_HP = 23,
	HPMAX = 24,
	FIRST_ATK = 25,
	SECOND_ATK = 26,
	ATKMAX = 27,
	SAME_CLASS = 28,
	CAN_SELECT = 29,
	EXIST_NOT_OPEN_COSTUME = 30,
	NOT_HAVE_RELEASE_ITEM = 31,
	COSTUME_NOT_OPEN = 32,
	COSTUME_OPEN = 33,
	RARITY_COMMON = 34,
	RARITY_UNCOMMON = 35,
	RARITY_RARE = 36,
	RARITY_SRARE = 37,
	RARITY_SSRARE = 38,
	CHOICE_SELECT = 39,
	BONUS_EQUIP_ALL = 40,
	BONUS_INDIVIDUAL = 41,
	NP_BUSTER = 42,
	NP_ARTS = 43,
	NP_QUICK = 44,
	NP_ATTACK_ENEMY_ONE = 45,
	NP_ATTACK_ENEMY_ALL = 46,
	NP_SUPPORT = 47,
	CLASS_SERVANT = 48,
	COLLECTION_ENCOUNT = 49,
	SERVANT_EFFECT_TREASURE_DEVICE = 50,
	SERVANT_EFFECT_SKILL = 51,
	ITEM_HAVE = 52,
	ITEM_NOT_HAVE = 53,
	SERVANT_EQUIP_TYPE_NORMAL = 54,
	SERVANT_EQUIP_TYPE_FRIENDSHIP = 55,
	SERVANT_EQUIP_TYPE_CHOCOLATE = 56,
	CLASS_8 = 57,
	CLASS_9 = 58,
	CLASS_11 = 59,
	CLASS_23 = 60,
	CLASS_10 = 61,
	CLASS_25 = 62,
	CLASS_28 = 63,
	CLASS_33 = 64,
	CLASS_GROUP_THREE_KNIGHT = 65,
	CLASS_GROUP_FOUR_CAVALRY = 66,
	CLASS_GROUP_EXTRA1 = 67,
	CLASS_GROUP_EXTRA2 = 68,
	NOT_LIMITED = 69,
	PERIOD_LIMITED = 70,
	STORY_LIMITED = 71,
	SERVANT_EQUIP_TYPE_MANA_PRI = 72,
	SERVANT_EQUIP_TYPE_CAMPAIGN = 73,
	SERVANT_EQUIP_TYPE_EVENT_LIMITED = 74,
	SERVANT_EQUIP_TYPE_EVENT_REWARD = 75,
	SERVANT_EQUIP_TYPE_EQUIP_EXP = 76,
	SERVANT_EQUIP_STATUS_LIMIT_MAX = 77,
	SERVANT_EQUIP_STATUS_CAN_LIMIT_MAX = 78,
	SERVANT_EQUIP_STATUS_CAN_LIMIT = 79,
	SERVANT_EQUIP_STATUS_NOT_LIMIT = 80,
	SERVANT_EQUIP_STATUS_COMBINE = 81,
	SERVANT_EQUIP_STATUS_CAN_COMBINE = 82,
	SERVANT_EQUIP_STATUS_NOT_COMBINE = 83,
	SERVANT_EQUIP_HAVE_STATUS_NOT = 84,
	SERVANT_EQUIP_HAVE_STATUS_1 = 85,
	SERVANT_EQUIP_HAVE_STATUS_3 = 86,
	SERVANT_EQUIP_HAVE_STATUS_5 = 87,
	SUM = 88,
}

public enum ListViewSort.FilterCategoryKind
{
	CLASS = 0,
	NP_TYPE = 1,
	NP_EFFECT = 2,
	SERVANT_TYPE = 3,
	RARITY = 4,
	COSTUME = 5,
	COMBINE_COSTUME = 6,
	OTHER = 7,
	SERVANT_COMBINE_BASE = 8,
	EXPLANATION = 9,
	EXPLANATION_PRESENT_BOX = 10,
	SERVANT_EVENT_BONUS = 11,
	EQUIP_TYPE = 12,
	CLASS_GROUP = 13,
	CLASS_EXTRA1 = 14,
	CLASS_EXTRA2 = 15,
	COLLECTION_STATUS = 16,
	HAVE_STATUS = 17,
	SUMMON_CATEGORY = 18,
	EQUIP_COMBINE_STATUS = 19,
	EQUIP_HAVE_STATUS = 20,
	EQUIP_EFFECT = 998,
	NONE = 999,
}

public enum ListViewSort.PresentBoxCategoryFilterKind
{
	SERVANT = 0,
	SERVANT_COMBINE_MATERIAL = 1,
	SERVANT_STATUS_UP = 2,
	SERVANT_EQUIP = 3,
	SERVANT_EQUIP_COMBINE_MATERIAL = 4,
	COMMAND_CODE = 5,
	ITEM_AP_RECOVER = 6,
	ITEM_LV_UP = 7,
	ITEM_GACHA_TICKET = 8,
	ITEM_SELECT = 9,
	ITEM_STONE = 10,
	ITEM_MANA = 11,
	ITEM_EVENT = 12,
	IMPORTANT = 13,
	OTHER = 14,
	SUM = 15,
}

public enum ListViewSort.PresentBoxRarityFilterKind
{
	CARD_RARITY_COMMON = 0,
	CARD_RARITY_UNCOMMON = 1,
	CARD_RARITY_RARE = 2,
	CARD_RARITY_SRARE = 3,
	CARD_RARITY_SSRARE = 4,
	SUM = 5,
}

public enum ListViewSort.AutoOrganizationCategoryFilterKind
{
	SERVANT = 0,
	SERVANT_EQUIP = 1,
	SERVANT_RARIRY_COMMON = 2,
	SERVANT_RARIRY_UNCOMMON = 3,
	SERVANT_RARIRY_RARE = 4,
	SERVANT_RARIRY_SRARE = 5,
	SERVANT_RARIRY_SSRARE = 6,
	UNIT_1 = 7,
	UNIT_2 = 8,
	UNIT_3 = 9,
	UNIT_4 = 10,
	UNIT_5 = 11,
	UNIT_6 = 12,
	SUM = 13,
}

public enum ListViewSort.WaveBattleAutoOrganizationCategoryFilterKind
{
	SERVANT = 0,
	SERVANT_EQUIP = 1,
	SERVANT_RARIRY_COMMON = 2,
	SERVANT_RARIRY_UNCOMMON = 3,
	SERVANT_RARIRY_RARE = 4,
	SERVANT_RARIRY_SRARE = 5,
	SERVANT_RARIRY_SSRARE = 6,
	SUM = 7,
}

public enum ListViewSort.Filter2Type
{
	ALL = 0,
	FILTER1 = 1,
	FILTER2 = 2,
	FILTER3 = 3,
}

public enum ListViewSort.BonusFilterKind
{
	ALL = 0,
	EVENT = 1,
	SERVANT = 2,
	CAMPAIGN = 3,
	CLOSE_EVENT = 4,
	FINISH_EVENT = 5,
}

public enum ListViewSort.ScaleType
{
	NONE = 0,
	NORMAL = 1,
	SMALL = 2,
	EXTREMELY_SMALL = 3,
}

public enum ListViewSort.ExpUpDispKind
{
	USER = 0,
	WARHOUSE = 1,
	TOTAL = 2,
	SUM = 3,
}

public enum ListViewSort.ExpUpDispType
{
	EXP_UP = 0,
	ATK_UP = 1,
	HP_UP = 2,
	SUM = 3,
}

public enum ListViewSort.PriorityKind
{
	NONE = 0,
	FRIEND_POINT_UP = 1,
	MASTER_EXP_UP = 2,
	EQUIP_EXP_UP = 3,
	BOND_UP = 4,
	QP_UP = 5,
	DROP_UP = 6,
}

public enum ListViewSort.AutoOrganizationMode
{
	USE_ENEMY_CLASS_MAIN = 0,
	USE_ENEMY_CLASS_ALL = 1,
}

public enum MainMenuBarButton.Kind
{
	TERMINAL = 0,
	FORMATION = 1,
	SUMMON = 2,
	COMBINE = 3,
	SHOP = 4,
	FRIEND = 5,
	MYROOM = 6,
	LATEST_SCENARIO = 7,
	SIZEOF = 8,
}

public enum MainMenuBarButton.Mode
{
	NONE = 0,
	DISABLE = 1,
	ENABLE = 2,
	SELECT = 3,
}

public enum SyncWidget.SyncParamType
{
	WIDTH = 0,
	HEIGHT = 1,
	SCALE = 2,
	COLOR_ALPHA = 3,
	PRINTED_WIDTH = 4,
	PRINTED_HEIGHT = 5,
}

public enum UICharaGraphRender.Kind
{
	SERVANT = 0,
	SERVANT_EQUIP = 1,
	COMMAND_CODE = 2,
}

public enum UICharaGraphRender.RealNameCheck
{
	DO_CHECK = 0,
	NOT_REAL = 1,
	REAL_NAME = 2,
	RELEASE_PRESENTATION = 3,
}

public enum UICharaGraphRender.SaintGraphType
{
	NORMAL = 0,
	NPC_FOLLOWER_SERVANT_EQUIP = 1,
}

public enum UICommonButtonColor.State
{
	Normal = 0,
	Hover = 1,
	Pressed = 2,
	Disabled = 3,
}

public enum UIDragDropListViewItem.Restriction
{
	None = 0,
	Horizontal = 1,
	Vertical = 2,
	PressAndHold = 3,
	Press = 4,
}

public enum UIMasterFaceRender.DispType
{
	FULL = 0,
	STATUS = 1,
}

public enum UIMasterFigureRenderOld.DispType
{
	FULL = 0,
	USER_SELECT = 1,
	MY_ROOM = 2,
}

public enum UIMasterFullFigureRender.DispType
{
	USER_SELECT = 0,
}

public enum UIMeshSprite.SpriteMeshType
{
	NormalRect = 0,
	TopCutFace = 1,
	ServantEquipRect = 2,
	ServantEquipBigRect = 3,
}

public enum UINarrowFigureRender.DispType
{
	FULL = 0,
	USER_SELECT = 1,
	MY_ROOM = 2,
}

public enum UIPanel.RenderQueue
{
	Automatic = 0,
	StartAt = 1,
	Explicit = 2,
}

public enum UIPlaySystemSe.Trigger
{
	OnClick = 0,
	OnMouseOver = 1,
	OnMouseOut = 2,
	OnPress = 3,
	OnRelease = 4,
	Custom = 5,
}

private enum UISliderWithButton.Direction
{
	Horizontal = 0,
	Vertical = 1,
	Upgraded = 2,
}

public enum StateLog.LogType
{
	ALL = 0,
	SHORT = 1,
	NOW = 2,
	STOP = 3,
}

public enum FSOffset.AddDirectionX
{
	Left = 0,
	Right = 1,
}

public enum ResponseCommandBase.Result
{
	SUCCESS = 0,
	ERROR = 1,
	RETRY = 2,
}

public enum ResponseFailData.ErrorType
{
	Common = 0,
	NotAbleToCloseTapOutDialog = 1,
}

private enum TopLoginRequest.UserState
{
	Flag1 = 0,
	Flag2 = 1,
	Flag3 = 2,
	Flag4 = 4,
	Flag5 = 8,
	Flag6 = 16,
	Flag7 = 32,
	Flag8 = 64,
	Flag9 = 128,
	Flag10 = 256,
	Flag11 = 512,
	Flag12 = 1024,
}

protected enum CommonMessageManager.State
{
	NONE = 0,
	IDLE = 1,
	LOAD = 2,
	EXECUTE = 3,
	WAIT = 4,
	WAIT_EXIT = 5,
	EXIT = 6,
	BACK_VIEW_INIT = 7,
	BACK_VIEW = 8,
	FIGURE_VIEW_INIT = 9,
	FIGURE_VIEW = 10,
	ERROR = 11,
}

public enum CommonMessageManager.PlaySpeed
{
	NONE = 0,
	PAUSE = 1,
	NORMAL = 2,
	FAST = 3,
}

public enum ScriptActionAdvPrefabController.DisplayCond
{
	Always = 0,
	Male = 2,
	Female = 4,
}

public enum ScriptActionSetRenderTextureComponent.RenderTextureType
{
	RenderTarget = 0,
	Capture = 1,
}

public enum ScriptBackLogListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum ScriptBackLogListViewManager.InitMode
{
	NONE = 0,
	INPUT = 1,
}

public enum ScriptBackLogListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

protected enum ScriptBackLogListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum ScriptCharaData.Kind
{
	FIGURE = 0,
	EQUIP = 1,
	IMAGE = 2,
	VERTICAL_IMAGE = 3,
	HORIZONTAL_IMAGE = 4,
}

public enum ScriptCharaData.State
{
	LOAD = 0,
	IDLE = 1,
	MOVE = 2,
	DESTROY = 3,
}

public enum ScriptFaceMessageManager.TalkMode
{
	FaceTalk = 0,
	WarBoardTalk = 1,
}

public enum ScriptLogMessage.HorizontalAlign
{
	Left = 0,
	Center = 1,
	Right = 2,
}

private enum ScriptManager.PresentMessageType
{
	NONE = 0,
	ADD_FRIENDPOINT_SUMMON = 1,
}

protected enum ScriptManager.PlayMode
{
	NORMAL = 0,
	DEBUG = 1,
	BACK = 2,
	FIGURE = 3,
	EQUIPGRAPH = 4,
}

public enum ScriptManager.StartMode
{
	NONE = 0,
	CLEAR_BLACK = 1,
	CLEAR_WHITE = 2,
	BLACK_CLEAR = 3,
	WHITE_CLEAR = 4,
	CLEAR = 5,
	BLACK = 6,
	WHITE = 7,
	FULL = 8,
	CLEAR_FULL = 9,
	BLACK_FULL = 10,
	WHITE_FULL = 11,
	CLEAR_BLACK_FULL = 12,
	CLEAR_WHITE_FULL = 13,
	THROUGH = 14,
	THROUGH_BLACK = 15,
	BLACK_SCENE_STOP = 16,
}

public enum ScriptManager.State
{
	NONE = 0,
	IDLE = 1,
	LOAD = 2,
	EXECUTE = 3,
	WAIT = 4,
	WAIT_SKIP = 5,
	WAIT_EXIT = 6,
	EXIT = 7,
	BACK_VIEW_INIT = 8,
	BACK_VIEW = 9,
	FIGURE_VIEW_INIT = 10,
	FIGURE_VIEW = 11,
	EQUIPGRAPH_VIEW_INIT = 12,
	EQUIPGRAPH_VIEW = 13,
	ERROR = 14,
}

protected enum ScriptManager.PlaySpeed
{
	NONE = 0,
	PAUSE = 1,
	NORMAL = 2,
	FAST = 3,
}

protected enum ScriptManager.InputTopMode
{
	NORMAL = 0,
	MENU = 1,
	SKIP_CONFIRM = 2,
	NOTIFICATION = 3,
	INPUT = 4,
	BACK_LOG = 5,
	SKIP_VOICE = 6,
	SHOW_BACK = 7,
	EXIT = 8,
}

private enum ScriptManager.ScriptCommandExecuteReturnCode
{
	Normal = 0,
	Continue = 1,
	ReturnFalse = 2,
}

public enum ScriptManager.MenuRouteInfo.RouteType
{
	NONE = 0,
	BAD = 1,
	TRUE = 2,
}

private enum ScriptManager.ExWipeType
{
	None = 0,
	CutVar = 1,
}

public enum ScriptManager.SCENE_MODE
{
	DEFAULT = 0,
	FULLSCREEN_IMAGE_DEVICE_WIDTH = 1,
}

public enum ScriptMessageCommonManager.HorizontalAlign
{
	Left = 0,
	Center = 1,
	Right = 2,
}

public enum ScriptMessageCommonManager.VerticalAlign
{
	Top = 0,
	Center = 1,
	Bottom = 2,
}

public enum ScriptMessageLabel.VerticalAlign
{
	Top = 0,
	Center = 1,
	Bottom = 2,
	Default = 0,
}

public enum ScriptMessageLabel.HorizontalAlign
{
	Left = 0,
	Center = 1,
	Right = 2,
}

protected enum ScriptNotificationDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum ScriptReplaceString.Index
{
	USER_NAME = 1,
}

public enum ScriptSelectListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum ScriptSelectListViewManager.InitMode
{
	NONE = 0,
	INTO = 1,
	INPUT = 2,
	SELECT = 3,
}

public enum ScriptSelectListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INTO = 3,
	INPUT = 4,
	NO_SELECT = 5,
	SELECT = 6,
}

protected enum ScriptSelectListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum ScriptSkipDialog.ResultKind
{
	CANCEL = 0,
	SKIP = 1,
	EXIT = 2,
}

protected enum ScriptStoryOpenDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum UIScriptChara.ChangeKind
{
	NONE = 0,
	NORMAL = 1,
	FADE = 2,
	BLINK = 3,
	CROSS_FADE = 4,
	MAX = 5,
}

private enum UIScriptImage.FULLSCREEN_SCALE_TYPE
{
	WIDTH_1345 = 1,
}

public enum BattlePerformance.BattleUIPanel
{
	BackCom = 0,
	Command = 1,
	FrontCom = 2,
	PopUp = 3,
	Event = 4,
}

public enum BattlePerformance.ActorGroup
{
	Actor = 0,
	ActorsParty = 1,
	ActorsEnemy = 2,
	Players = 3,
	Enemies = 4,
	All = 5,
}

private enum BattlePerformance.PositionMode
{
	BATTLE = 0,
	TACTICAL = 1,
}

public enum BattlePerformance.playMovieType
{
	NONE = 0,
	BATTLE_FINISH = 1,
	WAVE_START = 2,
}

public enum BattleWindowComponent.ACTIONTYPE
{
	SLIDE = 0,
	POPUP = 1,
	ALPHA = 2,
}

private enum BattleWindowComponent.WINDOWSTATE
{
	INIT = 0,
	ING_CLOSE = 1,
	CLOSE = 2,
	OPEN = 3,
	ING_OPEN = 4,
}

public enum ShopBuyBulkItemConfirmMenu.DispMode
{
	NORMAL = 0,
	TERMINAL_AP_SEED_EXCHANGE = 1,
}

private enum ShopBuyBulkItemConfirmMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum TerminalSceneComponent.TUTORIAL_KIND
{
	NONE = 0,
	_1 = 1,
	_2 = 2,
	_3 = 3,
	_4 = 4,
	_5 = 5,
}

public enum TerminalSceneComponent.STATE
{
	NORMAL = 0,
	TUTORIAL1_SPOT_ARROW = 1,
	TUTORIAL1_QUEST_ARROW = 2,
	TUTORIAL2_SPOT_ARROW = 3,
	TUTORIAL2_QUEST_ARROW = 4,
	TUTORIAL3_MENU_ARROW = 5,
	TUTORIAL3_GACHA_ARROW = 6,
	TUTORIAL4_SPOT_ARROW = 7,
	TUTORIAL4_QUEST_ARROW = 8,
	TUTORIAL5_MENU_ARROW = 9,
	TUTORIAL5_COMBINE_ARROW = 10,
	SIZEOF = 11,
}

public enum TerminalSceneComponent.QUIT_TYPE
{
	NONE = 0,
	RESUME = 1,
	FINISH = 2,
	PAUSE = 3,
}

public enum TitleRootComponent.StoryProgress
{
	NORMAL = 0,
	EPIC_OF_REMNANT = 1,
	COSMOS_IN_THE_LOSTBELT = 2,
	COSMOS_IN_THE_LOSTBELT_VER2 = 3,
}

public enum ParticleSystemPropertyChange.UpdateTiming
{
	Update = 0,
	LateUpdate = 1,
}

public enum ShaderCutoutDisplayProgress.DisplayStartPosition
{
	Left = 0,
	Top = 1,
	Right = 2,
	Bottom = 3,
}

public enum ShaderParamAnimation.FloatCountType
{
	Float_0 = 0,
	Float_1 = 1,
	Float_2 = 2,
	Float_3 = 3,
	Float_4 = 4,
}

public enum ShaderParamAnimation.VectorCountType
{
	Vector_0 = 0,
	Vector_1 = 1,
	Vector_2 = 2,
	Vector_3 = 3,
	Vector_4 = 4,
}

public enum ShaderParamAnimation.RendererType
{
	Renderer = 0,
	BillboardRenderer = 1,
	LineRenderer = 2,
	MeshRenderer = 3,
	ParticleSystemRenderer = 4,
	SkinnedMeshRenderer = 5,
	SpriteMask = 6,
	SpriteRenderer = 7,
	TrailRenderer = 8,
}

public enum BattleActionLogType.Type
{
	NONE = 0,
	SELECT_TARGET = 1,
	SKILL = 2,
	COMMAND_SPELL = 3,
	SELECT_COMMAND = 4,
	CONTINUE = 5,
	TERMINATE = 6,
}

public enum BattleAssetLoadStatus
{
	None = 0,
	Preloading = 1,
	Preloaded = 2,
}

public enum CompensateArgForShowAll.EffectType
{
	DAMAGE = 1,
	HEAL = 2,
	BUFF = 4,
}

public enum BattleActionData.STATE
{
	ACTORS = 0,
	SYSTEM = 1,
	FIELD = 2,
	MOTION = 3,
	ENEMY_MASTER = 4,
	LOAD_IMMEDIATE_ENTRY_SERVANT = 5,
	WAIT_COND = 6,
	UPDATE_VIEW = 7,
	EXEC_IN_ACTION_DATA = 8,
}

public enum BattleActionData.DamageHitType
{
	NORMAL = 0,
	INVINCIBLE = 1,
	AVOIDANCE = 2,
	PIERCE_INVINCIBLE = 3,
	BREAK_AVOIDANCE = 4,
}

public enum BattleActionData.BuffData.BuffProcType
{
	NONE = 0,
	INSTANT_DEATH = 1,
	UPDATE_HP = 2,
	UPDATE_NP = 3,
	UPDATE_CRITICAL = 4,
	UPDATE_NPTURN = 5,
}

public enum BattleActionData.BuffData.UpdateBuffType
{
	SKILL_RANK = 1,
}

public enum BattleActionData.BaseShiftGaugeData.PlayedStateFlag
{
	SHIFT_GAUGE_MAIN = 1,
}

public enum BattleActionData.BaseShiftGaugeData.NotUpdateFlag
{
	TD_GAUGE = 1,
}

public enum BattleActionData.ACTTYPE
{
	NOMAL = 0,
	ATTACK = 1,
	DAMAGE = 2,
	ATTACK_BEFORE = 3,
	FUNCTION = 4,
}

public enum BattleActorEffectMesh.MeshType
{
	SkinnedMeshRenderer = 0,
	MeshRenderer = 1,
}

public enum BattleActorNodeLookAt.Type
{
	WorldLook = 0,
	TargetLook = 1,
}

public enum BattleAttack.SideType
{
	PLAYER = 1,
	ENEMY = 2,
	ALL = 3,
}

public enum BattleBoostItemInfoData.EFFECT_TIMING
{
	BATTLE_ACTION = 0,
	BATTLE_START = 1,
}

public enum BattleBuffData.IntervalData.UpdateTiming
{
	NONE = 0,
	CURRENT_ACTION = 1,
	OTHER_ACTION = 2,
}

public enum BattleBuffData.BuffData.STATEENUM
{
	NOFIELD = 1,
	BOOST = 2,
	ISSHOW = 4,
	ISHIDE = 8,
	NOACT = 16,
	COND = 32,
	FRAME = 64,
	ISHIDEPARAM = 128,
	ISAPPID = 256,
	ISSHOWCOMMAND = 512,
	ISSHOWDEFF = 1024,
	ISOPPONENTONLY = 2048,
	IS_SHOW_STATUS_BUFF_ONLY = 4096,
	IS_SHOW_DAMAGE_AND_COMMANDCARD_BUFF = 8192,
	NO_FIELD_COUNT = 16384,
	INVALID_HIDE = 32768,
	IGNORE_INDIVIDUALITY = 65536,
	FORCE_NOACT = 131072,
	NO_TARGET_NOACT = 262144,
	UNSUBSTATE = 524288,
	IGNORE_INDIV_UNRELEASEABLE = 1048576,
	SKILL_ACTOR_NOT_IN_PARTY_NOACT = 2097152,
	FAMILY_BUFF = 4194304,
	UNSUBSTATE_WHILE_LINKED_TO_OTHERS = 8388608,
	NOT_ACCOMPANY_WHEN_LINKED_TARGET_MOVE_STATE = 16777216,
	UNSUBSTATE_WHEN_CONTINUE = 33554432,
}

public enum BattleData.BattleResult
{
	NONE = 0,
	WIN = 1,
	LOSE = 2,
	CANCEL = 3,
	INTERRUPTION = 4,
}

public enum BattleData.WinResult
{
	None = 0,
	Normal = 1,
	TimeLimit = 2,
	Lose = 3,
}

public enum BattleData.TYPETURN
{
	PLAYER = 1,
	ENEMY = 2,
}

public enum BattleData.MULTI_TARGET_POS
{
	UP = 0,
	CORE = 1,
	UNDER = 2,
}

public enum BattleData.CHAIN_COUNT_TYPE
{
	ARTS = 1,
	BUSTER = 2,
	QUICK = 3,
	BRAVE = 4,
	BRAVE_AND_ARTS = 5,
	BRAVE_AND_BUSTER = 6,
	BRAVE_AND_QUICK = 7,
	TREASURE_DVC = 8,
	MIGHTY = 9,
	BRAVE_AND_MIGHTY = 10,
	TEST3 = 11,
	TEST4 = 12,
	TEST5 = 13,
	TEST6 = 14,
	TEST7 = 15,
	TEST8 = 16,
}

public enum BattleData.TURN_TYPE
{
	PLAYER_TURN = 0,
	ENEMY_TURN = 1,
}

public enum BattleData.PROGRESS
{
	FIELDAI_WAVESTART = 1,
	BOOSTITEM = 2,
	WAVEBUFF = 4,
	FIRST_ENTRY = 8,
	SERVANT_AI_WAVE = 16,
	FIELDAI_TURNSTART = 32,
	QUEST_BEHAVIOR = 64,
	GIMMICK = 128,
	BOOST_SKILL = 256,
	ASSIST = 512,
	FIELDAI_ENTRY = 1024,
	PRECHECK_END_BATTLE = 2048,
	SERVANT_AI_TURN_START = 4096,
	TURN_START_FUNCTION = 8192,
	SERVANT_AI_BEFORE_MOVE_WAVE = 16384,
	FIELDAI_BEFORE_MOVE_WAVE = 32768,
	PROGRESS_INTERVAL_TURN = 65536,
	STAGE_CUTIN = 131072,
	FIELD_AI_BEFORE_WAVE_START_ANIMATION = 262144,
}

public enum BattleDataDefine.FieldActorPosition
{
	FRONT = 0,
	CENTER = 1,
	BACK = 2,
}

public enum BattleDataDefine.RaidType
{
	NONE = 0,
	RAID = 1,
	SUPER_BOSS = 2,
}

public enum BattleDataDefine.WinLeave
{
	PULLOUT_RAID = 1,
	PULLOUT_EXCEPT_ENEMY_ALL_DEAD = 2,
	NORMAL_ENEMY_FOCUS = 3,
}

public enum BattleDataDefine.SkillTiming
{
	NONE = 0,
	PASSIVE_ON_TRANSFORM = 1,
}

public enum BattleDebug.TAG
{
	NONE = 0,
	SKILL = 1,
	ACTION = 2,
	FUNCTION = 3,
	AI = 4,
	ANIMATION = 5,
	KEISAN = 6,
	PRINT = 7,
	BUFF = 8,
	PERF = 9,
	LOGIC = 10,
	NEW_AI = 11,
	DEBUG = 100,
	WARNING = 101,
	ERROR = 102,
}

public enum BattleEffectControl.ID
{
	DAMAGE_NO = 0,
	CRITICAL_DAMAGE__NO = 1,
	TITLE_CRITICAL = 2,
	TITLE_WEEK = 3,
	STAR = 4,
	SERVANT = 5,
	HEAL_NO = 6,
	REGIST = 7,
	TITLE_CRITICAL_MISS = 8,
	STAR_DEAL = 9,
}

public enum BattleEffectUtility.EffectFolderType
{
	COMMON = 1,
	NOBLE = 2,
	WEAPON = 3,
	BATTLEASSET = 4,
	BATTLECOMMON = 5,
}

public enum BattleFieldEnvironmentData.SortTargetType
{
	Background = 1,
	BGM = 2,
	All = 3,
}

public enum BattleFieldEnvironmentData.GrantType
{
	None = 0,
	Stage = 1,
	Function = 2,
}

protected enum CommonMotionSkip.State
{
	SKIPPING = 1,
}

public enum BattleMoveObject.TYPE
{
	NONE = 0,
	CRITICAL = 1,
	ITEM = 2,
	BATTLE_ITEM = 3,
}

public enum BattleMoveObject.EASING
{
	EASEINQUART = 0,
	EASEINBACK = 1,
}

public enum BattleServantActionHistory.TYPE
{
	NONE = 0,
	DAMAGE_COMMAND = 1,
	DAMAGE_TD = 2,
	HPLOSS = 3,
	INSTANT_DEATH = 4,
	REDUCE_HP = 5,
	DAMAGE_REFLECTION = 6,
	DAMAGE_VALUE = 7,
}

public enum BattleServantData.STATUS
{
	NOMAL = 0,
	ACT_RESURRECTION = 1,
	ACT_DEAD = 2,
	ACT_WITHDRAW = 3,
	ACT_CHANGEAPP = 4,
}

public enum BattleServantData.DEADTYPE
{
	NORMAL = 0,
	ESCAPE = 1,
	STAND = 2,
	EFFECT = 3,
	WAIT = 4,
	ENERGY = 5,
	CRYSTAL = 6,
}

private enum BattleServantData.GroupIdValidFlag
{
	PLAYER = 1,
	ENEMY_OR_SUPPORT = 2,
	PLAYER_ENEMY_OR_SUPPORT = 3,
}

private enum BattleServantData.FixNpSpeedType
{
	NOT_FIX = 1,
	NORMAL = 2,
	FAST = 3,
}

public enum BattleSkillInfoData.TYPE
{
	NONE = 0,
	MASTER_EQUIP = 1,
	MASTER_COMMAND = 2,
	SERVANT_CLASS = 10,
	SERVANT_SELF = 11,
	SERVANT_EQUIP = 12,
	TEMP = 20,
	BOOST = 21,
	COMMAND_CODE = 22,
	COMMAND_ASSIST = 23,
	ADD_PASSIVE = 24,
	APPEND_SKILL = 25,
	CLASS_BOARD = 26,
	TEMP_EFFECT_SQUARE = 100,
	WARBOARD_PARTY_SKILL = 101,
}

public enum BattleSkillInfoData.BATTLE_ITEM_DISP_TYPE
{
	ITEM_MAX = 0,
	ITEM_USE = 1,
}

public enum BattleRankUpSkillInfoData.RankUpState
{
	None = 0,
	RightAfterUp = 1,
	AlreadyUp = 2,
}

public enum WrapBaseBattlePopupControl.DamageType
{
	NORMAL = 0,
	CRITICAL = 1,
	WEEK = 2,
	RESIST = 3,
}

public enum ChangeRendererMaterialColorEffect.RendererType
{
	Renderer = 0,
	ParticleSystemRenderer = 1,
	MeshRenderer = 2,
	SkinnedMeshRenderer = 3,
	SpriteRenderer = 4,
}

public enum ChrDirectionalLight.MaterialType
{
	ShareMaterial = 0,
	NormalMaterial = 1,
}

public enum ChrRenderMatrix.MaterialType
{
	ShareMaterial = 0,
	NormalMaterial = 1,
}

public enum BattleCommandComponent.ADDOBJECT_TYPE
{
	ARROW_RESIST = 0,
	ARROW_WEAK = 1,
	MAX = 2,
}

public enum BattleCommandComponent.EFFECT_OBJ_TYPE
{
	ICON_FLASH = 0,
	COMMAND_BURN = 1,
	NOBLE_EFFECT = 2,
	COMMAND_UP_DETAIL = 3,
	FIRST_AURA = 4,
	SELECT_MARK = 5,
}

public enum BattleCommandComponent.ARROW_POS_TYPE
{
	NOMAL = 0,
	CODE = 1,
	SUPPORT_CODE = 2,
}

public enum BattleCommandComponent.CODE_POS_TYPE
{
	NOMAL = 0,
	SUPPORT_CODE = 1,
}

public enum BattleCommandData.CriticalDecisionType
{
	NONE = 0,
	ENEMY_NORMAL = 1,
	FORCE = 2,
	NO_CRITICAL = 3,
}

public enum BattleCommandSealStatus.Status
{
	DONOT_ACT_BY_PERMANENT_SLEEP = 0,
	DONOT_ACT_BY_SLEEP = 1,
	DONOT_ACT_BY_OTHER_DEBUFF = 2,
	NO_FUNC_HEROINE = 3,
	NO_FUNC = 4,
	DONOT_NOBLE = 5,
	SHORTAGE_CRITICAL_STAR = 6,
	DONOT_NOBLE_COND_MISMATCH = 7,
	DONOT_ACT_WITH_TYPE_SP = 8,
	TREASURE_DEVICE_ERROR = 9,
	NONE = 2147483647,
}

public enum AiLogic.PROC_STATE
{
	NONE = 0,
	NOMAL = 1,
	DEAD = 2,
	PLAYERACTIONEND = 3,
	TURN_START = 4,
	TURN_END = 5,
	WAVE_START = 6,
	MAXNP = 7,
	USENP_TARGET = 8,
	TURN_ENEMY_START = 10,
	TURN_ENEMY_END = 11,
	TURN_PLAYER_START = 12,
	TURN_PLAYER_END = 13,
	AFTER_TURN_PLAYER_END = 14,
	ENTRY_UNIT = 15,
	TURN_START_PREV = 16,
	BEFORE_DEAD = 17,
	BEFORE_RESURRECTION = 18,
	PLAYER_SKILL_AFTER = 19,
	SHIFT_SERVANT_AFTER = 20,
	BEFORE_MOVE_WAVE = 21,
	PLAYER_SKILL_AFTER_PRIOR = 22,
	BEFORE_WAVE_START_ANIMATION = 23,
}

public enum AiLogic.AiInfo.AITYPE
{
	NONE = 0,
	SERVANT = 1,
	FIELD = 2,
}

public enum ConditionsInformation.TARGET
{
	NONE = 0,
	FIELD = 1,
	SELF = 2,
	PT = 3,
	OPPONENT = 4,
	PT_FIELD = 5,
	OPPONENT_FIELD = 6,
	PT_ALL = 7,
	OPPONENT_ALL = 8,
	OPPONENT_FRONT = 9,
	OPPONENT_CENTER = 10,
	OPPONENT_BACK = 11,
	ALL_FIELD = 12,
	PT_FRONT = 13,
	PT_CENTER = 14,
	PT_BACK = 15,
}

public enum ConditionsInformation.PARAMATER
{
	NONE = 0,
	TURN = 1,
	SPACE = 2,
	PREV_ACTID = 3,
	PREV_ACTTYPE = 4,
	HP = 5,
	NPGAUGE = 6,
	TDTURN = 7,
	ACT_COUNT = 8,
	ACT_COUNT_THISTURN = 9,
	TURN_FIELD = 10,
	TURN_ACT_COUNT = 11,
	BUFF_ID = 12,
	INDIVIDUALITY = 13,
	BUFF_INDIVIDUALITY = 14,
	BUFF_ACTIVE_INDIVIDUALITY = 15,
	RAID_HP = 16,
	RAID_COUNT = 17,
	RAID_COUNT_VALUE = 18,
	COUNT_ALIVE = 19,
	COUNT_REST = 20,
	COUNT_ITEM = 21,
	COUNT_BUFFCOUNT_INDIVIDUALITY = 22,
	BUFF_ACTIVE_ID = 23,
	ENEMY_MASTER_COMMAND_SPELL_COUNT = 24,
	COUNT_STAR = 25,
	TARGET_POSITION = 26,
	COUNT_TARGET_BUFF_INDIVIDUALITY_SUM = 27,
	DEAD = 28,
	PRECEDING_ENEMY = 29,
	REMAIN_TURN = 30,
	MASTER_COMMAND_SPELL_COUNT = 31,
	CHECK_MASTER_SKILL_THISTURN = 32,
	CHAIN_COUNT = 33,
	CHECK_TARGET_SKILL_THISTURN = 34,
	CHECK_SELECT_CHAIN = 35,
	COUNT_PLAYER_NP = 36,
	COUNT_PLAYER_SKILL = 37,
	COUNT_PLAYER_SKILL_INCLUDE_MASTER_SKILL = 38,
	TOTAL_TURN = 39,
	WAR_BOARD_SQUARE_INDIVIDUALITY = 40,
	CHECK_BATTLE_VALUE = 41,
	CHECK_PLAYER_MASTER_SKILL_INDEX = 42,
	CHECK_PLAYER_MASTER_SKILL_INDEX_THIS_TURN = 43,
	COUNT_PLAYER_MASTER_SKILL_THIS_TURN = 44,
	COUNT_PLAYER_MASTER_SKILL_THIS_WAVE = 45,
}

public enum ConditionsInformation.REFINE
{
	ANY = 0,
	ALL = 1,
	HIGHER = 2,
	LOWER = 3,
	TOTAL_COUNT = 4,
}

public enum ConditionsInformation.CHECK
{
	NONE = 0,
	EQUAL = 1,
	EQUAL_NOT = 2,
	HIGHER = 3,
	LOWER = 4,
	MULTIPLE = 5,
	EXIST = 6,
	BETWEEN = 7,
	BETWEEN_NOT = 8,
	ALL_EXIST = 9,
}

public enum AiResetChecker.ResetTiming
{
	DO_NOT = 0,
	DEAD = 1,
	EVERY_BATTLE = 2,
}

public enum BattleLogic.LOGICTYPE
{
	COMMAND_BEFORE = 0,
	COMMAND_ATTACK_1 = 1,
	COMMAND_ATTACK_2 = 2,
	COMMAND_ATTACK_3 = 3,
	COMMAND_ADDATTACK = 4,
	COMMAND_AFTER = 5,
	PLAYER_SPECIAL_1 = 6,
	PLAYER_SPECIAL_2 = 7,
	PLAYER_SPECIAL_3 = 8,
	COMMAND_WAIT = 9,
	ENEMY_ATTACK_1 = 10,
	ENEMY_ATTACK_2 = 11,
	ENEMY_ATTACK_3 = 12,
	LAST_BACKSTEP = 13,
	ENEMY_SPECIAL_1 = 14,
	ENEMY_SPECIAL_2 = 15,
	ENEMY_SPECIAL_3 = 16,
	DEBUG = 17,
	PLAYER_SP1_ALWAYS = 18,
	PLAYER_SP2_ALWAYS = 19,
	PLAYER_SP3_ALWAYS = 20,
	ENEMY_SP1_ALWAYS = 21,
	ENEMY_SP2_ALWAYS = 22,
	ENEMY_SP3_ALWAYS = 23,
	GET_DROPITEM = 24,
	PLAYER_ENDTURN = 25,
	ENEMY_ENDTURN = 26,
	TOTAL_ENDTURN = 27,
	AFTER_SKILL = 28,
	AFTER_COMMAND = 29,
	REACTION_STARTENEMY = 30,
	REACTION_ENDENEMY = 31,
	ENEMY_ENDWAIT = 32,
	REACTION_PLAYERACTIONEND = 33,
	BUFF_ADDPARAM_PLAYER = 34,
	BUFF_ADDPARAM_ENEMY = 35,
	START_PLAYERTURN = 36,
	START_ENEMYTURN = 37,
	TACTICAL_START = 38,
	WAVE_START = 39,
	REFLECTION_ENEMY = 40,
	REFLECTION_PLAYER = 41,
	ENEMY_ATTACK_NORMAL_AI = 42,
	FIELDAI_START_WAVE = 43,
	FIELDAI_ENTRY_UNIT = 44,
	FIELDAI_START_TURN = 45,
	FIELDAI_START_PLAYERTURN = 46,
	FIELDAI_END_PLAYERTURN = 47,
	FIELDAI_START_ENEMYTURN = 48,
	FIELDAI_END_ENEMYTURN = 49,
	CHECK_OVERKILL = 50,
	CHECK_IMMEDIATE_ENTRY = 51,
	START_IMMEDIATE_ENTRY = 52,
	AFTER_IMMEDIATE_ENTRY = 53,
	RESET_ENEMYACTLIST = 54,
	UPDATE_SHIFTSERVANT = 55,
	ACT_SHIFTSERVANT = 56,
	AFTER_END_PLAYERTURN = 57,
	PLAYER_ATTACK_TERM = 58,
	ENEMY_ATTACK_TERM = 59,
	NPCAI_START_WAVE = 60,
	NPCAI_START_TURN = 61,
	NPCAI_ENTRY_UNIT = 62,
	NPCAI_START_PLAYERTURN = 63,
	NPCAI_END_PLAYERTURN = 64,
	NPCAI_START_ENEMYTURN = 65,
	NPCAI_END_ENEMYTURN = 66,
	COUNTER_FUNC_PLAYER = 67,
	COUNTER_FUNC_ENEMY = 68,
	ENEMY_ATTACK_AI_START = 69,
	ENEMY_ATTACK_AI_END = 70,
	ENEMY_ATTACK_AI_PRECHECK = 71,
	REACTION_PLAYER_ACTION_START = 72,
	AFTER_SHIFTSERVANT = 73,
	BEFORE_MOVE_WAVE = 74,
	FIELDAI_BEFORE_MOVE_WAVE = 75,
	FIELD_AI_BEFORE_WAVE_START_ANIMATION = 76,
	LOGIC_TERM = 77,
}

public enum BattleLogic.ClassRelationBuffShowState
{
	SHOW = 0,
	HIDE = 1,
	SHOWDARK = 2,
}

private enum BattleLogic.ACTTYPE
{
	NONE = 0,
	LIST = 1,
	ONE = 2,
}

public enum BattleLogic.DamageType
{
	NOMAL = 0,
	NOBLE_NOMAL = 1,
	NOBLE_PIERCE = 2,
	NOBLE_INDIVIDUAL = 3,
	NOBLE_STATE_INDIVIDUAL = 4,
	NOBLE_HPRATIO_HIGH = 5,
	NOBLE_HPRATIO_LOW = 6,
	NOBLE_STATE_INDIVIDUAL_FIX = 7,
	NOBLE_SAFE = 8,
	NOBLE_RARE = 9,
	NOBLE_AND_CHECK_INDIVIDUAL = 10,
	NOBLE_INDIVIDUAL_SUM = 11,
}

public enum BattleLogic.TuStates
{
	Attack = 0,
	Skill = 1,
	SelectEnemy = 2,
}

public enum BattleLogicFunctionProcess.CommonAddStateTargetCheck.AttachTarget
{
	Servant = 1,
	CommandCard1 = 101,
	CommandCard2 = 102,
	CommandCard3 = 103,
	CommandCard4 = 104,
	CommandCard5 = 105,
	Field = 10001,
}

public enum BattleLogicFunctionProcess.FieldAddStateTargetCheck.GrantType
{
	Overwrite = 0,
	InvalidAdd = 1,
	Add = 2,
}

public enum BattleLogicFunctionProcess.FuncInvalidType
{
	None = 0,
	NoEffect = 1,
	Miss = 2,
	GrayPopup = 3,
}

public enum GainNpIndividualSum.GainIndividualTarget
{
	SELF = 0,
	PLAYER = 1,
	ENEMY = 2,
	ALL = 3,
}

public enum ServantReactTaskCreator.ExecOrder
{
	P = 0,
	E = 1,
	N = 2,
}

public enum BattleLogicTarget.Position
{
	FRONT = 0,
	CENTER = 1,
	BACK = 2,
}

public enum BattleLogicTask.ACTORTYPE
{
	NONE = 0,
	PLAYER_MASTER = 1,
	PLAYER_SERVANT = 2,
	ENEMY_SERVANT = 3,
	COMMAND = 4,
	FIELD = 5,
}

public enum BattleLogicTask.ACTIONTYPE
{
	NONE = 0,
	COMMAND_BATTLE = 1,
	ADDATTACK = 2,
	SKILL = 3,
	TREASURE_DEVICE = 4,
	OVERWRITE_TREASURE_DEVICE = 5,
	BACKSTEP = 6,
	SYSTEM = 7,
	COMBO_ORDER = 8,
	COMMAND_SPELL = 9,
	PLAY_MOTION = 10,
	ENDTURN_PLAYER = 11,
	ENDTURN_ENEMY = 12,
	RESURRECTION = 13,
	DEAD = 14,
	PROC_BUFFDEAD = 15,
	ENEMYLOGIC_ENEMYDEAD = 16,
	ENEMYLOGIC_PLAYERACTIONEND = 17,
	BUFF_ADD_PLAYER = 18,
	BUFF_ADD_ENEMY = 19,
	STARTTURN_PLAYER = 20,
	STARTTURN_ENEMY = 21,
	ENEMYLOGIC_STARTTURN = 22,
	ENEMYLOGIC_ENDTURN = 23,
	FUNCTIONCHECK_ENTRY = 24,
	RESERVATION_SKILL = 25,
	ENEMYLOGIC_WAVESTART = 26,
	CAMERA = 27,
	FIELDAI_START_ENEMYTURN = 28,
	FIELDAI_END_ENEMYTURN = 29,
	FIELDAI_START_PLAYERTURN = 30,
	FIELDAI_END_PLAYERTURN = 31,
	FIELDAI_START_WAVE = 32,
	FIELDAI_START_TURN = 33,
	FIELDAI_REACT_DEAD = 34,
	BREAK_ON_BATTLE = 35,
	CHECK_SHIFTSERVANT = 36,
	SHIFT_SERVANT = 37,
	WITHDRAW = 38,
	TURN_PLAYER_END_AFTER = 39,
	CHANGE_APP = 40,
	ENEMY_MASTER_CUTIN = 41,
	LOAD_IMMEDIATE_ENTRY_SERVANT = 42,
	FIELDAI_ENTRY_UNIT = 43,
	PLAY_FIELD_MOTION = 44,
	NPCAI_START_WAVE = 45,
	NPCAI_START_TURN = 46,
	NPCAI_ENTRY_UNIT = 47,
	NPCAI_REACT_DEAD = 48,
	NPCAI_START_PLAYERTURN = 49,
	NPCAI_END_PLAYERTURN = 50,
	NPCAI_START_ENEMYTURN = 51,
	NPCAI_END_ENEMYTURN = 52,
	CREATE_RESURRECTION = 53,
	BEFORE_RESURRECTION = 54,
	BEFORE_DEAD = 55,
	MESSAGE = 56,
	LOGIC_REPEAT_REACTION = 57,
	UPDATE_VIEW = 58,
	LOGIC_SERVANT_AI_REACTION = 59,
	LOGIC_NPC_AI_REACTION = 60,
	PLAY_FIELD_MOTION_NPC = 61,
	SHIFT_GUTS = 62,
	SHIFT_SERVANT_AFTER = 63,
	FIELDAI_BEFORE_MOVE_WAVE = 64,
	PROGRESS_INTERVAL_TURN = 65,
	FIELD_AI_PLAYER_SKILL_AFTER = 66,
	FIELD_AI_PLAYER_SKILL_AFTER_PRIOR = 67,
	GENERAL_RELAY_TASK = 68,
	DO_NOT_ACT = 69,
	FIELD_AI_BEFORE_WAVE_START_ANIMATION = 70,
	CREATE_TASK_SIDE = 71,
}

public enum BattleLogicTask.MESSAGE_TYPE
{
	NONE = 0,
	SUB_ENTRY = 1,
	ACTOR_SIDE = 2,
}

public enum MultiplyTargetMatrix.MaterialType
{
	ShareMaterial = 0,
	NormalMaterial = 1,
}

public enum MultiplyTargetMatrixChr.MaterialType
{
	ShareMaterial = 0,
	NormalMaterial = 1,
}

public enum MultiplyTargetMatrixChr.TargetObjPathRootType
{
	Own = 0,
	Chr = 1,
}

private enum ParticleAttatchMesh.CustomDataType
{
	None = 0,
	Color = 1,
	UV = 2,
}

public enum BattleActorAnimationEffect.ScaleFlipType
{
	None = 0,
	X = 1,
	Y = 2,
	Z = 4,
	X_Y = 3,
	X_Z = 5,
	Y_Z = 6,
	X_Y_Z = 7,
}

private enum BattleActorControl.DIR
{
	RIGHT = 0,
	LEFT = 1,
}

public enum BattleActorControl.POS
{
	FRONT = 0,
	BACK = 1,
	CENTER = 2,
	CRITERIA = 3,
	MYSTAGE = 4,
	ENEMYSTAGE = 5,
	REPLACE = 6,
	NPSTAGE = 7,
}

public enum BattleConcatLabelMessageComponent.ResizeTarget
{
	NONE = 0,
	WIDTH = 1,
	HEIGHT = 2,
	ALL = 3,
}

public enum BattleEffectReplaceShaderTexture.RendererType
{
	Renderer = 0,
	MeshRenderer = 1,
	SkinnedMeshRenderer = 2,
	ParticleSystemRenderer = 3,
}

private enum BattleInformationComponent.TYPEOVER
{
	KILL = 0,
	GAUGE = 1,
	MAX = 2,
}

private enum BattlePerformanceBg.FADE
{
	NONE = 0,
	IN = 1,
	OUT = 2,
}

public enum BattlePerformanceDefenceTarget.MoveToPositionType
{
	TACTICAL_PHASE = 0,
	COMMAND_CARD = 1,
	BATTLE_PHASE = 2,
}

private enum BattlePerformanceEnemyMst.loadState
{
	NONE = 0,
	VOICE = 1,
	FACE = 2,
}

public enum BattlePerformanceTurnSituationComponent.ComponentType
{
	NONE = 0,
	LABEL = 1,
	CHANGE_SPRITE = 2,
	LABEL_WITH_RAIDNAME = 3,
}

public enum BattleSelectMainSubServantWindow.POSITION
{
	MAIN = 1,
	SUB = 2,
}

private enum BattleServantConfConponent.TAB
{
	ABILLITY = 0,
	STATE = 1,
}

private enum BattleServantConfConponent.HideState
{
	QUESTION = 1,
	NONE = 2,
	HIDDEN = 3,
}

private enum BattleServantHeadUpComponent.MODE
{
	NONE = 0,
	WAVE_START = 1,
	COMMAND = 2,
	TAC = 3,
	ACTION = 4,
}

private enum BattleServantParamComponent.WINDOW_MODE
{
	NONE = 0,
	INIT = 1,
	OPEN = 2,
	CLOSE = 3,
}

public enum BattleServantSkillIConComponent.SHOW_TYPE
{
	NONE = 0,
	NOMAL = 1,
	NOTOUCH = 2,
}

public enum BattleSkillSelectAddFuncConfComponent.BtnLayoutType
{
	SELECT_NOMAL = 0,
	SELECT_CARD_TYPE = 1,
}

private enum BattleSkillSelectComandCardBtnComponent.CommandCardType
{
	Quick = 0,
	Arts = 1,
	Buster = 2,
}

public enum BattleSyncTransformComponent.SyncTargetType
{
	None = 0,
	POS = 1,
	ROTATION = 2,
	POS_ROTATION = 3,
	SCALE = 4,
	POS_SCALE = 5,
	ROTATION_SCALE = 6,
	ALL = 7,
}

public enum BattleSyncTransformComponent.SyncParamType
{
	POSITION = 1,
	ROTATION = 2,
	SCALE = 4,
}

public enum CommandSpellWindowComponent.MODE
{
	NO_BATTLE = 0,
	BATTLE = 1,
}

public enum FieldMotionManager.GET_TYPE
{
	ENEMY_POP_POINT = 0,
	POP_ENEMY = 1,
	PLAYER_POP_POINT = 2,
	POP_PLAYER = 3,
	PLAYER_TACTICAL = 4,
	ENEMY_TACTOCAL = 5,
	NPC_BATTLE = 6,
	NPC_TACTICAL = 7,
	FIELD_POPUP_BATTLE = 8,
	FIELD_POPUP_TACTICAL = 9,
	FIELD_EFFECT_BATTLE = 10,
	FIELD_EFFECT_TACTICAL = 11,
	FIELD_EFFECT_NP = 12,
}

public enum BattleResultComponent.resultData.ResultDispFlagEnum
{
	BONDS = 1,
	EXP = 2,
	ITEM = 4,
	EVENT_ITEM = 8,
	DAMAGE_ITEM = 16,
	FRIEND = 32,
	TUTORIAL = 64,
	FRIEND_POINT = 128,
	SUPER_BOSS = 256,
	NO_DAMAGE_ITEM = 512,
	EVENT_POINT_RESULT = 1024,
	RETRY_QUEST = 2048,
	EVENT_FORTIFICATION_ITEM = 4096,
	RESERVE_7 = 8192,
	RESERVE_8 = 16384,
	RESERVE_9 = 32768,
}

private enum BattleResultExpComponent.ParamList
{
	MASTER_LEVEL = 0,
	AP = 1,
	COST = 2,
	FRIENDKEEP = 3,
	FULL_AP = 4,
}

protected enum BattleResultKnockdownComponent.ColorType
{
	Normal = 0,
	NewRecord = 1,
	Term = 2,
}

public enum SetTargetObjectMatrix.RendererType
{
	SkinnedMesh = 0,
	Mesh = 1,
	Sprite = 2,
	Particle = 3,
}

public enum SetTargetObjectMatrix.MaterialType
{
	ShareMaterial = 0,
	NormalMaterial = 1,
}

public enum BattleScriptRootComponent.TalkType
{
	NONE = 0,
	WAR_PROLOGUE = 1,
	WAR_EPILOGUE = 2,
	BATTLE_BEFORE = 3,
	BATTLE_AFTER = 4,
	NOBATTLE_QUEST = 5,
	NOTMEETS_COND = 6,
	BATTLE_BEFORE_WITH_MAP = 7,
	NOBATTLE_QUEST_WITH_MAP = 8,
}

public enum BattleScriptRootComponent.QuestTalkPhase
{
	NONE = 0,
	BEFORE_BATTLE_QUEST_START = 1,
	BEFORE_BATTLE_BEFORE_DEMO = 2,
	BEFORE_BATTLE_BATTLE_DEMO = 3,
	BEFORE_BATTLE_AFTER_DEMO = 4,
	GO_TO_BATTLE = 5,
	AFTER_BATTLE_BEFORE_DEMO = 6,
	AFTER_BATTLE_BATTLE_DEMO = 7,
	AFTER_BATTLE_AFTER_DEMO = 8,
	AFTER_BATTLE_BATTLE_DEMO2 = 9,
	GO_TO_TERMINAL = 10,
}

public enum CRIMovieControl.Status
{
	Closed = 0,
	Opening = 1,
	Opened = 2,
	Closing = 3,
}

private enum ClassBoardBlank.ConnectType
{
	NOT_CONNECTED = 0,
	CONNECTED = 1,
	CONNECTED_ON = 2,
}

public enum ClassBoardEffectListDialog.DispSkillType
{
	ALL = 0,
	PASSIVE_ONLY = 1,
	COMMAND_SPELL_ONLY = 2,
}

private enum ClassBoardLine.ConnectType
{
	NOT_CONNECTED = 0,
	CONNECTED = 1,
	CONNECTED_ON = 2,
}

private enum ClassBoardPageSwitcher.ViewType
{
	NONE = 0,
	BOARD_SELECT = 1,
	BOARD_MAIN = 2,
}

public enum AcquireFlag
{
	AVAILABLE = 0,
	ACQUIRED = 1,
	NOT_LINE_CONNECTED = 2,
	NOT_CONDITION = 4,
	ITEM_SHORTAGE = 8,
	LOCK_ITEM_SHORTAGE = 16,
}

private enum CoinBulkSelectDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

private enum CoinConfirmDialog.State
{
	INIT = 0,
	OPEN = 1,
	CLOSE = 2,
}

private enum CoinConfirmSliderDialog.State
{
	INIT = 0,
	OPEN = 1,
	CLOSE = 2,
}

public enum CoinRoomCoinIconDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum CoinRoomCoinIconObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	MODIFY = 4,
	INTO = 5,
	ENTER = 6,
	EXIT = 7,
}

protected enum CoinRoomCoinIconObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum CoinRoomCoinListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
	MODIFY = 3,
}

public enum CoinRoomCoinListViewManager.ResultKind
{
	NONE = 0,
	ITEM_DETAIL = 1,
	SELECT_DETAIL = 2,
}

protected enum CoinRoomEffectComponent.State
{
	INIT = 0,
	EFFECT = 1,
	CLOSE = 2,
}

protected enum CoinRoomGaugeEffectComponent.State
{
	INIT = 0,
	PLAY = 1,
	END = 2,
}

protected enum CoinRoomRootComponent.State
{
	INIT = 0,
	SELECT_COIN = 1,
}

protected enum CoinRoomSelectCoinComponent.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	CLOSE = 3,
}

public enum CoinRoomSortSelectManager.Kind
{
	COIN_ROOM_SORT = 0,
	COIN_ROOM_FILTER = 1,
}

protected enum CoinRoomSortSelectManager.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

private enum AppendSkillCombineControl.STATUS
{
	NONE = 0,
	LOCK = 1,
	NORMAL = 2,
	MAX = 3,
}

public enum CombineEffectComponent.Kind
{
	SERVANT = 0,
	SKILL = 1,
	DVC = 2,
	SVTEQ = 3,
}

private enum CombineEffectComponent.CardColor
{
	BRONZE = 0,
	SILVER = 1,
	GOLD = 2,
}

public enum CombineListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum CombineListViewManager.Kind
{
	NORMAL = 0,
}

public enum CombineListViewManager.InitMode
{
	NONE = 0,
	INPUT = 1,
}

public enum CombineListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	FADEIN = 3,
	INPUT = 4,
	INTO = 5,
	ENTER = 6,
	EXIT = 7,
	RETRY = 8,
}

protected enum CombineListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum CombineMenuControl.TargetType
{
	BASE_STATUS = 0,
	MATERIAL_SELECT = 1,
	MATERIAL_STATUS = 2,
}

public enum CombineRootComponent.MenuState
{
	NON = 0,
	MENU_TOP = 1,
	BASE_SELECT = 2,
	MATERIAL_SELECT = 3,
	COMMAND_CODE_SELECT = 4,
}

public enum CombineRootComponent.State
{
	INIT = 0,
	INIT_TOP = 1,
	HELP = 2,
	SVT_COMBINE = 3,
	SVTEQ_COMBINE = 4,
	LIMIT_UP = 5,
	LV_EXCEED = 6,
	SPECIAL_ASCENSION = 7,
	SVT_COSTUME = 8,
	COMMAND_CODE = 9,
	SKILL_COMBINE = 10,
	NP_COMBINE = 11,
	FRIENDSHIP = 12,
	COMMAND_CARD_EXCEED = 13,
	APPEND_SKILL = 14,
	CLASS_BOARD = 15,
}

public enum CombineRootComponent.StateType
{
	SELECT_BASE = 0,
	SELECT_MATERIAL = 1,
	EXE_COMBINE = 2,
	SELECT_COSTUME = 3,
	SELECT_COMMAND_CARD = 4,
	SELECT_COMMAND_CODE = 5,
}

public enum CombineRootComponent.CombineTutorialProgress
{
	TOP_SVT_COMBINE = 0,
	COMBINE_BASE = 1,
	LIST_SELECT_BASE = 2,
	COMBINE_MATERIAL = 3,
	LIST_SELECT_MATERIAL = 4,
	LIST_DICTION_BUTTON = 5,
	COMBINE_DICTION_BUTTON = 6,
	COMBINE_COMFIRM_DIALOG = 7,
	COMBINE_CLOSE_BUTTON = 8,
	TOP_CLOSE_BUTTON = 9,
}

public enum CombineCommandCardComponent.Kind
{
	LOCK = 0,
	UNLOCK_NOT_EQUIP = 1,
	EQUIPED = 2,
}

public enum CombineCommandCodeListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum CombineCommandCodeListViewManager.ModeKind
{
	NORMAL = 0,
	LOCK = 1,
	CHOICE = 2,
}

public enum CombineCommandCodeListViewManager.InitMode
{
	NONE = 0,
	INTO = 1,
	VALID = 2,
	INPUT = 3,
	ENTER = 4,
	EXIT = 5,
	MODIFY = 6,
}

public enum CombineCommandCodeListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

protected enum CombineCommandCodeListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	INPUT = 2,
}

protected enum CommandCardDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	CLOSE = 3,
}

public enum CombineInfoComponent.DispType
{
	SVT_COMBINE = 0,
	LIMITCNT_UP = 1,
	SVTEQ_COMBINE = 2,
	LEVEL_EXCEED = 3,
	SPECIAL_ASCENTION = 4,
}

public enum RecommendedConfigSaveData.ClassType
{
	MIX = 0,
	ALL = 1,
	TARGET = 2,
}

public enum FriendshipExceedFriendshipGauge.Type
{
	Normal = 0,
	Disable = 1,
	Exceeded = 2,
}

public enum CombineHelpListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
}

public enum CombineHelpListViewManager.ItemKind
{
	COMBINE = 1,
	COMBINE_SKILL = 2,
	COMBINE_SVT_EQ = 3,
	COMBINE_LIMIT = 4,
	COMBINE_NP = 5,
	COMBINE_LV_EXCEED = 6,
	COMBINE_COSTUME = 7,
	COMBINE_CMD_CODE = 8,
	COMBINE_FRIENDSHIP_EXCEED = 9,
	COMBINE_SPECIAL_ASCENSION = 10,
	COMBINE_CMD_CARD_EXCEED = 11,
	COMBINE_APPEND_SKILL = 12,
	COMBINE_CLASS_BOARD = 13,
	COMBINE_BLANK = 14,
}

public enum CombineHelpListViewManager.InitMode
{
	NONE = 0,
	LOADING = 1,
	LOADED = 2,
}

public enum CombineHelpListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

protected enum CombineHelpListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum MenuListControl.CombineKind
{
	SVT_COMBINE = 0,
	SKILL_COMBINE = 1,
	SVTEQ_COMBINE = 2,
	LIMIT_UP = 3,
	SPECIAL_ASCENSION = 4,
	FRIENDSHIP = 5,
	COMMAND_CODE = 6,
	COMMAND_CARD_EXCEED = 7,
	APPEND_SKILL = 8,
	NP_COMBINE = 9,
	LV_EXCEED = 10,
	SVT_COSTUME = 11,
	CLASS_BOARD = 12,
}

public enum CombineResultEffectComponent.Kind
{
	SVT_COMBINE = 0,
	LIMITUP = 1,
	SKILL_LEVELUP = 2,
	SKILLOPEN = 3,
	TREASUREDVC_LEVELUP = 4,
	TREASUREDVCOPEN = 5,
	SVTEQ_COMBINE = 6,
	SKILL_RANKUP = 7,
	TREASUREDVC_RANKUP = 8,
	FRIENDSHIP_UP = 9,
	MATERIAL_LIMIT_UP = 10,
	POWER_UP = 11,
	LV_EXCEED = 12,
	FRIENDSHIP_EXCEED = 13,
	NAME_REVEAL = 14,
	COSTUME_COMBINE = 15,
	SECRET_TREASURE_DEVICE_QUEST_CLEAR = 16,
	SECRET_TREASURE_DEVICE_SVT_GET = 17,
	SECRET_TREASURE_RANKUP = 18,
	SPECIAL_ASCENSION = 19,
	COMMAND_CARD_EXCEED = 20,
	SKILL_RANKUP_DUMMY = 21,
	LV_EXCEED_HEROINE = 22,
	FRIENDSHIP_EXCEED_HEROINE = 23,
	SVT_COMBINE_LIMIT = 24,
	APPEND_SKILL = 25,
	UNSEAL_LIMIT_UP = 26,
	TREASUREDVC_RANKUP_DUMMY = 27,
}

protected enum SkillUpResultWindowComponent.State
{
	INIT = 0,
}

protected enum SvtCombineResultWindowComponent.SuccessInfo
{
	NORMAL = 1,
	LARGE_SUCCESS = 2,
	SUPER_SUCCESS = 3,
}

private enum CheckMaterialSvtEquippedDialog.State
{
	INIT = 0,
	INPUT = 1,
	OPEN = 2,
}

private enum CheckMaterialSvtListViewItem.Type
{
	NONE = 0,
	SERVANT = 1,
	COMMAND_CODE = 2,
}

private enum CheckMaterialSvtListViewItem.ServantAttributeKind
{
	NONE = 0,
	HEROINE = 1,
	LIMITED = 2,
}

public enum CheckMaterialSvtListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum CheckMaterialSvtListViewManager.Kind
{
	SERVANT = 0,
	SERVANT_EQUIP = 1,
	COMMAND_CODE = 2,
	SELL = 3,
}

public enum CheckMaterialSvtListViewManager.ModeKind
{
	SELECT = 0,
	LOCK = 1,
	CHOICE = 2,
}

public enum CheckMaterialSvtListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
}

public enum CheckMaterialSvtListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	MODIFY = 4,
}

private enum CheckMaterialSvtListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

protected enum RecommenededConfigDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	CLOSE = 3,
}

private enum ServantCombineControl.ConductionType
{
	NONE = 0,
	LIMIT_UP = 1,
	LVEXCEED = 2,
}

protected enum ServantCombineResultInfoComponent.State
{
	INIT = 0,
}

public enum CostumeListViewItem.Type
{
	CLEAR_CONDITION = 0,
	NOT_CLEAR_CONDITION = 1,
	NOT_HAVING_RELEASE_ITEM = 2,
	ALREADY_GET = 3,
	EVENT_COSTUME_CLEAR_CONDITION = 4,
	EVENT_COSTUME_NOT_CLEAR_CONDITION = 5,
}

public enum CostumeListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum CostumeListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
}

public enum CostumeListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

protected enum CostumeListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	INPUT = 2,
}

protected enum CombineLimitUpWarningDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	CLOSE = 3,
}

public enum CombineServantListViewItem.Type
{
	BASE = 0,
	MATERIAL = 1,
	LIMITUP_BASE = 2,
	SKILL_BASE = 3,
	NP_BASE = 4,
	NP_MATERIAL = 5,
	LVEXCEED_BASE = 6,
	COMMANDCARD_BASE = 7,
	FRIENDSHIP_EXCEED_BASE = 8,
	SPECIAL_ASCENSION_BASE = 9,
	COMMAND_CARD_EXCEED_BASE = 10,
	APPEND_SKILL_BASE = 11,
	SUM = 12,
}

public enum CombineServantListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum CombineServantListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
	MODIFY = 3,
}

public enum CombineServantListViewManager.ResultKind
{
	NONE = 0,
	SELECT_LIST = 1,
	SERVANT_STATUS = 2,
}

public enum CombineServantListViewManager.ModeKind
{
	NORMAL = 0,
	LOCK = 1,
	CHOICE = 2,
	PUSH = 3,
}

public enum CombineServantListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	MODIFY = 4,
}

protected enum CombineServantListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum SetRarityDialogControl.DispType
{
	IS_RARE = 0,
	EXE_COMBINE = 1,
	SHOW_CONFIRM = 2,
	SHORT_QP = 3,
}

public enum ServantCostumeListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum ServantCostumeListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
}

public enum ServantCostumeListViewManager.ResultKind
{
	NONE = 0,
	SERVANT_STATUS = 1,
}

public enum ServantCostumeListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	MODIFY = 4,
}

public enum ServantCostumeListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum SvtEqCombineListViewItem.Type
{
	SVTEQ_BASE = 0,
	SVTEQ_MATERIAL = 1,
	SUM = 2,
}

public enum SvtEqCombineListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum SvtEqCombineListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
	MODIFY = 3,
}

public enum SvtEqCombineListViewManager.ResultKind
{
	NONE = 0,
	SELECT_LIST = 1,
	SERVANT_STATUS = 2,
}

public enum SvtEqCombineListViewManager.ModeKind
{
	NORMAL = 0,
	LOCK = 1,
	CHOICE = 2,
}

public enum SvtEqCombineListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	FADEIN = 3,
	INPUT = 4,
	MODIFY = 5,
}

protected enum SvtEqCombineListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum EndrolContentItem.displayObjectType
{
	NONE = 0,
	TEXT = 1,
	IMAGE = 2,
	COLUMN_TEXT_2 = 3,
	COLUMN_TEXT_3 = 4,
}

private enum EndrolRootComponent.textType
{
	NONE = 0,
	TEXT = 1,
	IMAGE = 2,
	ORDER = 3,
	DESIGN_TEXT = 4,
	COLUMN_TEXT = 5,
}

protected enum EventConquestGetDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	CLOSE = 3,
}

public enum EventSpotMoveManager.STATE
{
	NONE = 0,
	MOVE = 1,
}

protected enum EventBoardGameTokenInfoDialog.State
{
	INIT = 0,
	OPEN = 1,
}

public enum EventExpeditionListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	VALID = 1,
	IMPOSSIBLE_SELECTION = 2,
	RUNNING = 3,
	COMPLETE = 4,
}

public enum EventExpeditionListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	INTO = 4,
	ENTER = 5,
	EXIT = 6,
	MODIFY = 7,
}

private enum ExpeditionPointRewardDialogComponent.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	CLOSE = 3,
}

private enum ExpeditionRewardDialogComponent.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	CLOSE = 3,
}

private enum HakkenshiAnimationPlayer.State
{
	STAY = 0,
	ACTION = 1,
}

public enum EventFortificationDataLogic.SvtType
{
	USER_SVT = 0,
	NPC = 1,
	NONE = 2,
}

public enum EventFortificationListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum EventFortificationListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
	MODIFY = 3,
}

public enum EventFortificationListViewManager.ResultKind
{
	NONE = 0,
	SERVANT_STATUS = 1,
}

public enum EventFortificationListViewManager.ModeKind
{
	NORMAL = 0,
	LOCK = 1,
	CHOICE = 2,
	PUSH = 3,
}

public enum EventFortificationListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	MODIFY = 4,
}

public enum EventFortificationListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

private enum FortificationAutomaticDialogComponent.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

private enum FortificationConfirmDialogComponent.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum FortificationConfirmDialogComponent.DialogType
{
	SET = 0,
	REMOVE = 1,
	CHANGE = 2,
}

private enum FortificationNotifyDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

private enum FortificationWarningDialogComponent.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum BoxGachaItemListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum BoxGachaItemListViewManager.InitMode
{
	NONE = 0,
	INTO = 1,
	INPUT = 2,
	ENTER = 3,
	EXIT = 4,
	MODIFY = 5,
}

public enum BoxGachaItemListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	INTO = 4,
	ENTER = 5,
	EXIT = 6,
	MODIFY = 7,
}

protected enum BoxGachaItemListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum EventMissionItemListViewManager.FilterStatus
{
	INIT = 0,
	CLEAR = 1,
	PROGRESS = 2,
	NOTOPEN = 3,
	ACHIVE = 4,
}

private enum EventSvtControl.PerformanceTiming
{
	BEFORE = 0,
	START = 1,
	AFTER = 2,
}

public enum EventPointItemListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum EventPointItemListViewManager.InitMode
{
	NONE = 0,
	INTO = 1,
	INPUT = 2,
	ENTER = 3,
	EXIT = 4,
	MODIFY = 5,
}

public enum EventPointItemListViewManager.Kind
{
	NORMAL = 0,
}

public enum EventPointItemListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	INTO = 4,
	ENTER = 5,
	EXIT = 6,
	MODIFY = 7,
}

protected enum EventPointItemListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

private enum ResultListWindow.State
{
	INIT = 0,
}

private enum HeelPortraitDetailDialogComponent.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum EventRandomMissionListViewManager.FilterStatus
{
	INIT = 0,
	CLEAR = 1,
	PROGRESS = 2,
	NOTOPEN = 3,
	ACHIVE = 4,
}

public enum EventRankingListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum EventRankingListViewManager.InitMode
{
	NONE = 0,
	INTO = 1,
	VALID = 2,
	INPUT = 3,
	ENTER = 4,
	EXIT = 5,
	MODIFY = 6,
}

public enum EventRankingListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	INTO = 4,
}

protected enum EventRankingListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

private enum EventRecipeConfirmDialogComponent.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum EventRecipeListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum EventRecipeListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	INTO = 4,
	ENTER = 5,
	EXIT = 6,
	MODIFY = 7,
}

private enum EventRecipeListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

private enum RecipePointRewardDialogComponent.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	CLOSE = 3,
}

private enum RecipeRewardDialogComponent.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	CLOSE = 3,
}

private enum CommandAssistLvUpDialogComponent.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

private enum AutoDiggingDialogComponent.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	CLOSE = 3,
}

private enum DiggingConfirmDialogComponent.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	CLOSE = 3,
}

private enum DiggingManager.DiggingAnimationKind
{
	SHOVELT_ANIMATION = 0,
	PICKAXET_ANIMATION = 1,
	HAMMERT_ANIMATION = 2,
}

private enum DiggingPointRewardDialogComponent.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	CLOSE = 3,
}

private enum DiggingRewardDialogComponent.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	CLOSE = 3,
}

private enum EventPointRewardDialog.State
{
	INIT = 0,
	INPUT = 1,
	OPEN = 2,
}

private enum EventRewardAnotherPayConfirmDialog.State
{
	INIT = 0,
	INPUT = 1,
	OPEN_BASE = 2,
	OPEN_CHOICES = 3,
	OPEN_PURCHASED = 4,
	OPEN_RESULT = 5,
}

public enum EventRewardAnotherPayConfirmDialog.BuyState
{
	Cancel = 0,
	Decide = 1,
	Normal = 2,
	Another = 3,
}

private enum EventRewardAssistConfirmDialog.State
{
	INIT = 0,
	INPUT = 1,
	OPEN = 2,
}

public enum EventRewardButtonChangeManager.SlotIndex
{
	Slot1 = 0,
	Slot2 = 1,
	Slot3 = 2,
	Slot4 = 3,
}

public enum EventRewardRootComponent.StateType
{
	NONE = 0,
	EVENT_POINT = 1,
	EVENT_GACHA = 2,
	EXE_GACHA = 3,
	EVENT_MISSION = 4,
	EVENT_RAID = 5,
	EVENT_SHOP = 6,
	EVENT_RANKING = 7,
	EVENT_TOWER = 8,
	RECOVERY_FATIGUE = 9,
	EVENT_BOARD_GAME_TOKEN = 10,
	EVENT_TREASURE = 11,
	EVENT_RANDOM = 12,
	EVENT_DIGGING = 13,
	EVENT_EXPEDITION = 14,
	EVENT_RECIPE = 15,
	EVENT_FORTIFICATION = 16,
	EVENT_HEEL_PORTRAIT = 17,
}

private enum EventRewardRootComponent.VoiceIndexEnum
{
	WELCOME = 0,
	PURCHASE = 1,
}

private enum EventRewardRootComponent.VoiceTypeAfterTutorial
{
	NONE = 0,
	SERVANT_VOICE = 1,
	WELCOME_VOICE = 2,
}

protected enum EventRewardRootComponent.State
{
	INIT = 0,
	INIT_TOP = 1,
	INPUT_TOP = 2,
	INPUT_EVENT = 3,
	QUIT_EVENT = 4,
	INIT_BUY_EVENT_ITEM = 5,
	INPUT_BUY_EVENT_ITEM = 6,
	QUIT_BUY_EVENT_ITEM = 7,
	INIT_BUY_EVENT_ITEM_CONFIRM = 8,
	INPUT_BUY_EVENT_ITEM_CONFIRM = 9,
	QUIT_BUY_EVENT_ITEM_CONFIRM = 10,
	START_HELP = 11,
}

private enum LotteryShopBulkResultDialog.State
{
	OPEN = 0,
	CLOSE = 1,
}

private enum LotteryShopBuyItemConfirmMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

private enum PresentBoxInfoComponent.BOX_STATE
{
	EMPTY = 0,
	MANY = 1,
	ALMOST_FULL = 2,
	MAX = 3,
}

protected enum PresentBoxOverDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum EventServantFatigueListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum EventServantFatigueListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
	MODIFY = 3,
}

public enum EventServantFatigueListViewManager.ResultKind
{
	NONE = 0,
	SERVANT_STATUS = 1,
}

public enum EventServantFatigueListViewManager.ModeKind
{
	NORMAL = 0,
	LOCK = 1,
	CHOICE = 2,
	PUSH = 3,
}

public enum EventServantFatigueListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	MODIFY = 4,
}

public enum EventServantFatigueListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum EventSpotCooltimeComponent.ReceivableRewardState
{
	None = 0,
	RewardExists = 1,
	MaxRewardExists = 2,
}

private enum SpotCooltimeRewardDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	CLOSE = 3,
}

public enum EventTowerListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum EventTowerListViewManager.InitMode
{
	NONE = 0,
	INTO = 1,
	VALID = 2,
	INPUT = 3,
	ENTER = 4,
	EXIT = 5,
	MODIFY = 6,
}

public enum EventTowerListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	INTO = 4,
}

protected enum EventTowerListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

private enum TreasureBoxBulkBuyConfirmMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum TreasureBoxDialogComponent.DialogType
{
	TreasureBoxLineupDialog = 0,
	GetTreasureBoxItemDialog = 1,
	GetEventPointRewardDialog = 2,
}

protected enum FollowerRootComponent.TutorialMode
{
	NONE = 0,
	SELECT_NONE = 1,
	FRIEND = 2,
	NPC = 3,
	MY_SVT_OR_NPC = 4,
}

protected enum FollowerRootComponent.TutorialState
{
	NONE = 0,
	INIT = 1,
	SELECT = 2,
}

protected enum FollowerRootComponent.State
{
	INIT = 0,
	INIT_TOP = 1,
	INIT_SHOW_FOLLOWER = 2,
	INPUT_SHOW_FOLLOWER = 3,
	QUIT_SHOW_FOLLOWER = 4,
	BATTLE_SETUP_SCENE = 5,
	SUPPORT_SHOW_SCENE = 6,
}

public enum FollowerSelectItemListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	TUTORIAL_INPUT = 4,
}

public enum FollowerSelectItemListViewManager.InitMode
{
	NONE = 0,
	INTO = 1,
	INPUT = 2,
	MODIFY = 3,
	NPC_GUIDE_FIRST_SELECT = 4,
}

public enum FollowerSelectItemListViewManager.ResultKind
{
	NONE = 0,
	SERVANT_STATUS = 1,
	SERVANT_SKILL1_STATUS = 2,
	SERVANT_SKILL2_STATUS = 3,
	SERVANT_SKILL3_STATUS = 4,
	SUPPORT_INFO = 5,
	SERVANT_EQUIP_STATUS = 6,
	REFRESH = 7,
	SERVANT_APPEND_SKILL1_STATUS = 8,
	SERVANT_APPEND_SKILL2_STATUS = 9,
	SERVANT_APPEND_SKILL3_STATUS = 10,
	SERVANT_APPEND_SKILL4_STATUS = 11,
	SERVANT_APPEND_SKILL5_STATUS = 12,
}

public enum FollowerSelectItemListViewManager.DisplaySkill
{
	NORMAL = 0,
	APPEND = 1,
	BOTH = 2,
}

public enum FollowerSelectItemListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	INTO = 4,
	MODIFY = 5,
	TUTORIAL_INPUT = 6,
}

protected enum FollowerSelectItemListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
	TUTORIAL_INPUT = 4,
}

private enum FormationRootComponent.MENUTYPE
{
	MAIN = 0,
	MASTER_FORMATION = 1,
	SERVANT_FORMATION = 2,
	SERVANT_LIST = 3,
}

public enum FriendOperationConfirmMenu.Kind
{
	NONE = 0,
	OFFER = 1,
	ACCEPT = 2,
	REJECT = 3,
	CANCEL = 4,
	REMOVE = 5,
	FOLLOW = 6,
	FOLLOW_REMOVE = 7,
}

protected enum FriendOperationConfirmMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum FriendOperationItemListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum FriendOperationItemListViewManager.InitMode
{
	NONE = 0,
	INTO = 1,
	INPUT = 2,
	ENTER = 3,
	EXIT = 4,
	MODIFY = 5,
}

public enum FriendOperationItemListViewManager.ResultKind
{
	NONE = 0,
	SERVANT_SKILL1_STATUS = 1,
	SERVANT_SKILL2_STATUS = 2,
	SERVANT_SKILL3_STATUS = 3,
	OFFER = 4,
	ACCEPT = 5,
	REJECT = 6,
	CANCEL = 7,
	REMOVE = 8,
	BLACKLIST_REGIST = 9,
	BLACKLIST_REMOVE = 10,
	MESSAGE_DISP = 11,
	SERVANT_EQUIP_STATUS = 12,
	SERVANT_APPEND_SKILL1_STATUS = 13,
	SERVANT_APPEND_SKILL2_STATUS = 14,
	SERVANT_APPEND_SKILL3_STATUS = 15,
	SERVANT_APPEND_SKILL4_STATUS = 16,
	SERVANT_APPEND_SKILL5_STATUS = 17,
}

public enum FriendOperationItemListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	INTO = 4,
	ENTER = 5,
	EXIT = 6,
	MODIFY = 7,
}

protected enum FriendOperationItemListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum FriendRootComponent.TabKind
{
	FRIEND = 0,
	OFFERED = 1,
	SEARCH = 2,
	DEFAULT = 3,
}

public enum FriendRootComponent.OfferState
{
	NONE = 0,
	CANCEL = 1,
	FRIEND_OFFER = 2,
	FOLLOW = 3,
}

protected enum FriendRootComponent.State
{
	INIT = 0,
	INIT_TOP = 1,
	INIT_SHOW_FRIEND = 2,
	INIT_SHOW_FRIEND2 = 3,
	INPUT_SHOW_FRIEND = 4,
	QUIT_SHOW_FRIEND = 5,
	QUIT_SHOW_FRIEND2 = 6,
	INIT_SHOW_OFFER = 7,
	INIT_SHOW_OFFER2 = 8,
	INPUT_SHOW_OFFER = 9,
	QUIT_SHOW_OFFER = 10,
	QUIT_SHOW_OFFER2 = 11,
	INIT_SHOW_OFFERED = 12,
	INIT_SHOW_OFFERED2 = 13,
	INPUT_SHOW_OFFERED = 14,
	QUIT_SHOW_OFFERED = 15,
	QUIT_SHOW_OFFERED2 = 16,
	INIT_SHOW_SEARCH = 17,
	INIT_SHOW_SEARCH2 = 18,
	INPUT_SHOW_SEARCH = 19,
	QUIT_SHOW_SEARCH = 20,
	QUIT_SHOW_SEARCH2 = 21,
	INIT_SEARCH_FRIEND = 22,
	INPUT_SEARCH_FRIEND = 23,
	QUIT_SEARCH_FRIEND = 24,
	QUIT_SEARCH_FRIEND2 = 25,
	INIT_FRIEND_OFFER_CONFIRM = 26,
	INPUT_FRIEND_OFFER_CONFIRM = 27,
	QUIT_FRIEND_OFFER_CONFIRM = 28,
	INPUT_FRIEND_OFFER_CONFIRM_MAX_FRIEND = 29,
	INIT_FRIEND_ACCEPT_CONFIRM = 30,
	INPUT_FRIEND_ACCEPT_CONFIRM = 31,
	QUIT_FRIEND_ACCEPT_CONFIRM = 32,
	INIT_FRIEND_REJECT_CONFIRM = 33,
	INPUT_FRIEND_REJECT_CONFIRM = 34,
	QUIT_FRIEND_REJECT_CONFIRM = 35,
	INIT_FRIEND_CANCEL_CONFIRM = 36,
	INPUT_FRIEND_CANCEL_CONFIRM = 37,
	QUIT_FRIEND_CANCEL_CONFIRM = 38,
	INIT_FRIEND_REMOVE_CONFIRM = 39,
	INPUT_FRIEND_REMOVE_CONFIRM = 40,
	QUIT_FRIEND_REMOVE_CONFIRM = 41,
	INPUT_FOLLOW_OFFER_CONFIRM = 42,
	INPUT_FOLLOW_OFFER_CONFIRM_MAX_FOLLOW = 43,
	INPUT_FOLLOW_OFFER_CONFIRM_ALREADY_FOLLOW = 44,
	INPUT_FOLLOW_REMOVE_CONFIRM = 45,
}

public enum FriendRootComponent.ModeKind
{
	USER_DETAIL = 0,
	EDIT_LOCK = 1,
}

protected enum FriendSearchMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

protected enum FriendSearchResultMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum FriendWarningDialog.Kind
{
	NONE = 0,
	MAX_FRIEND = 1,
	NO_SEARCH = 2,
	NO_STRING = 3,
	NO_OFFER = 4,
	NO_OFFERED = 5,
	NO_FRIEND = 6,
	MAX_FOLLOW = 7,
}

protected enum FriendWarningDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum MyRoomBackGroundManager.LoadType
{
	None = 0,
	BackGround = 1,
	BackObject = 2,
	All = 3,
}

public enum BlacklistRootComponent.MODE
{
	FRIEND_HISTORY = 0,
	BLACKLIST = 1,
}

protected enum ContinueDeviceComponent.State
{
	INIT = 0,
	INPUT_PASSWARD = 1,
	CONFIRM_PASSEWARD = 2,
	REQUEST_PASSWARD = 3,
	OUTPUT_CONTINUE_CODE = 4,
	CONFIRM_RETRY = 5,
	CLOSE = 6,
}

protected enum ContinueDeviceDispMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

protected enum ContinueDeviceInputMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum FavoriteChangeComponent.ModeKind
{
	NORMAL = 0,
	LOCK = 1,
	CHOICE = 2,
	PUSH = 3,
	SUM = 4,
}

protected enum FavoriteChangeComponent.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
	SHOW_STATUS = 5,
	WARNING = 6,
}

public enum FavoriteChangeListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum FavoriteChangeListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
	MODIFY = 3,
}

public enum FavoriteChangeListViewManager.ResultKind
{
	CANCEL = 0,
	DECIDE = 1,
	SHOW_STATUS = 2,
	SELECT = 3,
}

public enum FavoriteChangeListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	MODIFY = 4,
}

protected enum FavoriteChangeListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum SetGameOptionComponent.SceneType
{
	OPTION_TOP = 0,
	BLACKLIST = 1,
}

protected enum ItemDetailInfoComponent.State
{
	INIT = 0,
	NORMALOPEN = 1,
	STONEOPEN = 2,
	STONEINFO = 3,
}

public enum UserItemListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum UserItemListViewManager.InitMode
{
	NONE = 0,
	INPUT = 1,
}

public enum UserItemListViewManager.Type
{
	STONE = 1,
	TICKET = 2,
	MANA = 3,
	SKILLUP = 4,
	TDUP = 5,
}

public enum UserItemListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

protected enum UserItemListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

protected enum ChangeGenderTypeWindow.State
{
	INIT = 0,
	OPEN = 1,
	CLOSE = 2,
}

protected enum ChangeUserNameWindow.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	CLOSE = 3,
}

protected enum InputUserBirthDayConfirmWindow.State
{
	INIT = 0,
	OPEN = 1,
	CLOSE = 2,
}

protected enum InputUserBirthDayWindow.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	CLOSE = 3,
}

public enum MaterialCollectionMenu.TabKind
{
	SERVANT = 0,
	SERVANT_EQUIP = 1,
	COMMAND_CODE = 2,
	SUM = 3,
}

protected enum MaterialCollectionMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum MaterialCollectionMenu.ResultKind
{
	CLOSE = 0,
	SERVANT_QUEST = 1,
}

private enum MaterialCollectionServantListViewItem.IsCanSelectFlag
{
	NONE = 0,
	LINK_LOST = 1,
	DATA_LOST = 2,
	LINK_BAD = 4,
}

public enum MaterialCollectionServantListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum MaterialCollectionServantListViewManager.Kind
{
	SERVANT = 0,
	SERVANT_EQUIP = 1,
	SERVANT_COSTUME = 2,
	COMMAND_CODE = 3,
}

public enum MaterialCollectionServantListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
}

public enum MaterialCollectionServantListViewManager.ResultKind
{
	NONE = 0,
	SERVANT_STATUS = 1,
}

public enum MaterialCollectionServantListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	MODIFY = 4,
	INTO = 5,
	ENTER = 6,
	EXIT = 7,
}

protected enum MaterialCollectionServantListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum MaterialCollectionServantSortSelectMenu.Kind
{
	SERVANT = 0,
	SERVANT_EQUIP = 1,
	SERVANT_COSTUME = 2,
	COMMAND_CODE = 3,
}

protected enum MaterialCollectionServantSortSelectMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum MaterialCostumeMenu.TabKind
{
	SERVANT = 0,
	SERVANT_EQUIP = 1,
	SUM = 2,
}

protected enum MaterialCostumeMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum MaterialCostumeServantListViewItem.CostumeOpenStatus
{
	NOT_OPEN = 0,
	OPEN = 1,
	FULL_OPEN = 2,
}

public enum MaterialCostumeServantListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum MaterialCostumeServantListViewManager.Kind
{
	COSTUME = 0,
}

public enum MaterialCostumeServantListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
}

public enum MaterialCostumeServantListViewManager.ResultKind
{
	NONE = 0,
	COSTUME_STATUS = 1,
}

public enum MaterialCostumeServantListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	MODIFY = 4,
	INTO = 5,
	ENTER = 6,
	EXIT = 7,
}

protected enum MaterialCostumeServantListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum MaterialCostumeServantSortSelectMenu.Kind
{
	SERVANT_COSTUME = 0,
}

protected enum MaterialCostumeServantSortSelectMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum MaterialEventLogListViewItem.Kind
{
	TOP = 0,
	MAP = 1,
	STORY = 2,
	EVENT = 3,
	FREE = 4,
	QUEST = 5,
	SIZEOF = 6,
}

public enum MaterialEventLogListViewItem.Flag
{
	NONE = 0,
	NOPLAY_DECIDE_SE = 1,
	SVT_FACE = 2,
	PLAY_WARNING_SE = 4,
}

public enum MaterialEventLogListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum MaterialEventLogListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
	INTO = 3,
	EXIT = 4,
}

public enum MaterialEventLogListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

protected enum MaterialEventLogListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	INPUT = 2,
}

public enum MaterialEventLogServantListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
	INTO = 3,
	EXIT = 4,
}

public enum MaterialEventLogServantSortSelectMenu.Kind
{
	SERVANT = 0,
	SERVANT_EQUIP = 1,
	SERVANT_COSTUME = 2,
	COMMAND_CODE = 3,
}

protected enum MaterialEventLogServantSortSelectMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum MultipleViewComponent.ModeKind
{
	NORMAL = 0,
	LOCK = 1,
	CHOICE = 2,
	PUSH = 3,
	SUM = 4,
}

protected enum MultipleViewComponent.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
	SHOW_STATUS = 5,
	WARNING = 6,
}

public enum MultipleViewListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum MultipleViewListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
	MODIFY = 3,
}

public enum MultipleViewListViewManager.ResultKind
{
	CANCEL = 0,
	SHOW_STATUS = 1,
	SELECT = 2,
}

public enum MultipleViewListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	MODIFY = 4,
}

protected enum MultipleViewListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

protected enum SelectImageLimitDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	CLOSE = 3,
}

public enum SelectImageLimitListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum SelectImageLimitListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
	MODIFY = 3,
}

public enum SelectImageLimitListViewManager.ResultKind
{
	CANCEL = 0,
	SELECT = 1,
}

public enum SelectImageLimitListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	MODIFY = 4,
}

protected enum SelectImageLimitListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

private enum MyRoomControl.MENUTYPE
{
	MAIN = 0,
	MATERIAL = 1,
	MATERIAL_COLLECTION = 2,
	ITEM = 3,
	PROFILE = 4,
	OPTION = 5,
	NOTICE = 6,
	SERIALCODE = 7,
	CONTINUEDEVICE = 8,
	FAVORITE_CHANGE = 9,
	SOUND_PLAYER = 10,
	MATERIAL_COSTUME = 11,
	MATERIAL_MAIN_QUEST = 12,
	MATERIAL_MAIN_QUEST_PART = 13,
	MATERIAL_EVENT_QUEST = 14,
	MATERIAL_SERVANT = 15,
	MATERIAL_MAIN_INTERLUDE = 16,
	SERVANT_COIN = 17,
	ACCOUNT_LINKAGE = 18,
}

public enum MyRoomControl.STATE
{
	MATERIAL = 0,
	ETC = 1,
	SIZEOF = 2,
}

public enum MyRoomControl.MVSTATE
{
	INIT = 0,
	SVT_AND_UI = 1,
	ONLY_SVT = 2,
	ONLY_BG = 3,
}

public enum MyRoomControl.MULTIPLEVIEWSTATE
{
	INIT = 0,
	SELECT_SERVANT = 1,
	SERVANT_AND_UI = 2,
	SERVANT = 3,
}

private enum MyRoomControl.PHOTOCAMPAIGNSTATE
{
	INIT = 0,
	SELECT_SERVANT = 1,
	PHOTO_TARGET_AND_UI = 2,
	HIDE_UI = 3,
	PHOTO_ONLY_SERVANT = 4,
	FULL_DISP_SERVANT = 5,
	PHOTO_WITH_MASTER = 6,
	CHANGE_SERVANT = 7,
}

public enum MyRoomControl.PHOTOCAMPAIGNTYPE
{
	ONLY_SERVANT = 0,
	WITH_MASTER = 1,
}

public enum MyRoomControl.PHOTOMASTERPOSITION
{
	LEFT = 1,
	RIGHT = 2,
}

public enum MyRoomListControl.ActionType
{
	FSM = 0,
	BUTTON_METHOD = 1,
}

public enum MyRoomStateMaterial.STATE
{
	TOP = 0,
	MAINSTORY_TOP = 1,
	MAINSTORY_SUB = 2,
	SERVANT_MENU_TOP = 3,
	SERVANT_STORY = 4,
	EVENT = 5,
	FREE = 6,
	QUEST = 7,
	EVENT_SUB = 8,
	MAIN_INTERLUDE = 9,
	MAIN_INTERLUDE_SUB = 10,
	DUMMY_FOLDER = 11,
	SIZEOF = 12,
}

public enum MyRoomStateMaterial.FIXED_PARENT_WAR_ID
{
	NONE = 0,
	MAIN_STORY = 1,
	MAIN_INTERLUDE = 2,
	EVENT = 3,
	FREE = 4,
}

public enum MyRoomStateMaterial.SERVANTFACEICONTYPE
{
	STANDARD = 0,
	FACEICON = 1,
}

public enum MyRoomStateMaterial.SCENARIO
{
	STORY = 0,
	INDIVIDUAL = 1,
}

protected enum MasterEquipSettingDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	CLOSE = 3,
}

public enum MasterEquipSettingListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum MasterEquipSettingListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
	MODIFY = 3,
}

public enum MasterEquipSettingListViewManager.ResultKind
{
	CANCEL = 0,
	SELECT = 1,
}

public enum MasterEquipSettingListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	MODIFY = 4,
}

protected enum MasterEquipSettingListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum PhotoCampaignComponent.ModeKind
{
	NORMAL = 0,
	LOCK = 1,
	CHOICE = 2,
	PUSH = 3,
	SUM = 4,
}

protected enum PhotoCampaignComponent.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
	SHOW_STATUS = 5,
	WARNING = 6,
}

public enum PhotoCampaignListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum PhotoCampaignListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
	MODIFY = 3,
}

public enum PhotoCampaignListViewManager.ResultKind
{
	CANCEL = 0,
	SHOW_STATUS = 1,
	SELECT = 2,
}

public enum PhotoCampaignListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	MODIFY = 4,
}

protected enum PhotoCampaignListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

private enum PhotoTargetSelectDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum UserServantCoinListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum UserServantCoinListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
	MODIFY = 3,
}

public enum UserServantCoinListViewManager.ResultKind
{
	NONE = 0,
	ITEM_DETAIL = 1,
}

public enum UserServantCoinListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	MODIFY = 4,
	INTO = 5,
	ENTER = 6,
	EXIT = 7,
}

protected enum UserServantCoinListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

protected enum UserServantCoinMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum UserServantCoinSortSelectMenu.Kind
{
	SERVANT_COIN = 0,
}

protected enum UserServantCoinSortSelectMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum SoundPlayerListViewItem.OPEN_TYPE
{
	OPEN = 0,
	LOCK_ITEM = 1,
	LOCK = 2,
}

public enum SoundPlayerListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum SoundPlayerListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
	MODIFY = 3,
}

public enum SoundPlayerListViewManager.ResultKind
{
	CANCEL = 0,
	SELECT = 1,
	CHECK = 2,
}

public enum SoundPlayerListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	MODIFY = 4,
}

protected enum SoundPlayerListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

protected enum SoundPlayerMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum MyRoomHelpListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
}

public enum MyRoomHelpListViewManager.ItemKind
{
	MYROOM_HELP_MATERIAL_STORY = 1,
	MYROOM_HELP_MATERIAL_SERVANT = 2,
	MYROOM_HELP_ITEM = 3,
	MYROOM_HELP_SERVANT_COIN = 4,
	MYROOM_HELP_SOUND_PLAYER = 5,
	MYROOM_HELP_MST_PROFILE = 6,
	MYROOM_HELP_FAVORITE = 7,
	MYROOM_HELP_HELP = 8,
	MYROOM_HELP_OPTION = 9,
	MYROOM_HELP_TAKE_OVER = 10,
	MYROOM_HELP_ACCOUNT_LINKAGE = 11,
	MYROOM_HELP_RETURN_TITLE = 12,
	MYROOM_BLANK = 13,
}

public enum MyRoomHelpListViewManager.InitMode
{
	NONE = 0,
	LOADING = 1,
	LOADED = 2,
}

public enum MyRoomHelpListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

protected enum MyRoomHelpListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

protected enum OrganizationRootComponent.State
{
	INIT = 0,
	INIT_TOP = 1,
	INPUT_TOP = 2,
	INIT_BUY_QP_ITEM = 3,
	INIT_BUY_QP_ITEM2 = 4,
	INPUT_BUY_QP_ITEM = 5,
	QUIT_BUY_QP_ITEM = 6,
	QUIT_BUY_QP_ITEM2 = 7,
	INIT_BUY_MANA_ITEM = 8,
	INIT_BUY_MANA_ITEM2 = 9,
	INPUT_BUY_MANA_ITEM = 10,
	QUIT_BUY_MANA_ITEM = 11,
	QUIT_BUY_MANA_ITEM2 = 12,
	INIT_BUY_STONE_ITEM = 13,
	INIT_BUY_STONE_ITEM2 = 14,
	INPUT_BUY_STONE_ITEM = 15,
	QUIT_BUY_STONE_ITEM = 16,
	QUIT_BUY_STONE_ITEM2 = 17,
}

public enum OrganizationTopListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
}

public enum OrganizationTopListViewManager.Kind
{
	NORMAL = 0,
}

public enum OrganizationTopListViewManager.InitMode
{
	NONE = 0,
	INPUT = 1,
	INTO = 2,
	ENTER = 3,
	EXIT = 4,
	RETRY = 5,
}

public enum OrganizationTopListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	FADEIN = 3,
	INPUT = 4,
	INTO = 5,
	ENTER = 6,
	EXIT = 7,
	RETRY = 8,
}

protected enum OrganizationTopListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

private enum AutoOrganizationManager.RarityBit
{
	COMMON = 1,
	UNCOMMON = 2,
	RARE = 4,
	SRARE = 8,
	SSRARE = 16,
	ALL = 31,
}

public enum BoostFunctionUtility.BoostResultKind
{
	CANCEL = 0,
	UNSELECT = 1,
	SELECT = 2,
}

public enum BoostItemListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum BoostItemListViewManager.Kind
{
	EVENT = 0,
}

public enum BoostItemListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
}

public enum BoostItemListViewManager.ResultKind
{
	CANCEL = 0,
	SELECT = 1,
	COMMAND_CARD = 2,
}

public enum BoostItemListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

protected enum BoostItemListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum BoostItemMenu.ResultKind
{
	CANCEL = 0,
	SELECT = 1,
	INFOMATION = 2,
}

protected enum BoostItemMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum DeckListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum DeckListViewManager.Kind
{
	EVENT = 0,
}

public enum DeckListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
}

public enum DeckListViewManager.ResultKind
{
	CANCEL = 0,
	SELECT = 1,
	COMMAND_CARD = 2,
}

public enum DeckListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

protected enum DeckListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

protected enum DeckNameInputMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	CLOSE = 3,
}

public enum DeckSelectMenu.Kind
{
	COPY = 0,
}

public enum DeckSelectMenu.ResultKind
{
	CANCEL = 0,
	SELECT = 1,
}

protected enum DeckSelectMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

private enum DropAutoSellDlgComponent.FlagKind
{
	EXP_1 = 0,
	EXP_2 = 1,
	EXP_3 = 2,
	EXP_4 = 3,
	MAX = 4,
}

private enum DropAutoSellDlgComponent.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	NETWORK = 3,
	SELECTED = 4,
	CLOSE = 5,
}

protected enum PartyEventPointIndicator.DispKind
{
	NONE = 0,
	TREND = 1,
	RESTRICTION = 2,
}

public enum PartyListMenu.TutorialMode
{
	NONE = 0,
	ORGANIZATION_GUIDE_CHANGE_SELECT = 1,
	ORGANIZATION_GUIDE_DECK_EMPTY_SELECT = 2,
	FOLLOWER_GUIDE_START_SELECT = 3,
}

public enum PartyListMenu.ResultKind
{
	CANCEL = 0,
	DECIDE = 1,
	CHANGE = 2,
	SWAP = 3,
	REMOVE = 4,
	DECK_NAME = 5,
	DECK_COPY = 6,
	EDIT = 7,
	START = 8,
	MASTER_FORMATION = 9,
	MASTER_LIMIT_FORMATION = 10,
	INFOMATION = 11,
	EVENT_POINT = 12,
	MODIFY_STATUS = 13,
	CHANGE_SERVANT = 14,
	CHANGE_EQUIP = 15,
	DETAIL_SERVANT = 16,
	TUTORIAL_CHANGE_SERVANT = 17,
	QUEST_INFORMATION = 18,
	AUTO_ORGANIZATION = 19,
}

protected enum PartyListMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
	ENTER = 5,
	TUTORIAL_OPEN = 6,
	TUTORIAL = 7,
	TUTORIAL_CLOSE = 8,
}

public enum PartyListViewItem.MenuKind
{
	QUEST_START = 0,
	SUPPORT_ONLY_QUEST_START = 1,
	NO_SUPPORT_QUEST_START = 2,
	SINGLE_MEMBER_QUEST_START = 3,
	NUM_RESTRICTION_QUEST_START = 4,
	NUM_AND_POSITION_RESTRICTION_QUEST_START = 5,
	FIX_SUPPORT_ONLY_QUEST_START = 6,
	FIX_SUPPORT_QUEST_START = 7,
	SELECT_PARTY = 8,
	WAVE_BATTLE = 9,
}

public enum PartyListViewItem.DeckCondition
{
	OK = 0,
	EMPTY_DECK_MEMBER = 1,
	LEADER_ONLY_DECK_MEMBER = 2,
	SHORTAGE_DECK_MEMBER = 3,
	SAME_SAERVANT = 4,
	LEAVE_SERVANT = 5,
	FATIGURE_SERVANT = 6,
	COST_OVER = 7,
	RESTICTION_COST_OVER = 8,
	RESTICTION_FIXED_SUPPORT_POSITION = 9,
	RESTICTION_FIXED_SERVANT_POSITION = 10,
	RESTICTION_FIXED_MY_SERVANT_SINGLE = 11,
	RESTICTION_UNIQUE_SERVANT = 12,
	RESTRICTION_UNIQUE_INDIVIDUALITY = 13,
	RESTRICTION_SERVANT_NUM = 14,
	RESTRICTION_SERVANT_NUM_AND_FIXED_SERVANT_POSITION = 15,
	RESTRICTION_MY_SERVANT_FIX_SUPPORT_QUEST = 16,
	RESTRICTION_REQUIRED = 17,
	RESTICTION = 18,
	ALLOUT_BATTLE_SERVANT = 19,
	DATA_LOST_SERVANT = 20,
	TIME_TO_RESTART = 21,
	SINGLE_SUPPORT = 22,
	NEED_INDIVIDUALITY = 23,
}

public enum PartyListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	ORGANIZATION_GUIDE_DECK_EMPTY_SELECT = 4,
}

public enum PartyListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
	ORGANIZATION_GUIDE_DECK_EMPTY_SELECT = 3,
}

public enum PartyListViewManager.ResultKind
{
	NONE = 0,
	SELECT_SERVANT = 1,
	SELECT_EQUIP = 2,
	CHANGE_PARTY = 3,
	MODIFY_STATUS = 4,
}

public enum PartyListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	ORGANIZATION_GUIDE_DECK_EMPTY_SELECT = 4,
}

protected enum PartyListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

private enum PartyOrganizationAutoOrganizationConfirmDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

private enum PartyOrganizationAutoOrganizationSettingDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum PartyOrganizationChangeMenu.Mode
{
	NONE = 0,
	SELECT_SERVANT = 1,
	SELECT_EQUIP = 2,
	DETAIL_SERVANT = 3,
	ORGANIZATION_GUIDE_DECK_EMPTY_SELECT = 4,
	ORGANIZATION_GUIDE_DECIDE_SELECT = 5,
}

public enum PartyOrganizationChangeMenu.ResultKind
{
	CANCEL = 0,
	DECIDE = 1,
	REMOVE = 2,
	INFOMATION = 3,
	EVENT_POINT = 4,
	SELECT_SERVANT = 5,
	SELECT_EQUIP = 6,
	QUEST_INFORMATION = 7,
}

protected enum PartyOrganizationChangeMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
	ENTER = 5,
	TUTORIAL_OPEN = 6,
	TUTORIAL = 7,
	TUTORIAL_CLOSE = 8,
}

public enum PartyOrganizationChangeObject.ResultKind
{
	NONE = 0,
	SELECT_SERVANT = 1,
	SELECT_EQUIP = 2,
	MODIFY_STATUS = 3,
}

protected enum PartyOrganizationChangeObject.State
{
	INIT = 0,
	IDLE = 1,
	INPUT = 2,
}

public enum PartyOrganizationCommandCardMenu.Kind
{
	NORMAL = 0,
}

protected enum PartyOrganizationCommandCardMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum PartyOrganizationConfirmCopyMenu.Kind
{
	COPY = 0,
}

protected enum PartyOrganizationConfirmCopyMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum PartyOrganizationConfirmCostumeMenu.Kind
{
	FIX_COSTUME = 0,
}

protected enum PartyOrganizationConfirmCostumeMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum PartyOrganizationConfirmDeck2Menu.Kind
{
	CANCEL = 0,
	EMPTY_DECK_MEMBER = 1,
	SHORTAGE_DECK_MEMBER = 2,
	SAME_SAERVANT = 3,
	REMOVE = 4,
	REMOVE_MAIN_DECK = 5,
	REMOVE_MAIN_DECK_LEADER = 6,
	START_SHORTAGE_DECK_MEMBER = 7,
	START_COST_OVER = 8,
}

protected enum PartyOrganizationConfirmDeck2Menu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum PartyOrganizationConfirmDeckMenu.Kind
{
	CANCEL = 0,
	EMPTY_DECK_MEMBER = 1,
	SHORTAGE_DECK_MEMBER = 2,
	LEAVE_SERVANT = 3,
	FATIGURE_SERVANT = 4,
	COST_OVER = 5,
	INIT_ALL = 6,
	REMOVE_EQUIP = 7,
	REMOVE_ALL = 8,
	REMOVE_MAIN_DECK = 9,
	REMOVE_MAIN_DECK_LEADER = 10,
	START_SHORTAGE_DECK_MEMBER = 11,
	START_LEAVE_SERVANT = 12,
	START_FATIGURE_SERVANT = 13,
	START_COST_OVER = 14,
	RESTRICTION_COST_OVER = 15,
	RESTRICTION = 16,
	START_RESTRICTION_COST_OVER = 17,
	START_RESTICTION_UNIQUE_SERVANT = 18,
	START_RESTRICTION_UNIQUE_INDIVIDUALITY = 19,
	START_RESTICTION_FIXED_SUPPORT_POSITION = 20,
	START_RESTICTION_FIXED_SERVANT_POSITION = 21,
	START_RESTRICTION_REQUIRED = 22,
	START_RESTRICTION = 23,
	ALLOUT_BATTLE_SERVANT = 24,
	START_ALLOUT_BATTLE_SERVANT = 25,
	DATA_LOST_SERVANT = 26,
	SINGLE_SUPPORT = 27,
}

protected enum PartyOrganizationConfirmDeckMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum PartyOrganizationConfirmItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum PartyOrganizationConfirmMenu.Kind
{
	NONE = 0,
	BOOST_ITEM_USE = 1,
}

protected enum PartyOrganizationConfirmMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum PartyOrganizationConfirmMyServantMenu.Kind
{
	START_RESTICTION_FIXED_SERVANT_POSITION = 0,
	START_RESTICTION_FIXED_MY_SERVANT_SINGLE = 1,
}

protected enum PartyOrganizationConfirmMyServantMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum PartyOrganizationConfirmSupportMenu.Kind
{
	START_RESTICTION_FIXED_SUPPORT_POSITION = 0,
}

protected enum PartyOrganizationConfirmSupportMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum PartyOrganizationEventPointListViewItem.DisplayValueType
{
	Party = 0,
	Member = 1,
}

public enum PartyOrganizationEventPointListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum PartyOrganizationEventPointListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
	ORGANIZATION_GUIDE_FIRST_SELECT = 3,
}

public enum PartyOrganizationEventPointListViewManager.ResultKind
{
	NONE = 0,
	CANCEL = 1,
	DECIDE = 2,
}

public enum PartyOrganizationEventPointListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	MODIFY = 4,
	TUTORIAL_INPUT = 5,
}

protected enum PartyOrganizationEventPointListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
	TUTORIAL_INPUT = 4,
}

protected enum PartyOrganizationEventPointMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum PartyOrganizationListViewDropObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INTO = 3,
	INPUT = 4,
	DRAG_INVISIBLE = 5,
	DRAG_MOVE = 6,
	DRAG_DELETE = 7,
	DRAG_INPUT = 8,
	DRAG_VALID = 9,
	MODIFY = 10,
}

protected enum PartyOrganizationListViewDropObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum PartyOrganizationListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	DRAG_INVISIBLE = 4,
}

public enum PartyOrganizationListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
	INTO = 3,
	ENTER = 4,
	EXIT = 5,
	DETAIL_SERVANT = 6,
	DETAIL_EQUIP = 7,
	DRAG = 8,
	MODIFY = 9,
}

public enum PartyOrganizationListViewManager.ResultKind
{
	LIST = 0,
	SELECT_SERVANT = 1,
	SELECT_EQUIP = 2,
	SWAP_EQUIP = 3,
}

public enum PartyOrganizationListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	INTO = 4,
	ENTER = 5,
	EXIT = 6,
	DRAG_VALID = 7,
	DRAG_INPUT = 8,
	MODIFY = 9,
}

protected enum PartyOrganizationListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum PartyOrganizationMenu.ResultKind
{
	CANCEL = 0,
	DECIDE = 1,
	REMOVE = 2,
	INFOMATION = 3,
	EVENT_POINT = 4,
	SELECT_SERVANT = 5,
	SELECT_EQUIP = 6,
	QUEST_INFORMATION = 7,
}

protected enum PartyOrganizationMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
	ENTER = 5,
	TUTORIAL_OPEN = 6,
	TUTORIAL = 7,
	TUTORIAL_CLOSE = 8,
}

public enum PartyOrganizationMenu.Mode
{
	NONE = 0,
	SELECT_SERVANT = 1,
	SELECT_EQUIP = 2,
	DETAIL_SERVANT = 3,
	ORGANIZATION_GUIDE_DECIDE_SELECT = 4,
}

public enum PartyOrganizationRemoveSelectMenu.ResultKind
{
	CANCEL = 0,
	DECK_COPY = 1,
	REMOVE_ALL = 2,
	INIT_ALL = 3,
	REMOVE_EQUIP = 4,
	CHANGE_NAME = 5,
}

protected enum PartyOrganizationRemoveSelectMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

protected enum PartyOrganizationRestrictionHelpDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

protected enum PartyOrganizationRootComponent.TutorialMode
{
	NONE = 0,
	ORGANIZATION_GUIDE = 1,
	FRIEND = 2,
	NPC = 3,
}

protected enum PartyOrganizationRootComponent.TutorialState
{
	NONE = 0,
	INIT = 1,
	SELECT_PARTY = 2,
	SELECT_MEMBER = 3,
	SELECT_SERVANT = 4,
	SELECT_CHANGE_DECIDE = 5,
	SELECT_RETURN = 6,
	SELECT_START = 7,
}

protected enum PartyOrganizationRootComponent.MenuMode
{
	QUEST_START = 0,
	SUPPORT_ONLY_QUEST_START = 1,
	NO_SUPPORT_QUEST_START = 2,
	SINGLE_MEMBER_QUEST_START = 3,
	NUM_RESTRICTION_QUEST_START = 4,
	NUM_AND_POSITION_RESTRICTION_QUEST_START = 5,
	FIX_SUPPORT_ONLY_QUEST_START = 6,
	FIX_SUPPORT_QUEST_START = 7,
	WAVE_BATTLE = 8,
	SELECT_PARTY = 9,
	ORGANIZATION_CHANGE = 10,
	ORGANIZATION_SWAP = 11,
}

protected enum PartyOrganizationRootComponent.State
{
	INIT = 0,
	INIT_TOP = 1,
	INIT_QUEST_START = 2,
	INPUT_QUEST_START = 3,
	QUIT_QUEST_START = 4,
	INIT_SUPPORT_ONLY_QUEST_START = 5,
	INPUT_SUPPORT_ONLY_QUEST_START = 6,
	QUIT_SUPPORT_ONLY_QUEST_START = 7,
	INIT_SELECT_PARTY = 8,
	INPUT_SELECT_PARTY = 9,
	QUIT_SELECT_PARTY = 10,
	INIT_ORGANIZATION_CHANGE = 11,
	INPUT_ORGANIZATION_CHANGE = 12,
	QUIT_ORGANIZATION_CHANGE = 13,
	INIT_ORGANIZATION_SWAP = 14,
	INPUT_ORGANIZATION_SWAP = 15,
	QUIT_ORGANIZATION_SWAP = 16,
	INPUT_ORGANIZATION_CHANGE_SERVANT_SELECT = 17,
	INPUT_ORGANIZATION_SWAP_SERVANT_SELECT = 18,
	INPUT_ORGANIZATION_CHANGE_EQUIP_SELECT = 19,
	INPUT_ORGANIZATION_SWAP_EQUIP_SELECT = 20,
	INPUT_INFORMATION = 21,
	INPUT_EVENT_POINT = 22,
	INPUT_CHARA_GRAPH = 23,
	INPUT_DECK_NAME = 24,
	INPUT_DECK_COPY = 25,
	INPUT_QUEST_START_TUTORIAL = 26,
	INPUT_BOOST_ITEM = 27,
	QUIT_SCENE = 28,
	MASTER_FORMATION_SCENE = 29,
	QUEST_INFORMATION = 30,
	INIT_WAVE_QUEST_START = 31,
	INPUT_WAVE_QUEST_START = 32,
	QUIT_WAVE_QUEST_START = 33,
}

public enum PartyServantListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum PartyServantListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
	MODIFY = 3,
	SORT = 4,
	ORGANIZATION_GUIDE_FIRST_SELECT = 5,
}

public enum PartyServantListViewManager.ResultKind
{
	NONE = 0,
	CANCEL = 1,
	DECIDE = 2,
	SHOW_STATUS = 3,
}

public enum PartyServantListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	MODIFY = 4,
	TUTORIAL_INPUT = 5,
}

protected enum PartyServantListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
	TUTORIAL_INPUT = 4,
}

public enum PartyServantSelectMenu.TutorialMode
{
	NONE = 0,
	ORGANIZATION_GUIDE_FIRST_DIALOG = 1,
	ORGANIZATION_GUIDE_FIRST_SELECT = 2,
}

public enum PartyServantSelectMenu.ModeKind
{
	STATUS = 0,
	LOCK = 1,
	CHOICE = 2,
	PUSH = 3,
	SUM = 4,
}

public enum PartyServantSelectMenu.ResultKind
{
	CANCEL = 0,
	DECIDE = 1,
	DETAIL = 2,
	MOVE_COMBINE = 3,
}

protected enum PartyServantSelectMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
	SHOW_STATUS = 5,
	TUTORIAL_OPEN = 6,
	TUTORIAL = 7,
	TUTORIAL_CLOSE = 8,
}

protected enum SelectMyServantOrNpcDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum SelectMyServantOrNpcDialog.ResultClicked
{
	MY_SERVANT = 0,
	NPC = 1,
	CANCEL = 2,
}

private enum WaveBattlePartyOrganizationAutoOrganizationConfirmDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

private enum WaveBattlePartyOrganizationAutoOrganizationSettingDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum WaveBattlePartyOrganizationMenu.ResultKind
{
	DECIDE = 0,
	MASTER_FORMATION = 1,
	AUTO_ORGANIZATION = 2,
	PARTY_EDIT = 3,
	CLASS_INFO = 4,
	AUTO_SELL = 5,
	INTERRUPTION_DECK = 6,
	BATTLE_START = 7,
	DETAIL_SERVANT = 8,
}

protected enum WaveBattlePartyOrganizationMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

private enum WaveBattleSelectWaveConfirmDialog.State
{
	INIT = 0,
	OPEN = 1,
	CLOSE = 2,
}

private enum WaveBattleSelectWaveDialog.State
{
	INIT = 0,
	OPEN = 1,
	CLOSE = 2,
}

public enum WaveBattleSelectWaveDialog.Kind
{
	TERMINAL = 0,
	BATTLE = 1,
}

public enum WaveBattleWaveEnemyInfoItem.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

protected enum ServantCheckEquipDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	CLOSE = 3,
}

public enum ServantCheckEquipListViewItem.WarningType
{
	EQUIP = 0,
	COMBINE = 1,
	SSRARE = 2,
	MATERIAL_TD = 3,
}

public enum ServantCheckEquipListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum ServantCheckEquipListViewManager.InitMode
{
	NONE = 0,
	INTO = 1,
	VALID = 2,
	INPUT = 3,
	ENTER = 4,
	EXIT = 5,
	MODIFY = 6,
}

public enum ServantCheckEquipListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

protected enum ServantCheckEquipListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	INPUT = 2,
}

protected enum ServantCheckWarningDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	CLOSE = 3,
}

public enum CharaGraphListMenu.Kind
{
	EQUIP = 0,
}

public enum CharaGraphListMenu.TabKind
{
	SERVANT = 0,
	SERVANT_EQUIP = 1,
	COMMAND_CODE = 2,
	SUM = 3,
}

public enum CharaGraphListMenu.ModeKind
{
	STATUS = 0,
	LOCK = 1,
	CHOICE = 2,
	PUSH = 3,
	SUM = 4,
}

public enum CharaGraphListMenu.ResultKind
{
	CANCEL = 0,
	DECIDE = 1,
	SERVANT_QUEST = 2,
}

protected enum CharaGraphListMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
	EQUIP_SELECT = 5,
	SHOW_STATUS = 6,
}

protected enum ServantListRootComponent.State
{
	INIT = 0,
	INIT_TOP = 1,
}

public enum ServantListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum ServantListViewManager.Kind
{
	SERVANT = 0,
	SERVANT_EQUIP = 1,
	SERVANT_COSTUME = 2,
	COMMAND_CODE = 3,
}

public enum ServantListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
	MODIFY = 3,
}

public enum ServantListViewManager.ResultKind
{
	CANCEL = 0,
	DECIDE = 1,
	SHOW_STATUS = 2,
}

public enum ServantListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	MODIFY = 4,
}

protected enum ServantListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum BuyStorageConfirmDialogComponent.Kind
{
	SERVANT = 0,
	SERVANT_EQUIP = 1,
}

private enum BuyStorageConfirmDialogComponent.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

private enum BuyStorageConfirmDialogComponent.Type
{
	CONFIRM = 0,
	RESULT = 1,
	NOTIFICATION = 2,
}

public enum BuyStorageConfirmDialogComponent.NotificationType
{
	NONE = 0,
	SOLD_OUT = 1,
	NOT_ENOUGH = 2,
}

private enum ServantOperationListViewItem.Type
{
	NONE = 0,
	SERVANT = 1,
	COMMAND_CODE = 2,
}

private enum ServantOperationListViewItem.ServantAttributeKind
{
	None = 0,
	Heroine = 1,
	Limited = 2,
}

public enum ServantOperationListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum ServantOperationListViewManager.Kind
{
	SERVANT = 0,
	SERVANT_EQUIP = 1,
	COMMAND_CODE = 2,
	SELL = 3,
}

public enum ServantOperationListViewManager.ModeKind
{
	SELECT = 0,
	LOCK = 1,
	CHOICE = 2,
	PUSH = 3,
}

public enum ServantOperationListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
}

public enum ServantOperationListViewManager.ResultKind
{
	NONE = 0,
	SELECT_LIST = 1,
	SERVANT_STATUS = 2,
}

public enum ServantOperationListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	MODIFY = 4,
}

private enum ServantOperationListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	INPUT = 2,
}

public enum ServantOperationManager.Kind
{
	SERVANT = 0,
	SERVANT_EQUIP = 1,
	COMMAND_CODE = 2,
}

public enum ServantOperationManager.ActionKind
{
	NONE = 0,
	SELECT_LIST = 1,
	SERVANT_STATUS = 2,
}

public enum ServantOperationManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
	INTO = 3,
	ENTER = 4,
	EXIT = 5,
}

private enum ServantSellConfirmListViewItem.Type
{
	NONE = 0,
	SERVANT = 1,
	COMMAND_CODE = 2,
}

private enum ServantSellConfirmListViewItem.ServantAttributeKind
{
	NONE = 0,
	HEROINE = 1,
	LIMITED = 2,
}

public enum ServantSellConfirmListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum ServantSellConfirmListViewManager.Kind
{
	SERVANT = 0,
	SERVANT_EQUIP = 1,
	COMMAND_CODE = 2,
	SELL = 3,
}

public enum ServantSellConfirmListViewManager.ModeKind
{
	SELECT = 0,
	LOCK = 1,
	CHOICE = 2,
}

public enum ServantSellConfirmListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
}

public enum ServantSellConfirmListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	MODIFY = 4,
}

private enum ServantSellConfirmListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum ServantSellConfirmMenu.Kind
{
	SELECT_SERVANT = 0,
	SELECT_SERVANT_EQUIP = 1,
	SELECT_SERVANT_EXCEEDED = 2,
	SELECT_COMMAND_CODE = 3,
	SELECT_LAST_SVT = 4,
	SELL_SERVANT = 5,
	SELL_SERVANT_EQUIP = 6,
	SELL_COMMAND_CODE = 7,
	SELL_ERROR_SERVANT = 8,
	SELL_ERROR_SERVANT_EQUIP = 9,
	SELL_ERROR_COMMAND_CODE = 10,
	NO_SELECT_SERVANT = 11,
	NO_SELECT_SERVANT_EQUIP = 12,
	NO_SELECT_COMMAND_CODE = 13,
}

private enum ServantSellConfirmMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

private enum ServantSellConfirmMenu.ServantType
{
	SERVANT = 0,
	SERVANT_EQUIP = 1,
	COMMAND_CODE = 2,
	SUM = 3,
}

private enum ServantSellMaxAlertDialog.State
{
	NONE = 0,
	INIT = 1,
	OPEN = 2,
	INPUT = 3,
	SELECTED = 4,
	CLOSE = 5,
}

public enum ServantSellMenu.ResultKind
{
	CANCEL = 0,
	DECIDE = 1,
}

private enum ServantSellMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
	SHOW_SERVANT_DETAIL = 5,
}

private enum ShopBuyItemConfirmMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum ShopBuyItemListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum ShopBuyItemListViewManager.Kind
{
	NONE = 0,
	QP = 1,
	MANA = 2,
	STONE = 3,
	BANK = 4,
	ACCOUNT = 5,
	EVENT = 6,
	STONE_FRAGMENTS = 7,
	ANONYMOUS = 8,
	RARE_PRI = 9,
	SERVANT_STORAGE = 10,
	EQUIP_STORAGE = 11,
	SPECIAL_ITEM = 12,
	GRAIL_FRAGMENTS = 13,
	SVT_COSTUME = 14,
	START_UP_SUMMON = 15,
	SHOP13 = 16,
	TRADE_AP = 17,
	AP = 18,
	SHOP15 = 19,
	EVENT_SVT_EQUIP = 20,
}

public enum ShopBuyItemListViewManager.InitMode
{
	NONE = 0,
	INTO = 1,
	INPUT = 2,
	ENTER = 3,
	EXIT = 4,
	MODIFY = 5,
}

private enum ShopBuyItemListViewManager.FilterStatus
{
	All = 0,
	HAVE = 1,
	NOT_HAVE = 2,
}

public enum ShopBuyItemListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	INTO = 4,
	ENTER = 5,
	EXIT = 6,
	MODIFY = 7,
}

private enum ShopBuyItemListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum ShopEventListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum ShopEventListViewManager.Kind
{
	NORMAL = 0,
}

public enum ShopEventListViewManager.InitMode
{
	NONE = 0,
	INTO = 1,
	INPUT = 2,
	ENTER = 3,
	EXIT = 4,
	RETRY = 5,
	ENTERED = 6,
}

public enum ShopEventListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	INTO = 4,
	ENTER = 5,
	EXIT = 6,
	RETRY = 7,
	ENTERED = 8,
}

private enum ShopEventListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum ShopHelpItemInfo.ItemKind
{
	NONE = 0,
	SHOP_HELP_EVENT_SHOP = 1,
	SHOP_HELP_SELL_SERVANT = 2,
	SHOP_HELP_MANA_SHOP = 3,
	SHOP_HELP_RARE_PRI_SHOP = 4,
	SHOP_HELP_STONE_FRAGMENTS_SHOP = 5,
	SHOP_HELP_STONE_PURCHASE = 6,
	SHOP_HELP_SERVANT_FRAME_EXTENSION = 7,
	SHOP_HELP_EQUIP_FRAME_EXTENSION = 8,
	SHOP_HELP_SERVANT_STORAGE_EXTENSION = 9,
	SHOP_HELP_EQUIP_STORAGE_EXTENSION = 10,
	SHOP_HELP_ANONYMOUS_SHOP = 11,
	SHOP_HELP_STONE_SHOP = 12,
	SHOP_HELP_SPECIAL_ITEM_SHOP = 13,
	SHOP_HELP_GRAIL_FRAGMENTS = 14,
	SHOP_HELP_SVT_COSTUME = 15,
	SHOP_HELP_START_UP_SUMMON = 16,
	SHOP_HELP_COIN_ROOM = 17,
	SHOP_HELP_SHOP13 = 18,
	SHOP_HELP_TRADE_AP = 19,
	SHOP_HELP_SHOP15 = 20,
	SHOP_HELP_EVENT_SVT_EQUIP = 21,
	SHOP_BLANK = 22,
}

public enum ShopHelpListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
}

public enum ShopHelpListViewManager.InitMode
{
	NONE = 0,
	LOADING = 1,
	LOADED = 2,
}

public enum ShopHelpListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

private enum ShopHelpListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum ShopListNotice.ShopLimitedType
{
	None = 0,
	Period = 1,
	Monthly = 2,
	ExchangeServant = 3,
	StartUpSummon = 4,
	PeriodAndMonthly = 6,
	PeriodAndExchangeServant = 10,
	PeriodAndStartUpSummon = 18,
	MonthlyAndExchangeServant = 12,
	MonthlyAndStartUpSummon = 20,
	ExchangeServantAndStartUpSummon = 24,
	MonthlyAndExchangeServantAndStartUpSummon = 28,
	PeriodAndExchangeServantAndStartUpSummon = 26,
	PeriodAndMonthlyAndStartUpSummon = 22,
	PeriodAndMonthlyAndExchangeServant = 14,
	PeriodAndMonthlyAndExchangeServantAndSpecialSummonable = 30,
}

public enum ShopListNotice.ShopLimitedTypeFlag
{
	PERIOD = 2,
	MONTHLY = 4,
	EXCHANGE_SERVANT = 8,
	START_UP_SUMMON = 16,
}

protected enum ShopPlayVoiceConstants.VoiceKind
{
	ENTER_EVENT_SHOP = 1,
	ENTER_SELL_SERVANT = 2,
	ENTER_MANA_PRI_SHOP = 3,
	ENTER_RARE_PRI_SHOP = 4,
	ENTER_SVT_STORAGE_SHOP = 5,
	ENTER_EQUIP_STORAGE_SHOP = 6,
	ENTER_FRAGMENT_SHOP = 7,
	ENTER_BANK_ITEM = 8,
	ENTER_ANONYMOUS_SHOP = 9,
	ENTER_STONE_SHOP = 10,
	BACK_SHOP1 = 11,
	BACK_SHOP2 = 12,
	CANCEL_SHOP = 13,
	ENTER_SPECIAL_ITEM_SHOP = 14,
	ENTER_GRAIL_FRAGMENTS_SHOP = 15,
	ENTER_SVT_COSTUME_SHOP = 16,
	ENTER_START_UP_SUMMON_SHOP = 17,
	ENTER_SHOP13_SHOP = 18,
	ENTER_TRADE_AP_SHOP = 19,
	ENTER_SHOP15_SHOP = 20,
	ENTER_EVENT_SVT_EQUIP_SHOP = 21,
}

public enum ShopPlayVoiceConstants.VoiceFlag
{
	ENTER_EVENT_SHOP = 2,
	ENTER_SELL_SERVANT = 4,
	ENTER_MANA_PRI_SHOP = 8,
	ENTER_RARE_PRI_SHOP = 16,
	ENTER_SVT_STORAGE_SHOP = 32,
	ENTER_EQUIP_STORAGE_SHOP = 64,
	ENTER_FRAGMENT_SHOP = 128,
	ENTER_BANK_ITEM = 256,
	ENTER_ANONYMOUS_SHOP = 512,
	ENTER_STONE_SHOP = 1024,
	BACK_SHOP1 = 2048,
	BACK_SHOP2 = 4096,
	CANCEL_SHOP = 8192,
	ENTER_SPECIAL_ITEM_SHOP = 16384,
	ENTER_GRAIL_FRAGMENTS_SHOP = 32768,
	ENTER_SVT_COSTUME_SHOP = 65536,
	ENTER_START_UP_SUMMON_SHOP = 131072,
	ENTER_SHOP13_SHOP = 262144,
	ENTER_TRADE_AP_SHOP = 524288,
	ENTER_SHOP15_SHOP = 1048576,
	ENTER_EVENT_SVT_EQUIP_SHOP = 2097152,
}

public enum ShopRootConstants.State
{
	INIT = 0,
	TOP = 1,
	MANA_PRI = 2,
	RARE_PRI = 3,
	STONE_FRAGMENTS = 4,
	SPECIAL = 5,
	ANONYMOUS = 6,
	EVENT = 7,
	EVENT_ITEM = 8,
	SELL_SERVANT = 9,
	BANK = 10,
	SERVANT_STORAGE = 11,
	EQUIP_STORAGE = 12,
	HELP = 13,
	GRAIL_FRAGMENTS = 14,
	SVT_COSTUME = 15,
	START_UP_SUMMON = 16,
	COIN_ROOM = 17,
	SHOP13 = 18,
	TRADE_AP = 19,
	SHOP15 = 20,
	EVENT_SVT_EQUIP = 21,
}

public enum ShopRootConstants.InputState
{
	INIT_START = 0,
	INIT_END = 1,
	INPUT = 2,
	QUIT_START = 3,
	QUIT_END = 4,
}

private enum ShopSceneListViewControlHelper.Hierarchy
{
	NONE = 0,
	FIRST = 1,
	SECOND = 2,
	THIRD = 3,
}

public enum ShopTopItemInfo.ItemKind
{
	SHOP_BUY_BANK_ITEM = 1,
	SHOP_BUY_QP_ITEM = 2,
	SHOP_BUY_MANA_ITEM = 3,
	SHOP_BUY_STONE_ITEM = 4,
	SHOP_BUY_EVENT_ITEM = 5,
	SHOP_BUY_SERVANT_STORAGE = 6,
	SHOP_BUY_SERVANT_EQUIP_STORAGE = 7,
	SHOP_SELL_SERVANT = 8,
	SHOP_START_UP_SUMMON = 9,
	SHOP_NOAH = 10,
	SHOP_BUY_ACCOUNT_ITEM = 11,
	SHOP_BUY_STONE_FRAGMENTS = 12,
	SHOP_BUY_ANONYMOUS = 13,
	SHOP_BUY_RARE_PRI = 14,
	SHOP_BUY_SPECIAL_ITEM = 15,
	SHOP_GRAIL_FRAGMENTS = 16,
	SHOP_BUY_SVT_COSTUME = 17,
	SHOP_COIN_ROOM = 18,
	SHOP13 = 19,
	SHOP_TRADE_AP = 20,
	SHOP_BLANK = 21,
	SHOP15 = 22,
	SHOP_EVENT_SVT_EQUIP = 23,
}

public enum ShopTopListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
}

public enum ShopTopListViewManager.Kind
{
	NORMAL = 0,
}

public enum ShopTopListViewManager.InitMode
{
	NONE = 0,
	INPUT = 1,
	INTO = 2,
	ENTER = 3,
	EXIT = 4,
	RETRY = 5,
	ENTERED = 6,
}

public enum ShopTopListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	INTO = 4,
	ENTER = 5,
	EXIT = 6,
	RETRY = 7,
	ENTERED = 8,
}

private enum ShopTopListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

private enum AutomaticSaleDlgComponent.FlagKind
{
	EXP_1 = 0,
	EXP_2 = 1,
	EXP_3 = 2,
	STATUS_UP_1 = 3,
	STATUS_UP_2 = 4,
	STATUS_UP_3 = 5,
	EQUIP_1 = 6,
	EQUIP_2 = 7,
	EQUIP_3 = 8,
	MAX = 9,
}

protected enum AutomaticSaleDlgComponent.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	NETWORK = 3,
	SELECTED = 4,
	CLOSE = 5,
}

public enum BonusSelectSummonPartyOrganizationListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum SummonCategory
{
	NOT_LIMITED = 0,
	PERIOD_LIMITED = 1,
	STORY_LIMITED = 2,
}

public enum BonusSelectSummonPartyServantListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum BonusSelectSummonPartyServantListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
	MODIFY = 3,
	SORT = 4,
}

public enum BonusSelectSummonPartyServantListViewManager.ResultKind
{
	NONE = 0,
	CANCEL = 1,
	DECIDE = 2,
	SHOW_STATUS = 3,
}

public enum BonusSelectSummonPartyServantListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	MODIFY = 4,
}

private enum BonusSelectSummonPartyServantListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

protected enum BonusSelectSummonPartyServantSelectMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
	SHOW_STATUS = 5,
	TUTORIAL_OPEN = 6,
	TUTORIAL = 7,
	TUTORIAL_CLOSE = 8,
}

public enum SummonHistoryListViewItem.LayoutType
{
	Message = 0,
	Datetime = 1,
	ItemMessage = 2,
}

protected enum SummonConfirmDlgComponent.State
{
	INIT = 0,
	SHORT_SERVANT = 1,
	SHORT_STONE = 2,
	SHORT_POINT = 3,
	CONFIRM_STONE = 4,
	CONFIRM_TICKET = 5,
	CONFIRM_POINT = 6,
	CONFIRM_FREE = 7,
}

public enum SummonControl.TUTORIAL_KIND
{
	NONE = 0,
	TUTORIAL1_MSG = 1,
	TUTORIAL2_MSG = 2,
	EXE_FORMATION = 3,
	TUTORIAL3_MSG = 4,
	SVTEQ_TUTORIAL_MSG = 5,
}

public enum SummonControl.GACHATYPE
{
	PAYGACHA = 1,
	FREEGACHA = 3,
	TICKETGACHA = 5,
	CHARGE_STONE = 7,
}

protected enum SummonControl.QUESTTYPE
{
	FRIENDSHIP = 3,
	HEROBALLAD = 6,
}

public enum SummonEffectComponent.CardColor
{
	BRONZE = 0,
	SILVER = 1,
	GOLD = 2,
}

public enum SummonEffectComponent.CardType
{
	OTHER = 0,
	CANCER = 1,
	SERVANT = 2,
	COMMAND_CODE = 3,
	SPECIAL = 4,
}

public enum SummonEffectComponent.NoticeEffect
{
	NONE = 0,
	SR = 1,
	SSR = 2,
	SPECIAL = 3,
}

private enum SummonEffectComponent.RankUp
{
	NONE = 0,
	TO_SILVER = 1,
	TO_GOLD = 2,
	COMMANDCODE = 3,
}

protected enum SummonLimitWarningDlgComponent.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum SummonLimitWarningDlgComponent.Result
{
	CANCEL = 0,
	OTHER_SCENE = 1,
	DECIDE = 2,
}

private enum CancelConfirmDeckIdDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum CancelConfirmMenu.Kind
{
	CANCEL = 0,
	EMPTY_DECK_MEMBER = 1,
	SHORTAGE_DECK_MEMBER = 2,
	SAME_SAERVANT = 3,
	REMOVE = 4,
	REMOVE_MAIN_DECK = 5,
	REMOVE_MAIN_DECK_LEADER = 6,
	START_SHORTAGE_DECK_MEMBER = 7,
	START_COST_OVER = 8,
	DECKID_CHANGE = 9,
}

protected enum CancelConfirmMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

private enum SupportDeckFixErrorDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	CLOSE = 3,
}

public enum SupportDeckFixErrorListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
}

protected enum SupportDeckNameInputMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	CLOSE = 3,
}

private enum SupportSelectConfirmCopyMenu.State
{
	OPEN = 0,
	INPUT = 1,
	CLOSE = 2,
}

public enum SupportSelectConfirmDeckMenu.DialogKind
{
	REMOVE_ALL = 0,
	INIT_ALL = 1,
	REMOVE_ALL_EQUIP = 2,
}

private enum SupportSelectConfirmDeckMenu.State
{
	OPEN = 0,
	INPUT = 1,
	CLOSE = 2,
}

public enum SupportSelectConfirmMenu.Kind
{
	NONE = 0,
	NO_SERVANT = 1,
	SERVANT_CLEAR = 2,
	EQUIP_CLEAR = 3,
	ALL_CLEAR = 4,
	EQUIP_CHANGE = 5,
}

protected enum SupportSelectConfirmMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

private enum SupportSelectCopyDeckSelectMenu.State
{
	OPEN = 0,
	INPUT = 1,
	CLOSE = 2,
}

public enum SupportSelectDeckListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
}

public enum SupportSelectEditMenu.ResultKind
{
	COPY = 0,
	REMOVE_ALL = 1,
	INIT_ALL = 2,
	REMOVE_EQUIP = 3,
	CHANGE_NAME = 4,
}

private enum SupportSelectEditMenu.State
{
	OPEN = 0,
	INPUT = 1,
	CLOSE = 2,
}

public enum SupportSelectItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	DRAG_INVISIBLE = 4,
}

public enum SupportSelectMenu.ResultKind
{
	CANCEL = 0,
	DECIDE = 1,
	CLOSE = 2,
	SELECT_SERVANT = 3,
	SELECT_EQUIP = 4,
	DECK_NAME = 5,
	SWAP = 6,
	EDIT = 7,
	SELECT_FOLLOWER = 8,
	SUPPORT_INFO_SERVANT = 9,
	SUPPORT_INFO_EQUIP = 10,
}

protected enum SupportSelectRootComponent.State
{
	INIT = 0,
	SELECT = 1,
	INPUT_SERVANT_SELECT = 2,
	INPUT_EQUIP_SELECT = 3,
	INFO = 4,
	QUIT_SCENE = 5,
}

public enum SupportSelectRootComponent.ResultKind
{
	CANCEL = 0,
	DECIDE = 1,
	REMOVE = 2,
}

public enum SupportSelectRootComponent.SwapKind
{
	SERVANT = 0,
	EQUIPMENT = 1,
}

public enum SupportServantData.ClassPos
{
	ALL = 0,
	SABER = 1,
	ARCHER = 2,
	LANCER = 3,
	RIDER = 4,
	CASTER = 5,
	ASSASSIN = 6,
	BERSERKER = 7,
	EXTRA = 8,
	SUM = 9,
}

public enum SupportServantEquipListMenu.ModeKind
{
	NORMAL = 0,
	LOCK = 1,
	CHOICE = 2,
	SUM = 3,
}

protected enum SupportServantEquipListMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
	SHOW_STATUS = 5,
	WARNING = 6,
}

public enum SupportServantEquipListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum SupportServantEquipListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
	MODIFY = 3,
}

public enum SupportServantEquipListViewManager.ResultKind
{
	CANCEL = 0,
	DECIDE = 1,
	SHOW_STATUS = 2,
	SELECT = 3,
	SELECTED_CHECK = 4,
}

public enum SupportServantEquipListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	MODIFY = 4,
}

protected enum SupportServantEquipListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum SupportServantEquipServantItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum SupportServantListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum SupportServantListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
	MODIFY = 3,
}

public enum SupportServantListViewManager.ResultKind
{
	NONE = 0,
	CANCEL = 1,
	DECIDE = 2,
}

public enum SupportServantListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	MODIFY = 4,
	TUTORIAL_INPUT = 5,
}

protected enum SupportServantListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
	TUTORIAL_INPUT = 4,
}

protected enum SupportServantSelectMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum SupportServantSelectMenu.ModeKind
{
	NORMAL = 0,
	LOCK = 1,
	CHOICE = 2,
	PUSH = 3,
	SUM = 4,
}

public enum BaseCore.CORE_TYPE
{
	EARTH = 0,
	CYLINDER = 1,
}

public enum BaseCore.STATE
{
	NONE = 0,
	MAIN = 1,
	ZOOM_IN = 2,
	ZOOM_OUT = 3,
	SIZEOF = 4,
}

public enum BlankEarth.STATE
{
	NONE = 0,
	START = 1,
	MAIN = 2,
	ZOOM_IN = 3,
	ZOOM_OUT = 4,
	QAA_ROTATE = 5,
	SHORTCUT_ROTATE = 6,
	SIZEOF = 7,
}

public enum BlankEarthGimmickComponent.DispType
{
	None = 0,
	Normal = 1,
}

public enum BlankEarthGimmickComponent.STATE
{
	NONE = 0,
	MAP_MAIN = 1,
	HIDE_ANIM = 2,
	DISP_ANIM = 3,
	SIZEOF = 4,
}

private enum BlankEarthShortcutUIButton.WaitState
{
	NONE = 0,
	ENABLE = 1,
	DISABLE = 2,
}

private enum SubmarineScanConfirmDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	EXECUTE = 3,
	CLOSE = 4,
}

private enum SubmarineSelectScannerDialog.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum EventMuralUpdateAction.STATE
{
	NONE = 0,
	PLAY = 1,
	TOUCH_WAIT = 2,
	SIZEOF = 3,
}

public enum EventPointVsResultAction.STATE
{
	NONE = 0,
	PLAY = 1,
	TOUCH_WAIT = 2,
	SIZEOF = 3,
}

public enum EventPointVsResultAction.GROUP_WIN
{
	NONE = 0,
	GROUP1_WIN = 1,
	GROUP2_WIN = 2,
	BOSSPOINT_WIN = 3,
	SIZEOF = 4,
}

public enum EventRaceBoostEffect.BoostColor
{
	NONE = 0,
	BURST = 1,
	QUICK = 2,
	ARTS = 3,
}

public enum EventRaceBoostEffect.BoostGrade
{
	NONE = 1,
	BOOSTED = 2,
	BOOSTED_LOT = 3,
}

public enum EventRaceResultEffect.STATE
{
	NONE = 0,
	PLAY = 1,
	TOUCH_WAIT = 2,
	SIZEOF = 3,
}

public enum FortuneBonusBoxAction.STATE
{
	NONE = 0,
	PLAY = 1,
	SIZEOF = 2,
}

public enum FortuneBonusResultAction.STATE
{
	NONE = 0,
	PLAY = 1,
	TOUCH_WAIT = 2,
	SIZEOF = 3,
}

public enum CTouch.TCH_STATE
{
	NONE = 0,
	PUSH = 1,
	KEEP = 2,
	RELEASE = 3,
}

public enum ColorChange.CHANGE_STYLE
{
	ONE = 0,
	PINGPONG = 1,
}

public enum Easing.TYPE
{
	LINER = 0,
	QUADRATIC_IN = 1,
	QUADRATIC_OUT = 2,
	QUADRATIC_IN_OUT = 3,
	CUBIC_IN = 4,
	CUBIC_OUT = 5,
	CUBIC_IN_OUT = 6,
	QUARTIC_IN = 7,
	QUARTIC_OUT = 8,
	QUARTIC_IN_OUT = 9,
	QUINTIC_IN = 10,
	QUINTIC_OUT = 11,
	QUINTIC_IN_OUT = 12,
	SINUSOIDAL_IN = 13,
	SINUSOIDAL_OUT = 14,
	SINUSOIDAL_IN_OUT = 15,
	EXPONENTIAL_IN = 16,
	EXPONENTIAL_OUT = 17,
	EXPONENTIAL_IN_OUT = 18,
	CIRCULAR_IN = 19,
	CIRCULAR_OUT = 20,
	CIRCULAR_IN_OUT = 21,
}

public enum ScrollArrowComponent.DirectionType
{
	Left = 0,
	Right = 1,
	Top = 2,
	Bottom = 3,
}

public enum SlideFadeObject.STYLE
{
	LEFT = 0,
	RIGHT = 1,
}

public enum SlideFadeObject.SLIDE_STATE
{
	NONE = 0,
	IN_COMPLETE = 1,
	OUT_COMPLETE = 2,
}

public enum StandFigureSlideComponent.STATE
{
	NONE = 0,
	READY = 1,
	SLIDE = 2,
	SIZEOF = 3,
}

public enum MapControl.QuestInfo.DispType
{
	None = 0,
	Normal = 1,
	Closed = 2,
	Never = 3,
}

public enum MapControl.QuestInfo.TouchType
{
	Disable = 0,
	Enable = 1,
}

public enum MapControl.SpotInfo.DispType
{
	None = 0,
	Normal = 1,
	Gray = 2,
}

public enum MapControl.SpotInfo.TouchType
{
	Disable = 0,
	Enable = 1,
}

public enum MapControl.SpotRoadInfo.DispType
{
	None = 0,
	Normal = 1,
	Gray = 2,
}

public enum MapControl.MapGimmickInfo.DispType
{
	None = 0,
	Normal = 1,
}

public enum MapControl.WarInfo.Status
{
	None = 0,
	Normal = 1,
	New = 2,
	Clear = 3,
	Complete = 4,
}

public enum MapControl.WarInfo.StatusCheckFlag
{
	isClosed = 1,
	isClearingAll = 2,
	isHasNoneUserQuest = 4,
	isWarLastQuestCleard = 8,
}

public enum MapControl.WarInfo.MapUpdateState
{
	None = 0,
	Enabled = 1,
	Disabled = 2,
}

public enum MapGimmickComponent.STATE
{
	NONE = 0,
	MAP_MAIN = 1,
	HIDE_ANIM = 2,
	DISP_ANIM = 3,
	SIZEOF = 4,
}

public enum MapShakerComponent.ShakeType
{
	RANDOM_COORDINATE = 0,
	FLAGED_RANDOM = 1,
	FREQUENTIZED_RANDOM = 2,
}

public enum ModelLineComponent.STATE
{
	NONE = 0,
	MAP_MAIN = 1,
	QAA_HIDE = 2,
	QAA_GRAY = 3,
	QAA_DISP = 4,
	SIZEOF = 5,
}

public enum PlayerStatusRaidPointComponent.DispType
{
	EMPTY = 0,
	NORMAL = 1,
	OVER = 2,
}

public enum QuestAfterAction.COMMAND
{
	NONE = 0,
	SPOT_HIDE = 100,
	SPOT_GRAY = 101,
	SPOT_DISP = 102,
	SPOT_CHANGE = 103,
	SPOT_ANIM = 104,
	SPOT_HIDE_QUICK = 110,
	SPOT_GRAY_QUICK = 111,
	SPOT_DISP_QUICK = 112,
	SPOT_CHANGE_QUICK = 113,
	SPOT_ANIM_QUICK = 114,
	ROAD_HIDE = 200,
	ROAD_GRAY = 201,
	ROAD_DISP = 202,
	ROAD_HIDE_QUICK = 203,
	ROAD_GRAY_QUICK = 204,
	ROAD_DISP_QUICK = 205,
	CAM_MV_SPOT = 300,
	CAM_MV_ROAD = 301,
	CAM_MV_GIMMICK = 302,
	CAM_MV_COORD = 303,
	CAM_ZOOM = 304,
	CAM_MV_ZOOM_SPOT = 305,
	CAM_MV_ZOOM_ROAD = 306,
	CAM_MV_ZOOM_GIMMICK = 307,
	CAM_MV_ZOOM_COORD = 308,
	CAM_3D_MV_LAYER = 350,
	CAM_3D_MV_COORD = 351,
	CAM_3D_MV_ZOOM_COORD = 352,
	GIMMICK_HIDE = 400,
	GIMMICK_DISP = 401,
	GIMMICK_HIDE_QUICK = 402,
	GIMMICK_DISP_QUICK = 403,
	GIMMICK_MV_COORD = 404,
	GIMMICK_DISP_WITH_FADE = 405,
	GIMMICK_TWEEN_COLOR = 406,
	GIMMICK_SET_COLOR = 407,
	GIMMICK_DISP_UPDATE = 408,
	GIMMICK_DISP_PILE_UP = 409,
	QUEST_FOCUS = 500,
	QUEST_UNFOCUS = 501,
	PLAYER_FOCUS = 510,
	AFTER_FADE_IN = 520,
	QUEST_START = 530,
	MAP_CHANGE = 540,
	START_MAP_CHANGE = 550,
	TITLE_INFO_CONTROL = 560,
	MESSAGE_WINDOW = 600,
	MESSAGE_WINDOW_MST = 601,
	MESSAGE_OTHER_WINDOW = 602,
	MESSAGE_OTHER_WINDOW_MST = 603,
	MESSAGE_OTHER_WINDOW_BOOST_SUPPORT = 604,
	EVENT_REWARD = 700,
	PLAY_VOICE = 800,
	PLAY_SE = 801,
	BGM_STOP = 850,
	BGM_PLAY = 851,
	WAIT = 900,
}

public enum QuestAfterAction.COMMAND_TYPE
{
	SPOT = 0,
	SPOT_ROAD = 1,
	MAP_GIMMICK = 2,
	SELECT_MAP = 3,
	SIZEOF = 4,
}

public enum QuestAfterAction.STATE
{
	NONE = 0,
	MAIN = 1,
	ADDITIONAL = 2,
	INSTANT = 3,
	SIZEOF = 4,
}

public enum QAASpotStateController.STATE
{
	NONE = 0,
	MAP_MAIN = 1,
	QAA_HIDE = 2,
	QAA_GRAY = 3,
	QAA_DISP = 4,
	QAA_HIDE_QUICK = 5,
	QAA_GRAY_QUICK = 6,
	QAA_DISP_QUICK = 7,
	QAA_CHANGE = 8,
	QAA_ANIM = 9,
	SIZEOF = 10,
}

public enum QuestBoardListEffectComponent.STATE
{
	NONE = 0,
	PLAY = 1,
	SIZEOF = 2,
}

public enum QuestBoardListViewEarthLine.STATE
{
	NONE = 0,
	MAIN = 1,
	SIZEOF = 2,
}

public enum QuestBoardListViewItem.InfoKind
{
	AREA = 0,
	MAP = 1,
	STORY = 2,
	HERO = 3,
	CALDEA = 4,
	WARBOARD = 5,
	WAR_QUEST_SELECTION = 6,
	SIZEOF = 7,
}

public enum QuestBoardListViewItemDraw.PhaseShowType
{
	NORMAL = 0,
	EXTRA = 1,
}

public enum QuestBoardListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
}

public enum QuestBoardListViewItemDraw.enQBoardL1Type
{
	enNone = 0,
	enBanner = 1,
	enCapter = 2,
	enCaldeaGate = 3,
	enStory = 4,
	enHeroBallad = 5,
	enWarBoard = 6,
	enOrdealCall = 7,
	enMAX = 8,
}

public enum QuestBoardListViewItemDraw.enStatus
{
	enNone = 0,
	enNew = 1,
	enClear = 2,
	enComplete = 3,
	enPickup = 4,
	enMAX = 5,
	enNotice = 6,
}

public enum QuestBoardListViewItemDraw.BannerState
{
	NONE = 0,
	READY = 1,
	PLAY_SLIDE = 2,
}

public enum QuestBoardListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
	INTO = 3,
	EXIT = 4,
	FADE_IN = 5,
	FADE_OUT = 6,
}

public enum QuestBoardListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

protected enum QuestBoardListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	INPUT = 2,
}

public enum QuestIncomingAction.STATE
{
	NONE = 0,
	PLAY = 1,
	SIZEOF = 2,
}

private enum QuestInformationComponent.TabStatus
{
	REWARD = 0,
	ENEMY = 1,
}

public enum QuestInformationComponent.DisplayScene
{
	NONE = 0,
	TERMINAL = 1,
	PARTY_CHECK = 2,
}

private enum QuestInformationComponent.DispAnimState
{
	IDLE = 0,
	FRAME_IN = 1,
	FRAME_OUT = 2,
}

public enum QuestInformationListViewItem.InfoType
{
	REWARD = 0,
	ENEMY = 1,
}

public enum QuestInformationListViewItem.rewardType
{
	UNDROP = 0,
	SERVANT = 1,
	ITEM = 2,
}

public enum QuestInformationListViewItem.EnemyType
{
	UNKNOWN = 0,
	SERVANT = 1,
	ENEMY = 2,
}

public enum QuestInformationListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum QuestInformationListViewManager.Kind
{
	NORMAL = 0,
}

public enum QuestInformationListViewManager.InitMode
{
	NONE = 0,
	INPUT = 1,
}

public enum QuestInformationListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

protected enum QuestInformationListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum QuestRewardBoxAction.BOX_TYPE
{
	NORMAL = 0,
	SILVER = 1,
	GOLD = 2,
	SIZEOF = 3,
}

public enum QuestRewardBoxAction.STATE
{
	NONE = 0,
	PLAY = 1,
	SIZEOF = 2,
}

public enum QuestRewardCostumeAction.STATE
{
	NONE = 0,
	PLAY = 1,
	ITEM_LABEL = 2,
	TOUCH_WAIT = 3,
	SIZEOF = 4,
}

public enum QuestRewardHarvestAction.STATE
{
	NONE = 0,
	PLAY = 1,
	ITEM_LABEL = 2,
	TOUCH_WAIT = 3,
	SIZEOF = 4,
}

private enum QuestRewardHeelPortraitAction.STATE
{
	NONE = 0,
	PLAY = 1,
	TOUCH_WAIT = 2,
}

public enum QuestRewardItemAction.STATE
{
	NONE = 0,
	PLAY = 1,
	ITEM_LABEL = 2,
	TOUCH_WAIT = 3,
	SIZEOF = 4,
}

public enum QuestRewardOrderGradeAction.STATE
{
	NONE = 0,
	PLAY = 1,
	ITEM_LABEL = 2,
	TOUCH_WAIT = 3,
	SIZEOF = 4,
}

public enum QuestRewardTokenAction.STATE
{
	NONE = 0,
	PLAY = 1,
	TOUCH_WAIT = 2,
	SIZEOF = 3,
}

public enum ScrPlayerStatus.enSpell
{
	Zero = 0,
	One = 1,
	Two = 2,
	Tree = 3,
	enMAX = 4,
}

private enum ScrPlayerStatus.MstMissionState
{
	Weekly = 0,
	Limited = 1,
}

public enum ScrTerminalListTop.enPrevList
{
	TOPMENU = 0,
	HEROBALLAD = 1,
	STORY = 2,
}

public enum ScrTerminalListTop.AdditionalDlgMessage.TYPE
{
	NONE = 0,
	QUEST = 1,
	SERVANT_MATERIAL = 2,
	SERVANT_COSTUME = 3,
	QUEST_STORY = 4,
	SERVANT_MATERIAL_SG = 5,
}

public enum ScrTerminalMap.STATE
{
	ALL_DISP = 0,
	SPOT_ONLY = 1,
	ALL_HIDE = 2,
}

public enum ServantRewardAction.PLAY_FLAG
{
	NONE = 0,
	SVT_NEW = 1,
	FADE_IN = 2,
	FADE_OUT = 4,
	EVENT_SVT_GET = 8,
	NEW_EFFECT = 16,
	DETAIL_SKIP = 32,
	EVENT_JOIN_SKIP = 64,
}

public enum ServantRewardAction.STATE
{
	NONE = 0,
	PLAY = 1,
	NUM_DISPLAY = 2,
	TOUCH_WAIT = 3,
	TALK = 4,
	DETAIL = 5,
	SECRET_TREASURE_DEVICE = 6,
	END = 7,
	SIZEOF = 8,
}

public enum SpotLargeComponent.STATE
{
	NONE = 0,
	LARGE_IN = 1,
	LARGE_MAIN = 2,
	LARGE_OUT = 3,
	SIZEOF = 4,
}

public enum SrcSpotBasePrefab.STATE
{
	NONE = 0,
	MAP_MAIN = 1,
	QAA_HIDE = 2,
	QAA_GRAY = 3,
	QAA_DISP = 4,
	QAA_CHANGE = 5,
	SIZEOF = 6,
}

public enum TerminalBannerComponent.DIR
{
	NONE = 0,
	L = 1,
	R = 2,
}

public enum EventConquestInfo.GiftType
{
	NONE = 1,
	ITEM = 2,
}

public enum TerminalPramsManager.enSceneStatus
{
	enNone = 0,
	enInitialize = 1,
	enResume = 2,
	enResumeFromScript = 3,
	enMAX = 4,
}

public enum TerminalPramsManager.eDispState
{
	None = 0,
	Top = 1,
	Map = 2,
	Caldea = 3,
	Story = 4,
	Hero = 5,
	MAX = 6,
}

public enum TerminalPramsManager.eSpecifiedScene
{
	None = 0,
	EventReward = 1,
}

public enum clsQuestCheck.QUEST_START_EFFECT_SKIP
{
	NONE = 0,
	FIRST = 1,
	SECOND = 2,
	DESABLE = 3,
}

public enum srcLineSprite.STATE
{
	NONE = 0,
	MAP_MAIN = 1,
	QAA_HIDE = 2,
	QAA_GRAY = 3,
	QAA_DISP = 4,
	SIZEOF = 5,
}

public enum BackViewListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum BackViewListViewManager.InitMode
{
	NONE = 0,
	INPUT = 1,
}

protected enum BackViewListViewMenu.State
{
	INIT = 0,
	INIT_MOVE = 1,
	INPUT = 2,
	VIEW_BACK = 3,
	SELECTED = 4,
	CLOSE = 5,
}

public enum BackViewListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

protected enum BackViewListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum CostSpriteCheckView.FilterMode
{
	ALL = 0,
	FAILED = 1,
	SUCCESS = 2,
}

public enum CostSpriteListManager.ListType
{
	ALL = 0,
	FAILED = 1,
	SUCCESS = 2,
}

public enum DPIListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum DPIListViewManager.InitMode
{
	NONE = 0,
	INPUT = 1,
}

protected enum DPIListViewMenu.State
{
	INIT = 0,
	INPUT = 1,
}

public enum DPIListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

protected enum DPIListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum DebugListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum DebugListViewManager.InitMode
{
	NONE = 0,
	INPUT = 1,
}

protected enum DebugListViewMenu.State
{
	INIT = 0,
	INPUT = 1,
}

public enum DebugListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	FADEIN = 3,
	INTO = 4,
	INPUT = 5,
}

protected enum DebugListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

protected enum DebugSignupMenu.State
{
	INIT = 0,
	INPUT = 1,
	INPUT_OBJECT_MENU = 2,
	SELECTED = 3,
	CLOSE = 4,
}

protected enum EquipGraphViewListViewMenu.State
{
	INIT = 0,
	INIT_MOVE = 1,
	INPUT = 2,
	VIEW_EQUIPGRAPH = 3,
	SELECTED = 4,
	CLOSE = 5,
}

public enum FigureViewListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum FigureViewListViewManager.InitMode
{
	NONE = 0,
	INPUT = 1,
}

protected enum FigureViewListViewMenu.State
{
	INIT = 0,
	INIT_MOVE = 1,
	INPUT = 2,
	VIEW_FIGURE = 3,
	SELECTED = 4,
	CLOSE = 5,
}

public enum FigureViewListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

protected enum FigureViewListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum ReceiptListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum ReceiptListViewManager.InitMode
{
	NONE = 0,
	INTO = 1,
	INPUT = 2,
}

protected enum ReceiptListViewMenu.State
{
	INIT = 0,
	INIT_MOVE = 1,
	INPUT = 2,
	CHECK_RECEIPT_VIEW = 3,
	SELECTED = 4,
	CLOSE = 5,
}

public enum ReceiptListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	FADEIN = 3,
	INTO = 4,
	INPUT = 5,
}

protected enum ReceiptListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

protected enum ReceiptViewMenu.State
{
	INIT = 0,
	INPUT = 1,
	SELECTED = 2,
	CLOSE = 3,
}

public enum ScriptAssetListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum ScriptAssetListViewManager.InitMode
{
	NONE = 0,
	INPUT = 1,
}

protected enum ScriptAssetListViewMenu.State
{
	INIT = 0,
	INIT_MOVE = 1,
	INPUT = 2,
	INPUT_OBJECT_MENU = 3,
	PLAY_SCRIPT = 4,
	SELECTED = 5,
	CLOSE = 6,
}

public enum ScriptAssetListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

protected enum ScriptAssetListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum ScriptBranchListViewItem.BranchType
{
	Material = 0,
	NotMaterial = 1,
	QuestClear = 2,
	QuestNotClear = 3,
	Revival = 4,
	HaveServantEquip = 5,
	NotHaveServantEquip = 6,
	RouteSelect = 7,
	NotRouteSelect = 8,
	IfClear = 9,
	tRoute = 10,
	bScene = 11,
}

public enum ScriptBranchListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum ScriptBranchListViewManager.InitMode
{
	NONE = 0,
	INPUT = 1,
}

public enum ScriptBranchListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

private enum ScriptBranchListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

private enum ScriptBranchMenu.State
{
	INIT = 0,
	INPUT = 1,
}

private enum ScriptBranchMenu.SortType
{
	Line = 0,
	Command = 1,
}

public enum ScriptConnectListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum ScriptConnectListViewManager.InitMode
{
	NONE = 0,
	INPUT = 1,
}

public enum ScriptConnectListViewManager.ResultKind
{
	NONE = 0,
	CANCEL = 1,
	PLAY = 2,
	VIEW_PLAY = 3,
}

public enum ScriptConnectListViewMenu.ResultKind
{
	NONE = 0,
	CANCEL = 1,
	PLAY = 2,
	VIEW_PLAY = 3,
}

protected enum ScriptConnectListViewMenu.State
{
	INIT = 0,
	LOAD = 1,
	INIT_MOVE = 2,
	INPUT = 3,
	INPUT_OBJECT_MENU = 4,
	SELECTED = 5,
	CLOSE = 6,
}

public enum ScriptConnectListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

protected enum ScriptConnectListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

protected enum ScriptConnectMenu.State
{
	INIT = 0,
	INPUT = 1,
	INPUT_OBJECT_MENU = 2,
	SELECTED = 3,
	CLOSE = 4,
	PLAY_SCRIPT = 5,
}

protected enum ScriptDefaultFilePlayerMenu.State
{
	INIT = 0,
	INPUT = 1,
	INPUT_OBJECT_MENU = 2,
	SELECTED = 3,
	CLOSE = 4,
	PLAY_SCRIPT = 5,
}

protected enum ScriptFilePlayerMenu.State
{
	INIT = 0,
	INPUT = 1,
	INPUT_OBJECT_MENU = 2,
	SELECTED = 3,
	CLOSE = 4,
	PLAY_SCRIPT = 5,
}

public enum ScriptObjectListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum ScriptObjectListViewManager.InitMode
{
	NONE = 0,
	INPUT = 1,
}

public enum ScriptObjectListViewManager.ResultKind
{
	NONE = 0,
	CANCEL = 1,
	PLAY = 2,
	VIEW_PLAY = 3,
}

public enum ScriptObjectListViewMenu.ResultKind
{
	NONE = 0,
	CANCEL = 1,
	PLAY = 2,
	VIEW_PLAY = 3,
}

protected enum ScriptObjectListViewMenu.State
{
	INIT = 0,
	LOAD = 1,
	INPUT = 2,
	INPUT_OBJECT_MENU = 3,
	SELECTED = 4,
	CLOSE = 5,
}

public enum ScriptObjectListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

protected enum ScriptObjectListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum ScriptPlayListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum ScriptPlayListViewManager.InitMode
{
	NONE = 0,
	INPUT = 1,
}

public enum ScriptPlayListViewManager.ResultKind
{
	NONE = 0,
	CANCEL = 1,
	PLAY = 2,
	VIEW_PLAY = 3,
}

public enum ScriptPlayListViewMenu.ResultKind
{
	NONE = 0,
	CANCEL = 1,
	PLAY = 2,
	VIEW_PLAY = 3,
}

protected enum ScriptPlayListViewMenu.State
{
	INIT = 0,
	LOAD = 1,
	INIT_MOVE = 2,
	INPUT = 3,
	INPUT_OBJECT_MENU = 4,
	SELECTED = 5,
	CLOSE = 6,
}

public enum ScriptPlayListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

protected enum ScriptPlayListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum ScriptTextListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum ScriptTextListViewManager.InitMode
{
	NONE = 0,
	INPUT = 1,
}

public enum ScriptTextListViewManager.ResultKind
{
	NONE = 0,
	CANCEL = 1,
	PLAY = 2,
	JUMP_PLAY = 3,
}

public enum ScriptTextListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

protected enum ScriptTextListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum ScriptTextViewMenu.ResultKind
{
	NONE = 0,
	CANCEL = 1,
	PLAY = 2,
	JUMP_PLAY = 3,
}

protected enum ScriptTextViewMenu.State
{
	INIT = 0,
	INPUT = 1,
	SELECTED = 2,
	CLOSE = 3,
}

protected enum ServerSettingMenu.State
{
	INIT = 0,
	INPUT = 1,
	SELECTED = 2,
	CLOSE = 3,
}

protected enum SoundTestMenu.State
{
	INIT = 0,
	INPUT = 1,
	INPUT_OBJECT_MENU = 2,
	SELECTED = 3,
	CLOSE = 4,
}

private enum SoundTestMenu.SortType
{
	CUE_NUM = 0,
	ASCENDING_ORDER = 1,
	DESCENDING_ORDER = 2,
}

private enum SoundTestMenu.PrefixList
{
	CHARA_VOICE = 0,
	NOBLE_PHANTASM = 1,
	SERVANTS = 2,
	VAL_VOICE = 3,
	SE_SPLIT = 4,
	RESIDENT_SE = 5,
	SE = 6,
	BATTLE = 7,
	RESOURCE_SOUND = 8,
	NONE = 9,
	MAX = 10,
}

protected enum WebConnectMenu.State
{
	INIT = 0,
	INPUT = 1,
	SELECTED = 2,
	CLOSE = 3,
}

protected enum SampleAssetBundleScene.State
{
	INIT = 0,
	LOAD_ASSET_BUNDLE = 1,
	LOAD_MEMORY = 2,
	IDLE = 3,
}

public enum SampleCardListViewDropObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	FADEIN = 3,
	INTO = 4,
	TURN = 5,
	INPUT = 6,
	DRAG_MOVE = 7,
	DRAG_DELETE = 8,
}

protected enum SampleCardListViewDropObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum SampleCardListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum SampleCardListViewManager.InitMode
{
	NONE = 0,
	INTO = 1,
	INTO_TURN = 2,
	INPUT = 3,
}

public enum SampleCardListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	FADEIN = 3,
	INTO = 4,
	TURN = 5,
	INPUT = 6,
}

protected enum SampleCardListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

protected enum SampleCardListViewScene.State
{
	INIT = 0,
	INIT_MOVE = 1,
	INIT_TURN = 2,
	INPUT = 3,
}

public enum SampleEventListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum SampleEventListViewManager.InitMode
{
	NONE = 0,
	INTO = 1,
	INPUT = 2,
}

public enum SampleEventListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	FADEIN = 3,
	INTO = 4,
	INPUT = 5,
}

protected enum SampleEventListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

protected enum SampleEventListViewScene.State
{
	INIT = 0,
	INIT_MOVE = 1,
	INPUT = 2,
}

protected enum LogoMain.Status
{
	NONE = 0,
	FADEIN = 1,
	WAIT = 2,
	FADEOUT = 3,
	WAIT2 = 4,
	CANCEL = 5,
}

protected enum TakeoverConfirmMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

protected enum TakeoverDecideMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

protected enum TermsOfUseMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

protected enum WarBoardBGEffectComponent.Status
{
	NONE = 0,
	DEFAULT = 1,
	PAUSE = 2,
	START = 3,
	LOOP = 4,
	END = 5,
}

private enum WarBoardControlUiDataComponent.ComponentType
{
	Square = 0,
	Piece = 1,
}

private enum WarBoardControlUiDataComponent.AdjustType
{
	Default = 0,
	Treasure = 1,
	Item = 2,
	Wall = 3,
	Goal = 4,
	Servant = 5,
	Master = 6,
}

public enum WarBoardOverlayEffectComponent.Kind
{
	TOUCH = 0,
	TIME = 1,
}

private enum WarBoardServantPieceComponent.DeadEffectTypes
{
	NormalDead = 0,
	Escape = 1,
	Special = 2,
}

private enum WarBoardTreasureComponent.Rarity
{
	COMMON = 0,
	RARE = 1,
	SRARE = 2,
	COMMON_PLUS = 3,
	RARE_PLUS = 4,
	SRARE_PLUS = 5,
	COMMON_PLUS2 = 6,
	RARE_PLUS2 = 7,
	SRARE_PLUS2 = 8,
	ITEM_ICON = 9,
	ITEM_ICON_PLUS = 10,
	ITEM_ICON_PLUS2 = 11,
}

public enum WarBoardEventBossUIComponent.BossUIDataIndex
{
	SATGE_BOSS_IDX = 0,
	CURRENT_HP = 1,
	DEFEAT_POINT = 2,
	MAX = 3,
}

public enum WarBoardAIRoute.DistanceType
{
	none = 0,
	approach = 1,
	noChange = 2,
	leave = 3,
}

public enum WarBoardAIRoute.RouteData.Kind
{
	NONE = 0,
	isAttack = 1,
	isAttackMove = 2,
	isMasterDefense = 3,
	isAttackRange = 4,
	isAttackMasterRange = 5,
	isMoveByAttackRange = 6,
	isMoveByAttackRangeMaster = 7,
	isBenefitRange = 8,
	isMoveByBenefitRange = 9,
	isDefenseAreaOnEnemy = 10,
	isDefenseAreaOnServant = 11,
	existClassAdvantageServant = 12,
	existClassDisAdvantageServant = 13,
	existAttackAdvantageServant = 14,
	existAttackDisAdvantageServant = 15,
	existDefenseAdvantageServant = 16,
	existDefenseDisAdvantageServant = 17,
	isTargetClassAdvantage = 18,
	isTargetAttackAdvantage = 19,
	isTargetDefenseAdvantage = 20,
	isTargetClassDisAdvantage = 21,
	isTargetAttackDisAdvantage = 22,
	isTargetDefenseDisAdvantage = 23,
	isAroundClassAdvantage = 24,
	isMoveByAroundClassAdvantage = 25,
	isAllyReplace = 26,
	isGetItem = 27,
	isMoveOnItem = 28,
	isAllBlockShortestRouteEnemyAndMaster = 29,
	isMoveOnAllBlockShortestRouteEnemyAndMaster = 30,
	isBlockShortestRouteEnemyAndMaster = 31,
	isMoveOnBlockShortestRouteEnemyAndMaster = 32,
	isMoveOnEffect = 33,
	isAroundAllyMaster = 34,
	isAroundAllyServant = 35,
	isMoveByMasterOnBlockShortestRouteEnemyAndMaster = 36,
	isDefenseAreaWithInEnemyAllBlock = 37,
	isMoveByDefenseAreaServant = 38,
	isMoveByDefenseAreaEnemy = 39,
	isAllDefenseAreaEnemyRouteBlock = 40,
	isComeBackSquare = 41,
	isMoveByAllDefenseAreaEnemyRouteBlock = 42,
}

public enum WarBoardAIRoute.RouteData.Flag
{
	NONE = 1,
	isAttack = 2,
	isAttackMove = 4,
	isMasterDefense = 8,
	isAttackRange = 16,
	isAttackMasterRange = 32,
	isMoveByAttackRange = 64,
	isMoveByAttackRangeMaster = 128,
	isBenefitRange = 256,
	isMoveByBenefitRange = 512,
	isDefenseAreaOnEnemy = 1024,
	isDefenseAreaOnServant = 2048,
	existClassAdvantageServant = 4096,
	existClassDisAdvantageServant = 8192,
	existAttackAdvantageServant = 16384,
	existAttackDisAdvantageServant = 32768,
	existDefenseAdvantageServant = 65536,
	existDefenseDisAdvantageServant = 131072,
	isTargetClassAdvantage = 262144,
	isTargetAttackAdvantage = 524288,
	isTargetDefenseAdvantage = 1048576,
	isTargetClassDisAdvantage = 2097152,
	isTargetAttackDisAdvantage = 4194304,
	isTargetDefenseDisAdvantage = 8388608,
	isAroundClassAdvantage = 16777216,
	isMoveByAroundClassAdvantage = 33554432,
	isAllyReplace = 67108864,
	isGetItem = 134217728,
	isMoveOnItem = 268435456,
	isAllBlockShortestRouteEnemyAndMaster = 536870912,
	isMoveOnAllBlockShortestRouteEnemyAndMaster = 1073741824,
	isBlockShortestRouteEnemyAndMaster = 2147483648,
	isMoveOnBlockShortestRouteEnemyAndMaster = 4294967296,
	isMoveOnEffect = 8589934592,
	isAroundAllyMaster = 17179869184,
	isAroundAllyServant = 34359738368,
	isMoveByMasterOnBlockShortestRouteEnemyAndMaster = 68719476736,
	isDefenseAreaWithInEnemyAllBlock = 137438953472,
	isMoveByDefenseAreaServant = 274877906944,
	isMoveByDefenseAreaEnemy = 549755813888,
	isAllDefenseAreaEnemyRouteBlock = 1099511627776,
	isComeBackSquare = 2199023255552,
	isMoveByAllDefenseAreaEnemyRouteBlock = 4398046511104,
}

public enum WarBoardAIRoute.AIRouteMasterData.MasterType
{
	DEFAULT = 0,
	SQUARE = 1,
	SERVANT = 2,
	NONE = 3,
}

public enum IWarBoardObjectData.AiTargetSortLevel
{
	Item = 0,
	Treasure = 1,
	Wall = 2,
	Piece = 3,
}

public enum WarBoardData.LocalSaveTiming
{
	NORMAL = 0,
	PLAY_START = 1,
	PIECE_ACTION_BEFORE = 2,
	BATTLE_BEFORE = 3,
	BATTLE_AFTER = 4,
	NEXT_TURN_BEFORE = 5,
	TURN_END_BEFORE = 6,
	TURN_END_AFTER = 7,
	CONTINUE = 8,
}

public enum WarBoardPieceData.RoleType
{
	NONE = 0,
	DANGER = 1,
}

public enum WarBoardSquareData.Flag
{
	WARNING_AREA = 1,
}

public enum WarBoardManager.STATE
{
	ALL_DISP = 0,
	SPOT_ONLY = 1,
	ALL_HIDE = 2,
}

public enum WarBoardManager.ControllType
{
	None = 0,
	Configuration = 1,
	Playing = 2,
}

public enum WarBoardManager.WarBoardSqEfType
{
	omen = 1,
	miasma = 2,
}

public enum WarBoardManager.WarBoardResult
{
	Win = 1,
	Lose = 2,
	Retire = 3,
}

public enum WarBoardManager.WarBoardBreakPointDamageType
{
	DAMAGE_TYPE_NONE = 0,
	DAMAGE_TYPE_NORMAL = 1,
	DAMAGE_TYPE_SAFE = 2,
	DAMAGE_TYPE_ALL_SAFE = 3,
	DAMAGE_TYPE_SAFE_ONCE = 4,
}

public enum WarBoardManager.WarBoardOnBoardSkillParam.BossProcessType
{
	Type1 = 1,
}

private enum WarBoardManager.TargetType
{
	PIECE = 0,
	SQUARE = 1,
}

public enum WarBoardPartyListViewObject.InitMode
{
	VALID = 0,
	CHANGE = 1,
	INPUT = 2,
}

protected enum WarBoardPartyListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

public enum WarBoardPartyOrganizationListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	DRAG_INVISIBLE = 4,
}

public enum WarBoardPartyOrganizationListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	CHANGE = 2,
	INPUT = 3,
}

public enum ContinueConfirmPopup.RESULT
{
	USE_STONE = 1,
	USE_SPELL = 2,
	GIVE_UP = 3,
}

private enum WarBoardSimplePopupElementServant.DispType
{
	NORMAL = 0,
	HAS_COST = 1,
}

protected enum WarBoardBackMenuComponent.State
{
	INIT = 0,
	OPEN = 1,
}

protected enum WarBoardServantEquipSimpleDialogComponent.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
}

public enum WarBoardTreasureListComponent.DialogType
{
	AcquiredDialog = 0,
	RewardDialog = 1,
	GetTreasureListDialog = 2,
}

public enum WarBoardCondType.Kind
{
	PIECE_DEFEAT = 1,
	PIECE_TARGET_NUM_BELOW = 2,
	TARGET_TURN = 3,
	TARGET_TURN_MULTIPLE = 4,
	TARGET_SQUARE_MOVE = 5,
	PIECE_ALIVE = 6,
	TARGET_TURN_COND_ACHIEVE = 7,
	TARGET_TURN_MULTIPLE_COND_ACHIEVE = 8,
	SQUARE_INDEX_GROUP_SVT_NUM_COMP_MORE = 9,
	SQUARE_INDEX_GROUP_SVT_NUM_COMP_LESS = 10,
	BOSS_STATUS = 11,
	NOT_BOSS_STATUS = 12,
	WALL_DESTROY = 13,
	PIECE_BREAK_POINT_DEFEAT = 14,
	REINFORCEMENTS_APPEAR_ID = 15,
	INDIVIDUALITY_TARGET_NUM_BELOW = 16,
	TARGET_TURN_FIRST_EVENT_DONE = 17,
	TARGET_TURN_LATEST_EVENT_DONE = 18,
	TARGET_TURN_MULTIPLE_FIRST_EVENT_DONE = 19,
	TARGET_TURN_MULTIPLE_LATEST_EVENT_DONE = 20,
	SPECIFIED_FORCE_TURN = 21,
	TARGET_EVENT_NOT_DONE = 22,
}

public enum WarBoardEventTiming.Kind
{
	ATTACK_BEFORE = 1,
	ATTACK_AFTER = 2,
	WAR_BOARD_START_BEFORE = 4,
	WAR_BOARD_START_AFTER = 5,
	WAR_BOARD_WIN_BEFORE = 6,
	WAR_BOARD_WIN_AFTER = 7,
	GET_TREASURE_BOX_BEFORE = 8,
	GET_TREASURE_BOX_AFTER = 9,
	DEFEAT_HALF_ENEMY_BEFORE = 10,
	DEFEAT_HALF_ENEMY_AFTER = 11,
	WAR_BOARD_LOSE_BEFORE = 12,
	WAR_BOARD_LOSE_AFTER = 13,
	PLAYER_TURN_START = 14,
	ENEMY_TURN_START = 15,
	PLAYER_TURN_END = 16,
	ENEMY_TURN_END = 17,
	ATTACK_TARGET_PIECE_BEFORE = 19,
	ATTACK_TARGET_PIECE_AFTER = 20,
	MY_SVT_NUM_BELOW = 22,
	ENEMY_SVT_NUM_BELOW = 23,
	DEFEAT_ENEMY_BEFORE = 24,
	DEFEAT_ENEMY_AFTER = 25,
	ATTACK_WALL_BEFORE = 26,
	ATTACK_WALL_AFTER = 27,
	WIN_COND_ACHIEVED = 28,
	INITIAL_WAR_BOARD = 29,
	PIECE_MOVE_BEFORE = 30,
	BREAK_TARGET_PIECE_BEFORE = 32,
	BREAK_TARGET_PIECE_AFTER = 33,
	DEFEAT_TARGET_PIECE_BEFORE = 34,
	DEFEAT_TARGET_PIECE_AFTER = 35,
	PIECE_MOVE_TARGET_SQUARE_BEFORE = 36,
	PIECE_MOVE_TARGET_SQUARE_AFTER = 37,
	PIECE_MOVE_AFTER = 38,
	PIECE_JOIN_BATTLE_BEFORE = 39,
	PIECE_JOIN_BATTLE_AFTER = 40,
	PIECE_JOIN_BATTLE_MOVE_BEFORE = 41,
	ATTACK_MOVE_BEFORE = 42,
	ATTACK_TARGET_PIECE_MOVE_BEFORE = 43,
	CONTINUE_WAR_BOARD = 44,
	BEFORE_ENTRY_WAR_BOARD = 45,
}

public enum WarehouseConfirmMenu.Kind
{
	CONFIRM_PUT_IN_SERVANT = 0,
	CONFIRM_PUT_IN_SERVANT_EQUIP = 1,
	CONFIRM_PUT_OUT_SERVANT = 2,
	CONFIRM_PUT_OUT_SERVANT_EQUIP = 3,
	NOTIFICATION_PUT_IN_SERVANT = 4,
	NOTIFICATION_PUT_IN_SERVANT_EQUIP = 5,
	NOTIFICATION_PUT_OUT_SERVANT = 6,
	NOTIFICATION_PUT_OUT_SERVANT_EQUIP = 7,
	OVER_PUT_IN_SERVANT = 8,
	OVER_PUT_IN_SERVANT_EQUIP = 9,
	OVER_PUT_OUT_SERVANT = 10,
	OVER_PUT_OUT_SERVANT_EQUIP = 11,
}

protected enum WarehouseConfirmMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
}

public enum WarehouseListManager.Kind
{
	SERVANT = 0,
	SERVANT_EQUIP = 1,
	WAREHOUSE_SERVANT = 2,
	WAREHOUSE_SERVANT_EQUIP = 3,
}

public enum WarehouseListManager.ModeKind
{
	STATUS = 0,
	LOCK = 1,
	CHOICE = 2,
	PUSH = 3,
	SUM = 4,
}

public enum WarehouseListManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
	MODIFY = 3,
}

public enum WarehouseListManager.ResultKind
{
	NONE = 0,
	DECIDE = 1,
	SHOW_STATUS = 2,
	PUSH_SERVANT = 3,
}

public enum WarehouseListMenu.Kind
{
	SERVANT = 0,
	SERVANT_EQUIP = 1,
	RETRY = 2,
	MODIFY = 3,
	CHANGE = 4,
}

public enum WarehouseListMenu.TabKind
{
	SERVANT = 0,
	SERVANT_EQUIP = 1,
	WAREHOUSE_SERVANT = 2,
	WAREHOUSE_SERVANT_EQUIP = 3,
	SUM = 4,
}

public enum WarehouseListMenu.ModeKind
{
	STATUS = 0,
	LOCK = 1,
	CHOICE = 2,
	PUSH = 3,
	SUM = 4,
}

public enum WarehouseListMenu.ResultKind
{
	CANCEL = 0,
	MODIFY = 1,
	SERVANT_QUEST = 2,
}

protected enum WarehouseListMenu.State
{
	INIT = 0,
	OPEN = 1,
	INPUT = 2,
	SELECTED = 3,
	CLOSE = 4,
	CONFIRM_MOVE = 5,
	REQUEST_MOVE = 6,
	SERVANT_STATUS = 7,
}

public enum WarehouseListViewItem.ServantAttributeKind
{
	NONE = 0,
	HEROINE = 1,
	LIMITED = 2,
}

public enum WarehouseListViewItemDraw.DispMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
}

public enum WarehouseListViewManager.Kind
{
	SERVANT = 0,
	SERVANT_EQUIP = 1,
	WAREHOUSE_SERVANT = 2,
	WAREHOUSE_SERVANT_EQUIP = 3,
}

public enum WarehouseListViewManager.InitMode
{
	NONE = 0,
	VALID = 1,
	INPUT = 2,
	MODIFY = 3,
}

public enum WarehouseListViewManager.ResultKind
{
	NONE = 0,
	SELECT_ITEM = 1,
	SHOW_STATUS = 2,
}

public enum WarehouseListViewObject.InitMode
{
	INVISIBLE = 0,
	INVALID = 1,
	VALID = 2,
	INPUT = 3,
	MODIFY = 4,
}

protected enum WarehouseListViewObject.State
{
	INIT = 0,
	IDLE = 1,
	MOVE = 2,
	INPUT = 3,
}

protected enum WarehouseRootComponent.State
{
	INIT = 0,
	INPUT_WAREHOUSE_LIST = 1,
}

public enum UIButtonColor.State
{
	Normal = 0,
	Hover = 1,
	Pressed = 2,
	Disabled = 3,
}

public enum UIButtonMessage.Trigger
{
	OnClick = 0,
	OnMouseOver = 1,
	OnMouseOut = 2,
	OnPress = 3,
	OnRelease = 4,
	OnDoubleClick = 5,
}

public enum UIDragDropItem.Restriction
{
	None = 0,
	Horizontal = 1,
	Vertical = 2,
	PressAndHold = 3,
}

public enum UIDragObject.DragEffect
{
	None = 0,
	Momentum = 1,
	MomentumAndSpring = 2,
}

public enum UIGrid.Arrangement
{
	Horizontal = 0,
	Vertical = 1,
	CellSnap = 2,
}

public enum UIGrid.Sorting
{
	None = 0,
	Alphabetic = 1,
	Horizontal = 2,
	Vertical = 3,
	Custom = 4,
}

public enum UIKeyBinding.Action
{
	PressAndClick = 0,
	Select = 1,
	All = 2,
}

public enum UIKeyBinding.Modifier
{
	None = 0,
	Shift = 1,
	Control = 2,
	Alt = 3,
}

public enum UIKeyNavigation.Constraint
{
	None = 0,
	Vertical = 1,
	Horizontal = 2,
	Explicit = 3,
}

public enum UIPlaySound.Trigger
{
	OnClick = 0,
	OnMouseOver = 1,
	OnMouseOut = 2,
	OnPress = 3,
	OnRelease = 4,
	Custom = 5,
	OnEnable = 6,
	OnDisable = 7,
}

public enum UIPopupList.Position
{
	Auto = 0,
	Above = 1,
	Below = 2,
}

public enum UIPopupList.OpenOn
{
	ClickOrTap = 0,
	RightClick = 1,
	DoubleClick = 2,
	Manual = 3,
}

public enum UIProgressBar.FillDirection
{
	LeftToRight = 0,
	RightToLeft = 1,
	BottomToTop = 2,
	TopToBottom = 3,
}

private enum UIScrollBar.Direction
{
	Horizontal = 0,
	Vertical = 1,
	Upgraded = 2,
}

public enum UIScrollView.Movement
{
	Horizontal = 0,
	Vertical = 1,
	Unrestricted = 2,
	Custom = 3,
}

public enum UIScrollView.DragEffect
{
	None = 0,
	Momentum = 1,
	MomentumAndSpring = 2,
}

public enum UIScrollView.ShowCondition
{
	Always = 0,
	OnlyIfNeeded = 1,
	WhenDragging = 2,
}

private enum UISlider.Direction
{
	Horizontal = 0,
	Vertical = 1,
	Upgraded = 2,
}

public enum UITable.Direction
{
	Down = 0,
	Up = 1,
}

public enum UITable.Sorting
{
	None = 0,
	Alphabetic = 1,
	Horizontal = 2,
	Vertical = 3,
	Custom = 4,
}

public enum NGUIText.Alignment
{
	Automatic = 0,
	Left = 1,
	Center = 2,
	Right = 3,
	Justified = 4,
}

public enum NGUIText.SymbolStyle
{
	None = 0,
	Normal = 1,
	Colored = 2,
}

public enum PropertyBinding.UpdateCondition
{
	OnStart = 0,
	OnUpdate = 1,
	OnLateUpdate = 2,
	OnFixedUpdate = 3,
}

public enum PropertyBinding.Direction
{
	SourceUpdatesTarget = 0,
	TargetUpdatesSource = 1,
	BiDirectional = 2,
}

public enum UIBasicSprite.Type
{
	Simple = 0,
	Sliced = 1,
	Tiled = 2,
	Filled = 3,
	Advanced = 4,
}

public enum UIBasicSprite.FillDirection
{
	Horizontal = 0,
	Vertical = 1,
	Radial90 = 2,
	Radial180 = 3,
	Radial360 = 4,
}

public enum UIBasicSprite.AdvancedType
{
	Invisible = 0,
	Sliced = 1,
	Tiled = 2,
}

public enum UIBasicSprite.Flip
{
	Nothing = 0,
	Horizontally = 1,
	Vertically = 2,
	Both = 3,
}

public enum UIDrawCall.Clipping
{
	None = 0,
	TextureMask = 1,
	SoftClip = 3,
	ConstrainButDontClip = 4,
}

public enum UIRect.AnchorUpdate
{
	OnEnable = 0,
	OnUpdate = 1,
	OnStart = 2,
}

public enum UIWidget.Pivot
{
	TopLeft = 0,
	Top = 1,
	TopRight = 2,
	Left = 3,
	Center = 4,
	Right = 5,
	BottomLeft = 6,
	Bottom = 7,
	BottomRight = 8,
}

public enum UIWidget.AspectRatioSource
{
	Free = 0,
	BasedOnWidth = 1,
	BasedOnHeight = 2,
}

public enum UITweener.Method
{
	Linear = 0,
	EaseIn = 1,
	EaseOut = 2,
	EaseInOut = 3,
	BounceIn = 4,
	BounceOut = 5,
	EaseOutQuad = 6,
	QuadraticIn = 7,
	QuadraticOut = 8,
	QuadraticInOut = 9,
	CubicIn = 10,
	CubicOut = 11,
	CubicInOut = 12,
	QuarticIn = 13,
	QuarticOut = 14,
	QuarticInOut = 15,
	QuinticIn = 16,
	QuinticOut = 17,
	QuinticInOut = 18,
}

public enum UITweener.Style
{
	Once = 0,
	Loop = 1,
	PingPong = 2,
}

public enum UIAnchor.Side
{
	BottomLeft = 0,
	Left = 1,
	TopLeft = 2,
	Top = 3,
	TopRight = 4,
	Right = 5,
	BottomRight = 6,
	Bottom = 7,
	Center = 8,
}

private enum UIAtlas.Coordinates
{
	Pixels = 0,
	TexCoords = 1,
}

public enum UIInput.InputType
{
	Standard = 0,
	AutoCorrect = 1,
	Password = 2,
}

public enum UIInput.Validation
{
	None = 0,
	Integer = 1,
	Float = 2,
	Alphanumeric = 3,
	Username = 4,
	Name = 5,
}

public enum UIInput.KeyboardType
{
	Default = 0,
	ASCIICapable = 1,
	NumbersAndPunctuation = 2,
	URL = 3,
	NumberPad = 4,
	PhonePad = 5,
	NamePhonePad = 6,
	EmailAddress = 7,
}

public enum UIInput.OnReturnKey
{
	Default = 0,
	Submit = 1,
	NewLine = 2,
}

public enum UILabel.Effect
{
	None = 0,
	Shadow = 1,
	Outline = 2,
	Outline8 = 3,
}

public enum UILabel.Overflow
{
	ShrinkContent = 0,
	ClampContent = 1,
	ResizeFreely = 2,
	ResizeHeight = 3,
}

public enum UILabel.Crispness
{
	Never = 0,
	OnDesktop = 1,
	Always = 2,
}

public enum UIRoot.Scaling
{
	Flexible = 0,
	Constrained = 1,
	ConstrainedOnMobiles = 2,
}

public enum UIRoot.Constraint
{
	Fit = 0,
	Fill = 1,
	FitWidth = 2,
	FitHeight = 3,
}

public enum UIStretch.Style
{
	None = 0,
	Horizontal = 1,
	Vertical = 2,
	Both = 3,
	BasedOnHeight = 4,
	FillKeepingRatio = 5,
	FitInternalKeepingRatio = 6,
}

public enum UITextList.Style
{
	Text = 0,
	Chat = 1,
}

public enum NGuiPlayMakerDelegates
{
	OnClickEvent = 0,
	OnHoverEvent = 1,
	OnHoverEventEnter = 2,
	OnHoverEventExit = 3,
	OnPressEvent = 4,
	OnPressEventUp = 5,
	OnPressEventDown = 6,
	OnSelectEvent = 7,
	OnDragEvent = 8,
	OnDropEvent = 9,
	OnSubmitEvent = 10,
	OnSliderChangeEvent = 11,
	OnSelectionChangeEvent = 12,
	OnTooltipEvent = 13,
	OnChangeEvent = 14,
}

public enum iTweenFSMType
{
	all = 0,
	move = 1,
	rotate = 2,
	scale = 3,
	shake = 4,
	position = 5,
	value = 6,
	look = 7,
}

public enum iTween.EaseType
{
	easeInQuad = 0,
	easeOutQuad = 1,
	easeInOutQuad = 2,
	easeInCubic = 3,
	easeOutCubic = 4,
	easeInOutCubic = 5,
	easeInQuart = 6,
	easeOutQuart = 7,
	easeInOutQuart = 8,
	easeInQuint = 9,
	easeOutQuint = 10,
	easeInOutQuint = 11,
	easeInSine = 12,
	easeOutSine = 13,
	easeInOutSine = 14,
	easeInExpo = 15,
	easeOutExpo = 16,
	easeInOutExpo = 17,
	easeInCirc = 18,
	easeOutCirc = 19,
	easeInOutCirc = 20,
	linear = 21,
	spring = 22,
	easeInBounce = 23,
	easeOutBounce = 24,
	easeInOutBounce = 25,
	easeInBack = 26,
	easeOutBack = 27,
	easeInOutBack = 28,
	easeInElastic = 29,
	easeOutElastic = 30,
	easeInOutElastic = 31,
	punch = 32,
}

public enum iTween.LoopType
{
	none = 0,
	loop = 1,
	pingPong = 2,
}

public enum iTween.NamedValueColor
{
	_Color = 0,
	_SpecColor = 1,
	_Emission = 2,
	_ReflectColor = 3,
}

public enum Trigger
{
	OnClick = 0,
	OnHover = 1,
	OnPress = 2,
	OnHoverTrue = 3,
	OnHoverFalse = 4,
	OnPressTrue = 5,
	OnPressFalse = 6,
	OnActivate = 7,
	OnActivateTrue = 8,
	OnActivateFalse = 9,
	OnDoubleClick = 10,
	OnSelect = 11,
	OnSelectTrue = 12,
	OnSelectFalse = 13,
}

public enum Direction
{
	Toggle = 0,
	Forward = 1,
}

public enum EnableCondition
{
	DoNothing = 0,
	EnableThenPlay = 1,
	IgnoreDisabledState = 2,
}

public enum DisableCondition
{
	DoNotDisable = 0,
	DisableAfterForward = 1,
}

public enum PieceType
{
	Servant = 0,
	Master = 1,
}

public enum FrequencyType
{
	ONCE = 1,
	EVERY_TIME = 2,
	EVERY_TURN = 3,
}

public enum EventAction
{
	PLAY_TALK = 1,
	CHANGE_WAR_BOARD_WIN_COND = 2,
	REINFORCE = 3,
	MOVE_CAMERA = 5,
	HIGHLIGHT_SQUARE_INDEX = 7,
	DEFEAT_PIECE = 8,
	DIRECT_SKILL = 9,
	UNLOCK_SQUARE_INDEX = 10,
	UNLOCK_SQUARE_ROAD = 11,
	WAIT = 12,
	UPDATE_BOSS_INFO = 14,
	BG_ANIMATION = 15,
	SQUARE_EFFECT_DISP = 16,
	SQUARE_EFFECT_HIDE = 17,
	OVERLAY_EFFECT = 19,
	SET_WARNING_AREA = 20,
	REMOVE_WARNING_AREA = 21,
	SET_UI_SQUARE = 22,
	SET_UI_PIECE = 23,
	CHANGE_ACTION_TYPE = 25,
	CHANGE_AI_ID = 26,
	DIRECT_SKILL_DELAYED_DEAD = 27,
	EVENT_TUTORIAL = 28,
}

protected enum SwitchingSoundInfoMenu.State
{
	INIT = 0,
	ACTIVE = 1,
}

public enum DebugItemMenuBase.Group
{
	ALL = 0,
	ASSET = 1,
	VIEW = 2,
	SOUND = 3,
	ETC = 4,
}

protected enum DebugItemRoot.State
{
	INIT = 0,
	INPUT = 1,
}

public enum USFGOActorBattleActionEvent.ActionType
{
	Damage = 0,
	BuffDebuff = 1,
	Heal = 2,
	DamageVoice = 3,
	SilentDead = 4,
	SelfDead = 5,
	MoveToSubMember = 6,
	FuncSideEffect = 7,
	TransformServantUpdateUi = 8,
}

public enum USFGOActorChangePosition.PosChangeTargetType
{
	ACTOR = 1,
}

public enum USFGOActorChangePosition.PosSetType
{
	TARGET = 0,
	TARGET_OTHER_FRONT = 1,
	TARGET_OTHER_BACK = 2,
}

public enum USFGOActorUpdateScale.UpdateType
{
	RATIO = 0,
	OVERWRITE = 1,
}

public enum FGOTarget
{
	ActorObject = 0,
	EnemyObject = 1,
	Zero = 2,
	Camera = 3,
	Actor1 = 4,
	Actor2 = 5,
	Actor3 = 6,
	Actor4 = 7,
	Actor5 = 8,
	Actor6 = 9,
	Node = 10,
}

public enum USFGOCameraEffectEvent.CameraEffectType
{
	Bloom = 0,
	MotionBlur = 1,
	Vignet = 2,
	Grayscale = 3,
}

public enum USFGOChangeShaderProperty.PropertyType
{
	Float = 0,
	Int = 1,
}

public enum USFGOCheckPlayerTypeFlip.FGOFlipPlayerType
{
	None = 0,
	Player = 1,
	Enemy = 2,
}

public enum USFGOChrAlphaChangeEvent.ChangeTarget
{
	Actor = 0,
	PlayerSide = 1,
	EnemySide = 2,
	All = 3,
	Other = 4,
}

public enum USFGOChrBulrEvent.MODE
{
	BULR_VALID = 0,
	BULR_LAG = 1,
}

public enum USFGOChrColorChange2Event.ChangeTarget
{
	Actor = 0,
	PlayerSide = 1,
	EnemySide = 2,
	All = 3,
	Other = 4,
}

public enum USFGOChrColorChangeEvent.ChangeTarget
{
	Actor = 0,
	PlayerSide = 1,
	EnemySide = 2,
	All = 3,
	Other = 4,
}

public enum USFGOChrDispChangeEvent.ChangeTarget
{
	Actor = 0,
	PlayerSide = 1,
	EnemySide = 2,
	All = 3,
}

public enum USFGOChrShadowColorSetEvent.ChangeTarget
{
	Actor = 0,
	PlayerSide = 1,
	EnemySide = 2,
	All = 3,
}

public enum USFGOCreateEffectEvent.EffectCategory
{
	ServantNoblePhantasm = 0,
	Servant = 1,
	Weapon = 2,
	Common = 3,
}

public enum USFGOCreateEffectEvent.EffectTarget
{
	Actor = 0,
	Target = 1,
	DamageTagets = 2,
	BuffTargets = 3,
	DebuffTargets = 4,
	PlayerParty = 5,
	EnemyParty = 6,
	All = 7,
}

public enum USFGOObjectFlip.FGOFlipTarget
{
	None = 0,
	X = 1,
	Y = 2,
	Z = 4,
	X_Y = 3,
	X_Z = 5,
	Y_Z = 6,
	X_Y_Z = 7,
}

public enum USFGOPlayAudioEvent.AudioCategory
{
	ServantNoblePhantasm = 0,
	ServantBattle = 1,
	ServantNormal = 2,
	Common = 3,
	BattleCommon = 4,
	Weapon = 5,
}

public enum USFGOPlayAudioEvent.AudioType
{
	Auto = 0,
	SE = 1,
	Voice = 2,
	VoiceNotStop = 3,
}

public enum USFGOResetCharacterPositionEvent.CharacterPosition
{
	ResetAll = 0,
	ResetPlayers = 1,
	ResetEnemies = 2,
}

public enum USFGOSetAudioGroupIndexConditional.WeightIndex.VoiceStrParam
{
	SVT_ID = 0,
	VOICE_PREFIX = 1,
	VOICE_ID = 2,
	TERM = 3,
}

public enum USFGOSetAudioGroupIndexConditional.AudioGroupData.ApplySide
{
	ALL = 0,
	PLAYER = 1,
	ENEMY = 2,
}

public enum USFGOTargetEffectSwitchEvent.EffectSwitch
{
	Off = 0,
	On = 1,
}

public enum USFGOTargetEffectSwitchEvent.SwitchType
{
	SwitchActive = 0,
	SwitchParticle = 1,
}

public enum USFGOToggleImageEffect.ImageEffectType
{
	Constrast = 0,
	Saturation = 1,
}

public enum EasingFunction.Ease
{
	EaseInQuad = 0,
	EaseOutQuad = 1,
	EaseInOutQuad = 2,
	EaseInCubic = 3,
	EaseOutCubic = 4,
	EaseInOutCubic = 5,
	EaseInQuart = 6,
	EaseOutQuart = 7,
	EaseInOutQuart = 8,
	EaseInQuint = 9,
	EaseOutQuint = 10,
	EaseInOutQuint = 11,
	EaseInSine = 12,
	EaseOutSine = 13,
	EaseInOutSine = 14,
	EaseInExpo = 15,
	EaseOutExpo = 16,
	EaseInOutExpo = 17,
	EaseInCirc = 18,
	EaseOutCirc = 19,
	EaseInOutCirc = 20,
	Linear = 21,
	Spring = 22,
	EaseInBounce = 23,
	EaseOutBounce = 24,
	EaseInOutBounce = 25,
	EaseInBack = 26,
	EaseOutBack = 27,
	EaseInOutBack = 28,
	EaseInElastic = 29,
	EaseOutElastic = 30,
	EaseInOutElastic = 31,
	CustomCurve = 32,
}

public enum FGOActorAnimation.ANIMATIONNAME
{
	NONE = 0,
	attack_a = 1,
	attack_b = 2,
	attack_q = 3,
	attack_gen = 4,
	spell = 5,
	damage_01 = 6,
	step_front = 7,
	step_back = 8,
	wait = 9,
	treasure_arms = 10,
	death_01 = 11,
	attack_ex = 12,
	attack_a02 = 13,
	attack_b02 = 14,
	attack_q02 = 15,
	attack_gen02 = 16,
	attack_ex02 = 17,
	attack_a03 = 18,
	attack_b03 = 19,
	attack_q03 = 20,
	attack_gen03 = 21,
	attack_ex03 = 22,
	spell02 = 23,
	spell03 = 24,
	step_back02 = 25,
	step_front02 = 26,
	attack_a04 = 27,
	attack_b04 = 28,
	attack_q04 = 29,
	attack_gen04 = 30,
	attack_ex04 = 31,
	damage_02 = 32,
	spell_loop = 33,
	treasureArms1_a = 34,
	treasureArms2_a = 35,
	treasureArms3_a = 36,
	treasureArms4_a = 37,
	treasureArms5_a = 38,
	wait02 = 39,
	wait03 = 40,
	attack_a05 = 41,
	attack_b05 = 42,
	attack_q05 = 43,
	attack_gen05 = 44,
	attack_ex05 = 45,
	sleep_wait01 = 46,
	spell04 = 47,
	spell05 = 48,
	counter_wait01 = 49,
	counter_attack01 = 50,
}

public enum FGOActorBulr.MODE
{
	BULR_VALID = 0,
	BULR_LAG = 1,
}

public enum FGOActorChangeLimitCount.ACTION
{
	CHANGE = 0,
	CHANGE_BASE = 1,
	RESET = 2,
}

public enum FGOActorCheck.CHECK
{
	NONE = 0,
	PREVATTACK_ME = 1,
	NEXTATTACK_ME = 2,
	ISPLAYER = 3,
	ISENEMY = 4,
	STEP_IN = 5,
	ISSHADOW = 6,
	ISMONSTER = 7,
	ISDEAD = 8,
	IS_SUCCEEDED_MOVING_TO_SUBMEMBER = 9,
}

public enum FGOActorCutIn.TYPE
{
	RTLD = 1,
	LTRD = 2,
	CENTER = 3,
	INPUT_NAME = 4,
}

public enum FGOActorEffect.PROC
{
	NAME_INPUT = 0,
	DAMAGE_1 = 1,
	DAMAGE_2 = 2,
	DAMAGE_3 = 3,
	DAMAGE_4 = 4,
	DAMAGE_5 = 5,
	DAMAGE_6 = 6,
}

public enum FGOActorLogic.LOGIC
{
	NONE = 0,
	END_FINISH = 1,
	ON_SKIP_VOICE = 2,
	OFF_SKIP_VOICE = 3,
	DROP_ITEM = 4,
	ON_DRESS = 5,
	OFF_DRESS = 6,
	LOAD_CALL = 7,
	STOP_VOICE = 8,
	ON_SKIP_DEAD = 9,
	OFF_SKIP_DEAD = 10,
}

public enum FGOActorMotion.MOTION
{
	NONE = 0,
	JUMP = 1,
	STEP = 2,
	BACKSTEP = 3,
	DASHATTACK = 4,
	STEP_WAIT = 5,
	TREASURE_ARMS = 6,
	CANCEL = 7,
	STEP_USE_PARAM = 8,
	BACKSTEP_USE_PARAM = 9,
}

public enum FGOActorParticleEffectSwitch.PARTICLE_SWITCH_TYPE
{
	STOP = 0,
	PLAY = 1,
}

public enum FGOActorSetAttackTarget.TARGET_POS
{
	LEFT = 0,
	CENTER = 1,
	RIGHT = 2,
}

public enum FGOActorShowMessage.TYPE
{
	NOBLE_NAME = 0,
	COMMON = 1,
}

public enum FGOActorSwitchWidget.WidgetType
{
	ShadowObject = 0,
	SpecialShadowObject = 1,
	ShadowServantAura = 2,
	Find = 3,
}

public enum FGOActorSystemLogic.LOGIC
{
	NONE = 0,
	ON_SKIP_DEAD = 1,
	OFF_SKIP_DEAD = 2,
}

public enum FGOActorVoiceDesignate.CheckType
{
	None = 0,
	Skill = 1,
}

public enum FGOBattleStatusCheck.CHECK
{
	NONE = 0,
	CRITICAL_PERFORMANCE = 1,
}

public enum FGOCheckAttackSide.CheckType
{
	NEXT = 0,
	TURN_START = 1,
	TURN_END = 2,
	NEXT_ACTION_ATTACKED = 3,
	PREV_ACTION_ATTACKED = 4,
}

public enum FGOCheckBattleFaze.FAZE
{
	TACTICAL = 0,
	BATTLE = 1,
}

public enum FGOEffectFirstTimeScale.PROC
{
	SET = 0,
	RESET = 1,
}

public enum FGOFieldGimmick.STATE
{
	SET = 0,
	START = 1,
	END = 2,
	WAIT_VOICE = 3,
}

public enum FGOFieldLogic.PROC
{
	START_REPLACE = 0,
	LOAD_TARGETACTOR = 1,
	LOAD_REPLACE = 2,
	PT_STEPOUT = 3,
	LOAD_PT = 4,
	LOAD_FIELD_CALL = 5,
	BEFORE_FIELD_CALL_EFFECT = 6,
	AFTER_FIELD_CALL_EFFECT = 7,
	DISPLAY_DEFENCE_TARGET = 8,
}

public enum FGOFieldSkillCutIn.ActionType
{
	Load = 0,
	Play = 1,
	Release = 2,
	Finish = 3,
	Skip = 4,
}

public enum FGOGetBattleParam.PARAM
{
	WAVE = 0,
	TURN = 1,
	EFFECT_BGM_ID = 2,
}

public enum FGOLogic.PROC
{
	INIT_QUEST = 0,
	DRAW_COMMAND = 1,
	CHECK_COMBO = 2,
	INIT_BATTLETURN = 3,
	SELECT_TACTICAL = 4,
	END_BATTLETURN = 5,
	CHECK_ENDBATTLE = 6,
	TURN_PROGRSSING = 7,
	CHECK_BATTLEEND = 8,
	TEST_INITBATTLETURN = 9,
	LOAD_N_STAGE = 10,
	ENTRY_SUBMEMBER = 11,
	CHECK_NEXTBATTLE = 12,
	SET_NEXTBATTLE = 13,
	START_BATTLETURN = 14,
	PROC_WIN = 15,
	PROC_LOSE = 16,
	END_BATTLE = 17,
	CONNECT_BATTLEEND = 18,
	SHOW_RESULT = 19,
	LOAD_NEXT = 20,
	START_CONTINUE = 21,
	RECOVERPT = 22,
	START_COMMAND = 23,
	ENTRY_CHECK = 24,
	ENTRY_WAIT = 25,
	LOSE_PERFORMANCE = 26,
	FIELDAI_STARTWAVE = 27,
	BOOSTITEM = 28,
	WAVEBUFF = 29,
	FIRSTENTRY = 30,
	ENEMYAI_WAVE = 31,
	FIELDAI_TURNSTART = 32,
	START_CONTINUE_TURN = 33,
	ENTRY_CHECK_TACTICAL = 34,
	ENTRY_WAIT_TACTICAL = 35,
	RECOVERPT_TACTICAL = 36,
	QUEST_BEHAVIOR = 37,
	GIMMICK = 38,
	STAR_DIRECTION = 39,
	ENTRY_CHECK_EVENT = 40,
	DROP_ITEM_COLLECTION = 41,
	FORCE_DROP_ITEM = 42,
	CHECK_ENDBATTLE_IGNORE_TURN = 43,
	CHECK_REMAIN_BATTLE_END_WAVE = 44,
	BOOST_SKILL = 45,
	ASSIST = 46,
	FIELDAI_ENTRY = 47,
	PRECHECK_ENDBATTLE = 48,
	SERVANT_AI_WAVE = 49,
	SERVANT_AI_TURN_START = 50,
	TURN_START_FUNCTION = 51,
	SERVANT_AI_BEFORE_MOVE_WAVE = 52,
	FIELDAI_BEFORE_MOVE_WAVE = 53,
	PROGRESS_INTERVAL_TURN = 54,
	LOAD_N_STAGE_PLAYER = 55,
	START_CONTINUE_WAVE_RESTART = 56,
	INITIALIZE_WAVE_RESTART = 57,
	STAGE_CUTIN = 58,
	WAIT_DROP_ITEM_COLLECT = 59,
	FIELD_AI_BEFORE_WAVE_START_ANIMATION = 60,
	START_CONTINUE_INTERRUPTION = 61,
}

public enum FGOPerformance.Effect
{
	QUEST_START = 0,
	QUEST_CLEAR = 1,
	QUEST_OVER = 2,
	BATTLE_START = 3,
	BATTLE_WIN = 4,
	BATTLE_LOSE = 5,
	ACTION_BATTLE = 6,
	END_SELECTCOMMAND = 7,
	ACTION_ABILITY = 8,
	MOVE_TACTICAL = 9,
	MOVE_COMMAND = 10,
	MOVE_ACTION = 11,
	MOVE_NEXTBATTLE = 12,
	PROC_BUFF = 13,
	RAIDATTACK = 14,
	UPDATE_VIEW = 15,
	PLAY_SHIFTSERVANT = 16,
	PLAY_SHIFTEFFECT = 17,
	SET_TIMEACCELERATION = 18,
	RESET_TIMEACCELERATION = 19,
	PLAY_CHANGESERVANT = 20,
	PLAY_CHANGEBG = 21,
	UPDATE_FOV = 22,
	CHECK_RAIDATTACK = 23,
	DOWNLOAD_ASSETBUNDLE = 24,
	SAVE_PART_ACTION_TIMEACCELERATION = 25,
	RESET_PART_ACTION_TIMEACCELERATION = 26,
	PLAY_SHIFTGAUGECHANGE = 27,
	PLAY_SHIFTGAUGECHANGE_SERVANT = 28,
	SET_TIMEACCELERATION_DIFFERENT = 29,
	FORCE_RESET_TIMEACCELERATION = 30,
	PREV_TACTICAL = 31,
	LOSS_COMMAND_SPELL = 32,
	MOVE_TO_SUBMEMBER = 33,
	START_FADE_OUT = 34,
}

public enum FGOPlayStarDirection.DirectionType
{
	Refresh = 0,
	Recovery = 1,
	Add = 2,
}

public enum FGOQuestStartEffect.ActionType
{
	Load = 0,
	Play = 1,
	Release = 2,
}

public enum FGOSetPopupDisplayLayerType.PopupLayerType
{
	e2DUI = 0,
	eFront2DUI = 1,
}

public enum FGOSpecifiedBattleStartVoice.TYPE
{
	CHECK = 0,
	PLAY = 1,
}

public enum GetAppearActorObject.SIDE
{
	PLAYER = 0,
	ENEMY = 1,
}

public enum ManagerConfigCheck.Kind
{
	USE_DEBUG_COMMAND = 0,
}

public enum ShowDefenceTargetAddBuffEffect.AddType
{
	NoblePhantasm = 0,
}

public enum iTweenFsmActionSimple.AxisRestriction
{
	none = 0,
	x = 1,
	y = 2,
	z = 3,
	xy = 4,
	xz = 5,
	yz = 6,
}

public enum AnimateFsmAction.Calculation
{
	None = 0,
	SetValue = 1,
	AddToValue = 2,
	SubtractFromValue = 3,
	SubtractValueFromCurve = 4,
	MultiplyValue = 5,
	DivideValue = 6,
	DivideCurveByValue = 7,
}

public enum CurveFsmAction.Calculation
{
	None = 0,
	AddToValue = 1,
	SubtractFromValue = 2,
	SubtractValueFromCurve = 3,
	MultiplyValue = 4,
	DivideValue = 5,
	DivideCurveByValue = 6,
}

public enum EaseFsmAction.EaseType
{
	easeInQuad = 0,
	easeOutQuad = 1,
	easeInOutQuad = 2,
	easeInCubic = 3,
	easeOutCubic = 4,
	easeInOutCubic = 5,
	easeInQuart = 6,
	easeOutQuart = 7,
	easeInOutQuart = 8,
	easeInQuint = 9,
	easeOutQuint = 10,
	easeInOutQuint = 11,
	easeInSine = 12,
	easeOutSine = 13,
	easeInOutSine = 14,
	easeInExpo = 15,
	easeOutExpo = 16,
	easeInOutExpo = 17,
	easeInCirc = 18,
	easeOutCirc = 19,
	easeInOutCirc = 20,
	linear = 21,
	spring = 22,
	bounce = 23,
	easeInBack = 24,
	easeOutBack = 25,
	easeInOutBack = 26,
	elastic = 27,
	punch = 28,
}

public enum FsmStateActionAnimatorBase.AnimatorFrameUpdateSelector
{
	OnUpdate = 0,
	OnAnimatorMove = 1,
	OnAnimatorIK = 2,
}

public enum ArrayTransferValue.ArrayTransferType
{
	Copy = 0,
	Cut = 1,
	nullify = 2,
}

public enum ArrayTransferValue.ArrayPasteType
{
	AsFirstItem = 0,
	AsLastItem = 1,
	InsertAtSameIndex = 2,
	ReplaceAtSameIndex = 3,
}

public enum BaseUpdateAction.UpdateType
{
	OnUpdate = 0,
	OnLateUpdate = 1,
	OnFixedUpdate = 2,
}

public enum BoolOperator.Operation
{
	AND = 0,
	NAND = 1,
	OR = 2,
	XOR = 3,
}

public enum ConvertFloatToInt.FloatRounding
{
	RoundDown = 0,
	RoundUp = 1,
	Nearest = 2,
}

public enum Assert.AssertType
{
	IsTrue = 0,
	IsFalse = 1,
}

public enum DebugDrawShape.ShapeType
{
	Sphere = 0,
	Cube = 1,
	WireSphere = 2,
	WireCube = 3,
}

public enum FloatOperator.Operation
{
	Add = 0,
	Subtract = 1,
	Multiply = 2,
	Divide = 3,
	Min = 4,
	Max = 5,
}

public enum GetAxisVector.AxisPlane
{
	XZ = 0,
	XY = 1,
	YZ = 2,
}

public enum GetDeviceRoll.BaseOrientation
{
	Portrait = 0,
	LandscapeLeft = 1,
	LandscapeRight = 2,
}

public enum GetTimeInfo.TimeInfo
{
	DeltaTime = 0,
	TimeScale = 1,
	SmoothDeltaTime = 2,
	TimeInCurrentState = 3,
	TimeSinceStartup = 4,
	TimeSinceLevelLoad = 5,
	RealTimeSinceStartup = 6,
	RealTimeInCurrentState = 7,
}

public enum IntOperator.Operation
{
	Add = 0,
	Subtract = 1,
	Multiply = 2,
	Divide = 3,
	Min = 4,
	Max = 5,
}

public enum MouseLook.RotationAxes
{
	MouseXAndY = 0,
	MouseX = 1,
	MouseY = 2,
}

public enum MouseLook2.RotationAxes
{
	MouseXAndY = 0,
	MouseX = 1,
	MouseY = 2,
}

public enum ProjectLocationToMap.MapProjection
{
	EquidistantCylindrical = 0,
	Mercator = 1,
}

public enum QuaternionBaseAction.everyFrameOptions
{
	Update = 0,
	FixedUpdate = 1,
	LateUpdate = 2,
}

public enum RectTransformFlipLayoutAxis.RectTransformFlipOptions
{
	Horizontal = 0,
	Vertical = 1,
	Both = 2,
}

public enum RectTransformGetLocalPosition.LocalPositionReference
{
	Anchor = 0,
	CenterPosition = 1,
}

public enum RectTransformSetAnchorRectPosition.AnchorReference
{
	TopLeft = 0,
	Top = 1,
	TopRight = 2,
	Right = 3,
	BottomRight = 4,
	Bottom = 5,
	BottomLeft = 6,
	Left = 7,
	Center = 8,
}

public enum GetSceneActionBase.SceneReferenceOptions
{
	SceneAtIndex = 0,
	SceneByName = 1,
	SceneByPath = 2,
}

public enum GetSceneActionBase.SceneSimpleReferenceOptions
{
	SceneAtIndex = 0,
	SceneByName = 1,
}

public enum GetSceneActionBase.SceneBuildReferenceOptions
{
	SceneAtBuildIndex = 0,
	SceneByName = 1,
}

public enum GetSceneActionBase.SceneAllReferenceOptions
{
	ActiveScene = 0,
	SceneAtIndex = 1,
	SceneByName = 2,
	SceneByPath = 3,
	SceneByGameObject = 4,
}

public enum SetActiveScene.SceneReferenceOptions
{
	SceneAtBuildIndex = 0,
	SceneAtIndex = 1,
	SceneByName = 2,
	SceneByPath = 3,
	SceneByGameObject = 4,
}

public enum UnloadScene.SceneReferenceOptions
{
	ActiveScene = 0,
	SceneAtBuildIndex = 1,
	SceneAtIndex = 2,
	SceneByName = 3,
	SceneByPath = 4,
	SceneByGameObject = 5,
}

public enum UnloadSceneAsynch.SceneReferenceOptions
{
	ActiveScene = 0,
	SceneAtBuildIndex = 1,
	SceneAtIndex = 2,
	SceneByName = 3,
	SceneByPath = 4,
	SceneByGameObject = 5,
}

public enum SendMessage.MessageType
{
	SendMessage = 0,
	SendMessageUpwards = 1,
	BroadcastMessage = 2,
}

public enum TakeScreenshot.Destination
{
	MyPictures = 0,
	PersistentDataPath = 1,
	CustomPath = 2,
}

public enum TouchGUIEvent.OffsetOptions
{
	TopLeft = 0,
	Center = 1,
	TouchStart = 2,
}

public enum TransformInputToWorldSpace.AxisPlane
{
	XZ = 0,
	XY = 1,
	YZ = 2,
}

public enum GetAtan2FromVector3.aTan2EnumAxis
{
	x = 0,
	y = 1,
	z = 2,
}

public enum UiEventSystemExecuteEvent.EventHandlers
{
	Submit = 0,
	beginDrag = 1,
	cancel = 2,
	deselectHandler = 3,
	dragHandler = 4,
	dropHandler = 5,
	endDragHandler = 6,
	initializePotentialDrag = 7,
	pointerClickHandler = 8,
	pointerDownHandler = 9,
	pointerEnterHandler = 10,
	pointerExitHandler = 11,
	pointerUpHandler = 12,
	scrollHandler = 13,
	submitHandler = 14,
	updateSelectedHandler = 15,
}

public enum Vector2Operator.Vector2Operation
{
	DotProduct = 0,
	Distance = 1,
	Angle = 2,
	Add = 3,
	Subtract = 4,
	Multiply = 5,
	Divide = 6,
	Min = 7,
	Max = 8,
}

public enum Vector3Operator.Vector3Operation
{
	DotProduct = 0,
	CrossProduct = 1,
	Distance = 2,
	Angle = 3,
	Project = 4,
	Reflect = 5,
	Add = 6,
	Subtract = 7,
	Multiply = 8,
	Divide = 9,
	Min = 10,
	Max = 11,
}

public enum iTweenFsmAction.AxisRestriction
{
	none = 0,
	x = 1,
	y = 2,
	z = 3,
	xy = 4,
	xz = 5,
	yz = 6,
}

private enum Json.Parser.TOKEN
{
	NONE = 0,
	CURLY_OPEN = 1,
	CURLY_CLOSE = 2,
	SQUARED_OPEN = 3,
	SQUARED_CLOSE = 4,
	COLON = 5,
	COMMA = 6,
	STRING = 7,
	NUMBER = 8,
	TRUE = 9,
	FALSE = 10,
	NULL = 11,
}

public enum TabKind
{
	SERVANT = 0,
	SERVANT_EQUIP = 1,
	COMMAND_CODE = 2,
}

public enum ModeKind
{
	MAIN = 0,
	STATUS = 1,
	LOCK = 2,
	CHOICE = 3,
	PUSH = 4,
}

public enum RenderOption.Grade
{
	Normal = 0,
	Low = 1,
}

public enum RenderOption.Type
{
	Shadow = 0,
}

public enum RendererScaler.RenderScale
{
	S12 = 12,
	S25 = 25,
	S50 = 50,
	S75 = 75,
	S100 = 100,
}

private enum ScreenEffectBlur.State
{
	NONE = 0,
	START = 1,
	STOP = 2,
	KEEP = 3,
}

private enum ScreenEffectCrossFade.State
{
	NONE = 0,
	START = 1,
}

