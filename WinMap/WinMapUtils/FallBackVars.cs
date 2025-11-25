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

        public class ScanTypes
        {
            // HOST DISCOVERY SCANS
            public static string _PING_SWEEP = "Ping Sweep";
            public static string _ARP_SCAN = "ARP Scan";
            public static string _TCP_SYN_PING = "TCP SYN Ping";
            public static string _TCP_ACK_PING = "TCP ACK Ping";
            public static string _UDP_PING = "UDP Ping";
            public static string _ICMP_TIMESTAMP = "ICMP Timestamp";
            public static string _ICMP_ADDRESS_MASK = "ICMP Address Mask";
            public static string _IP_PROTOCOL_PING = "IP Protocol Ping";

            // PORT SCANNING TECHNIQUES
            public static string _TCP_CONNECT_SCAN = "TCP Connect Scan";
            public static string _TCP_SYN_SCAN = "TCP SYN Scan";
            public static string _TCP_FIN_SCAN = "TCP FIN Scan";
            public static string _TCP_NULL_SCAN = "TCP NULL Scan";
            public static string _TCP_XMAS_SCAN = "TCP XMAS Scan";
            public static string _TCP_ACK_SCAN = "TCP ACK Scan";
            public static string _TCP_WINDOW_SCAN = "TCP Window Scan";
            public static string _TCP_MAIMON_SCAN = "TCP Maimon Scan";
            public static string _UDP_SCAN = "UDP Scan";
            public static string _SCTP_INIT_SCAN = "SCTP INIT Scan";

            // SERVICE & VERSION DETECTION
            public static string _VERSION_DETECTION = "Version Detection";
            public static string _RPC_SCAN = "RPC Scan";
            public static string _SSL_TLS_SCAN = "SSL/TLS Scan";

            // OS DETECTION
            public static string _TCPIP_FINGERPRINTING = "TCP/IP Stack Fingerprinting";
            public static string _IDLE_SCAN = "Idle Scan";

            // NETWORK MAPPING
            public static string _TRACEROUTE = "Traceroute";
            public static string _TOPOLOGY_DISCOVERY = "Topology Discovery";

            // VULNERABILITY SCANS
            public static string _SCRIPT_SCANNING = "Script Scanning";
            public static string _VULN_SCAN = "Vulnerability Scan";
            public static string _EXPLOIT_SCAN = "Exploit Scan";

            // SPECIALIZED SCANS
            public static string _FTP_BOUNCE_SCAN = "FTP Bounce Scan";
            public static string _HTTP_SERVICE_SCAN = "HTTP Service Scan";
            public static string _SMB_SCAN = "SMB Scan";
            public static string _SNMP_SCAN = "SNMP Scan";
            public static string _DNS_ENUMERATION = "DNS Enumeration";
            public static string _SMTP_USER_ENUMERATION = "SMTP User Enumeration";

            // WIRELESS SCANS
            public static string _WIFI_NETWORK_SCAN = "WiFi Network Scan";
            public static string _BLUETOOTH_SCAN = "Bluetooth Scan";

            // WEB APPLICATION SCANS
            public static string _HTTP_METHOD_SCAN = "HTTP Method Scan";
            public static string _DIRECTORY_BRUTEFORCE = "Directory Bruteforce";
            public static string _SUBDOMAIN_ENUMERATION = "Subdomain Enumeration";

            // DATABASE SCANS
            public static string _SQL_SERVER_SCAN = "SQL Server Scan";
            public static string _NOSQL_SCAN = "NoSQL Scan";

            // COMMON SCAN PROFILES
            public static string _BASIC_NETWORK_SCAN = "Basic Network Scan";
            public static string _COMPREHENSIVE_AUDIT = "Comprehensive Audit";
            public static string _STEALTH_SCAN = "Stealth Scan";
            public static string _QUICK_SCAN = "Quick Scan";
            public static string _FULL_PORT_SCAN = "Full Port Scan";
            public static string _WEB_INFRASTRUCTURE_SCAN = "Web Infrastructure Scan";
            public static string _UDP_SERVICE_SCAN = "UDP Service Scan";
            public static string _OS_FINGERPRINTING_SCAN = "OS Fingerprinting Scan";
        }

        public class ConsoleHelper
        {
            // BASIC COLORS
            public static string _BLACK = "Black";
            public static string _BLUE = "Blue";
            public static string _CYAN = "Cyan";
            public static string _DARKBLUE = "DarkBlue";
            public static string _DARKCYAN = "DarkCyan";
            public static string _DARKGRAY = "DarkGray";
            public static string _DARKGREEN = "DarkGreen";
            public static string _DARKMAGENTA = "DarkMagenta";
            public static string _DARKRED = "DarkRed";
            public static string _DARKYELLOW = "DarkYellow";
            public static string _GRAY = "Gray";
            public static string _GREEN = "Green";
            public static string _MAGENTA = "Magenta";
            public static string _RED = "Red";
            public static string _WHITE = "White";
            public static string _YELLOW = "Yellow";

            // FOREGROUND COLOR CODES
            public static string _FG_BLACK = "\u001b[30m";
            public static string _FG_RED = "\u001b[31m";
            public static string _FG_GREEN = "\u001b[32m";
            public static string _FG_YELLOW = "\u001b[33m";
            public static string _FG_BLUE = "\u001b[34m";
            public static string _FG_MAGENTA = "\u001b[35m";
            public static string _FG_CYAN = "\u001b[36m";
            public static string _FG_WHITE = "\u001b[37m";
            public static string _FG_BRIGHT_BLACK = "\u001b[90m";
            public static string _FG_BRIGHT_RED = "\u001b[91m";
            public static string _FG_BRIGHT_GREEN = "\u001b[92m";
            public static string _FG_BRIGHT_YELLOW = "\u001b[93m";
            public static string _FG_BRIGHT_BLUE = "\u001b[94m";
            public static string _FG_BRIGHT_MAGENTA = "\u001b[95m";
            public static string _FG_BRIGHT_CYAN = "\u001b[96m";
            public static string _FG_BRIGHT_WHITE = "\u001b[97m";
            public static string _FG_DARKGRAY = "\033[90m";

            // BACKGROUND COLOR CODES
            public static string _BG_BLACK = "\u001b[40m";
            public static string _BG_RED = "\u001b[41m";
            public static string _BG_GREEN = "\u001b[42m";
            public static string _BG_YELLOW = "\u001b[43m";
            public static string _BG_BLUE = "\u001b[44m";
            public static string _BG_MAGENTA = "\u001b[45m";
            public static string _BG_CYAN = "\u001b[46m";
            public static string _BG_WHITE = "\u001b[47m";
            public static string _BG_BRIGHT_BLACK = "\u001b[100m";
            public static string _BG_BRIGHT_RED = "\u001b[101m";
            public static string _BG_BRIGHT_GREEN = "\u001b[102m";
            public static string _BG_BRIGHT_YELLOW = "\u001b[103m";
            public static string _BG_BRIGHT_BLUE = "\u001b[104m";
            public static string _BG_BRIGHT_MAGENTA = "\u001b[105m";
            public static string _BG_BRIGHT_CYAN = "\u001b[106m";
            public static string _BG_BRIGHT_WHITE = "\u001b[107m";

            // TEXT STYLES
            public static string _RESET = "\u001b[0m";
            public static string _BOLD = "\u001b[1m";
            public static string _DIM = "\u001b[2m";
            public static string _ITALIC = "\u001b[3m";
            public static string _UNDERLINE = "\u001b[4m";
            public static string _BLINK = "\u001b[5m";
            public static string _REVERSE = "\u001b[7m";
            public static string _HIDDEN = "\u001b[8m";
            public static string _STRIKETHROUGH = "\u001b[9m";

            // CUSTOM COLOR THEMES
            public static string _SUCCESS_COLOR = _FG_GREEN;
            public static string _ERROR_COLOR = _FG_RED;
            public static string _WARNING_COLOR = _FG_YELLOW;
            public static string _INFO_COLOR = _FG_CYAN;
            public static string _DEBUG_COLOR = _FG_MAGENTA;
            public static string _HIGHLIGHT_COLOR = _FG_BRIGHT_YELLOW;
            public static string _ACCENT_COLOR = _FG_BRIGHT_CYAN;
            public static string _MUTED_COLOR = _FG_DARKGRAY;

            // STATUS COLORS
            public static string _STATUS_SUCCESS = _FG_BRIGHT_GREEN;
            public static string _STATUS_ERROR = _FG_BRIGHT_RED;
            public static string _STATUS_WARNING = _FG_BRIGHT_YELLOW;
            public static string _STATUS_INFO = _FG_BRIGHT_CYAN;
            public static string _STATUS_DEBUG = _FG_BRIGHT_MAGENTA;
            public static string _STATUS_NEUTRAL = _FG_WHITE;
            public static string _STATUS_ACTIVE = _FG_BRIGHT_GREEN;
            public static string _STATUS_INACTIVE = _FG_DARKGRAY;
            public static string _STATUS_PENDING = _FG_BRIGHT_YELLOW;
            public static string _STATUS_COMPLETED = _FG_GREEN;
            public static string _STATUS_FAILED = _FG_RED;
            public static string _STATUS_RUNNING = _FG_BRIGHT_BLUE;
            public static string _STATUS_STOPPED = _FG_RED;
            public static string _STATUS_PAUSED = _FG_YELLOW;
            public static string _STATUS_QUEUED = _FG_BRIGHT_MAGENTA;
            public static string _STATUS_CANCELLED = _FG_DARKGRAY;
            public static string _STATUS_UNKNOWN = _FG_DARKGRAY;
            public static string _STATUS_CRITICAL = _FG_BRIGHT_RED;
            public static string _STATUS_MAJOR = _FG_RED;
            public static string _STATUS_MINOR = _FG_YELLOW;
            public static string _STATUS_NORMAL = _FG_GREEN;
            public static string _STATUS_OPTIMAL = _FG_BRIGHT_GREEN;
            public static string _STATUS_GOOD = _FG_GREEN;
            public static string _STATUS_FAIR = _FG_YELLOW;
            public static string _STATUS_POOR = _FG_RED;
            public static string _STATUS_HIGH = _FG_RED;
            public static string _STATUS_MEDIUM = _FG_YELLOW;
            public static string _STATUS_LOW = _FG_GREEN;
            public static string _STATUS_NONE = _FG_DARKGRAY;
            public static string _STATUS_FULL = _FG_BRIGHT_GREEN;
            public static string _STATUS_PARTIAL = _FG_YELLOW;
            public static string _STATUS_EMPTY = _FG_RED;
            public static string _STATUS_CONNECTED = _FG_BRIGHT_GREEN;
            public static string _STATUS_DISCONNECTED = _FG_RED;
            public static string _STATUS_CONNECTING = _FG_BRIGHT_YELLOW;
            public static string _STATUS_AUTHENTICATED = _FG_BRIGHT_GREEN;
            public static string _STATUS_UNAUTHENTICATED = _FG_RED;
            public static string _STATUS_AUTHORIZED = _FG_GREEN;
            public static string _STATUS_UNAUTHORIZED = _FG_RED;
            public static string _STATUS_VALID = _FG_GREEN;
            public static string _STATUS_INVALID = _FG_RED;
            public static string _STATUS_VERIFIED = _FG_BRIGHT_GREEN;
            public static string _STATUS_UNVERIFIED = _FG_YELLOW;
            public static string _STATUS_TRUSTED = _FG_GREEN;
            public static string _STATUS_UNTRUSTED = _FG_RED;
            public static string _STATUS_SECURE = _FG_BRIGHT_GREEN;
            public static string _STATUS_INSECURE = _FG_RED;
            public static string _STATUS_ENCRYPTED = _FG_GREEN;
            public static string _STATUS_UNENCRYPTED = _FG_RED;
            public static string _STATUS_COMPATIBLE = _FG_GREEN;
            public static string _STATUS_INCOMPATIBLE = _FG_RED;
            public static string _STATUS_SUPPORTED = _FG_GREEN;
            public static string _STATUS_UNSUPPORTED = _FG_RED;
            public static string _STATUS_AVAILABLE = _FG_BRIGHT_GREEN;
            public static string _STATUS_UNAVAILABLE = _FG_RED;
            public static string _STATUS_ONLINE = _FG_BRIGHT_GREEN;
            public static string _STATUS_OFFLINE = _FG_RED;
            public static string _STATUS_REACHABLE = _FG_GREEN;
            public static string _STATUS_UNREACHABLE = _FG_RED;
            public static string _STATUS_RESPONSIVE = _FG_BRIGHT_GREEN;
            public static string _STATUS_UNRESPONSIVE = _FG_RED;
            public static string _STATUS_HEALTHY = _FG_BRIGHT_GREEN;
            public static string _STATUS_UNHEALTHY = _FG_RED;
            public static string _STATUS_STABLE = _FG_GREEN;
            public static string _STATUS_UNSTABLE = _FG_RED;
            public static string _STATUS_OPTIMIZED = _FG_BRIGHT_GREEN;
            public static string _STATUS_SUBOPTIMAL = _FG_YELLOW;
            public static string _STATUS_EFFICIENT = _FG_GREEN;
            public static string _STATUS_INEFFICIENT = _FG_RED;
            public static string _STATUS_PERFORMANT = _FG_BRIGHT_GREEN;
            public static string _STATUS_SLOW = _FG_RED;
            public static string _STATUS_FAST = _FG_BRIGHT_GREEN;
            public static string _STATUS_UP_TO_DATE = _FG_GREEN;
            public static string _STATUS_OUTDATED = _FG_RED;
            public static string _STATUS_CURRENT = _FG_GREEN;
            public static string _STATUS_DEPRECATED = _FG_YELLOW;
            public static string _STATUS_MODERN = _FG_BRIGHT_GREEN;
            public static string _STATUS_LEGACY = _FG_DARKGRAY;
            public static string _STATUS_STANDARD = _FG_GREEN;
            public static string _STATUS_NONSTANDARD = _FG_YELLOW;
            public static string _STATUS_COMPLIANT = _FG_GREEN;
            public static string _STATUS_NONCOMPLIANT = _FG_RED;
            public static string _STATUS_CERTIFIED = _FG_BRIGHT_GREEN;
            public static string _STATUS_UNCERTIFIED = _FG_YELLOW;
            public static string _STATUS_LICENSED = _FG_GREEN;
            public static string _STATUS_UNLICENSED = _FG_RED;
            public static string _STATUS_ACTIVATED = _FG_BRIGHT_GREEN;
            public static string _STATUS_DEACTIVATED = _FG_RED;
            public static string _STATUS_ENABLED = _FG_GREEN;
            public static string _STATUS_DISABLED = _FG_RED;
            public static string _STATUS_ALLOWED = _FG_GREEN;
            public static string _STATUS_DENIED = _FG_RED;
            public static string _STATUS_PERMITTED = _FG_GREEN;
            public static string _STATUS_FORBIDDEN = _FG_RED;
            public static string _STATUS_GRANTED = _FG_BRIGHT_GREEN;
            public static string _STATUS_REVOKED = _FG_RED;
            public static string _STATUS_APPROVED = _FG_GREEN;
            public static string _STATUS_REJECTED = _FG_RED;
            public static string _STATUS_ACCEPTED = _FG_BRIGHT_GREEN;
            public static string _STATUS_DECLINED = _FG_RED;
            public static string _STATUS_CONFIRMED = _FG_GREEN;
            public static string _STATUS_UNCONFIRMED = _FG_YELLOW;
            public static string _STATUS_VERIFIED_USER = _FG_BRIGHT_GREEN;
            public static string _STATUS_UNVERIFIED_USER = _FG_YELLOW;
            public static string _STATUS_PREMIUM_USER = _FG_BRIGHT_YELLOW;
            public static string _STATUS_BASIC_USER = _FG_WHITE;
            public static string _STATUS_ADMIN_USER = _FG_BRIGHT_RED;
            public static string _STATUS_MODERATOR_USER = _FG_BRIGHT_BLUE;
            public static string _STATUS_REGULAR_USER = _FG_GREEN;
            public static string _STATUS_GUEST_USER = _FG_DARKGRAY;
            public static string _STATUS_BANNED_USER = _FG_RED;
            public static string _STATUS_SUSPENDED_USER = _FG_YELLOW;
            public static string _STATUS_ACTIVE_USER = _FG_BRIGHT_GREEN;
            public static string _STATUS_INACTIVE_USER = _FG_DARKGRAY;
            public static string _STATUS_NEW_USER = _FG_BRIGHT_CYAN;
            public static string _STATUS_EXISTING_USER = _FG_WHITE;
            public static string _STATUS_RETURNING_USER = _FG_BRIGHT_GREEN;
            public static string _STATUS_FIRST_TIME_USER = _FG_BRIGHT_MAGENTA;
            public static string _STATUS_VIP_USER = _FG_BRIGHT_YELLOW;
            public static string _STATUS_STAFF_USER = _FG_BRIGHT_CYAN;
            public static string _STATUS_DEVELOPER_USER = _FG_BRIGHT_MAGENTA;
            public static string _STATUS_TESTER_USER = _FG_BRIGHT_BLUE;
            public static string _STATUS_SUPPORT_USER = _FG_BRIGHT_GREEN;
            public static string _STATUS_SALES_USER = _FG_BRIGHT_YELLOW;
            public static string _STATUS_MARKETING_USER = _FG_BRIGHT_CYAN;
            public static string _STATUS_HR_USER = _FG_BRIGHT_MAGENTA;
            public static string _STATUS_FINANCE_USER = _FG_BRIGHT_GREEN;
            public static string _STATUS_LEGAL_USER = _FG_BRIGHT_RED;
            public static string _STATUS_IT_USER = _FG_BRIGHT_BLUE;
            public static string _STATUS_OPS_USER = _FG_BRIGHT_YELLOW;
            public static string _STATUS_SECURITY_USER = _FG_BRIGHT_RED;
            public static string _STATUS_AUDIT_USER = _FG_BRIGHT_MAGENTA;
            public static string _STATUS_COMPLIANCE_USER = _FG_BRIGHT_CYAN;
            public static string _STATUS_PRIVACY_USER = _FG_BRIGHT_GREEN;
            public static string _STATUS_RISK_USER = _FG_BRIGHT_YELLOW;
            public static string _STATUS_GOVERNANCE_USER = _FG_BRIGHT_BLUE;
            public static string _STATUS_STRATEGY_USER = _FG_BRIGHT_MAGENTA;
            public static string _STATUS_PLANNING_USER = _FG_BRIGHT_CYAN;
            public static string _STATUS_ANALYTICS_USER = _FG_BRIGHT_GREEN;
            public static string _STATUS_RESEARCH_USER = _FG_BRIGHT_YELLOW;
            public static string _STATUS_DEVELOPMENT_USER = _FG_BRIGHT_BLUE;
            public static string _STATUS_PRODUCTION_USER = _FG_BRIGHT_GREEN;
            public static string _STATUS_TESTING_USER = _FG_BRIGHT_MAGENTA;
            public static string _STATUS_STAGING_USER = _FG_BRIGHT_YELLOW;
            public static string _STATUS_SANDBOX_USER = _FG_BRIGHT_CYAN;
            public static string _STATUS_DEMO_USER = _FG_BRIGHT_BLUE;
            public static string _STATUS_TRIAL_USER = _FG_BRIGHT_MAGENTA;
            public static string _STATUS_PAID_USER = _FG_BRIGHT_GREEN;
            public static string _STATUS_FREE_USER = _FG_WHITE;
            public static string _STATUS_FREEMIUM_USER = _FG_BRIGHT_CYAN;
            public static string _STATUS_PREMIUM_SUBSCRIBER = _FG_BRIGHT_YELLOW;
            public static string _STATUS_BASIC_SUBSCRIBER = _FG_WHITE;
            public static string _STATUS_EXPIRED_SUBSCRIBER = _FG_RED;
            public static string _STATUS_ACTIVE_SUBSCRIBER = _FG_BRIGHT_GREEN;
            public static string _STATUS_CANCELLED_SUBSCRIBER = _FG_DARKGRAY;
            public static string _STATUS_PENDING_SUBSCRIBER = _FG_YELLOW;
            public static string _STATUS_GRACE_PERIOD_SUBSCRIBER = _FG_BRIGHT_YELLOW;
            public static string _STATUS_SUSPENDED_SUBSCRIBER = _FG_RED;
            public static string _STATUS_DELINQUENT_SUBSCRIBER = _FG_BRIGHT_RED;
            public static string _STATUS_IN_COLLECTIONS_SUBSCRIBER = _FG_RED;
            public static string _STATUS_CHURNED_SUBSCRIBER = _FG_DARKGRAY;
            public static string _STATUS_REACTIVATED_SUBSCRIBER = _FG_BRIGHT_GREEN;
            public static string _STATUS_LOYAL_SUBSCRIBER = _FG_BRIGHT_YELLOW;
            public static string _STATUS_NEW_SUBSCRIBER = _FG_BRIGHT_CYAN;
            public static string _STATUS_EXISTING_SUBSCRIBER = _FG_WHITE;
            public static string _STATUS_RETURNING_SUBSCRIBER = _FG_BRIGHT_GREEN;
            public static string _STATUS_AT_RISK_SUBSCRIBER = _FG_YELLOW;
            public static string _STATUS_SAFE_SUBSCRIBER = _FG_GREEN;
            public static string _STATUS_VIP_SUBSCRIBER = _FG_BRIGHT_YELLOW;
            public static string _STATUS_ENTERPRISE_SUBSCRIBER = _FG_BRIGHT_MAGENTA;
            public static string _STATUS_BUSINESS_SUBSCRIBER = _FG_BRIGHT_BLUE;
            public static string _STATUS_PRO_SUBSCRIBER = _FG_BRIGHT_GREEN;
            public static string _STATUS_PERSONAL_SUBSCRIBER = _FG_WHITE;
            public static string _STATUS_FAMILY_SUBSCRIBER = _FG_BRIGHT_CYAN;
            public static string _STATUS_STUDENT_SUBSCRIBER = _FG_BRIGHT_MAGENTA;
            public static string _STATUS_EDUCATOR_SUBSCRIBER = _FG_BRIGHT_BLUE;
            public static string _STATUS_NONPROFIT_SUBSCRIBER = _FG_BRIGHT_GREEN;
            public static string _STATUS_GOVERNMENT_SUBSCRIBER = _FG_BRIGHT_YELLOW;
            public static string _STATUS_MILITARY_SUBSCRIBER = _FG_BRIGHT_RED;
            public static string _STATUS_SENIOR_SUBSCRIBER = _FG_BRIGHT_CYAN;
            public static string _STATUS_YOUTH_SUBSCRIBER = _FG_BRIGHT_MAGENTA;
            public static string _STATUS_DISABLED_SUBSCRIBER = _FG_DARKGRAY;
            public static string _STATUS_LOW_INCOME_SUBSCRIBER = _FG_BRIGHT_YELLOW;
            public static string _STATUS_AFFILIATE_SUBSCRIBER = _FG_BRIGHT_GREEN;
            public static string _STATUS_PARTNER_SUBSCRIBER = _FG_BRIGHT_BLUE;
            public static string _STATUS_RESELLER_SUBSCRIBER = _FG_BRIGHT_MAGENTA;
            public static string _STATUS_DISTRIBUTOR_SUBSCRIBER = _FG_BRIGHT_CYAN;
            public static string _STATUS_WHOLESALER_SUBSCRIBER = _FG_BRIGHT_YELLOW;
            public static string _STATUS_RETAILER_SUBSCRIBER = _FG_BRIGHT_GREEN;
            public static string _STATUS_CUSTOMER_SUBSCRIBER = _FG_WHITE;
            public static string _STATUS_CLIENT_SUBSCRIBER = _FG_BRIGHT_BLUE;
            public static string _STATUS_CONSUMER_SUBSCRIBER = _FG_WHITE;
            public static string _STATUS_END_USER_SUBSCRIBER = _FG_WHITE;
            public static string _STATUS_POWER_USER_SUBSCRIBER = _FG_BRIGHT_YELLOW;
            public static string _STATUS_CASUAL_USER_SUBSCRIBER = _FG_DARKGRAY;
            public static string _STATUS_OCCASIONAL_USER_SUBSCRIBER = _FG_WHITE;
            public static string _STATUS_FREQUENT_USER_SUBSCRIBER = _FG_BRIGHT_GREEN;
            public static string _STATUS_HEAVY_USER_SUBSCRIBER = _FG_BRIGHT_YELLOW;
            public static string _STATUS_LIGHT_USER_SUBSCRIBER = _FG_DARKGRAY;
            public static string _STATUS_MODERATE_USER_SUBSCRIBER = _FG_WHITE;
            public static string _STATUS_EXTREME_USER_SUBSCRIBER = _FG_BRIGHT_RED;
            public static string _STATUS_AVERAGE_USER_SUBSCRIBER = _FG_WHITE;
            public static string _STATUS_TYPICAL_USER_SUBSCRIBER = _FG_WHITE;
            public static string _STATUS_STANDARD_USER_SUBSCRIBER = _FG_WHITE;
            public static string _STATUS_BASIC_USER_SUBSCRIBER = _FG_WHITE;
            public static string _STATUS_ADVANCED_USER_SUBSCRIBER = _FG_BRIGHT_GREEN;
            public static string _STATUS_EXPERT_USER_SUBSCRIBER = _FG_BRIGHT_YELLOW;
            public static string _STATUS_PROFESSIONAL_USER_SUBSCRIBER = _FG_BRIGHT_BLUE;
            public static string _STATUS_MASTER_USER_SUBSCRIBER = _FG_BRIGHT_MAGENTA;
            public static string _STATUS_GURU_USER_SUBSCRIBER = _FG_BRIGHT_CYAN;
            public static string _STATUS_NINJA_USER_SUBSCRIBER = _FG_BRIGHT_RED;
            public static string _STATUS_ROCKSTAR_USER_SUBSCRIBER = _FG_BRIGHT_YELLOW;
            public static string _STATUS_CHAMPION_USER_SUBSCRIBER = _FG_BRIGHT_GREEN;
            public static string _STATUS_LEGEND_USER_SUBSCRIBER = _FG_BRIGHT_MAGENTA;
            public static string _STATUS_ICON_USER_SUBSCRIBER = _FG_BRIGHT_CYAN;
            public static string _STATUS_HERO_USER_SUBSCRIBER = _FG_BRIGHT_RED;
            public static string _STATUS_SUPER_USER_SUBSCRIBER = _FG_BRIGHT_YELLOW;
            public static string _STATUS_ULTIMATE_USER_SUBSCRIBER = _FG_BRIGHT_GREEN;
            public static string _STATUS_PREMIUM_PLUS_USER_SUBSCRIBER = _FG_BRIGHT_MAGENTA;
            public static string _STATUS_DIAMOND_USER_SUBSCRIBER = _FG_BRIGHT_CYAN;
            public static string _STATUS_PLATINUM_USER_SUBSCRIBER = _FG_BRIGHT_WHITE;
            public static string _STATUS_GOLD_USER_SUBSCRIBER = _FG_BRIGHT_YELLOW;
            public static string _STATUS_SILVER_USER_SUBSCRIBER = _FG_WHITE;
            public static string _STATUS_BRONZE_USER_SUBSCRIBER = _FG_DARKGRAY;
            public static string _STATUS_COPPER_USER_SUBSCRIBER = _FG_RED;
            public static string _STATUS_STEEL_USER_SUBSCRIBER = _FG_DARKGRAY;
            public static string _STATUS_IRON_USER_SUBSCRIBER = _FG_DARKGRAY;
            public static string _STATUS_WOOD_USER_SUBSCRIBER = _FG_YELLOW;
            public static string _STATUS_STONE_USER_SUBSCRIBER = _FG_DARKGRAY;
            public static string _STATUS_PAPER_USER_SUBSCRIBER = _FG_WHITE;
            public static string _STATUS_ROCK_USER_SUBSCRIBER = _FG_DARKGRAY;
            public static string _STATUS_SCISSORS_USER_SUBSCRIBER = _FG_WHITE;
            public static string _STATUS_FIRE_USER_SUBSCRIBER = _FG_BRIGHT_RED;
            public static string _STATUS_WATER_USER_SUBSCRIBER = _FG_BRIGHT_BLUE;
            public static string _STATUS_EARTH_USER_SUBSCRIBER = _FG_GREEN;
            public static string _STATUS_AIR_USER_SUBSCRIBER = _FG_BRIGHT_CYAN;
            public static string _STATUS_LIGHTNING_USER_SUBSCRIBER = _FG_BRIGHT_YELLOW;
            public static string _STATUS_ICE_USER_SUBSCRIBER = _FG_BRIGHT_CYAN;
            public static string _STATUS_POISON_USER_SUBSCRIBER = _FG_BRIGHT_GREEN;
            public static string _STATUS_PSYCHIC_USER_SUBSCRIBER = _FG_BRIGHT_MAGENTA;
            public static string _STATUS_GHOST_USER_SUBSCRIBER = _FG_DARKGRAY;
            public static string _STATUS_DRAGON_USER_SUBSCRIBER = _FG_BRIGHT_RED;
            public static string _STATUS_DARK_USER_SUBSCRIBER = _FG_DARKGRAY;
            public static string _STATUS_FAIRY_USER_SUBSCRIBER = _FG_BRIGHT_MAGENTA;
            public static string _STATUS_FIGHTING_USER_SUBSCRIBER = _FG_RED;
            public static string _STATUS_FLYING_USER_SUBSCRIBER = _FG_BRIGHT_CYAN;
            public static string _STATUS_GRASS_USER_SUBSCRIBER = _FG_GREEN;
            public static string _STATUS_GROUND_USER_SUBSCRIBER = _FG_YELLOW;
            public static string _STATUS_BUG_USER_SUBSCRIBER = _FG_BRIGHT_GREEN;
            public static string _STATUS_ELECTRIC_USER_SUBSCRIBER = _FG_BRIGHT_YELLOW;
            public static string _STATUS_NORMAL_USER_SUBSCRIBER = _FG_WHITE;
            // public static string _STATUS_ROCK_USER_SUBSCRIBER = _FG_DARKGRAY;
            // public static string _STATUS_STEEL_USER_SUBSCRIBER = _FG_DARKGRAY;

            // LOG LEVEL COLORS
            public static string _LOG_EMERGENCY = _FG_BRIGHT_RED;
            public static string _LOG_ALERT = _FG_BRIGHT_RED;
            public static string _LOG_CRITICAL = _FG_RED;
            public static string _LOG_ERROR = _FG_RED;
            public static string _LOG_WARNING = _FG_YELLOW;
            public static string _LOG_NOTICE = _FG_BRIGHT_YELLOW;
            public static string _LOG_INFO = _FG_CYAN;
            public static string _LOG_DEBUG = _FG_MAGENTA;
            public static string _LOG_TRACE = _FG_DARKGRAY;
            public static string _LOG_VERBOSE = _FG_DARKGRAY;
            public static string _LOG_SILLY = _FG_DARKGRAY;
            public static string _LOG_FATAL = _FG_BRIGHT_RED;
            public static string _LOG_SEVERE = _FG_RED;
            public static string _LOG_IMPORTANT = _FG_BRIGHT_YELLOW;
            public static string _LOG_MINOR = _FG_WHITE;
            public static string _LOG_ROUTINE = _FG_DARKGRAY;
            public static string _LOG_BACKGROUND = _FG_DARKGRAY;
            public static string _LOG_FOREGROUND = _FG_WHITE;
            public static string _LOG_INTERACTIVE = _FG_BRIGHT_CYAN;
            public static string _LOG_AUTOMATED = _FG_DARKGRAY;
            public static string _LOG_MANUAL = _FG_WHITE;
            public static string _LOG_SCHEDULED = _FG_BRIGHT_BLUE;
            public static string _LOG_ON_DEMAND = _FG_BRIGHT_GREEN;
            public static string _LOG_REALTIME = _FG_BRIGHT_CYAN;
            public static string _LOG_BATCH = _FG_DARKGRAY;
            public static string _LOG_STREAMING = _FG_BRIGHT_MAGENTA;
            public static string _LOG_EVENT_DRIVEN = _FG_BRIGHT_YELLOW;
            public static string _LOG_POLLING = _FG_WHITE;
            public static string _LOG_WEBHOOK = _FG_BRIGHT_GREEN;
            public static string _LOG_API_CALL = _FG_BRIGHT_BLUE;
            public static string _LOG_DATABASE = _FG_BRIGHT_MAGENTA;
            public static string _LOG_NETWORK = _FG_BRIGHT_CYAN;
            public static string _LOG_SECURITY = _FG_BRIGHT_RED;
            public static string _LOG_PERFORMANCE = _FG_BRIGHT_YELLOW;
            public static string _LOG_AVAILABILITY = _FG_BRIGHT_GREEN;
            public static string _LOG_RELIABILITY = _FG_GREEN;
            public static string _LOG_SCALABILITY = _FG_BRIGHT_BLUE;
            public static string _LOG_MAINTAINABILITY = _FG_BRIGHT_CYAN;
            public static string _LOG_USABILITY = _FG_BRIGHT_MAGENTA;
            public static string _LOG_ACCESSIBILITY = _FG_BRIGHT_GREEN;
            public static string _LOG_COMPATIBILITY = _FG_BRIGHT_YELLOW;
            public static string _LOG_PORTABILITY = _FG_BRIGHT_BLUE;
            public static string _LOG_TESTABILITY = _FG_BRIGHT_CYAN;
            public static string _LOG_DEPLOYABILITY = _FG_BRIGHT_MAGENTA;
            public static string _LOG_OBSERVABILITY = _FG_BRIGHT_GREEN;
            public static string _LOG_DEBUGGABILITY = _FG_BRIGHT_YELLOW;
            public static string _LOG_PROFILABILITY = _FG_BRIGHT_BLUE;
            public static string _LOG_MONITORABILITY = _FG_BRIGHT_CYAN;
            public static string _LOG_MANAGEABILITY = _FG_BRIGHT_MAGENTA;
            public static string _LOG_OPERABILITY = _FG_BRIGHT_GREEN;
            public static string _LOG_SUPPORTABILITY = _FG_BRIGHT_YELLOW;
            public static string _LOG_EXTENSIBILITY = _FG_BRIGHT_BLUE;
            public static string _LOG_CUSTOMIZABILITY = _FG_BRIGHT_CYAN;
            public static string _LOG_CONFIGURABILITY = _FG_BRIGHT_MAGENTA;
            public static string _LOG_INTEGRABILITY = _FG_BRIGHT_GREEN;
            public static string _LOG_INTEROPERABILITY = _FG_BRIGHT_YELLOW;
            public static string _LOG_CONNECTIVITY = _FG_BRIGHT_BLUE;
            public static string _LOG_COMMUNICABILITY = _FG_BRIGHT_CYAN;
            public static string _LOG_COLLABORABILITY = _FG_BRIGHT_MAGENTA;
            public static string _LOG_SHAREABILITY = _FG_BRIGHT_GREEN;
            public static string _LOG_DISCOVERABILITY = _FG_BRIGHT_YELLOW;
            public static string _LOG_FINDABILITY = _FG_BRIGHT_BLUE;
            public static string _LOG_SEARCHABILITY = _FG_BRIGHT_CYAN;
            public static string _LOG_NAVIGABILITY = _FG_BRIGHT_MAGENTA;
            public static string _LOG_BROWSABILITY = _FG_BRIGHT_GREEN;
            public static string _LOG_SCANNABILITY = _FG_BRIGHT_YELLOW;
            public static string _LOG_READABILITY = _FG_BRIGHT_BLUE;
            public static string _LOG_WRITABILITY = _FG_BRIGHT_CYAN;
            public static string _LOG_EDITABILITY = _FG_BRIGHT_MAGENTA;
            public static string _LOG_MODIFIABILITY = _FG_BRIGHT_GREEN;
            public static string _LOG_ADAPTABILITY = _FG_BRIGHT_YELLOW;
            public static string _LOG_FLEXIBILITY = _FG_BRIGHT_BLUE;
            public static string _LOG_AGILITY = _FG_BRIGHT_CYAN;
            public static string _LOG_RESILIENCE = _FG_BRIGHT_MAGENTA;
            public static string _LOG_ROBUSTNESS = _FG_BRIGHT_GREEN;
            public static string _LOG_REDUNDANCY = _FG_BRIGHT_YELLOW;
            public static string _LOG_FAULT_TOLERANCE = _FG_BRIGHT_BLUE;
            public static string _LOG_DISASTER_RECOVERY = _FG_BRIGHT_CYAN;
            public static string _LOG_BACKUP = _FG_BRIGHT_MAGENTA;
            public static string _LOG_RESTORE = _FG_BRIGHT_GREEN;
            public static string _LOG_SNAPSHOT = _FG_BRIGHT_YELLOW;
            public static string _LOG_CLONE = _FG_BRIGHT_BLUE;
            public static string _LOG_MIRROR = _FG_BRIGHT_CYAN;
            public static string _LOG_REPLICA = _FG_BRIGHT_MAGENTA;
            public static string _LOG_SHADOW = _FG_DARKGRAY;
            public static string _LOG_GHOST = _FG_DARKGRAY;
            public static string _LOG_ZOMBIE = _FG_RED;
            public static string _LOG_VAMPIRE = _FG_BRIGHT_RED;
            public static string _LOG_WEREWOLF = _FG_YELLOW;
            public static string _LOG_DRACULA = _FG_RED;
            public static string _LOG_FRANKENSTEIN = _FG_GREEN;
            public static string _LOG_MUMMY = _FG_YELLOW;
            public static string _LOG_PHANTOM = _FG_DARKGRAY;
            public static string _LOG_SPECTER = _FG_DARKGRAY;
            public static string _LOG_WRAITH = _FG_DARKGRAY;
            public static string _LOG_BANSHEE = _FG_BRIGHT_MAGENTA;
            public static string _LOG_GHOUL = _FG_GREEN;
            public static string _LOG_DEMON = _FG_RED;
            public static string _LOG_ANGEL = _FG_BRIGHT_WHITE;
            public static string _LOG_ARCHANGEL = _FG_BRIGHT_CYAN;
            public static string _LOG_CHERUB = _FG_BRIGHT_YELLOW;
            public static string _LOG_SERAPH = _FG_BRIGHT_RED;
            public static string _LOG_DEMIGOD = _FG_BRIGHT_MAGENTA;
            public static string _LOG_TITAN = _FG_BRIGHT_BLUE;
            public static string _LOG_GIANT = _FG_BRIGHT_GREEN;
            public static string _LOG_DWARF = _FG_YELLOW;
            public static string _LOG_ELF = _FG_BRIGHT_GREEN;
            public static string _LOG_FAIRY = _FG_BRIGHT_MAGENTA;
            public static string _LOG_GNOME = _FG_GREEN;
            public static string _LOG_GOBLIN = _FG_BRIGHT_GREEN;
            public static string _LOG_HOBGOBLIN = _FG_GREEN;
            public static string _LOG_IMP = _FG_BRIGHT_RED;
            public static string _LOG_KOBOLD = _FG_YELLOW;
            public static string _LOG_LEPRECHAUN = _FG_BRIGHT_GREEN;
            public static string _LOG_ORC = _FG_GREEN;
            public static string _LOG_TROLL = _FG_DARKGRAY;
            public static string _LOG_OGRE = _FG_YELLOW;
            public static string _LOG_CYCLOPS = _FG_WHITE;
            public static string _LOG_MINOTAUR = _FG_RED;
            public static string _LOG_CENTAUR = _FG_YELLOW;
            public static string _LOG_SATYR = _FG_GREEN;
            public static string _LOG_FAUN = _FG_BRIGHT_GREEN;
            public static string _LOG_DRYAD = _FG_BLACK;
        }
        public static class ConsoleColorPresets
        {
            // Foreground colors
            public static ConsoleColor _BLACK = ConsoleColor.Black;
            public static ConsoleColor _BLUE = ConsoleColor.Blue;
            public static ConsoleColor _CYAN = ConsoleColor.Cyan;
            public static ConsoleColor _DARKBLUE = ConsoleColor.DarkBlue;
            public static ConsoleColor _DARKCYAN = ConsoleColor.DarkCyan;
            public static ConsoleColor _DARKGRAY = ConsoleColor.DarkGray;
            public static ConsoleColor _DARKGREEN = ConsoleColor.DarkGreen;
            public static ConsoleColor _DARKMAGENTA = ConsoleColor.DarkMagenta;
            public static ConsoleColor _DARKRED = ConsoleColor.DarkRed;
            public static ConsoleColor _DARKYELLOW = ConsoleColor.DarkYellow;
            public static ConsoleColor _GRAY = ConsoleColor.Gray;
            public static ConsoleColor _GREEN = ConsoleColor.Green;
            public static ConsoleColor _MAGENTA = ConsoleColor.Magenta;
            public static ConsoleColor _RED = ConsoleColor.Red;
            public static ConsoleColor _WHITE = ConsoleColor.White;
            public static ConsoleColor _YELLOW = ConsoleColor.Yellow;

            // Background colors
            public static ConsoleColor _BG_BLACK = ConsoleColor.Black;
            public static ConsoleColor _BG_BLUE = ConsoleColor.Blue;
            public static ConsoleColor _BG_CYAN = ConsoleColor.Cyan;
            public static ConsoleColor _BG_DARKBLUE = ConsoleColor.DarkBlue;
            public static ConsoleColor _BG_DARKCYAN = ConsoleColor.DarkCyan;
            public static ConsoleColor _BG_DARKGRAY = ConsoleColor.DarkGray;
            public static ConsoleColor _BG_DARKGREEN = ConsoleColor.DarkGreen;
            public static ConsoleColor _BG_DARKMAGENTA = ConsoleColor.DarkMagenta;
            public static ConsoleColor _BG_DARKRED = ConsoleColor.DarkRed;
            public static ConsoleColor _BG_DARKYELLOW = ConsoleColor.DarkYellow;
            public static ConsoleColor _BG_GRAY = ConsoleColor.Gray;
            public static ConsoleColor _BG_GREEN = ConsoleColor.Green;
            public static ConsoleColor _BG_MAGENTA = ConsoleColor.Magenta;
            public static ConsoleColor _BG_RED = ConsoleColor.Red;
            public static ConsoleColor _BG_WHITE = ConsoleColor.White;
            public static ConsoleColor _BG_YELLOW = ConsoleColor.Yellow;

            // Example combined presets (Foreground, Background)
            public static (ConsoleColor FG, ConsoleColor BG) _PRESET_ERROR = (ConsoleColor.White, ConsoleColor.Red);
            public static (ConsoleColor FG, ConsoleColor BG) _PRESET_WARNING = (ConsoleColor.Black, ConsoleColor.Yellow);
            public static (ConsoleColor FG, ConsoleColor BG) _PRESET_INFO = (ConsoleColor.White, ConsoleColor.Blue);
            public static (ConsoleColor FG, ConsoleColor BG) _PRESET_SUCCESS = (ConsoleColor.Black, ConsoleColor.Green);


            public static void ApplyPreset((ConsoleColor FG, ConsoleColor BG) preset)
            {
                Console.ForegroundColor = preset.FG;
                Console.BackgroundColor = preset.BG;
            }

            public static void ThisPreset(ConsoleColor foregroundColor, ConsoleColor backgroundColor)
            {
                Console.ForegroundColor = foregroundColor;
                Console.BackgroundColor = backgroundColor;
                // ApplyPreset(_PRESET_SUCCESS)
            }

            public enum ColorPresets
            {
                Error,
                Warning,
                Info,
                Success
            }

            public static class ColorPreseClass
            {
                private static readonly Dictionary<ColorPresets, (ConsoleColor FG, ConsoleColor BG)> PresetMap = new()
                {
                    [ColorPresets.Error] = (ConsoleColor.White, ConsoleColor.Red),
                    [ColorPresets.Warning] = (ConsoleColor.Black, ConsoleColor.Yellow),
                    [ColorPresets.Info] = (ConsoleColor.White, ConsoleColor.Blue),
                    [ColorPresets.Success] = (ConsoleColor.Black, ConsoleColor.Green),
                };

                public static void ApplyPreset(ColorPresets preset)
                {
                    var colors = PresetMap[preset];
                    Console.ForegroundColor = colors.FG;
                    Console.BackgroundColor = colors.BG;
                }
            }
        }

    }
}