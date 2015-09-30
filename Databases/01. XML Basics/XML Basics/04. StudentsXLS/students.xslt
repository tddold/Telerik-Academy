<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:output method="html" indent="yes"/>
  <xsl:template match="/">
    <html>
      <body>
        <h1>Students</h1>
        <table bgcolor="#E0E0E0" cellspacing="1" cellpadding="3" border="1" >
          <tr bgcolor="#EEEEEE" align="center">
            <td rowspan="2"><b>Name</b></td>
            <td rowspan="2"><b>Sex</b></td>
            <td rowspan="2"><b>Birth date</b></td>
            <td rowspan="2"><b>Phone</b></td>
            <td rowspan="2"><b>Email</b></td>
            <td rowspan="2"><b>Course</b></td>
            <td rowspan="2"><b>Specialty</b></td>
            <td rowspan="2"><b>Faculty Number</b></td>
            <td colspan="3"><b>Exams</b></td>
          </tr>
          <tr>
            <td>Name</td>
            <td>Tutor</td>
            <td>Score</td>
          </tr>
          <xsl:for-each select="/students/student">
            <tr bgcolor="white">
              <td rowspan="4"><xsl:value-of select="name"/></td>
              <td rowspan="4"><xsl:value-of select="sex"/></td>
              <td rowspan="4"><xsl:value-of select="birth_date"/></td>
              <td rowspan="4"><xsl:value-of select="phone"/></td>
              <td rowspan="4"><xsl:value-of select="email"/></td>
              <td rowspan="4"><xsl:value-of select="course"/></td>
              <td rowspan="4"><xsl:value-of select="specialty"/></td>
              <td rowspan="4"><xsl:value-of select="faculty-number"/></td>
                <xsl:for-each select="exams/exam">
                  <tr bgcolor="white">
                    <td rowspan="1"><xsl:value-of select="name"/></td>
                    <td rowspan="1"><xsl:value-of select="tutor"/></td>
                    <td rowspan="1"><xsl:value-of select="score"/></td>
                  </tr>
                </xsl:for-each>
              
            </tr>
          </xsl:for-each>          
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
