<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:xs="http://www.w3.org/2001/XMLSchema"
    exclude-result-prefixes="xs"
    version="2.0">
    <xsl:template match="/congty">
        <html>
            <body>
                <head>
                    <style>
                        * {
                        font-family: sans-serif;
                        }
                        /* css cho bảng */
                        .content-table {
                        border-collapse: collapse;
                        margin: 25px 0;
                        font-size: 0.9em;
                        min-width: 400px;
                        border-radius: 6px 6px 0 0;
                        overflow: hidden;
                        box-shadow: 0 0 20px rgba(0, 0, 0, 0.15);
                        }
                        
                        .content-table thead tr {
                        background-color: #009879;
                        color: #ffffff;
                        text-align: left;
                        font-weight: bold;
                        }
                        
                        .content-table th,
                        .content-table td {
                        padding: 12px 15px;
                        }
                        
                        .content-table tbody tr {
                        border-bottom: 1px solid #dddddd;
                        }
                        
                        .content-table tbody tr:nth-of-type(even) {
                        background-color: #f3f3f3;
                        }
                        
                        .content-table tbody tr:last-of-type {
                        border-bottom: 2px solid #009879;
                        }
                        
                        .content-table tbody tr.active-row {
                        font-weight: bold;
                        color: #009879;
                        }
                    </style>
                </head>
                <h3>Bảng nhân viên</h3>
                <table class="content-table">
                    <thead>
                        <tr>
                            <th>Mã nv</th>
                            <th>Họ tên</th>
                            <th>Lương</th>
                            <th>Tên phòng ban</th>
                            <th>Số điện thoại</th>
                        </tr>
                    </thead>
                    <tbody>
                        <xsl:for-each select="nhanvien">
                            <tr>
                                <td><xsl:value-of select="@manv"/></td>
                                <td><xsl:value-of select="hoten"/></td>
                                <td><xsl:value-of select="luong"/></td>
                                <td><xsl:value-of select="phongban/tenphong"/></td>
                                <td><xsl:value-of select="phongban/dienthoai"/></td>
                            </tr>
                        </xsl:for-each>
                    </tbody>
                </table>
                
                <h3>Bảng Hợp Đồng Lao Động</h3>
                <table class="content-table">
                    <thead>
                        <tr>
                            <th>Mã hợp đồng</th>
                            <th>Mã nhân viên</th>
                            <th>Tên hợp đồng</th>
                            <th>Ngày bắt đầu</th>
                            <th>Ngày kết thúc</th>
                        </tr>
                    </thead>
                    <tbody>
                        <xsl:for-each select="HopDongLD">
                            <tr>
                                <td><xsl:value-of select="@MaHD"/></td>
                                <td><xsl:value-of select="@manv"/></td>
                                <td><xsl:value-of select="TenHD"/></td>
                                <td><xsl:value-of select="NgayBD"/></td>
                                <td><xsl:value-of select="NgayKT"/></td>
                            </tr>
                        </xsl:for-each>
                    </tbody>
                </table>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>