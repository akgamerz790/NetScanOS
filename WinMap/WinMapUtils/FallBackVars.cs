using System;

namespace VariableSpace
{
    public class FallBackVars
    {
        // ===== Core Network Values =====
        public static string _LOCALHOST = "127.0.0.1";
        public static string _LOOPBACK_IPV6 = "::1";
        public static string _HTTP_PORT = "80";
        public static string _HTTPS_PORT = "443";
        public static string _HTTP_ALT = "8080";
        public static string _FTP_PORT = "21";
        public static string _SSH_PORT = "22";
        public static string _TELNET_PORT = "23";
        public static string _SMTP_PORT = "25";
        public static string _POP3_PORT = "110";
        public static string _IMAP_PORT = "143";
        public static string _DNS_PORT = "53";
        public static string _NTP_PORT = "123";
        public static string _RDP_PORT = "3389";
        public static string _MYSQL_PORT = "3306";
        public static string _POSTGRES_PORT = "5432";
        public static string _MONGODB_PORT = "27017";
        public static string _REDIS_PORT = "6379";
        public static string _MEMCACHED_PORT = "11211";
        public static string _DOCKER_PORT = "2375";
        public static string _KAFKA_PORT = "9092";
        public static string _ELASTICSEARCH_PORT = "9200";
        public static string _LDAP_PORT = "389";
        public static string _LDAPS_PORT = "636";
        public static string _VNC_PORT = "5900";
        public static string _TEAMSPEAK_PORT = "9987";
        public static string _SFTP_PORT = "115";
        public static string _SMB_PORT = "445";
        public static string _NETBIOS_PORT = "139";
        public static string _SNMP_PORT = "161";
        public static string _SYSLOG_PORT = "514";
        public static string _XMPP_PORT = "5222";
        public static string _IRC_PORT = "6667";
        public static string _RADIUS_PORT = "1812";
        public static string _VPN_PORT = "1194";
        public static string _PROMETHEUS_PORT = "9090";
        public static string _GRAFANA_PORT = "3000";
        public static string _JENKINS_PORT = "8081";
        public static string _WS_PORT = "81";
        public static string _WEBRTC_PORT = "3478";
        public static string _QUIC_PORT = "443";
        public static string _TOR_PORT = "9050";
        public static string _OPENVPN_PORT = "1194";
        public static string _SSH_KEY_DEFAULT = "id_rsa";
        public static string _MAC_BROADCAST = "FF:FF:FF:FF:FF:FF";

        // ===== HTTP Status Codes =====
        public static int _HTTP_OK = 200;
        public static int _HTTP_CREATED = 201;
        public static int _HTTP_ACCEPTED = 202;
        public static int _HTTP_NO_CONTENT = 204;
        public static int _HTTP_BAD_REQUEST = 400;
        public static int _HTTP_UNAUTHORIZED = 401;
        public static int _HTTP_FORBIDDEN = 403;
        public static int _HTTP_NOT_FOUND = 404;
        public static int _HTTP_METHOD_NOT_ALLOWED = 405;
        public static int _HTTP_CONFLICT = 409;
        public static int _HTTP_INTERNAL_SERVER_ERROR = 500;
        public static int _HTTP_NOT_IMPLEMENTED = 501;
        public static int _HTTP_BAD_GATEWAY = 502;
        public static int _HTTP_SERVICE_UNAVAILABLE = 503;
        public static int _HTTP_GATEWAY_TIMEOUT = 504;

        // ===== File & Path Defaults =====
        public static string _USERPROFILE = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        public static string _DESKTOP = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public static string _DOCUMENTS = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string _DOWNLOADS = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
        public static string _PICTURES = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        public static string _APPDATA = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string _LOCALAPPDATA = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        public static string _PROGRAMFILES = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
        public static string _SYSDRIVE = Environment.GetEnvironmentVariable("SystemDrive") ?? "C:";
        public static string _TEMP = Environment.GetEnvironmentVariable("TEMP") ?? "/tmp";
        public static string _HOSTS_FILE = Environment.ExpandEnvironmentVariables("%SystemRoot%\\System32\\drivers\\etc\\hosts");
        public static string _ETC_PASSWD = "/etc/passwd";
        public static string _ETC_SHADOW = "/etc/shadow";
        public static string _ETC_GROUP = "/etc/group";
        public static string _ROOT = "/";
        public static string _HOME = Environment.GetEnvironmentVariable("HOME") ?? _USERPROFILE;
        public static string _PATH_SEP = System.IO.Path.DirectorySeparatorChar.ToString();

