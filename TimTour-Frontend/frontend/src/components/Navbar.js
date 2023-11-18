// Navbar.js

import React, { useState } from 'react';
import { View, Text, StyleSheet, TouchableOpacity, Modal, FlatList } from 'react-native';

const Navbar = () => {
  const [isMenuVisible, setIsMenuVisible] = useState(false);
  const [menuPosition, setMenuPosition] = useState({ top: 0, left: 0 });
  const [isHamburgerOpen, setIsHamburgerOpen] = useState(false);

  const menuData = [
    { id: '1', label: 'Restaurants', onPress: () => handleMenuItemPress('Restaurants') },
    { id: '2', label: 'Eveniments', onPress: () => handleMenuItemPress('Eveniments') },
    { id: '3', label: 'Hotels', onPress: () => handleMenuItemPress('Hotels') },
    { id: '4', label: 'Pubs', onPress: () => handleMenuItemPress('Pubs') },
    { id: '5', label: 'Places to visit', onPress: () => handleMenuItemPress('Places to visit') },
  ];

  const handleMenuItemPress = (option) => {
    // Handle the press of a menu item
    console.log(`Selected: ${option}`);
    // Toggle the menu visibility
    setIsMenuVisible(!isMenuVisible);
    // Close the hamburger menu
    setIsHamburgerOpen(false);
  };

  const handleMenuLayout = (event) => {
    // Update menu position based on layout event
    setMenuPosition({
      top: event.nativeEvent.layout.y + event.nativeEvent.layout.height,
      left: event.nativeEvent.layout.x,
    });
  };

  const handleMenuToggle = () => {
    // Toggle the menu visibility
    setIsMenuVisible(!isMenuVisible);
    // Toggle the hamburger icon
    setIsHamburgerOpen(!isHamburgerOpen);
  };

  return (
    <View style={styles.navbar}>
      {/* Partea stângă a barei de navigare */}
      <Text style={styles.navbarText}>TimTour</Text>

      {/* Partea dreaptă a barei de navigare */}
      <TouchableOpacity onPress={handleMenuToggle} onLayout={handleMenuLayout}>
        <View style={styles.menuIconContainer}>
          <Text style={isHamburgerOpen ? styles.closeIcon : styles.hamburgerIcon}>{isHamburgerOpen ? 'X' : '☰'}</Text>
        </View>
      </TouchableOpacity>

      {/* Modal pentru meniu */}
      <Modal
        animationType="slide"
        transparent={true}
        visible={isMenuVisible}
        onRequestClose={handleMenuToggle}
      >
        <View style={[styles.menuModal, { top: menuPosition.top, left: menuPosition.left - 130 }]}>
          {/* Adaugă un offset negativ (de exemplu, -20) pentru a ajusta la stânga */}
          <FlatList
            data={menuData}
            keyExtractor={(item) => item.id}
            renderItem={({ item }) => (
              <TouchableOpacity style={styles.menuItem} onPress={() => { item.onPress(); handleMenuToggle(); }}>
                <Text style={{ color: '#fff' }}>{item.label}</Text>
              </TouchableOpacity>
            )}
          /> 
        </View>
        <TouchableOpacity style={styles.menuCloseMenu} onPress={handleMenuToggle}>
          <Text style={[styles.menuCloseMenu, {top: menuPosition.top-32.5 ,left: menuPosition.left+10}]}> </Text>
      </TouchableOpacity>
      </Modal>
    </View>
  );
};

const styles = StyleSheet.create({
  navbar: {
    backgroundColor: '#3498db',
    padding: 10,
    flexDirection: 'row',
    justifyContent: 'space-between',
    alignItems: 'center',
  },
  navbarText: {
    color: '#fff',
    fontSize: 20,
    fontWeight: 'bold',
  },
  menuIconContainer: {
    padding: 5,
  },
  hamburgerIcon: {
    color: '#fff',
    fontSize: 24,
  },
  closeIcon: {
    color: '#fff',
    fontSize: 24,
    fontWeight: 'bold',
  },
  menuModal: {
    position: 'absolute',
    width: "40%",
    backgroundColor: 'rgba(0, 0, 0, 0.5)',
  },
  menuItem: {
    padding: 20,
    borderBottomWidth: 1,
    borderBottomColor: '#ddd',
    width: '100%',
    alignItems: 'center',
  },
  menuIconCenter: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
  },
  menuCloseMenu: {
    closeIcon: {
      color: '#fff',
    },
  }
});

export default Navbar;
