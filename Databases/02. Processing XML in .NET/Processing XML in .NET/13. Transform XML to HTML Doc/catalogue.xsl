<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt"
    exclude-result-prefixes="msxsl"
>
  <xsl:output method="html" indent="yes"/>
  <xsl:template match="/">
    <html>
      <body>
        <h1>Catalogue</h1>
        <table bgcolor="#E0E0E0" cellspacing="1" cellpadding="3" border="1" >
          <tr bgcolor="#EEEEEE" align="center">
            <td rowspan="2">
              <b>Name of albums</b>
            </td>
            <td rowspan="2">
              <b>Artist</b>
            </td>
            <td rowspan="2">
              <b>Year</b>
            </td>
            <td rowspan="2">
              <b>Producer</b>
            </td>
            <td rowspan="2">
              <b>Price</b>
            </td>
            <td colspan="3">
              <b>Song</b>
            </td>
          </tr>
          <tr>
            <td>Title</td>
            <td>Duration</td>
          </tr>
          <xsl:for-each select="/catalogue/album">
            <tr bgcolor="white">
              <td rowspan="4">
                <xsl:value-of select="name"/>
              </td>
              <td rowspan="4">
                <xsl:value-of select="artist"/>
              </td>
              <td rowspan="4">
                <xsl:value-of select="year"/>
              </td>
              <td rowspan="4">
                <xsl:value-of select="producer"/>
              </td>
              <td rowspan="4">
                <xsl:value-of select="price"/>USD
              </td>
              <xsl:for-each select="song">
                <tr bgcolor="white">
                  <td rowspan="1">
                    <xsl:value-of select="title"/>
                  </td>
                  <td rowspan="1">
                    <xsl:value-of select="duration"/>
                  </td>
                </tr>
              </xsl:for-each>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