        // ===== System Defaults =====
        public static string _OS_VERSION = Environment.OSVersion.ToString();
        public static string _MACHINE_NAME = Environment.MachineName;
        public static string _USER_NAME = Environment.UserName;
        public static string _DOMAIN = Environment.UserDomainName;
        public static string? _PROCESSOR_ARCH = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
        public static string? _PROCESSOR_IDENTIFIER = Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER");
        public static string _CPU_COUNT = Environment.ProcessorCount.ToString();
        public static string _CURRENT_DIR = Environment.CurrentDirectory;
        public static string _NEWLINE = Environment.NewLine;
        public static string _SEPARATOR = Path.DirectorySeparatorChar.ToString();
        public static string _EMPTY_GUID = Guid.Empty.ToString();

        // ===== Random/Fallback Constants =====
        public static string _EMPTY = string.Empty;
        public static string? _NULL = null;
        public static string _DEFAULT_IP = "0.0.0.0";
        public static string _DEFAULT_IPV6 = "::";
        public static string _DEFAULT_MAC = "00:00:00:00:00:00";
        public static string _DEFAULT_PORT = "0";
        public static string _YES = "Yes";
        public static string _NO = "No";
        public static string _TRUE = "True";
        public static string _FALSE = "False";
        public static string _ALL = "ALL";
        public static string _NONE = "NONE";
        public static string _SUCCESS = "SUCCESS";
        public static string _FAIL = "FAIL";
        public static string _PENDING = "PENDING";
        public static string _ERROR = "ERROR";
        public static string _WARNING = "WARNING";
        public static string _INFO = "INFO";
        public static string _DEFAULT_USER = "admin";
        public static string _DEFAULT_PASS = "password";
        public static string _DEFAULT_EMAIL = "test@example.com";
        public static string _DEFAULT_URL = "http://localhost/";
        public static string _DEFAULT_FILE = "file.txt";
        public static string _DEFAULT_DIR = "/tmp";

        // ===== Date/Time Formats =====
        public static string _FORMAT_DATETIME = "yyyy-MM-dd HH:mm:ss";
        public static string _FORMAT_DATE = "yyyy-MM-dd";
        public static string _FORMAT_TIME = "HH:mm:ss";
        public static string _FORMAT_TIMESTAMP = "yyyyMMdd_HHmmss";
        public static string _FORMAT_ISO8601 = "yyyy-MM-ddTHH:mm:ssZ";

        // ===== Env Variables & Defaults =====
        public static string _ENV_TEMP = "TEMP";
        public static string _ENV_PATH = "PATH";
        public static string _ENV_HOME = "HOME";
        public static string _ENV_USER = "USER";
        public static string _ENV_SHELL = "SHELL";
        public static string _ENV_LOGNAME = "LOGNAME";
        public static string _ENV_LANG = "LANG";
        public static string _ENV_COMPUTERNAME = "COMPUTERNAME";
        public static string _ENV_USERNAME = "USERNAME";
        public static string _ENV_PWD = "PWD";

        // ===== Protocols =====
        public static string _PROTOCOL_TCP = "TCP";
        public static string _PROTOCOL_UDP = "UDP";
        public static string _PROTOCOL_HTTP = "HTTP";
        public static string _PROTOCOL_HTTPS = "HTTPS";
        public static string _PROTOCOL_FTP = "FTP";
        public static string _PROTOCOL_SSH = "SSH";
        public static string _PROTOCOL_WS = "WS";
        public static string _PROTOCOL_WSS = "WSS";
        public static string _PROTOCOL_DNS = "DNS";
        public static string _PROTOCOL_NTP = "NTP";
        public static string _PROTOCOL_ICMP = "ICMP";
        public static string _PROTOCOL_IP = "IP";
        public static string _PROTOCOL_ARP = "ARP";
        public static string _PROTOCOL_SMB = "SMB";
        public static string _PROTOCOL_POP3 = "POP3";
        public static string _PROTOCOL_IMAP = "IMAP";
        public static string _PROTOCOL_LDAP = "LDAP";
        public static string _PROTOCOL_RADIUS = "RADIUS";
        public static string _PROTOCOL_MQTT = "MQTT";
        public static string _PROTOCOL_SNMP = "SNMP";
        public static string _PROTOCOL_IPV6 = "IPv6";

        // ===== HTTP Methods =====
        public static string _HTTP_GET = "GET";
        public static string _HTTP_POST = "POST";
        public static string _HTTP_PUT = "PUT";
        public static string _HTTP_DELETE = "DELETE";
        public static string _HTTP_PATCH = "PATCH";
        public static string _HTTP_OPTIONS = "OPTIONS";
        public static string _HTTP_HEAD = "HEAD";

