\ Numbers used in the ssh protocol according to rfc4250
\ Value - Message ID -- Reference
\ [SSH-TRANS]
1   constant SSH_MSG_DISCONNECT
2   constant SSH_MSG_IGNORE
3   constant SSH_MSG_UNIMPLEMENTED
4   constant SSH_MSG_DEBUG
5   constant SSH_MSG_SERVICE_REQUEST
6   constant SSH_MSG_SERVICE_ACCEPT
20  constant SSH_MSG_KEXINIT
21  constant SSH_MSG_NEWKEYS
\ [SSH-USERAUTH]
50  constant SSH_MSG_USERAUTH_REQUEST
51  constant SSH_MSG_USERAUTH_FAILURE
52  constant SSH_MSG_USERAUTH_SUCCESS
53  constant SSH_MSG_USERAUTH_BANNER
\ [SSH-CONNECT]
80  constant SSH_MSG_GLOBAL_REQUEST
81  constant SSH_MSG_REQUEST_SUCCESS
82  constant SSH_MSG_REQUEST_FAILURE
90  constant SSH_MSG_CHANNEL_OPEN
91  constant SSH_MSG_CHANNEL_OPEN_CONFIRMATION
92  constant SSH_MSG_CHANNEL_OPEN_FAILURE
93  constant SSH_MSG_CHANNEL_WINDOW_ADJUST
94  constant SSH_MSG_CHANNEL_DATA
95  constant SSH_MSG_CHANNEL_EXTENDED_DATA
96  constant SSH_MSG_CHANNEL_EOF
97  constant SSH_MSG_CHANNEL_CLOSE
98  constant SSH_MSG_CHANNEL_REQUEST
99  constant SSH_MSG_CHANNEL_SUCCESS
100 constant SSH_MSG_CHANNEL_FAILURE


\ Disconnection Messages Reason Codes and Descriptions

\ reason code - Symbolic Name
1  constant SSH_DISCONNECT_HOST_NOT_ALLOWED_TO_CONNECT
2  constant SSH_DISCONNECT_PROTOCOL_ERROR
3  constant SSH_DISCONNECT_KEY_EXCHANGE_FAILED
4  constant SSH_DISCONNECT_RESERVED
5  constant SSH_DISCONNECT_MAC_ERROR
6  constant SSH_DISCONNECT_COMPRESSION_ERROR
7  constant SSH_DISCONNECT_SERVICE_NOT_AVAILABLE
8  constant SSH_DISCONNECT_PROTOCOL_VERSION_NOT_SUPPORTED
9  constant SSH_DISCONNECT_HOST_KEY_NOT_VERIFIABLE
10 constant SSH_DISCONNECT_CONNECTION_LOST
11 constant SSH_DISCONNECT_BY_APPLICATION
12 constant SSH_DISCONNECT_TOO_MANY_CONNECTIONS
13 constant SSH_DISCONNECT_AUTH_CANCELLED_BY_USER
14 constant SSH_DISCONNECT_NO_MORE_AUTH_METHODS_AVAILABLE
15 constant SSH_DISCONNECT_ILLEGAL_USER_NAME

\ Channel Connection Failure Reason Codes and Descriptions
\ reason code - Symbolic Name
1 constant SSH_OPEN_ADMINISTRATIVELY_PROHIBITED
2 constant SSH_OPEN_CONNECT_FAILED
3 constant SSH_OPEN_UNKNOWN_CHANNEL_TYPE
4 constant SSH_OPEN_RESOURCE_SHORTAGE

\ Extended Channel Data Transfer data_type_code and Data
\ data_type_code - Symbolic name
1 constant SSH_EXTENDED_DATA_STDERR

\ Pseudo-Terminal Encoded Terminal Modes

\ opcode - mnemonic - description
0   constant TTY_OP_END    \ Indicates end of options.
1   constant VINTR         \ Interrupt character; 255 if none.  Similarly for the other characters.  Not all of these characters are supported on all systems.
2   constant VQUIT         \ The quit character (sends SIGQUIT signal on POSIX systems).
3   constant VERASE        \ Erase the character to left of the cursor.
4   constant VKILL         \ Kill the current input line.
5   constant VEOF          \ End-of-file character (sends EOF from the terminal).
6   constant VEOL          \ End-of-line character in addition to carriage return and/or linefeed.
7   constant VEOL2         \ Additional end-of-line character.
8   constant VSTART        \ Continues paused output (normally control-Q).
9   constant VSTOP         \ Pauses output (normally control-S).
10  constant VSUSP         \ Suspends the current program.
11  constant VDSUSP        \ Another suspend character.
12  constant VREPRINT      \ Reprints the current input line.
13  constant VWERASE       \ Erases a word left of cursor.
14  constant VLNEXT        \ Enter the next character typed literally, even if it is a special character
15  constant VFLUSH        \ Character to flush output.
16  constant VSWTCH        \ Switch to a different shell layer.
17  constant VSTATUS       \ Prints system status line (load, command, pid, etc).
18  constant VDISCARD      \ Toggles the flushing of terminal output.
30  constant IGNPAR        \ The ignore parity flag.  The parameter SHOULD be 0 if this flag is FALSE, and 1 if it is TRUE.
31  constant PARMRK        \ Mark parity and framing errors.
32  constant INPCK         \ Enable checking of parity errors.
33  constant ISTRIP        \ Strip 8th bit off characters.
34  constant INLCR         \ Map NL into CR on input.
35  constant IGNCR         \ Ignore CR on input.
36  constant ICRNL         \ Map CR to NL on input.
37  constant IUCLC         \ Translate uppercase characters to lowercase.
38  constant IXON          \ Enable output flow control.
39  constant IXANY         \ Any char will restart after stop.
40  constant IXOFF         \ Enable input flow control.
41  constant IMAXBEL       \ Ring bell on input queue full.
50  constant ISIG          \ Enable signals INTR, QUIT, [D]SUSP.
51  constant ICANON        \ Canonicalize input lines.
52  constant XCASE         \ Enable input and output of uppercase characters by preceding their lowercase equivalents with "\".
53  constant ECHO          \ Enable echoing.
54  constant ECHOE         \ Visually erase chars.
55  constant ECHOK         \ Kill character discards current line.
56  constant ECHONL        \ Echo NL even if ECHO is off.
57  constant NOFLSH        \ Don't flush after interrupt.
58  constant TOSTOP        \ Stop background jobs from output.
59  constant IEXTEN        \ Enable extensions.
60  constant ECHOCTL       \ Echo control characters as ^(Char).
61  constant ECHOKE        \ Visual erase for line kill.
62  constant PENDIN        \ Retype pending input.
70  constant OPOST         \ Enable output processing.
71  constant OLCUC         \ Convert lowercase to uppercase.
72  constant ONLCR         \ Map NL to CR-NL.
73  constant OCRNL         \ Translate carriage return to newline (output).
74  constant ONOCR         \ Translate newline to carriage return-newline (output).
75  constant ONLRET        \ Newline performs a carriage return (output).
90  constant CS7           \ 7 bit mode.
91  constant CS8           \ 8 bit mode.
92  constant PARENB        \ Parity enable.
93  constant PARODD        \ Odd parity, else even.
128 constant TTY_OP_ISPEED \ Specifies the input baud rate in bits per second.
129 constant TTY_OP_OSPEED \ Specifies the output baud rate in bits per second.
