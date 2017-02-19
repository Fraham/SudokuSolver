using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.Repositories.Input.HTML
{
	public class HTMLFake : IHTMLClient
	{
		private IDictionary<string, string> stringDict = new Dictionary<string, string>();

		public HTMLFake()
		{
			stringDict.Add("http://show.websudoku.com/?level=3", @"<HTML>
	<HEAD>
		<TITLE>Web Sudoku - Billions of Free Sudoku Puzzles to Play Online</TITLE>
		<META HTTP-EQUIV=""Content-Type"" CONTENT=""text/html; charset=UTF-8"">
		<meta id = ""mobileviewport"" name=""viewport"" content=""width=device-width, initial-scale=1"">
		<LINK REL=""stylesheet"" TYPE=""text/css"" HREF=""style24.css"">


		<SCRIPT language=""JavaScript""><!--
			var w_c=1;
			var w_s=0;
			var e_m=0;
			var m_c='<FONT COLOR=green><B>Back to the start, we go!</B></FONT>';
			var m_m='<FONT COLOR=red><B>You have made some mistakes, highlighted in red!</B></FONT>';
			var m_w='<FONT COLOR=purple><B>Something is not quite right in * of the cells!</B></FONT>';
			var m_i='<FONT COLOR=blue><B>Everything is OK, you still have * to go!</B></FONT>';
			var m_d='<B>Here is the puzzle. Good luck!</B>';
			var s_c=false;
			var cheat='517326498694851732832794516451278369789643125263519874978432651145967283326185947';
			var prefix='36mtc';
			var pid='6872255636';
		// --></SCRIPT>
		<SCRIPT TYPE=""text/javascript"" SRC=""index29.js""></SCRIPT>
		<!-- The HTML code and text in this document are copyright. Infringers of copyright will be prosecuted. -->
	</HEAD>
	
	<BODY BGCOLOR=""#F9F9FF"" onLoad=""j3(-1)""><TABLE WIDTH=100% HEIGHT=100% CELLSPACING=16 BORDER=0><TR>	<TD id=""left-column"" WIDTH=""248"">
			<TABLE WIDTH=""248"" CELLSPACING=0 BORDER=0 HEIGHT=100%>
				<TR><TD VALIGN=top ALIGN=center >
					<SCRIPT language=""JavaScript""><!--
						j0();
					// --></SCRIPT>
<P STYLE=""font-size:8pt; margin:0;""><B>English</B> &nbsp; <A HREF=""http://fr.websudoku.com/"" TARGET=""_top"" TITLE=""Web Sudoku - Des Milliards de Sudokus Gratuits pour Jouer en Ligne"">Français</A> &nbsp; <A HREF=""http://de.websudoku.com/"" TARGET=""_top"" TITLE=""Web Sudoku - Milliarden Kostenlose Online-Sudokus"">Deutsch</A> &nbsp; <A HREF=""http://es.websudoku.com/"" TARGET=""_top"" TITLE=""Web Sudoku - Billones de rompecabezas sudoku gratis a los que jugar en Línea"">Español</A> </P>					<P CLASS=tm STYLE=""margin:18px 0""><IMG SRC=""logo-108x108.gif"" HEIGHT=108 WIDTH=108 BORDER=0></P>
					<P CLASS=tm STYLE=""font-size:12pt""><A HREF=""http://www.websudoku.com/?level=1"" TARGET=""_top""><B>Easy</B></A> &nbsp; <A HREF=""http://www.websudoku.com/?level=2"" TARGET=""_top""><B>Medium</B></A> &nbsp; <B>Hard</B> &nbsp; <A HREF=""http://www.websudoku.com/?level=4"" TARGET=""_top""><B>Evil</B></A> </P>
					<P CLASS=tm STYLE=""font-size:10pt"">
					<A HREF=""http://www.jigsawdoku.com/"" TARGET=""_top"" TITLE=""Play Sudoku in color, plus 4x4 and 6x6 for beginners!""><B>JigSawDoku</B></A>
					&nbsp;
					<A HREF=""http://www.websudoku.com/variation/"" TARGET=""_top"" TITLE=""Print a Sudoku variation! Samurai, Squiggly and more...""><B>Variations</B></A>
					&nbsp;
					<A HREF=""http://www.websudoku.com/deluxe.php?l0"" TARGET=""_top"" TITLE=""Download Web Sudoku Deluxe to Play Offline!""><B>Download</B></A>
					<P CLASS=tm STYLE=""font-size:9pt;"">
<A HREF=""http://www.websudoku.com/?pic-a-pix"" TARGET=""_top""><B>Pic-a-Pix</B></A> &nbsp; <A HREF=""http://www.websudoku.com/?fill-a-pix"" TARGET=""_top""><B>Fill-a-Pix</B></A> &nbsp; <A HREF=""http://www.websudoku.com/?hashi"" TARGET=""_top""><B>Hashi</B></A> &nbsp; <A HREF=""http://www.websudoku.com/?calcudoku"" TARGET=""_top""><B>CalcuDoku</B></A>					</P>
					</P>
					<P CLASS=tm STYLE=""padding-top:6px; padding-bottom:12px; margin:18px 0;"">Every <A HREF=""http://en.wikipedia.org/wiki/Sudoku"" TARGET=""_top"">Sudoku</A> has a unique solution that can be reached logically. Enter numbers into the blank spaces so that each row, column and 3x3 box contains the numbers 1&nbsp;to&nbsp;9. For more help, try our <A HREF=""http://www.websudoku.com/tutorials/"" TARGET=""_top"">interactive Sudoku tutorials</A>.</P>
					<P CLASS=tm STYLE=""font-size:10pt;""><A HREF=""http://www.websudoku.com/deluxe.php?l1"" TARGET=""_top"" TITLE=""Play Offline, Full Screen, Extra Features!""><B><U>Play Offline with Web Sudoku Deluxe</U></B><br><IMG SRC=""green-arrow.gif"" ALIGN=""baseline"" WIDTH=""11"" HEIGHT=""11"" BORDER=""0"" STYLE=""position:relative; top:1px; left:-5px;""><FONT COLOR=""#006600"">Download for Windows and Mac</FONT></A></P>
					<P CLASS=tm STYLE=""font-size:10pt""><A HREF=""http://www.websudoku.com/ebook.php?l1"" TARGET=""_top"" TITLE=""Choose your own Puzzles and Levels!""><B><U>Create your own Sudoku Ebook</U></B></A></P>
					<P CLASS=tm STYLE=""font-size:10pt""><a href=""https://play.google.com/store/apps/details?id=com.websudoku.app&referrer=utm_source%3Dwebsudoku%26utm_medium%3Dreferral%26utm_campaign%3Dleft_link"" target=""_top""><B><U>Web Sudoku for Android</U></B></a> and <a href=""https://itunes.apple.com/us/app/web-sudoku/id786161944?mt=8&uo=4&at=11l558"" target=""_top""><B><U>iPad</U></B></a>:</P>
					<P STYLE=""margin-top:6px;""><a href=""https://itunes.apple.com/us/app/web-sudoku/id786161944?mt=8&uo=4&at=11l558"" target=""_top""><IMG SRC=""download-app-store.png"" TITLE=""Web Sudoku app for iPad"" WIDTH=""135"" HEIGHT=""40"" BORDER=""0""></a> <a href=""https://play.google.com/store/apps/details?id=com.websudoku.app&referrer=utm_source%3Dwebsudoku%26utm_medium%3Dreferral%26utm_campaign%3Dleft_button"" target=""_top""><IMG SRC=""get-it-google-play.png"" TITLE=""Web Sudoku app for Android"" WIDTH=""117"" HEIGHT=""40"" BORDER=""0""></a></P>
					<script>
  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
  })(window,document,'script','//www.google-analytics.com/analytics.js','ga');

  ga('create', 'UA-1165533-17', 'auto');
  ga('send', 'pageview');

</script>

				</TD></TR>
				<TR><TD VALIGN=bottom NOWRAP ALIGN=center>
					<P CLASS=tm><B><A HREF=""http://www.websudoku.com/syndication.php"" TARGET=""_top"" TITLE=""Sudoku puzzle syndication for newspapers, magazines, websites, books and more."">Syndication</A> | <A HREF=""http://www.websudoku.com/books/"" TARGET=""_top"" TITLE=""Our unique Sudoku books with online solving guides"">Books</A> | <A HREF=""http://www.websudoku.com/widget.php"" TARGET=""_top"" TITLE=""Add Sudoku to your website or blog"">Widget</A> | <A HREF=""http://www.websudoku.com/ipad-android.php"" TARGET=""_top"" TITLE=""Web Sudoku for iPad and Android"">iPad / Android</A></B></P>
					<P CLASS=tm STYLE=""margin-top:4pt;""><B><A HREF=""http://www.websudoku.com/about.php"" TARGET=""_top"" TITLE=""More information about Web Sudoku"">About Us</A> | <A HREF=""http://www.websudoku.com/faqs.php"" TARGET=""_top"" TITLE=""Frequently Asked Questions"">FAQs</A> | <A HREF=""http://www.websudoku.com/feedback.php"" TARGET=""_top"" TITLE=""Send feedback to Web Sudoku"">Feedback</A> | <A HREF=""http://www.websudoku.com/privacy.php"" TARGET=""_top"" TITLE=""Our full privacy statement"">Privacy Policy</A></B></P>
				</TD></TR>
			</TABLE>
		</TD>
		
		<TD id=""separator"" WIDTH=1 BGCOLOR=#999999><IMG SRC=""http://www.websudoku.com/images/transparent.gif"" WIDTH=1></TD>

		<TD WIDTH=* BGCOLOR=""#F9F9FF"" ><TABLE WIDTH=100% HEIGHT=100% CELLSPACING=0>

<TR><TD HEIGHT=""24"" ALIGN=""right"" STYLE=""padding-bottom:12px;""><B><A HREF=""http://www.websudoku.com/?register"" TARGET=""_top"">Register Free</A> or <A HREF=""http://www.websudoku.com/?signin"" TARGET=""_top"">Sign In to Web Sudoku</A></B> &nbsp;</TD></TR>	
			<TR VALIGN=""middle""><TD ALIGN=""center"">

			<FORM NAME=""board"" METHOD=POST ACTION=""./"" STYLE=""margin:0;"">
			<script id=""mNCC"" language=""javascript"">  medianet_width='468';  medianet_height= '60';  medianet_crid='715873954';  </script>  <script id=""mNSC"" src=""http://contextual.media.net/nmedianet.js?cid=8CU7UD0LJ"" language=""javascript""></script>
			<P STYLE=""margin-top:18px; margin-bottom:12px;""><FONT STYLE=""font-size:133%;""><SPAN id=""message""><B>Here is the puzzle. Good luck!</B></SPAN></FONT>
			</P><P STYLE=""margin:0;"">
<TABLE id=""puzzle_grid"" CELLSPACING=0 CELLPADDING=0 CLASS=t><TR><TD CLASS=g0 ID=c00><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc11 MAXLENGTH=1 onBlur=""j8(this)"" ID=f00></TD><TD CLASS=f0 ID=c10><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc21 MAXLENGTH=1 onBlur=""j8(this)"" ID=f10></TD><TD CLASS=f0 ID=c20><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc31 MAXLENGTH=1 onBlur=""j8(this)"" ID=f20></TD><TD CLASS=g0 ID=c30><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc41 MAXLENGTH=1 onBlur=""j8(this)"" ID=f30></TD><TD CLASS=f0 ID=c40><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc51 MAXLENGTH=1 onBlur=""j8(this)"" ID=f40></TD><TD CLASS=f0 ID=c50><INPUT CLASS=s0 SIZE=2 AUTOCOMPLETE=off NAME=s36mtc61 READONLY VALUE=""6"" ID=f50></TD><TD CLASS=g0 ID=c60><INPUT CLASS=s0 SIZE=2 AUTOCOMPLETE=off NAME=s36mtc71 READONLY VALUE=""4"" ID=f60></TD><TD CLASS=f0 ID=c70><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc81 MAXLENGTH=1 onBlur=""j8(this)"" ID=f70></TD><TD CLASS=f0 ID=c80><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc91 MAXLENGTH=1 onBlur=""j8(this)"" ID=f80></TD></TR><TR><TD CLASS=e0 ID=c01><INPUT CLASS=s0 SIZE=2 AUTOCOMPLETE=off NAME=s36mtc12 READONLY VALUE=""6"" ID=f01></TD><TD CLASS=c0 ID=c11><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc22 MAXLENGTH=1 onBlur=""j8(this)"" ID=f11></TD><TD CLASS=c0 ID=c21><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc32 MAXLENGTH=1 onBlur=""j8(this)"" ID=f21></TD><TD CLASS=e0 ID=c31><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc42 MAXLENGTH=1 onBlur=""j8(this)"" ID=f31></TD><TD CLASS=c0 ID=c41><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc52 MAXLENGTH=1 onBlur=""j8(this)"" ID=f41></TD><TD CLASS=c0 ID=c51><INPUT CLASS=s0 SIZE=2 AUTOCOMPLETE=off NAME=s36mtc62 READONLY VALUE=""1"" ID=f51></TD><TD CLASS=e0 ID=c61><INPUT CLASS=s0 SIZE=2 AUTOCOMPLETE=off NAME=s36mtc72 READONLY VALUE=""7"" ID=f61></TD><TD CLASS=c0 ID=c71><INPUT CLASS=s0 SIZE=2 AUTOCOMPLETE=off NAME=s36mtc82 READONLY VALUE=""3"" ID=f71></TD><TD CLASS=c0 ID=c81><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc92 MAXLENGTH=1 onBlur=""j8(this)"" ID=f81></TD></TR><TR><TD CLASS=e0 ID=c02><INPUT CLASS=s0 SIZE=2 AUTOCOMPLETE=off NAME=s36mtc13 READONLY VALUE=""8"" ID=f02></TD><TD CLASS=c0 ID=c12><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc23 MAXLENGTH=1 onBlur=""j8(this)"" ID=f12></TD><TD CLASS=c0 ID=c22><INPUT CLASS=s0 SIZE=2 AUTOCOMPLETE=off NAME=s36mtc33 READONLY VALUE=""2"" ID=f22></TD><TD CLASS=e0 ID=c32><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc43 MAXLENGTH=1 onBlur=""j8(this)"" ID=f32></TD><TD CLASS=c0 ID=c42><INPUT CLASS=s0 SIZE=2 AUTOCOMPLETE=off NAME=s36mtc53 READONLY VALUE=""9"" ID=f42></TD><TD CLASS=c0 ID=c52><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc63 MAXLENGTH=1 onBlur=""j8(this)"" ID=f52></TD><TD CLASS=e0 ID=c62><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc73 MAXLENGTH=1 onBlur=""j8(this)"" ID=f62></TD><TD CLASS=c0 ID=c72><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc83 MAXLENGTH=1 onBlur=""j8(this)"" ID=f72></TD><TD CLASS=c0 ID=c82><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc93 MAXLENGTH=1 onBlur=""j8(this)"" ID=f82></TD></TR><TR><TD CLASS=g0 ID=c03><INPUT CLASS=s0 SIZE=2 AUTOCOMPLETE=off NAME=s36mtc14 READONLY VALUE=""4"" ID=f03></TD><TD CLASS=f0 ID=c13><INPUT CLASS=s0 SIZE=2 AUTOCOMPLETE=off NAME=s36mtc24 READONLY VALUE=""5"" ID=f13></TD><TD CLASS=f0 ID=c23><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc34 MAXLENGTH=1 onBlur=""j8(this)"" ID=f23></TD><TD CLASS=g0 ID=c33><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc44 MAXLENGTH=1 onBlur=""j8(this)"" ID=f33></TD><TD CLASS=f0 ID=c43><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc54 MAXLENGTH=1 onBlur=""j8(this)"" ID=f43></TD><TD CLASS=f0 ID=c53><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc64 MAXLENGTH=1 onBlur=""j8(this)"" ID=f53></TD><TD CLASS=g0 ID=c63><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc74 MAXLENGTH=1 onBlur=""j8(this)"" ID=f63></TD><TD CLASS=f0 ID=c73><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc84 MAXLENGTH=1 onBlur=""j8(this)"" ID=f73></TD><TD CLASS=f0 ID=c83><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc94 MAXLENGTH=1 onBlur=""j8(this)"" ID=f83></TD></TR><TR><TD CLASS=e0 ID=c04><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc15 MAXLENGTH=1 onBlur=""j8(this)"" ID=f04></TD><TD CLASS=c0 ID=c14><INPUT CLASS=s0 SIZE=2 AUTOCOMPLETE=off NAME=s36mtc25 READONLY VALUE=""8"" ID=f14></TD><TD CLASS=c0 ID=c24><INPUT CLASS=s0 SIZE=2 AUTOCOMPLETE=off NAME=s36mtc35 READONLY VALUE=""9"" ID=f24></TD><TD CLASS=e0 ID=c34><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc45 MAXLENGTH=1 onBlur=""j8(this)"" ID=f34></TD><TD CLASS=c0 ID=c44><INPUT CLASS=s0 SIZE=2 AUTOCOMPLETE=off NAME=s36mtc55 READONLY VALUE=""4"" ID=f44></TD><TD CLASS=c0 ID=c54><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc65 MAXLENGTH=1 onBlur=""j8(this)"" ID=f54></TD><TD CLASS=e0 ID=c64><INPUT CLASS=s0 SIZE=2 AUTOCOMPLETE=off NAME=s36mtc75 READONLY VALUE=""1"" ID=f64></TD><TD CLASS=c0 ID=c74><INPUT CLASS=s0 SIZE=2 AUTOCOMPLETE=off NAME=s36mtc85 READONLY VALUE=""2"" ID=f74></TD><TD CLASS=c0 ID=c84><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc95 MAXLENGTH=1 onBlur=""j8(this)"" ID=f84></TD></TR><TR><TD CLASS=e0 ID=c05><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc16 MAXLENGTH=1 onBlur=""j8(this)"" ID=f05></TD><TD CLASS=c0 ID=c15><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc26 MAXLENGTH=1 onBlur=""j8(this)"" ID=f15></TD><TD CLASS=c0 ID=c25><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc36 MAXLENGTH=1 onBlur=""j8(this)"" ID=f25></TD><TD CLASS=e0 ID=c35><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc46 MAXLENGTH=1 onBlur=""j8(this)"" ID=f35></TD><TD CLASS=c0 ID=c45><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc56 MAXLENGTH=1 onBlur=""j8(this)"" ID=f45></TD><TD CLASS=c0 ID=c55><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc66 MAXLENGTH=1 onBlur=""j8(this)"" ID=f55></TD><TD CLASS=e0 ID=c65><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc76 MAXLENGTH=1 onBlur=""j8(this)"" ID=f65></TD><TD CLASS=c0 ID=c75><INPUT CLASS=s0 SIZE=2 AUTOCOMPLETE=off NAME=s36mtc86 READONLY VALUE=""7"" ID=f75></TD><TD CLASS=c0 ID=c85><INPUT CLASS=s0 SIZE=2 AUTOCOMPLETE=off NAME=s36mtc96 READONLY VALUE=""4"" ID=f85></TD></TR><TR><TD CLASS=g0 ID=c06><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc17 MAXLENGTH=1 onBlur=""j8(this)"" ID=f06></TD><TD CLASS=f0 ID=c16><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc27 MAXLENGTH=1 onBlur=""j8(this)"" ID=f16></TD><TD CLASS=f0 ID=c26><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc37 MAXLENGTH=1 onBlur=""j8(this)"" ID=f26></TD><TD CLASS=g0 ID=c36><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc47 MAXLENGTH=1 onBlur=""j8(this)"" ID=f36></TD><TD CLASS=f0 ID=c46><INPUT CLASS=s0 SIZE=2 AUTOCOMPLETE=off NAME=s36mtc57 READONLY VALUE=""3"" ID=f46></TD><TD CLASS=f0 ID=c56><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc67 MAXLENGTH=1 onBlur=""j8(this)"" ID=f56></TD><TD CLASS=g0 ID=c66><INPUT CLASS=s0 SIZE=2 AUTOCOMPLETE=off NAME=s36mtc77 READONLY VALUE=""6"" ID=f66></TD><TD CLASS=f0 ID=c76><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc87 MAXLENGTH=1 onBlur=""j8(this)"" ID=f76></TD><TD CLASS=f0 ID=c86><INPUT CLASS=s0 SIZE=2 AUTOCOMPLETE=off NAME=s36mtc97 READONLY VALUE=""1"" ID=f86></TD></TR><TR><TD CLASS=e0 ID=c07><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc18 MAXLENGTH=1 onBlur=""j8(this)"" ID=f07></TD><TD CLASS=c0 ID=c17><INPUT CLASS=s0 SIZE=2 AUTOCOMPLETE=off NAME=s36mtc28 READONLY VALUE=""4"" ID=f17></TD><TD CLASS=c0 ID=c27><INPUT CLASS=s0 SIZE=2 AUTOCOMPLETE=off NAME=s36mtc38 READONLY VALUE=""5"" ID=f27></TD><TD CLASS=e0 ID=c37><INPUT CLASS=s0 SIZE=2 AUTOCOMPLETE=off NAME=s36mtc48 READONLY VALUE=""9"" ID=f37></TD><TD CLASS=c0 ID=c47><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc58 MAXLENGTH=1 onBlur=""j8(this)"" ID=f47></TD><TD CLASS=c0 ID=c57><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc68 MAXLENGTH=1 onBlur=""j8(this)"" ID=f57></TD><TD CLASS=e0 ID=c67><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc78 MAXLENGTH=1 onBlur=""j8(this)"" ID=f67></TD><TD CLASS=c0 ID=c77><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc88 MAXLENGTH=1 onBlur=""j8(this)"" ID=f77></TD><TD CLASS=c0 ID=c87><INPUT CLASS=s0 SIZE=2 AUTOCOMPLETE=off NAME=s36mtc98 READONLY VALUE=""3"" ID=f87></TD></TR><TR><TD CLASS=i0 ID=c08><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc19 MAXLENGTH=1 onBlur=""j8(this)"" ID=f08></TD><TD CLASS=h0 ID=c18><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc29 MAXLENGTH=1 onBlur=""j8(this)"" ID=f18></TD><TD CLASS=h0 ID=c28><INPUT CLASS=s0 SIZE=2 AUTOCOMPLETE=off NAME=s36mtc39 READONLY VALUE=""6"" ID=f28></TD><TD CLASS=i0 ID=c38><INPUT CLASS=s0 SIZE=2 AUTOCOMPLETE=off NAME=s36mtc49 READONLY VALUE=""1"" ID=f38></TD><TD CLASS=h0 ID=c48><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc59 MAXLENGTH=1 onBlur=""j8(this)"" ID=f48></TD><TD CLASS=h0 ID=c58><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc69 MAXLENGTH=1 onBlur=""j8(this)"" ID=f58></TD><TD CLASS=i0 ID=c68><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc79 MAXLENGTH=1 onBlur=""j8(this)"" ID=f68></TD><TD CLASS=h0 ID=c78><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc89 MAXLENGTH=1 onBlur=""j8(this)"" ID=f78></TD><TD CLASS=h0 ID=c88><INPUT CLASS=d0 SIZE=2 AUTOCOMPLETE=off NAME=36mtc99 MAXLENGTH=1 onBlur=""j8(this)"" ID=f88></TD></TR></TABLE>
				<INPUT NAME=prefix ID=""prefix"" TYPE=hidden VALUE=""36mtc"">
				<INPUT NAME=start TYPE=hidden VALUE=""1487540352"">
				<INPUT NAME=inchallenge TYPE=hidden VALUE="""">
				<INPUT NAME=level TYPE=hidden VALUE=""3"">
				<INPUT NAME=id ID=""pid"" TYPE=hidden VALUE=""6872255636"">
				<INPUT NAME=cheat ID=""cheat"" TYPE=hidden VALUE=""517326498694851732832794516451278369789643125263519874978432651145967283326185947"">
				<INPUT ID=""editmask"" TYPE=hidden VALUE=""111110011011110001010101111001111111100101001111111100111101010100011110110011111"">
				<INPUT NAME=options TYPE=hidden VALUE=""3"">
				<INPUT NAME=errors TYPE=hidden VALUE=""0"" ID=""errors"">
				<INPUT NAME=layout TYPE=hidden VALUE="""">
			<P STYLE=""margin-top:12pt; margin-bottom:0pt;""><INPUT NAME=""jstimer"" ID=""jstimer"" TYPE=""hidden"">

<FONT STYLE=""font-size:111%""><A HREF=""http://www.websudoku.com/?level=3&set_id=6872255636"" TARGET=""_top"" TITLE=""Copy link for this puzzle"">Hard Puzzle 6,872,255,636</A> -<SPAN ID=""timer""></SPAN>- <A HREF=""http://www.websudoku.com/?select=1&level=3"" TARGET=""_top"">Select a puzzle...</A></FONT>				</P>
								<P STYLE=""margin-top: 9pt;"">
				<INPUT NAME=submit TYPE=submit VALUE="" How am I doing? "" onClick=""j12(); return j1();"">
				&nbsp; <INPUT NAME=pause TYPE=submit VALUE="" Pause "" onClick=""return j12();"">
				&nbsp; <INPUT NAME=printopts TYPE=submit VALUE="" Print... "" onClick=""return j12();"">
				&nbsp; <INPUT NAME=clear TYPE=submit VALUE="" Clear "" onClick=""j12(); return j7(2);"">
				&nbsp; <INPUT NAME=showopts TYPE=submit VALUE="" Options... "" onClick=""return j12();"">
				</P>

				<INPUT NAME=""jscheat"" ID=""jscheat"" TYPE=""hidden"">
			</FORM>
			</TD></TR>
		</TABLE></TD>

	</TR></TABLE></BODY>
</HTML>");
		}

		public string GetHTML(string url)
		{
			if (string.IsNullOrWhiteSpace(url))
			{
				throw new ArgumentException("URL can't be empty");
			}

			if (!stringDict.ContainsKey(url))
			{
				throw new ArgumentException("Unable to find url");
			}

			string stringStreamer = stringDict[url];

			return stringDict[url];
		}
	}
}