        // ===== File Extensions =====
        public static string _EXT_TXT = ".txt";
        public static string _EXT_LOG = ".log";
        public static string _EXT_CFG = ".cfg";
        public static string _EXT_JSON = ".json";
        public static string _EXT_XML = ".xml";
        public static string _EXT_YML = ".yml";
        public static string _EXT_MD = ".md";
        public static string _EXT_CSV = ".csv";
        public static string _EXT_HTML = ".html";
        public static string _EXT_HTM = ".htm";
        public static string _EXT_JS = ".js";
        public static string _EXT_PY = ".py";
        public static string _EXT_CS = ".cs";
        public static string _EXT_DLL = ".dll";
        public static string _EXT_EXE = ".exe";
        public static string _EXT_BAT = ".bat";
        public static string _EXT_SH = ".sh";
        public static string _EXT_JPG = ".jpg";
        public static string _EXT_PNG = ".png";
        public static string _EXT_GIF = ".gif";
        public static string _EXT_ZIP = ".zip";
        public static string _EXT_RAR = ".rar";
        public static string _EXT_TAR = ".tar";
        public static string _EXT_GZ = ".gz";

        // ===== Common File/Folder Names =====
        public static string _FOLDER_BIN = "bin";
        public static string _FOLDER_OBJ = "obj";
        public static string _FOLDER_LOGS = "logs";
        public static string _FOLDER_CONFIG = "config";
        public static string _FOLDER_TMP = "tmp";
        public static string _FOLDER_BACKUP = "backup";
        public static string _FOLDER_BUILD = "build";
        public static string _FOLDER_SRC = "src";
        public static string _FOLDER_DIST = "dist";
        public static string _FOLDER_PUBLIC = "public";
        public static string _FOLDER_PRIVATE = "private";
        public static string _FOLDER_ASSETS = "assets";
        public static string _FOLDER_STATIC = "static";
        public static string _FOLDER_DATA = "data";

        // ===== OS Type Checks =====
        public static bool _IS_WINDOWS = Environment.OSVersion.Platform == PlatformID.Win32NT;
        public static bool _IS_LINUX = Environment.OSVersion.Platform == PlatformID.Unix;
        public static bool _IS_MAC = Environment.OSVersion.Platform == PlatformID.MacOSX;

        // ===== Special Chars and Regex Patterns =====
        public static string _WILDCARD = "*";
        public static string _QUESTION = "?";
        public static string _REGEX_EMAIL = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        public static string _REGEX_IPV4 = @"^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$";
        public static string _REGEX_IPV6 = @"^([0-9a-f]{1,4}:){7}[0-9a-f]{1,4}$";
        public static string _REGEX_MAC = @"^([0-9A-F]{2}[:-]){5}([0-9A-F]{2})$";
        public static string _REGEX_URL = @"^(http|https|ftp):\/\/[^\s/$.?#].[^\s]*$";
        public static string _REGEX_PHONE = @"^\+?[1-9]\d{1,14}$";
        public static string _REGEX_HEX = @"^0x[a-fA-F0-9]+$";
        public static string _REGEX_GUID = @"^[{(]?[0-9A-Fa-f]{8}(-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}[)}]?$";

        // ===== Colors =====
        public static string _COLOR_RESET = "\x1b[0m";
        public static string _COLOR_RED = "\x1b[31m";
        public static string _COLOR_GREEN = "\x1b[32m";
        public static string _COLOR_YELLOW = "\x1b[33m";
        public static string _COLOR_BLUE = "\x1b[34m";
        public static string _COLOR_MAGENTA = "\x1b[35m";
        public static string _COLOR_CYAN = "\x1b[36m";
        public static string _COLOR_WHITE = "\x1b[37m";
        public static string _COLOR_BOLD = "\x1b[1m";

        // ===== Keyboard Keys =====
        public static ConsoleKey _KEY_ENTER = ConsoleKey.Enter;
        public static ConsoleKey _KEY_ESCAPE = ConsoleKey.Escape;
        public static ConsoleKey _KEY_UP = ConsoleKey.UpArrow;
        public static ConsoleKey _KEY_DOWN = ConsoleKey.DownArrow;
        public static ConsoleKey _KEY_LEFT = ConsoleKey.LeftArrow;
        public static ConsoleKey _KEY_RIGHT = ConsoleKey.RightArrow;
        public static ConsoleKey _KEY_F1 = ConsoleKey.F1;
        public static ConsoleKey _KEY_F2 = ConsoleKey.F2;

