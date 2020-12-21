/*
Navicat MySQL Data Transfer

Source Server         : db_kk
Source Server Version : 50722
Source Host           : localhost:3306
Source Database       : db_medium

Target Server Type    : MYSQL
Target Server Version : 50722
File Encoding         : 65001

Date: 2020-12-21 21:42:09
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for client
-- ----------------------------
DROP TABLE IF EXISTS `client`;
CREATE TABLE `client` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `cardCli` varchar(10) CHARACTER SET utf8 NOT NULL COMMENT '用户编号',
  `name` varchar(50) CHARACTER SET utf8 NOT NULL COMMENT '客户名字',
  `sex` int(2) NOT NULL COMMENT '客户性别',
  `cardNo` varchar(20) CHARACTER SET utf8 NOT NULL COMMENT '客户身份证号',
  `number` varchar(20) CHARACTER SET utf8 NOT NULL COMMENT '客户电话号码',
  `endDate` date NOT NULL,
  `status` int(2) NOT NULL COMMENT '客户类型',
  PRIMARY KEY (`id`),
  UNIQUE KEY `cardCli` (`cardCli`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of client
-- ----------------------------
INSERT INTO `client` VALUES ('1', '77009', 'yang', '0', '430481199810084535', '15073414410', '2020-11-30', '0');
INSERT INTO `client` VALUES ('2', '53261', 'yan', '0', '430481199810084535', '15073414410', '2020-11-30', '0');
INSERT INTO `client` VALUES ('3', '69827', 'wang', '0', '430481199810084535', '15073414410', '2020-11-30', '1');
INSERT INTO `client` VALUES ('4', '37193', 'wang', '0', '430481199810084535', '15073414410', '2020-12-04', '1');
INSERT INTO `client` VALUES ('5', '82938', 'wang', '0', '430481199810084535', '15073414410', '2020-12-04', '1');
INSERT INTO `client` VALUES ('6', '48266', 'op', '0', '430481199810084535', '15073414410', '2020-12-04', '1');
INSERT INTO `client` VALUES ('7', '27554', 'uu', '0', '456489198910084535', '15073414410', '2020-12-18', '0');
INSERT INTO `client` VALUES ('8', '72133', 'llkk', '1', '430481199810084535', '15073414410', '2020-12-10', '0');
INSERT INTO `client` VALUES ('9', '87612', 'uuu', '0', '430498199610255695', '15063415510', '2020-12-10', '1');
INSERT INTO `client` VALUES ('10', '79693', 'uiii', '0', '43048919891015', '130734948810', '2020-12-18', '1');
INSERT INTO `client` VALUES ('11', '35615', 'io', '0', '430489197611056585', '16074464410', '2020-12-18', '0');

-- ----------------------------
-- Table structure for house
-- ----------------------------
DROP TABLE IF EXISTS `house`;
CREATE TABLE `house` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `card` varchar(50) NOT NULL COMMENT '房源编号',
  `address` varchar(100) NOT NULL COMMENT '房源地址',
  `state` int(2) NOT NULL COMMENT '房源状态',
  `cardCli` varchar(10) NOT NULL COMMENT '房主编号',
  `insDate` date NOT NULL COMMENT '添加时间',
  `updDate` date NOT NULL COMMENT '修改时间',
  `estPrice` double DEFAULT NULL COMMENT '预估价格',
  `addCard` varchar(50) CHARACTER SET utf8 DEFAULT NULL COMMENT '添加人的编号',
  `suggest` varchar(300) CHARACTER SET utf8 DEFAULT NULL COMMENT '房源介绍',
  PRIMARY KEY (`id`),
  UNIQUE KEY `card` (`card`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of house
-- ----------------------------
INSERT INTO `house` VALUES ('1', '143090', '123456', '3', '77009', '2020-11-30', '2020-11-30', '1200', '00001', '456789');
INSERT INTO `house` VALUES ('2', '218342', '45655', '3', '53261', '2020-11-30', '2020-11-30', '1200', '00001', '123456');
INSERT INTO `house` VALUES ('3', '347153', 'klk', '1', '27554', '2020-12-04', '2020-12-18', '3000', '00001', 'fdfdfdf');
INSERT INTO `house` VALUES ('4', '151922', 'fdfdf', '1', '72133', '2020-12-10', '2020-12-10', '1300', '00001', 'hhhh');
INSERT INTO `house` VALUES ('5', '914142', 'fdfd', '0', '35615', '2020-12-18', '2020-12-18', '1600', '00001', 'fdfdf');

-- ----------------------------
-- Table structure for orderhouse
-- ----------------------------
DROP TABLE IF EXISTS `orderhouse`;
CREATE TABLE `orderhouse` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `orderCard` varchar(50) NOT NULL COMMENT '订单编号',
  `hostClient` varchar(50) NOT NULL COMMENT '房主编号',
  `guestClient` varchar(50) NOT NULL COMMENT '租客编号',
  `houseCard` varchar(50) NOT NULL COMMENT '房源编号',
  `type` int(2) NOT NULL COMMENT '交易类型',
  `endDate` date NOT NULL COMMENT '订单生成时间',
  `factPrice` double NOT NULL,
  `operateMan` varchar(50) NOT NULL COMMENT '操作人工号',
  PRIMARY KEY (`id`),
  UNIQUE KEY `orderCard` (`orderCard`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of orderhouse
-- ----------------------------
INSERT INTO `orderhouse` VALUES ('1', '427626', '53261', '69827', '218342', '1', '2020-11-30', '1200', '00001');
INSERT INTO `orderhouse` VALUES ('2', '755840', '53261', '37193', '218342', '1', '2020-12-04', '1200', '00001');
INSERT INTO `orderhouse` VALUES ('3', '278299', '53261', '82938', '218342', '1', '2020-12-04', '1300', '00001');
INSERT INTO `orderhouse` VALUES ('4', '456539', '53261', '48266', '218342', '1', '2020-12-04', '1500', '00001');
INSERT INTO `orderhouse` VALUES ('5', '888659', '27554', '87612', '347153', '1', '2020-12-10', '1500', '00001');
INSERT INTO `orderhouse` VALUES ('6', '399924', '72133', '79693', '151922', '1', '2020-12-18', '1500', '00001');

-- ----------------------------
-- Table structure for users
-- ----------------------------
DROP TABLE IF EXISTS `users`;
CREATE TABLE `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'id',
  `jobNum` varchar(50) CHARACTER SET utf8 NOT NULL COMMENT '工号',
  `name` varchar(50) CHARACTER SET utf8 NOT NULL COMMENT '姓名',
  `sex` int(2) NOT NULL COMMENT '性别0男1女',
  `cardNo` varchar(50) NOT NULL COMMENT '身份证号',
  `number` varchar(11) NOT NULL COMMENT '电话号码',
  `endDate` date NOT NULL COMMENT '入职时间',
  `status` int(2) NOT NULL COMMENT '身份',
  `password` varchar(50) NOT NULL COMMENT '密码',
  `addJobNum` varchar(50) CHARACTER SET utf8 DEFAULT NULL COMMENT '添加人',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of users
-- ----------------------------
INSERT INTO `users` VALUES ('1', '00001', 'admin', '0', '430481198912015695', '15076494480', '2020-11-26', '0', '123456', null);
INSERT INTO `users` VALUES ('4', '22222', 'uu', '1', '430481199810084535', '15073414410', '2020-12-12', '1', '22222', '00001');
INSERT INTO `users` VALUES ('6', '61382', 'qiang', '0', '430481199810084565', '15073414410', '2020-11-29', '1', '61382', '00001');
INSERT INTO `users` VALUES ('7', '55237', 'opkl', '0', '430481199810084535', '15073414410', '2020-12-10', '0', '55237', '00001');
INSERT INTO `users` VALUES ('8', '80727', '5656', '0', '430481198912023695', '15079425510', '2020-12-18', '0', '80727', '00001');