        // ===== Standard URLs / APIs =====
        public static string _URL_GOOGLE = "https://www.google.com";
        public static string _URL_GITHUB = "https://github.com";
        public static string _URL_STACKOVERFLOW = "https://stackoverflow.com";
        public static string _URL_DISCORD = "https://discord.com";
        public static string _URL_REDDIT = "https://reddit.com";
        public static string _URL_TWITCH = "https://twitch.tv";
        public static string _URL_SPOTIFY = "https://spotify.com";
        public static string _URL_YOUTUBE = "https://youtube.com";
        public static string _URL_WIKIPEDIA = "https://wikipedia.org";
        public static string _URL_PERPLEXITY = "https://www.perplexity.ai/";

        // ===== Status/Text Responses =====
        public static string _MSG_SUCCESS = "Operation completed successfully.";
        public static string _MSG_FAIL = "Operation failed.";
        public static string _MSG_INVALID = "Invalid input.";
        public static string _MSG_ERROR_CONN = "Connection error.";
        public static string _MSG_DENIED = "Access denied.";
        public static string _MSG_TIMEOUT = "Timeout occurred.";
        public static string _MSG_NOT_FOUND = "Not found.";
        public static string _MSG_RETRY = "Please retry the operation.";
        public static string _MSG_EXIT = "Exiting application.";

        // ===== CLI Tools / Unix Commands =====
        public static string _CMD_LS = "ls";
        public static string _CMD_CD = "cd";
        public static string _CMD_PWD = "pwd";
        public static string _CMD_MKDIR = "mkdir";
        public static string _CMD_TOUCH = "touch";
        public static string _CMD_CP = "cp";
        public static string _CMD_MV = "mv";
        public static string _CMD_RM = "rm";
        public static string _CMD_RMDIR = "rmdir";
        public static string _CMD_CAT = "cat";
        public static string _CMD_GREP = "grep";
        public static string _CMD_ECHO = "echo";
        public static string _CMD_PS = "ps";
        public static string _CMD_KILL = "kill";
        public static string _CMD_PING = "ping";
        public static string _CMD_NETSTAT = "netstat";
        public static string _CMD_TOP = "top";
        public static string _CMD_CLEAR = "clear";
        public static string _CMD_SHUTDOWN = "shutdown";
        public static string _CMD_REBOOT = "reboot";
        public static string _CMD_WGET = "wget";
        public static string _CMD_CURL = "curl";
        public static string _CMD_SSH = "ssh";
        public static string _CMD_SCP = "scp";
        public static string _CMD_SUDO = "sudo";
        public static string _CMD_DF = "df";
        public static string _CMD_DU = "du";
        public static string _CMD_CHMOD = "chmod";
        public static string _CMD_CHOWN = "chown";

        // ===== PowerShell Commands =====
        public static string _PS_GET_PROC = "Get-Process";
        public static string _PS_GET_SERVICE = "Get-Service";
        public static string _PS_SET_EXEC_POLICY = "Set-ExecutionPolicy";
        public static string _PS_GET_EVENTS = "Get-EventLog";
        public static string _PS_GET_CHILD = "Get-ChildItem";
        public static string _PS_GET_CONTENT = "Get-Content";
        public static string _PS_SET_ALIAS = "Set-Alias";
        public static string _PS_CLEAR_HOST = "Clear-Host";
        public static string _PS_STOP_PROCESS = "Stop-Process";
        public static string _PS_SELECT_OBJ = "Select-Object";
        public static string _PS_SORT_OBJ = "Sort-Object";
        public static string _PS_EXPORT_CSV = "Export-Csv";
        public static string _PS_IMPORT_CSV = "Import-Csv";
        public static string _PS_TEST_CONN = "Test-Connection";

        // ===== DateTime Utilities =====
        public static DateTime _NOW => DateTime.Now;
        public static DateTime _UTC_NOW => DateTime.UtcNow;
        public static DateTime _MIN_DATE => DateTime.MinValue;
        public static DateTime _MAX_DATE => DateTime.MaxValue;
        public static TimeSpan _ONE_SECOND = TimeSpan.FromSeconds(1);
        public static TimeSpan _FIVE_SECONDS = TimeSpan.FromSeconds(5);
        public static TimeSpan _TEN_SECONDS = TimeSpan.FromSeconds(10);
        public static TimeSpan _ONE_MINUTE = TimeSpan.FromMinutes(1);
        public static TimeSpan _FIVE_MINUTES = TimeSpan.FromMinutes(5);
        public static TimeSpan _ONE_HOUR = TimeSpan.FromHours(1);

        // ===== Misc OS Defaults =====
        public static string _CRLF = "\r\n";
        public static string _LF = "\n";
        public static string _CR = "\r";
        public static string _TAB = "\t";
        public static string _SPACE = " ";
        public static string _DASH = "-";
        public static string _COMMA = ",";
        public static string _DOT = ".";
        public static string _PIPE = "|";
        public static string _SLASH = "/";
        public static string _BACKSLASH = "\\";

        // ===== Random Fallback chars =====
        public static char _CHAR_NULL = '\0';
        public static char _CHAR_SPACE = ' ';
        public static char _CHAR_TAB = '\t';
        public static char _CHAR_LF = '\n';
        public static char _CHAR_CR = '\r';
        public static char _CHAR_DOT = '.';
        public static char _CHAR_COMMA = ',';
        public static char _CHAR_PIPE = '|';

        // ===== Binary Values for Security / Hex Utils =====
        public static byte[] _BYTES_ALL_ZERO = new byte[] { 0x00, 0x00, 0x00, 0x00 };
        public static byte[] _BYTES_ALL_FF = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF };
        public static byte[] _BYTES_GUID_EMPTY = new byte[16];

        // ===== Game/Coding Defaults (Fun) =====
        public static string _DEFAULT_PLAYER_NAME = "Player1";
        public static int _DEFAULT_PLAYER_SCORE = 0;
        public static string _GAME_OVER = "GAME OVER";
        public static string _LEVEL_UP = "LEVEL UP!";
        public static string _START = "START";
        public static string _PAUSE = "PAUSE";
        public static string _RESUME = "RESUME";

        // ===== Security Keywords =====
        public static string _SECURE = "SECURE";
        public static string _UNSECURE = "UNSECURE";
        public static string _ENCRYPTED = "ENCRYPTED";
        public static string _DECRYPTED = "DECRYPTED";
        public static string _AUTH = "AUTH";
        public static string _UNAUTH = "UNAUTH";
        public static string _TOKEN = "TOKEN";
        public static string _JWT = "JWT";
        public static string _API_KEY = "API_KEY";
        public static string _SECRET = "SECRET";
        public static string _HASH = "HASH";
        public static string _SALT = "SALT";

        // ===== Permissions =====
        public static string _PERM_READ = "READ";
        public static string _PERM_WRITE = "WRITE";
        public static string _PERM_EXECUTE = "EXECUTE";
        public static string _PERM_DELETE = "DELETE";
        public static string _PERM_MODIFY = "MODIFY";
        public static string _PERM_FULL = "FULL";
        public static string _PERM_DENY = "DENY";
        public static string _PERM_ALLOW = "ALLOW";

        // ===== Monitoring Keywords =====
        public static string _PING = "PING";
        public static string _PONG = "PONG";
        public static string _ALIVE = "ALIVE";
        public static string _DEAD = "DEAD";
        public static string _HEALTHY = "HEALTHY";
        public static string _UNHEALTHY = "UNHEALTHY";
        public static string _READY = "READY";
        public static string _NOT_READY = "NOT_READY";
        public static string _ACTIVE = "ACTIVE";
        public static string _INACTIVE = "INACTIVE";
        public static string _ENABLED = "ENABLED";
        public static string _DISABLED = "DISABLED";

        // ===== Severity/Log Levels =====
        public static string _LOG_TRACE = "TRACE";
        public static string _LOG_DEBUG = "DEBUG";
        public static string _LOG_INFO = "INFO";
        public static string _LOG_WARN = "WARN";
        public static string _LOG_ERROR = "ERROR";
        public static string _LOG_FATAL = "FATAL";
        public static string _LOG_VERBOSE = "VERBOSE";

        // ===== Email/Test Data  [Default PlaceHolders] =====
        public static string _EMAIL_EXAMPLE = "example@test.com";
        public static string _EMAIL_ADMIN = "admin@example.com";
        public static string _EMAIL_SUPPORT = "support@example.com";

        // ===== Socials/Usernames (Default) =====
        public static string _SOCIAL_GITHUB = "akgamerz790";
        public static string _SOCIAL_DISCORD = "discord.com/discord.gg";
        public static string _SOCIAL_YOUTUBE = "yotube.com/@youtube";

        // Unique Project Vectors
        public static string _COREOSLABS_MAIN = "CoreOS Labs";
        public static string _MY_GITHUB_PROFILE = "https://github.com/akgamerz790";
    }
}
